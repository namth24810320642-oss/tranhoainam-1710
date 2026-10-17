using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai2
{
    public partial class MainForm : Form
    {
        private readonly BindingList<EquipmentBorrow> _originalList = [];
        private readonly BindingList<EquipmentBorrow> _filteredList = [];
        private readonly BindingSource _bindingSource = [];

        public MainForm()
        {
            InitializeComponent();
            InitControlData();
            SetupBindings();
            RegisterEvents();
        }

        private void InitControlData()
        {
            // Nạp danh sách thiết bị mẫu
            cboEquipment.Items.AddRange([
                "Kính hiển vi quang học",
                "Máy dao động sóng (Oscilloscope)",
                "Bộ Kit Arduino Uno R3",
                "Cảm biến nhiệt độ DHT11",
                "Đồng hồ đo đa năng (Multimeter)",
                "Máy chiếu vật thể"
            ]);
            if (cboEquipment.Items.Count > 0) cboEquipment.SelectedIndex = 0;

            // Nạp trạng thái cho bộ lọc
            cboFilterStatus.Items.AddRange(["Tất cả", "Đang mượn", "Đã trả", "Quá hạn"]);
            cboFilterStatus.SelectedIndex = 0;

            // Dữ liệu mẫu kiểm thử
            _originalList.Add(new EquipmentBorrow
            {
                BorrowId = "PM001",
                StudentId = "SV001",
                StudentName = "Trần Văn Nam",
                EquipmentName = "Bộ Kit Arduino Uno R3",
                Quantity = 2,
                BorrowDate = DateTime.Now.AddDays(-10),
                DueDate = DateTime.Now.AddDays(-3),
                ReturnDate = null,
                Status = "Quá hạn"
            });

            _originalList.Add(new EquipmentBorrow
            {
                BorrowId = "PM002",
                StudentId = "SV002",
                StudentName = "Lê Thị Bích",
                EquipmentName = "Kính hiển vi quang học",
                Quantity = 1,
                BorrowDate = DateTime.Now.AddDays(-2),
                DueDate = DateTime.Now.AddDays(5),
                ReturnDate = null,
                Status = "Đang mượn"
            });
        }

        private void SetupBindings()
        {
            _bindingSource.DataSource = _filteredList;
            dgvBorrows.DataSource = _bindingSource;

            // Định dạng ngày hiển thị trên lưới
            colBorrowDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            colDueDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            colReturnDate.DefaultCellStyle.Format = "dd/MM/yyyy";

            UpdateOverdueStatus();
            ApplyFilter();
        }

        private void RegisterEvents()
        {
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnMarkReturned.Click += BtnMarkReturned_Click;
            btnClear.Click += (s, e) => ClearInputs();

            dgvBorrows.SelectionChanged += DgvBorrows_SelectionChanged;

            txtSearch.TextChanged += (s, e) => ApplyFilter();
            cboFilterStatus.SelectedIndexChanged += (s, e) => ApplyFilter();

            chkReturnDate.CheckedChanged += (s, e) =>
            {
                dtpReturnDate.Enabled = chkReturnDate.Checked;
                if (!chkReturnDate.Checked) dtpReturnDate.Value = DateTime.Now;
            };

            dtpBorrowDate.ValueChanged += DtpBorrowDate_ValueChanged;
            dtpDueDate.ValueChanged += DtpDueDate_ValueChanged;

            menuExportCsv.Click += MenuExportCsv_Click;
        }

        private void DtpBorrowDate_ValueChanged(object? sender, EventArgs e)
        {
            if (dtpDueDate.Value < dtpBorrowDate.Value.Date)
            {
                dtpDueDate.Value = dtpBorrowDate.Value.Date.AddDays(7);
            }
        }

        private void DtpDueDate_ValueChanged(object? sender, EventArgs e)
        {
            if (dtpDueDate.Value < dtpBorrowDate.Value.Date)
            {
                epValidate.SetError(dtpDueDate, "Hạn trả không được trước ngày mượn!");
            }
            else
            {
                epValidate.SetError(dtpDueDate, string.Empty);
            }
        }

        private void UpdateOverdueStatus()
        {
            DateTime today = DateTime.Now.Date;
            foreach (var item in _originalList)
            {
                if (item.ReturnDate == null && item.DueDate.Date < today)
                {
                    item.Status = "Quá hạn";
                }
                else if (item.ReturnDate == null)
                {
                    item.Status = "Đang mượn";
                }
            }
        }

        #region Validation Logic

        private bool ValidateInput(bool isAddingNew)
        {
            bool isValid = true;
            epValidate.Clear();

            // 1. Kiểm tra Mã phiếu
            if (string.IsNullOrWhiteSpace(txtBorrowId.Text))
            {
                epValidate.SetError(txtBorrowId, "Vui lòng nhập mã phiếu mượn!");
                isValid = false;
            }
            else if (isAddingNew && _originalList.Any(x => x.BorrowId.Equals(txtBorrowId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                epValidate.SetError(txtBorrowId, "Mã phiếu mượn đã tồn tại!");
                isValid = false;
            }

            // 2. Kiểm tra Mã sinh viên
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                epValidate.SetError(txtStudentId, "Vui lòng nhập mã sinh viên!");
                isValid = false;
            }

            // 3. Kiểm tra Tên sinh viên
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                epValidate.SetError(txtStudentName, "Vui lòng nhập họ tên sinh viên!");
                isValid = false;
            }

            // 4. Kiểm tra Thiết bị
            if (cboEquipment.SelectedItem == null || string.IsNullOrWhiteSpace(cboEquipment.Text))
            {
                epValidate.SetError(cboEquipment, "Vui lòng chọn hoặc nhập tên thiết bị!");
                isValid = false;
            }

            // 5. Kiểm tra Số lượng > 0
            if (nudQuantity.Value <= 0)
            {
                epValidate.SetError(nudQuantity, "Số lượng mượn phải lớn hơn 0!");
                isValid = false;
            }

            // 6. Kiểm tra Hạn trả không trước Ngày mượn
            if (dtpDueDate.Value.Date < dtpBorrowDate.Value.Date)
            {
                epValidate.SetError(dtpDueDate, "Hạn trả không được trước ngày mượn!");
                isValid = false;
            }

            // 7. Kiểm tra Ngày trả thực tế không trước Ngày mượn (nếu có nhập)
            if (chkReturnDate.Checked && dtpReturnDate.Value.Date < dtpBorrowDate.Value.Date)
            {
                epValidate.SetError(dtpReturnDate, "Ngày trả thực tế không được trước ngày mượn!");
                isValid = false;
            }

            return isValid;
        }

        #endregion

        #region CRUD Operations

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput(isAddingNew: true)) return;

            DateTime? actualReturnDate = chkReturnDate.Checked ? dtpReturnDate.Value.Date : null;
            string status;

            if (actualReturnDate.HasValue)
            {
                status = "Đã trả";
            }
            else if (dtpDueDate.Value.Date < DateTime.Now.Date)
            {
                status = "Quá hạn";
            }
            else
            {
                status = "Đang mượn";
            }

            var item = new EquipmentBorrow
            {
                BorrowId = txtBorrowId.Text.Trim(),
                StudentId = txtStudentId.Text.Trim(),
                StudentName = txtStudentName.Text.Trim(),
                EquipmentName = cboEquipment.Text.Trim(),
                Quantity = (int)nudQuantity.Value,
                BorrowDate = dtpBorrowDate.Value.Date,
                DueDate = dtpDueDate.Value.Date,
                ReturnDate = actualReturnDate,
                Status = status
            };

            _originalList.Add(item);
            UpdateOverdueStatus();
            ApplyFilter();
            ClearInputs();
            MessageBox.Show("Thêm phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvBorrows.CurrentRow?.DataBoundItem is not EquipmentBorrow selectedItem) return;
            if (!ValidateInput(isAddingNew: false)) return;

            DateTime? actualReturnDate = chkReturnDate.Checked ? dtpReturnDate.Value.Date : null;
            string status;

            if (actualReturnDate.HasValue)
            {
                status = "Đã trả";
            }
            else if (dtpDueDate.Value.Date < DateTime.Now.Date)
            {
                status = "Quá hạn";
            }
            else
            {
                status = "Đang mượn";
            }

            selectedItem.StudentId = txtStudentId.Text.Trim();
            selectedItem.StudentName = txtStudentName.Text.Trim();
            selectedItem.EquipmentName = cboEquipment.Text.Trim();
            selectedItem.Quantity = (int)nudQuantity.Value;
            selectedItem.BorrowDate = dtpBorrowDate.Value.Date;
            selectedItem.DueDate = dtpDueDate.Value.Date;
            selectedItem.ReturnDate = actualReturnDate;
            selectedItem.Status = status;

            _bindingSource.ResetBindings(false);
            UpdateOverdueStatus();
            ApplyFilter();
            MessageBox.Show("Cập nhật phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvBorrows.CurrentRow?.DataBoundItem is not EquipmentBorrow selectedItem) return;

            var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu mượn {selectedItem.BorrowId}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _originalList.Remove(selectedItem);
                UpdateOverdueStatus();
                ApplyFilter();
                ClearInputs();
            }
        }

        private void BtnMarkReturned_Click(object? sender, EventArgs e)
        {
            if (dgvBorrows.CurrentRow?.DataBoundItem is not EquipmentBorrow selectedItem)
            {
                MessageBox.Show("Vui lòng chọn 1 phiếu mượn trên bảng để đánh dấu đã trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedItem.ReturnDate != null)
            {
                MessageBox.Show("Phiếu này đã được trả trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selectedItem.ReturnDate = DateTime.Now.Date;
            selectedItem.Status = "Đã trả";

            _bindingSource.ResetBindings(false);
            UpdateOverdueStatus();
            ApplyFilter();

            // Cập nhật lại giao diện nhập liệu
            chkReturnDate.Checked = true;
            dtpReturnDate.Value = selectedItem.ReturnDate.Value;
            lblStatus.Text = "Trạng thái: Đã trả";

            MessageBox.Show($"Đã đánh dấu trả thiết bị cho phiếu {selectedItem.BorrowId} vào ngày {selectedItem.ReturnDate:dd/MM/yyyy}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DgvBorrows_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvBorrows.CurrentRow?.DataBoundItem is EquipmentBorrow item)
            {
                txtBorrowId.Text = item.BorrowId;
                txtBorrowId.ReadOnly = true;
                txtStudentId.Text = item.StudentId;
                txtStudentName.Text = item.StudentName;
                cboEquipment.Text = item.EquipmentName;
                nudQuantity.Value = item.Quantity;
                dtpBorrowDate.Value = item.BorrowDate;
                dtpDueDate.Value = item.DueDate;

                if (item.ReturnDate.HasValue)
                {
                    chkReturnDate.Checked = true;
                    dtpReturnDate.Value = item.ReturnDate.Value;
                }
                else
                {
                    chkReturnDate.Checked = false;
                    dtpReturnDate.Value = DateTime.Now;
                }

                lblStatus.Text = $"Trạng thái: {item.Status}";
            }
        }

        private void ClearInputs()
        {
            txtBorrowId.ReadOnly = false;
            txtBorrowId.Clear();
            txtStudentId.Clear();
            txtStudentName.Clear();
            if (cboEquipment.Items.Count > 0) cboEquipment.SelectedIndex = 0;
            nudQuantity.Value = 1;
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(7);
            chkReturnDate.Checked = false;
            dtpReturnDate.Value = DateTime.Now;
            lblStatus.Text = "Trạng thái: Đang mượn";
            epValidate.Clear();
            dgvBorrows.ClearSelection();
        }

        #endregion

        #region Filter, StatusStrip & Export CSV

        private void ApplyFilter()
        {
            string keyword = txtSearch.Text.Trim();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString() ?? "Tất cả";

            var query = _originalList.AsEnumerable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.StudentId.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                         x.EquipmentName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                         x.StudentName.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }

            if (selectedStatus != "Tất cả")
            {
                query = query.Where(x => x.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase));
            }

            _filteredList.Clear();
            foreach (var item in query)
            {
                _filteredList.Add(item);
            }

            int totalCount = _originalList.Count;
            int overdueCount = _originalList.Count(x => x.Status == "Quá hạn");
            int displayedCount = _filteredList.Count;

            lblStatusTotal.Text = $"Tổng số phiếu: {totalCount}";
            lblStatusOverdue.Text = $"Số phiếu quá hạn: {overdueCount}";
            lblStatusFiltered.Text = $"Đang hiển thị: {displayedCount}";
        }

        private void MenuExportCsv_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = $"DanhSachMuonThietBi_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Mã Phiếu,Mã SV,Họ Tên SV,Thiết Bị,Số Lượng,Ngày Mượn,Hạn Trả,Ngày Trả Thực Tế,Trạng Thái");

                    foreach (var item in _filteredList)
                    {
                        string returnDateStr = item.ReturnDate.HasValue ? item.ReturnDate.Value.ToString("dd/MM/yyyy") : "Chưa trả";
                        sb.AppendLine($"\"{item.BorrowId}\",\"{item.StudentId}\",\"{item.StudentName}\",\"{item.EquipmentName}\",\"{item.Quantity}\",\"{item.BorrowDate:dd/MM/yyyy}\",\"{item.DueDate:dd/MM/yyyy}\",\"{returnDateStr}\",\"{item.Status}\"");
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất danh sách ra CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất file CSV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}