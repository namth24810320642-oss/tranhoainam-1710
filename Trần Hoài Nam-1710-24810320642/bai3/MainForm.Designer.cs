namespace bai3
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            msMain = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuExportCsv = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            ssStatus = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            lblStatusTotalPendingCost = new ToolStripStatusLabel();
            tlpMain = new TableLayoutPanel();
            gbInput = new GroupBox();
            tlpInput = new TableLayoutPanel();
            label1 = new Label();
            txtOrderId = new TextBox();
            label2 = new Label();
            txtCustomerName = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            cboDeviceType = new ComboBox();
            label5 = new Label();
            dtpReceivedDate = new DateTimePicker();
            label6 = new Label();
            nudEstimatedCost = new NumericUpDown();
            label7 = new Label();
            cboStatus = new ComboBox();
            label8 = new Label();
            txtIssueDescription = new TextBox();
            pnlImage = new Panel();
            picDevice = new PictureBox();
            pnlImageButtons = new Panel();
            btnRemoveImage = new Button();
            btnSelectImage = new Button();
            pnlButtons = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pnlFilter = new Panel();
            cboFilterStatus = new ComboBox();
            label10 = new Label();
            txtSearch = new TextBox();
            label9 = new Label();
            dgvOrders = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colDeviceType = new DataGridViewTextBoxColumn();
            colIssueDescription = new DataGridViewTextBoxColumn();
            colReceivedDate = new DataGridViewTextBoxColumn();
            colEstimatedCost = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            epValidate = new ErrorProvider(components);
            msMain.SuspendLayout();
            ssStatus.SuspendLayout();
            tlpMain.SuspendLayout();
            gbInput.SuspendLayout();
            tlpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstimatedCost).BeginInit();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDevice).BeginInit();
            pnlImageButtons.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epValidate).BeginInit();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(1282, 28);
            msMain.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { menuExportCsv, toolStripSeparator1, menuExit });
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(236, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(239, 26);
            menuExit.Text = "Thoát ứng dụng";
            // 
            // ssStatus
            // 
            ssStatus.ImageScalingSize = new Size(20, 20);
            ssStatus.Items.AddRange(new ToolStripItem[] { lblStatusCount, lblStatusTotalPendingCost });
            ssStatus.Location = new Point(0, 677);
            ssStatus.Name = "ssStatus";
            ssStatus.Size = new Size(1282, 26);
            ssStatus.TabIndex = 1;
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(130, 20);
            lblStatusCount.Text = "Số đơn hiển thị: 0";
            // 
            // lblStatusTotalPendingCost
            // 
            lblStatusTotalPendingCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusTotalPendingCost.ForeColor = Color.DarkRed;
            lblStatusTotalPendingCost.Margin = new Padding(30, 3, 0, 2);
            lblStatusTotalPendingCost.Name = "lblStatusTotalPendingCost";
            lblStatusTotalPendingCost.Size = new Size(318, 21);
            lblStatusTotalPendingCost.Text = "Tổng chi phí đơn chưa hoàn tất: 0 VNĐ";
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(gbInput, 0, 0);
            tlpMain.Controls.Add(pnlFilter, 0, 1);
            tlpMain.Controls.Add(dgvOrders, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 28);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 320F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1282, 649);
            tlpMain.TabIndex = 2;
            // 
            // gbInput
            // 
            gbInput.Controls.Add(tlpInput);
            gbInput.Dock = DockStyle.Fill;
            gbInput.Location = new Point(3, 3);
            gbInput.Name = "gbInput";
            gbInput.Size = new Size(1276, 314);
            gbInput.TabIndex = 0;
            gbInput.TabStop = false;
            gbInput.Text = "Thông Tin Đơn Đăng Ký Sửa Chữa";
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 5;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpInput.Controls.Add(label1, 0, 0);
            tlpInput.Controls.Add(txtOrderId, 1, 0);
            tlpInput.Controls.Add(label2, 2, 0);
            tlpInput.Controls.Add(txtCustomerName, 3, 0);
            tlpInput.Controls.Add(label3, 0, 1);
            tlpInput.Controls.Add(txtPhone, 1, 1);
            tlpInput.Controls.Add(label4, 2, 1);
            tlpInput.Controls.Add(cboDeviceType, 3, 1);
            tlpInput.Controls.Add(label5, 0, 2);
            tlpInput.Controls.Add(dtpReceivedDate, 1, 2);
            tlpInput.Controls.Add(label6, 2, 2);
            tlpInput.Controls.Add(nudEstimatedCost, 3, 2);
            tlpInput.Controls.Add(label7, 0, 3);
            tlpInput.Controls.Add(cboStatus, 1, 3);
            tlpInput.Controls.Add(label8, 2, 3);
            tlpInput.Controls.Add(txtIssueDescription, 3, 3);
            tlpInput.Controls.Add(pnlImage, 4, 0);
            tlpInput.Controls.Add(pnlButtons, 0, 4);
            tlpInput.Dock = DockStyle.Fill;
            tlpInput.Location = new Point(3, 23);
            tlpInput.Name = "tlpInput";
            tlpInput.RowCount = 5;
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tlpInput.Size = new Size(1270, 288);
            tlpInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã đơn (*):";
            // 
            // txtOrderId
            // 
            txtOrderId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOrderId.Location = new Point(155, 12);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(400, 27);
            txtOrderId.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(561, 15);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng (*):";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerName.Location = new Point(713, 12);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(298, 27);
            txtCustomerName.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 4;
            label3.Text = "Số điện thoại (*):";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(155, 63);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(400, 27);
            txtPhone.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(561, 66);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 6;
            label4.Text = "Loại thiết bị (*):";
            // 
            // cboDeviceType
            // 
            cboDeviceType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboDeviceType.FormattingEnabled = true;
            cboDeviceType.Location = new Point(713, 62);
            cboDeviceType.Name = "cboDeviceType";
            cboDeviceType.Size = new Size(298, 28);
            cboDeviceType.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 117);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày tiếp nhận (*):";
            // 
            // dtpReceivedDate
            // 
            dtpReceivedDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpReceivedDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpReceivedDate.Format = DateTimePickerFormat.Custom;
            dtpReceivedDate.Location = new Point(155, 114);
            dtpReceivedDate.Name = "dtpReceivedDate";
            dtpReceivedDate.Size = new Size(400, 27);
            dtpReceivedDate.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(561, 117);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 10;
            label6.Text = "Chi phí dự kiến (*):";
            // 
            // nudEstimatedCost
            // 
            nudEstimatedCost.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudEstimatedCost.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            nudEstimatedCost.Location = new Point(713, 114);
            nudEstimatedCost.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudEstimatedCost.Name = "nudEstimatedCost";
            nudEstimatedCost.Size = new Size(298, 27);
            nudEstimatedCost.TabIndex = 11;
            nudEstimatedCost.ThousandsSeparator = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 183);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 12;
            label7.Text = "Trạng thái (*):";
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(155, 179);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(400, 28);
            cboStatus.TabIndex = 13;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(561, 183);
            label8.Name = "label8";
            label8.Size = new Size(122, 20);
            label8.TabIndex = 14;
            label8.Text = "Mô tả lỗi (*):";
            // 
            // txtIssueDescription
            // 
            txtIssueDescription.Dock = DockStyle.Fill;
            txtIssueDescription.Location = new Point(713, 156);
            txtIssueDescription.Multiline = true;
            txtIssueDescription.Name = "txtIssueDescription";
            txtIssueDescription.ScrollBars = ScrollBars.Vertical;
            txtIssueDescription.Size = new Size(298, 74);
            txtIssueDescription.TabIndex = 15;
            // 
            // pnlImage
            // 
            pnlImage.Controls.Add(picDevice);
            pnlImage.Controls.Add(pnlImageButtons);
            pnlImage.Dock = DockStyle.Fill;
            pnlImage.Location = new Point(1017, 3);
            pnlImage.Name = "pnlImage";
            tlpInput.SetRowSpan(pnlImage, 4);
            pnlImage.Size = new Size(250, 227);
            pnlImage.TabIndex = 16;
            // 
            // picDevice
            // 
            picDevice.BorderStyle = BorderStyle.FixedSingle;
            picDevice.Dock = DockStyle.Fill;
            picDevice.Location = new Point(0, 0);
            picDevice.Name = "picDevice";
            picDevice.Size = new Size(250, 187);
            picDevice.SizeMode = PictureBoxSizeMode.Zoom;
            picDevice.TabIndex = 0;
            picDevice.TabStop = false;
            // 
            // pnlImageButtons
            // 
            pnlImageButtons.Controls.Add(btnRemoveImage);
            pnlImageButtons.Controls.Add(btnSelectImage);
            pnlImageButtons.Dock = DockStyle.Bottom;
            pnlImageButtons.Location = new Point(0, 187);
            pnlImageButtons.Name = "pnlImageButtons";
            pnlImageButtons.Size = new Size(250, 40);
            pnlImageButtons.TabIndex = 1;
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.Location = new Point(130, 6);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(115, 30);
            btnRemoveImage.TabIndex = 1;
            btnRemoveImage.Text = "Xóa ảnh";
            btnRemoveImage.UseVisualStyleBackColor = true;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(5, 6);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(115, 30);
            btnSelectImage.TabIndex = 0;
            btnSelectImage.Text = "Chọn ảnh...";
            btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // pnlButtons
            // 
            tlpInput.SetColumnSpan(pnlButtons, 5);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(3, 236);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1264, 49);
            pnlButtons.TabIndex = 17;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(345, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 32);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(230, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(115, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 32);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(cboFilterStatus);
            pnlFilter.Controls.Add(label10);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(label9);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(3, 323);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1276, 39);
            pnlFilter.TabIndex = 1;
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(620, 6);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(180, 28);
            cboFilterStatus.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(505, 10);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 2;
            label10.Text = "Lọc trạng thái:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(205, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 27);
            txtSearch.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 10);
            label9.Name = "label9";
            label9.Size = new Size(190, 20);
            label9.TabIndex = 0;
            label9.Text = "Tìm kiếm (Mã/Tên/SĐT):";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colCustomerName, colPhone, colDeviceType, colIssueDescription, colReceivedDate, colEstimatedCost, colStatus });
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(3, 368);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1276, 278);
            dgvOrders.TabIndex = 2;
            // 
            // colOrderId
            // 
            colOrderId.DataPropertyName = "OrderId";
            colOrderId.HeaderText = "Mã Đơn";
            colOrderId.MinimumWidth = 6;
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            colOrderId.Width = 110;
            // 
            // colCustomerName
            // 
            colCustomerName.DataPropertyName = "CustomerName";
            colCustomerName.HeaderText = "Tên Khách Hàng";
            colCustomerName.MinimumWidth = 6;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            colCustomerName.Width = 160;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Số Điện Thoại";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 120;
            // 
            // colDeviceType
            // 
            colDeviceType.DataPropertyName = "DeviceType";
            colDeviceType.HeaderText = "Loại Thiết Bị";
            colDeviceType.MinimumWidth = 6;
            colDeviceType.Name = "colDeviceType";
            colDeviceType.ReadOnly = true;
            colDeviceType.Width = 130;
            // 
            // colIssueDescription
            // 
            colIssueDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colIssueDescription.DataPropertyName = "IssueDescription";
            colIssueDescription.HeaderText = "Mô Tả Lỗi";
            colIssueDescription.MinimumWidth = 6;
            colIssueDescription.Name = "colIssueDescription";
            colIssueDescription.ReadOnly = true;
            // 
            // colReceivedDate
            // 
            colReceivedDate.DataPropertyName = "ReceivedDate";
            colReceivedDate.HeaderText = "Ngày Tiếp Nhận";
            colReceivedDate.MinimumWidth = 6;
            colReceivedDate.Name = "colReceivedDate";
            colReceivedDate.ReadOnly = true;
            colReceivedDate.Width = 140;
            // 
            // colEstimatedCost
            // 
            colEstimatedCost.DataPropertyName = "EstimatedCost";
            colEstimatedCost.HeaderText = "Chi Phí Dự Kiến";
            colEstimatedCost.MinimumWidth = 6;
            colEstimatedCost.Name = "colEstimatedCost";
            colEstimatedCost.ReadOnly = true;
            colEstimatedCost.Width = 130;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Trạng Thái";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 130;
            // 
            // epValidate
            // 
            epValidate.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 703);
            Controls.Add(tlpMain);
            Controls.Add(ssStatus);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Đơn Đăng Ký Dịch Vụ Sửa Chữa - Repair Service Tracker";
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ssStatus.ResumeLayout(false);
            ssStatus.PerformLayout();
            tlpMain.ResumeLayout(false);
            gbInput.ResumeLayout(false);
            tlpInput.ResumeLayout(false);
            tlpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstimatedCost).EndInit();
            pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDevice).EndInit();
            pnlImageButtons.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)epValidate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem menuExportCsv;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuExit;
        private StatusStrip ssStatus;
        private ToolStripStatusLabel lblStatusCount;
        private ToolStripStatusLabel lblStatusTotalPendingCost;
        private TableLayoutPanel tlpMain;
        private GroupBox gbInput;
        private TableLayoutPanel tlpInput;
        private Label label1;
        private TextBox txtOrderId;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private ComboBox cboDeviceType;
        private Label label5;
        private DateTimePicker dtpReceivedDate;
        private Label label6;
        private NumericUpDown nudEstimatedCost;
        private Label label7;
        private ComboBox cboStatus;
        private Label label8;
        private TextBox txtIssueDescription;
        private Panel pnlImage;
        private PictureBox picDevice;
        private Panel pnlImageButtons;
        private Button btnRemoveImage;
        private Button btnSelectImage;
        private Panel pnlButtons;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel pnlFilter;
        private TextBox txtSearch;
        private Label label9;
        private ComboBox cboFilterStatus;
        private Label label10;
        private DataGridView dgvOrders;
        private ErrorProvider epValidate;
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colDeviceType;
        private DataGridViewTextBoxColumn colIssueDescription;
        private DataGridViewTextBoxColumn colReceivedDate;
        private DataGridViewTextBoxColumn colEstimatedCost;
        private DataGridViewTextBoxColumn colStatus;
    }
}