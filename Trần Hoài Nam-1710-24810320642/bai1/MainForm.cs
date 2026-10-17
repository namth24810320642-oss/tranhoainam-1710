using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bai1
{
    public partial class MainForm : Form
    {
        private readonly BindingList<Appointment> _originalList = [];
        private readonly BindingList<Appointment> _filteredList = [];
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
            cboDoctor.Items.AddRange(["BS. Nguyễn Văn A", "BS. Trần Thị B", "BS. Lê Hoàng C"]);
            cboDoctor.SelectedIndex = 0;

            string[] statuses = ["Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy"];
            cboStatus.Items.AddRange(statuses);
            cboStatus.SelectedIndex = 0;

            cboFilterStatus.Items.Add("Tất cả");
            cboFilterStatus.Items.AddRange(statuses);
            cboFilterStatus.SelectedIndex = 0;

            _originalList.Add(new Appointment
            {
                AppointmentId = "LH001",
                PatientName = "Nguyễn Văn Nam",
                Phone = "0912345678",
                AppointmentDate = DateTime.Now.AddHours(2),
                Doctor = "BS. Nguyễn Văn A",
                Reason = "Khám sức khỏe định kỳ",
                Status = "Chờ khám"
            });
        }

        private void SetupBindings()
        {
            _bindingSource.DataSource = _filteredList;
            dgvAppointments.DataSource = _bindingSource;
            colDate.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            ApplyFilter();
        }

        private void RegisterEvents()
        {
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += (s, e) => ClearInputs();

            dgvAppointments.SelectionChanged += DgvAppointments_SelectionChanged;

            txtSearch.TextChanged += (s, e) => ApplyFilter();
            cboFilterStatus.SelectedIndexChanged += (s, e) => ApplyFilter();
            dtpFilterDate.ValueChanged += (s, e) => ApplyFilter();
            chkFilterDate.CheckedChanged += (s, e) =>
            {
                dtpFilterDate.Enabled = chkFilterDate.Checked;
                ApplyFilter();
            };

            menuExportCsv.Click += MenuExportCsv_Click;
        }

        #region Validation Logic (Sử dụng Pattern Matching)

        private bool ValidateInput(bool isAddingNew)
        {
            bool isValid = true;
            epValidate.Clear();

            if (string.IsNullOrWhiteSpace(txtAppointmentId.Text))
            {
                epValidate.SetError(txtAppointmentId, "Vui lòng nhập mã lịch hẹn!");
                isValid = false;
            }
            else if (isAddingNew && _originalList.Any(x => x.AppointmentId.Equals(txtAppointmentId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                epValidate.SetError(txtAppointmentId, "Mã lịch hẹn đã tồn tại!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                epValidate.SetError(txtPatientName, "Vui lòng nhập tên bệnh nhân!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !Regex.IsMatch(txtPhone.Text.Trim(), @"^0\d{9}$"))
            {
                epValidate.SetError(txtPhone, "Số điện thoại không hợp lệ (phải gồm 10 chữ số, bắt đầu bằng số 0)!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                epValidate.SetError(txtReason, "Vui lòng nhập lý do khám!");
                isValid = false;
            }

            if (dtpAppointmentDate.Value < DateTime.Now.AddMinutes(-5))
            {
                epValidate.SetError(dtpAppointmentDate, "Thời gian hẹn không được ở trong quá khứ!");
                isValid = false;
            }

            return isValid;
        }

        #endregion

        #region CRUD Operations (Dùng Pattern Matching)

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput(isAddingNew: true)) return;

            var app = new Appointment
            {
                AppointmentId = txtAppointmentId.Text.Trim(),
                PatientName = txtPatientName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                AppointmentDate = dtpAppointmentDate.Value,
                Doctor = cboDoctor.SelectedItem?.ToString() ?? string.Empty,
                Reason = txtReason.Text.Trim(),
                Status = cboStatus.SelectedItem?.ToString() ?? string.Empty
            };

            _originalList.Add(app);
            ApplyFilter();
            ClearInputs();
            MessageBox.Show("Thêm lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is not Appointment selectedApp) return;
            if (!ValidateInput(isAddingNew: false)) return;

            selectedApp.PatientName = txtPatientName.Text.Trim();
            selectedApp.Phone = txtPhone.Text.Trim();
            selectedApp.AppointmentDate = dtpAppointmentDate.Value;
            selectedApp.Doctor = cboDoctor.SelectedItem?.ToString() ?? string.Empty;
            selectedApp.Reason = txtReason.Text.Trim();
            selectedApp.Status = cboStatus.SelectedItem?.ToString() ?? string.Empty;

            _bindingSource.ResetBindings(false);
            ApplyFilter();
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is not Appointment selectedApp) return;

            var dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa lịch hẹn {selectedApp.AppointmentId}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                _originalList.Remove(selectedApp);
                ApplyFilter();
                ClearInputs();
            }
        }

        private void DgvAppointments_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is Appointment app)
            {
                txtAppointmentId.Text = app.AppointmentId;
                txtAppointmentId.ReadOnly = true;
                txtPatientName.Text = app.PatientName;
                txtPhone.Text = app.Phone;
                dtpAppointmentDate.Value = app.AppointmentDate > DateTime.Now ? app.AppointmentDate : DateTime.Now;
                cboDoctor.SelectedItem = app.Doctor;
                txtReason.Text = app.Reason;
                cboStatus.SelectedItem = app.Status;
            }
        }

        private void ClearInputs()
        {
            txtAppointmentId.ReadOnly = false;
            txtAppointmentId.Clear();
            txtPatientName.Clear();
            txtPhone.Clear();
            txtReason.Clear();
            dtpAppointmentDate.Value = DateTime.Now;
            cboDoctor.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            epValidate.Clear();
            dgvAppointments.ClearSelection();
        }

        #endregion

        #region Search, Filter & Export

        private void ApplyFilter()
        {
            string keyword = txtSearch.Text.Trim();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString() ?? string.Empty;
            bool useDateFilter = chkFilterDate.Checked;
            DateTime filterDate = dtpFilterDate.Value.Date;

            var query = _originalList.AsEnumerable();

            // Sửa lỗi 'Contains' StringComparison
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.PatientName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                         x.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "Tất cả")
            {
                query = query.Where(x => x.Status == selectedStatus);
            }

            if (useDateFilter)
            {
                query = query.Where(x => x.AppointmentDate.Date == filterDate);
            }

            _filteredList.Clear();
            foreach (var item in query)
            {
                _filteredList.Add(item);
            }

            lblStatusCount.Text = $"Tổng số lịch hẹn: {_filteredList.Count}";
        }

        private void MenuExportCsv_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = $"DanhSachLichHen_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Mã Lịch Hẹn,Tên Bệnh Nhân,Số Điện Thoại,Ngày Giờ Hẹn,Bác Sĩ,Lý Do Khám,Trạng Thái");

                    foreach (var app in _filteredList)
                    {
                        sb.AppendLine($"\"{app.AppointmentId}\",\"{app.PatientName}\",\"{app.Phone}\",\"{app.AppointmentDate:dd/MM/yyyy HH:mm}\",\"{app.Doctor}\",\"{app.Reason}\",\"{app.Status}\"");
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}