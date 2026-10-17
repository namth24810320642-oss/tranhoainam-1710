namespace bai1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            msMain = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuExportCsv = new ToolStripMenuItem();
            ssStatus = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            tlpMain = new TableLayoutPanel();
            gbInput = new GroupBox();
            tlpInput = new TableLayoutPanel();
            label1 = new Label();
            txtAppointmentId = new TextBox();
            label2 = new Label();
            cboDoctor = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPhone = new TextBox();
            txtReason = new TextBox();
            txtPatientName = new TextBox();
            cboStatus = new ComboBox();
            label7 = new Label();
            dtpAppointmentDate = new DateTimePicker();
            pnlButtons = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pnlFilter = new Panel();
            cboFilterStatus = new ComboBox();
            label9 = new Label();
            dtpFilterDate = new DateTimePicker();
            chkFilterDate = new CheckBox();
            txtSearch = new TextBox();
            label8 = new Label();
            dgvAppointments = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colDoctor = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            epValidate = new ErrorProvider(components);
            msMain.SuspendLayout();
            ssStatus.SuspendLayout();
            tlpMain.SuspendLayout();
            gbInput.SuspendLayout();
            tlpInput.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epValidate).BeginInit();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(1262, 28);
            msMain.TabIndex = 0;
            msMain.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { menuExportCsv });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(88, 24);
            toolStripMenuItem1.Text = "Hệ Thống";
            // 
            // menuExportCsv
            // 
            menuExportCsv.Name = "menuExportCsv";
            menuExportCsv.Size = new Size(239, 26);
            menuExportCsv.Text = "Xuất danh sách ra CSV";
            // 
            // ssStatus
            // 
            ssStatus.ImageScalingSize = new Size(20, 20);
            ssStatus.Items.AddRange(new ToolStripItem[] { lblStatusCount });
            ssStatus.Location = new Point(0, 482);
            ssStatus.Name = "ssStatus";
            ssStatus.Size = new Size(1262, 26);
            ssStatus.TabIndex = 1;
            ssStatus.Text = "statusStrip1";
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(132, 20);
            lblStatusCount.Text = "Tổng số lịch hẹn: 0";
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(gbInput, 0, 0);
            tlpMain.Controls.Add(pnlFilter, 0, 1);
            tlpMain.Controls.Add(dgvAppointments, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 28);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 230F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1262, 454);
            tlpMain.TabIndex = 2;
            // 
            // gbInput
            // 
            gbInput.Controls.Add(tlpInput);
            gbInput.Dock = DockStyle.Fill;
            gbInput.Location = new Point(3, 3);
            gbInput.Name = "gbInput";
            gbInput.Size = new Size(1256, 224);
            gbInput.TabIndex = 0;
            gbInput.TabStop = false;
            gbInput.Text = "Thông Tin Lịch Hẹn";
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 4;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpInput.Controls.Add(label1, 0, 0);
            tlpInput.Controls.Add(txtAppointmentId, 1, 0);
            tlpInput.Controls.Add(label2, 2, 0);
            tlpInput.Controls.Add(cboDoctor, 3, 0);
            tlpInput.Controls.Add(label3, 0, 1);
            tlpInput.Controls.Add(label4, 2, 1);
            tlpInput.Controls.Add(label5, 0, 2);
            tlpInput.Controls.Add(label6, 2, 2);
            tlpInput.Controls.Add(txtPhone, 1, 2);
            tlpInput.Controls.Add(txtReason, 3, 2);
            tlpInput.Controls.Add(txtPatientName, 1, 1);
            tlpInput.Controls.Add(cboStatus, 3, 1);
            tlpInput.Controls.Add(label7, 0, 3);
            tlpInput.Controls.Add(dtpAppointmentDate, 1, 3);
            tlpInput.Controls.Add(pnlButtons, 3, 3);
            tlpInput.Dock = DockStyle.Fill;
            tlpInput.Location = new Point(3, 23);
            tlpInput.Name = "tlpInput";
            tlpInput.RowCount = 4;
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpInput.Size = new Size(1250, 198);
            tlpInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã lịch hẹn (*):";
            // 
            // txtAppointmentId
            // 
            txtAppointmentId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAppointmentId.Location = new Point(190, 11);
            txtAppointmentId.Name = "txtAppointmentId";
            txtAppointmentId.Size = new Size(431, 27);
            txtAppointmentId.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(627, 14);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Bác Sĩ:";
            // 
            // cboDoctor
            // 
            cboDoctor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(814, 10);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(433, 28);
            cboDoctor.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 63);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên bệnh nhân (*):";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(627, 63);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 5;
            label4.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 112);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 6;
            label5.Text = "Số điện thoại (*):";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(627, 112);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 7;
            label6.Text = "Lý do khám (*):";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(190, 109);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(431, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtReason
            // 
            txtReason.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtReason.Location = new Point(814, 109);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(433, 27);
            txtReason.TabIndex = 9;
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPatientName.Location = new Point(190, 60);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(431, 27);
            txtPatientName.TabIndex = 10;
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(814, 59);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(433, 28);
            cboStatus.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 162);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 12;
            label7.Text = "Ngày giờ hẹn (*):";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpAppointmentDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpAppointmentDate.Format = DateTimePickerFormat.Custom;
            dtpAppointmentDate.Location = new Point(190, 158);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(431, 27);
            dtpAppointmentDate.TabIndex = 13;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(814, 150);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(433, 45);
            pnlButtons.TabIndex = 14;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(303, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(203, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(103, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(cboFilterStatus);
            pnlFilter.Controls.Add(label9);
            pnlFilter.Controls.Add(dtpFilterDate);
            pnlFilter.Controls.Add(chkFilterDate);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(label8);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(3, 233);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1256, 54);
            pnlFilter.TabIndex = 1;
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(718, 12);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(151, 28);
            cboFilterStatus.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(634, 16);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 4;
            label9.Text = "Trạng thái:";
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Format = DateTimePickerFormat.Short;
            dtpFilterDate.Location = new Point(377, 10);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(220, 27);
            dtpFilterDate.TabIndex = 3;
            // 
            // chkFilterDate
            // 
            chkFilterDate.AutoSize = true;
            chkFilterDate.Location = new Point(244, 12);
            chkFilterDate.Name = "chkFilterDate";
            chkFilterDate.Size = new Size(127, 24);
            chkFilterDate.TabIndex = 2;
            chkFilterDate.Text = "Lọc theo ngày:";
            chkFilterDate.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(88, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 27);
            txtSearch.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 13);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 0;
            label8.Text = "Tìm kiếm:";
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPhone, colDate, colDoctor, colReason, colStatus });
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(3, 293);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(1256, 158);
            dgvAppointments.TabIndex = 2;
            // 
            // colId
            // 
            colId.DataPropertyName = "AppointmentId";
            colId.HeaderText = "Mã Lịch Hẹn";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 125;
            // 
            // colName
            // 
            colName.DataPropertyName = "PatientName";
            colName.HeaderText = "Bệnh Nhân";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 150;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Số Điện Thoại";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 125;
            // 
            // colDate
            // 
            colDate.DataPropertyName = "AppointmentDate";
            colDate.HeaderText = "Ngày Giờ Hẹn";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 130;
            // 
            // colDoctor
            // 
            colDoctor.DataPropertyName = "Doctor";
            colDoctor.HeaderText = "Bác Sĩ";
            colDoctor.MinimumWidth = 6;
            colDoctor.Name = "colDoctor";
            colDoctor.ReadOnly = true;
            colDoctor.Width = 130;
            // 
            // colReason
            // 
            colReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colReason.DataPropertyName = "Reason";
            colReason.HeaderText = "Lý do khám";
            colReason.MinimumWidth = 6;
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Trạng thái";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 125;
            // 
            // epValidate
            // 
            epValidate.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 508);
            Controls.Add(tlpMain);
            Controls.Add(ssStatus);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Lịch Hẹn Phòng Khám";
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ssStatus.ResumeLayout(false);
            ssStatus.PerformLayout();
            tlpMain.ResumeLayout(false);
            gbInput.ResumeLayout(false);
            tlpInput.ResumeLayout(false);
            tlpInput.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)epValidate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem menuExportCsv;
        private StatusStrip ssStatus;
        private ToolStripStatusLabel lblStatusCount;
        private TableLayoutPanel tlpMain;
        private GroupBox gbInput;
        private TableLayoutPanel tlpInput;
        private Label label1;
        private TextBox txtAppointmentId;
        private Label label2;
        private ComboBox cboDoctor;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPhone;
        private TextBox txtReason;
        private TextBox txtPatientName;
        private ComboBox cboStatus;
        private Label label7;
        private DateTimePicker dtpAppointmentDate;
        private Panel pnlButtons;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel pnlFilter;
        private DateTimePicker dtpFilterDate;
        private CheckBox chkFilterDate;
        private TextBox txtSearch;
        private Label label8;
        private ComboBox cboFilterStatus;
        private Label label9;
        private DataGridView dgvAppointments;
        private ErrorProvider epValidate;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colDoctor;
        private DataGridViewTextBoxColumn colReason;
        private DataGridViewTextBoxColumn colStatus;
    }
}