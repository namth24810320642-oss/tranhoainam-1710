using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bai3
{
    public partial class MainForm : Form
    {
        private readonly BindingList<RepairOrder> _originalList = [];
        private readonly BindingList<RepairOrder> _filteredList = [];
        private readonly BindingSource _bindingSource = [];
        private string _selectedImagePath = string.Empty;

        [GeneratedRegex(@"^0\d{9}$")]
        private static partial Regex PhoneRegex();

        public MainForm()
        {
            InitializeComponent();
            InitControlData();
            SetupBindings();
            RegisterEvents();
        }

        private void InitControlData()
        {
            // Nạp danh sách loại thiết bị
            cboDeviceType.Items.AddRange([
                "Điện thoại",
                "Laptop",
                "Máy tính bảng",
                "Máy tính để bàn (PC)",
                "Đồng hồ thông minh",
                "Thiết bị khác"
            ]);
            if (cboDeviceType.Items.Count > 0) cboDeviceType.SelectedIndex = 0;

            // Nạp trạng thái đơn
            string[] statuses = ["Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy"];
            cboStatus.Items.AddRange(statuses);
            cboStatus.SelectedIndex = 0;

            // Nạp trạng thái cho bộ lọc
            cboFilterStatus.Items.Add("Tất cả");
            cboFilterStatus.Items.AddRange(statuses);
            cboFilterStatus.SelectedIndex = 0;

            // Tạo dữ liệu mẫu kiểm thử
            _originalList.Add(new RepairOrder
            {
                OrderId = "DON001",
                CustomerName = "Trần Văn Nam",
                Phone = "0912345678",
                DeviceType = "Laptop",
                IssueDescription = "Máy bật không lên nguồn, sạc không vào điện",
                ReceivedDate = DateTime.Now.AddDays(-2),
                EstimatedCost = 500000m,
                Status = "Đang sửa",
                ImagePath = string.Empty
            });

            _originalList.Add(new RepairOrder
            {
                OrderId = "DON002",
                CustomerName = "Lê Thị Bích",
                Phone = "0987654321",
                DeviceType = "Điện thoại",
                IssueDescription = "Vỡ màn hình cảm ứng, liệt cảm ứng góc dưới",
                ReceivedDate = DateTime.Now.AddDays(-1),
                EstimatedCost = 1200000m,
                Status = "Chờ linh kiện",
                ImagePath = string.Empty
            });
        }

        private void SetupBindings()
        {
            _bindingSource.DataSource = _filteredList;
            dgvOrders.DataSource = _bindingSource;

            // Định dạng ngày giờ và tiền tệ N0 trên DataGridView
            colReceivedDate.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            colEstimatedCost.DefaultCellStyle.Format = "N0";

            ApplyFilter();
        }

        private void RegisterEvents()
        {
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += (s, e) => ClearInputs();

            btnSelectImage.Click += BtnSelectImage_Click;
            btnRemoveImage.Click += BtnRemoveImage_Click;

            dgvOrders.SelectionChanged += DgvOrders_SelectionChanged;

            txtSearch.TextChanged += (s, e) => ApplyFilter();
            cboFilterStatus.SelectedIndexChanged += (s, e) => ApplyFilter();

            menuExportCsv.Click += MenuExportCsv_Click;
            menuExit.Click += (s, e) => Close();
        }

        #region Handling Image Choice

        private void BtnSelectImage_Click(object? sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Chọn ảnh thiết bị cần sửa";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _selectedImagePath = ofd.FileName;
                LoadDeviceImage(_selectedImagePath);
            }
        }

        private void BtnRemoveImage_Click(object? sender, EventArgs e)
        {
            _selectedImagePath = string.Empty;
            if (picDevice.Image != null)
            {
                picDevice.Image.Dispose();
                picDevice.Image = null;
            }
        }

        private void LoadDeviceImage(string imagePath)
        {
            if (picDevice.Image != null)
            {
                picDevice.Image.Dispose();
                picDevice.Image = null;
            }

            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    // Đọc qua FileStream để không khóa file gốc
                    using var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    picDevice.Image = System.Drawing.Image.FromStream(fs);
                }
                catch
                {
                    picDevice.Image = null;
                }
            }
        }

        #endregion

        #region Validation Logic

        private bool ValidateInput(bool isAddingNew)
        {
            bool isValid = true;
            epValidate.Clear();

            // 1. Kiểm tra Mã đơn
            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                epValidate.SetError(txtOrderId, "Vui lòng nhập mã đơn!");
                isValid = false;
            }
            else if (isAddingNew && _originalList.Any(x => x.OrderId.Equals(txtOrderId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                epValidate.SetError(txtOrderId, "Mã đơn đã tồn tại!");
                isValid = false;
            }

            // 2. Kiểm tra Tên khách hàng
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                epValidate.SetError(txtCustomerName, "Vui lòng nhập tên khách hàng!");
                isValid = false;
            }

            // 3. Kiểm tra Số điện thoại
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !PhoneRegex().IsMatch(txtPhone.Text.Trim()))
            {
                epValidate.SetError(txtPhone, "Số điện thoại không hợp lệ (gồm 10 chữ số, bắt đầu bằng 0)!");
                isValid = false;
            }

            // 4. Kiểm tra Chi phí dự kiến phải là số không âm
            if (nudEstimatedCost.Value < 0)
            {
                epValidate.SetError(nudEstimatedCost, "Chi phí dự kiến không được âm!");
                isValid = false;
            }

            // 5. Kiểm tra Mô tả lỗi bắt buộc
            if (string.IsNullOrWhiteSpace(txtIssueDescription.Text))
            {
                epValidate.SetError(txtIssueDescription, "Vui lòng nhập mô tả lỗi!");
                isValid = false;
            }

            return isValid;
        }

        #endregion

        #region CRUD Operations

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput(isAddingNew: true)) return;

            var order = new RepairOrder
            {
                OrderId = txtOrderId.Text.Trim(),
                CustomerName = txtCustomerName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                DeviceType = cboDeviceType.SelectedItem?.ToString() ?? cboDeviceType.Text.Trim(),
                IssueDescription = txtIssueDescription.Text.Trim(),
                ReceivedDate = dtpReceivedDate.Value,
                EstimatedCost = nudEstimatedCost.Value,
                Status = cboStatus.SelectedItem?.ToString() ?? "Mới tiếp nhận",
                ImagePath = _selectedImagePath
            };

            _originalList.Add(order);
            ApplyFilter();
            ClearInputs();
            MessageBox.Show("Thêm đơn đăng ký dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is not RepairOrder selectedOrder) return;
            if (!ValidateInput(isAddingNew: false)) return;

            selectedOrder.CustomerName = txtCustomerName.Text.Trim();
            selectedOrder.Phone = txtPhone.Text.Trim();
            selectedOrder.DeviceType = cboDeviceType.SelectedItem?.ToString() ?? cboDeviceType.Text.Trim();
            selectedOrder.IssueDescription = txtIssueDescription.Text.Trim();
            selectedOrder.ReceivedDate = dtpReceivedDate.Value;
            selectedOrder.EstimatedCost = nudEstimatedCost.Value;
            selectedOrder.Status = cboStatus.SelectedItem?.ToString() ?? "Mới tiếp nhận";
            selectedOrder.ImagePath = _selectedImagePath;

            _bindingSource.ResetBindings(false);
            ApplyFilter();
            MessageBox.Show("Cập nhật đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is not RepairOrder selectedOrder) return;

            var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa đơn {selectedOrder.OrderId}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _originalList.Remove(selectedOrder);
                ApplyFilter();
                ClearInputs();
            }
        }

        private void DgvOrders_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is RepairOrder order)
            {
                txtOrderId.Text = order.OrderId;
                txtOrderId.ReadOnly = true;
                txtCustomerName.Text = order.CustomerName;
                txtPhone.Text = order.Phone;
                cboDeviceType.SelectedItem = order.DeviceType;
                txtIssueDescription.Text = order.IssueDescription;
                dtpReceivedDate.Value = order.ReceivedDate;
                nudEstimatedCost.Value = order.EstimatedCost;
                cboStatus.SelectedItem = order.Status;

                _selectedImagePath = order.ImagePath;
                LoadDeviceImage(_selectedImagePath);
            }
        }

        private void ClearInputs()
        {
            txtOrderId.ReadOnly = false;
            txtOrderId.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            if (cboDeviceType.Items.Count > 0) cboDeviceType.SelectedIndex = 0;
            txtIssueDescription.Clear();
            dtpReceivedDate.Value = DateTime.Now;
            nudEstimatedCost.Value = 0;
            cboStatus.SelectedIndex = 0;

            _selectedImagePath = string.Empty;
            LoadDeviceImage(string.Empty);

            epValidate.Clear();
            dgvOrders.ClearSelection();
        }

        #endregion

        #region Search, Filter, StatusStrip & Export CSV

        private void ApplyFilter()
        {
            string keyword = txtSearch.Text.Trim();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString() ?? "Tất cả";

            var query = _originalList.AsEnumerable();

            // Tìm kiếm tức thời theo mã đơn, tên khách hàng hoặc SĐT
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.OrderId.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                         x.CustomerName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                         x.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }

            // Lọc theo trạng thái
            if (selectedStatus != "Tất cả")
            {
                query = query.Where(x => x.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase));
            }

            _filteredList.Clear();
            foreach (var item in query)
            {
                _filteredList.Add(item);
            }

            // Tổng chi phí dự kiến của các đơn CHƯA HOÀN TẤT (và chưa bị hủy)
            decimal pendingTotalCost = _originalList
                .Where(x => x.Status != "Hoàn tất" && x.Status != "Đã hủy")
                .Sum(x => x.EstimatedCost);

            lblStatusCount.Text = $"Số đơn hiển thị: {_filteredList.Count}";
            lblStatusTotalPendingCost.Text = $"Tổng chi phí đơn chưa hoàn tất: {pendingTotalCost:N0} VNĐ";
        }

        private void MenuExportCsv_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = $"DanhSachDonSuaChua_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Mã Đơn,Tên Khách Hàng,Số Điện Thoại,Loại Thiết Bị,Mô Tả Lỗi,Ngày Tiếp Nhận,Chi Phí Dự Kiến (VNĐ),Trạng Thái,Đường Dẫn Ảnh");

                    foreach (var item in _filteredList)
                    {
                        sb.AppendLine($"\"{item.OrderId}\",\"{item.CustomerName}\",\"{item.Phone}\",\"{item.DeviceType}\",\"{item.IssueDescription}\",\"{item.ReceivedDate:dd/MM/yyyy HH:mm}\",\"{item.EstimatedCost:N0}\",\"{item.Status}\",\"{item.ImagePath}\"");
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