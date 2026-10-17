namespace bai2
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
            ssStatus = new StatusStrip();
            lblStatusTotal = new ToolStripStatusLabel();
            lblStatusOverdue = new ToolStripStatusLabel();
            lblStatusFiltered = new ToolStripStatusLabel();
            tlpMain = new TableLayoutPanel();
            gbInput = new GroupBox();
            tlpInput = new TableLayoutPanel();
            label1 = new Label();
            txtBorrowId = new TextBox();
            label2 = new Label();
            txtStudentId = new TextBox();
            label3 = new Label();
            txtStudentName = new TextBox();
            label4 = new Label();
            cboEquipment = new ComboBox();
            label5 = new Label();
            nudQuantity = new NumericUpDown();
            label6 = new Label();
            dtpBorrowDate = new DateTimePicker();
            label7 = new Label();
            dtpDueDate = new DateTimePicker();
            chkReturnDate = new CheckBox();
            dtpReturnDate = new DateTimePicker();
            lblStatus = new Label();
            pnlButtons = new Panel();
            btnMarkReturned = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pnlFilter = new Panel();
            cboFilterStatus = new ComboBox();
            label9 = new Label();
            txtSearch = new TextBox();
            label8 = new Label();
            dgvBorrows = new DataGridView();
            colBorrowId = new DataGridViewTextBoxColumn();
            colStudentId = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colEquipmentName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colBorrowDate = new DataGridViewTextBoxColumn();
            colDueDate = new DataGridViewTextBoxColumn();
            colReturnDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            epValidate = new ErrorProvider(components);
            msMain.SuspendLayout();
            ssStatus.SuspendLayout();
            tlpMain.SuspendLayout();
            gbInput.SuspendLayout();
            tlpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            pnlButtons.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).BeginInit();
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
            ssStatus.Items.AddRange(new ToolStripItem[] { lblStatusTotal, lblStatusOverdue, lblStatusFiltered });
            ssStatus.Location = new Point(0, 647);
            ssStatus.Name = "ssStatus";
            ssStatus.Size = new Size(1262, 26);
            ssStatus.TabIndex = 1;
            // 
            // lblStatusTotal
            // 
            lblStatusTotal.Name = "lblStatusTotal";
            lblStatusTotal.Size = new Size(119, 20);
            lblStatusTotal.Text = "Tổng số phiếu: 0";
            // 
            // lblStatusOverdue
            // 
            lblStatusOverdue.ForeColor = Color.Red;
            lblStatusOverdue.Margin = new Padding(20, 3, 0, 2);
            lblStatusOverdue.Name = "lblStatusOverdue";
            lblStatusOverdue.Size = new Size(137, 21);
            lblStatusOverdue.Text = "Số phiếu quá hạn: 0";
            // 
            // lblStatusFiltered
            // 
            lblStatusFiltered.Margin = new Padding(20, 3, 0, 2);
            lblStatusFiltered.Name = "lblStatusFiltered";
            lblStatusFiltered.Size = new Size(126, 21);
            lblStatusFiltered.Text = "Đang hiển thị: 0";
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(gbInput, 0, 0);
            tlpMain.Controls.Add(pnlFilter, 0, 1);
            tlpMain.Controls.Add(dgvBorrows, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 28);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1262, 619);
            tlpMain.TabIndex = 2;
            // 
            // gbInput
            // 
            gbInput.Controls.Add(tlpInput);
            gbInput.Dock = DockStyle.Fill;
            gbInput.Location = new Point(3, 3);
            gbInput.Name = "gbInput";
            gbInput.Size = new Size(1256, 274);
            gbInput.TabIndex = 0;
            gbInput.TabStop = false;
            gbInput.Text = "Thông Tin Phiếu Mượn Thiết Bị";
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 4;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpInput.Controls.Add(label1, 0, 0);
            tlpInput.Controls.Add(txtBorrowId, 1, 0);
            tlpInput.Controls.Add(label2, 2, 0);
            tlpInput.Controls.Add(txtStudentId, 3, 0);
            tlpInput.Controls.Add(label3, 0, 1);
            tlpInput.Controls.Add(txtStudentName, 1, 1);
            tlpInput.Controls.Add(label4, 2, 1);
            tlpInput.Controls.Add(cboEquipment, 3, 1);
            tlpInput.Controls.Add(label5, 0, 2);
            tlpInput.Controls.Add(nudQuantity, 1, 2);
            tlpInput.Controls.Add(label6, 2, 2);
            tlpInput.Controls.Add(dtpBorrowDate, 3, 2);
            tlpInput.Controls.Add(label7, 0, 3);
            tlpInput.Controls.Add(dtpDueDate, 1, 3);
            tlpInput.Controls.Add(chkReturnDate, 2, 3);
            tlpInput.Controls.Add(dtpReturnDate, 3, 3);
            tlpInput.Controls.Add(lblStatus, 0, 4);
            tlpInput.Controls.Add(pnlButtons, 1, 4);
            tlpInput.Dock = DockStyle.Fill;
            tlpInput.Location = new Point(3, 23);
            tlpInput.Name = "tlpInput";
            tlpInput.RowCount = 5;
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpInput.Size = new Size(1250, 248);
            tlpInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu (*):";
            // 
            // txtBorrowId
            // 
            txtBorrowId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBorrowId.Location = new Point(190, 11);
            txtBorrowId.Name = "txtBorrowId";
            txtBorrowId.Size = new Size(431, 27);
            txtBorrowId.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(627, 14);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã sinh viên (*):";
            // 
            // txtStudentId
            // 
            txtStudentId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStudentId.Location = new Point(814, 11);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(433, 27);
            txtStudentId.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 63);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 4;
            label3.Text = "Họ tên sinh viên (*):";
            // 
            // txtStudentName
            // 
            txtStudentName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStudentName.Location = new Point(190, 60);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(431, 27);
            txtStudentName.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(627, 63);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 6;
            label4.Text = "Thiết bị (*):";
            // 
            // cboEquipment
            // 
            cboEquipment.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboEquipment.FormattingEnabled = true;
            cboEquipment.Location = new Point(814, 59);
            cboEquipment.Name = "cboEquipment";
            cboEquipment.Size = new Size(433, 28);
            cboEquipment.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 112);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 8;
            label5.Text = "Số lượng (*):";
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudQuantity.Location = new Point(190, 109);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(431, 27);
            nudQuantity.TabIndex = 9;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(627, 112);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 10;
            label6.Text = "Ngày mượn (*):";
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpBorrowDate.Format = DateTimePickerFormat.Short;
            dtpBorrowDate.Location = new Point(814, 109);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(433, 27);
            dtpBorrowDate.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 161);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 12;
            label7.Text = "Hạn trả (*):";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(190, 158);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(431, 27);
            dtpDueDate.TabIndex = 13;
            // 
            // chkReturnDate
            // 
            chkReturnDate.Anchor = AnchorStyles.Left;
            chkReturnDate.AutoSize = true;
            chkReturnDate.Location = new Point(627, 159);
            chkReturnDate.Name = "chkReturnDate";
            chkReturnDate.Size = new Size(166, 24);
            chkReturnDate.TabIndex = 14;
            chkReturnDate.Text = "Ngày trả thực tế:";
            chkReturnDate.UseVisualStyleBackColor = true;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpReturnDate.Enabled = false;
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(814, 158);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(433, 27);
            dtpReturnDate.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Blue;
            lblStatus.Location = new Point(3, 212);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(170, 20);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Trạng thái: Đang mượn";
            // 
            // pnlButtons
            // 
            tlpInput.SetColumnSpan(pnlButtons, 3);
            pnlButtons.Controls.Add(btnMarkReturned);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(190, 199);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1057, 46);
            pnlButtons.TabIndex = 17;
            // 
            // btnMarkReturned
            // 
            btnMarkReturned.BackColor = Color.LightGreen;
            btnMarkReturned.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMarkReturned.Location = new Point(315, 7);
            btnMarkReturned.Name = "btnMarkReturned";
            btnMarkReturned.Size = new Size(160, 32);
            btnMarkReturned.TabIndex = 3;
            btnMarkReturned.Text = "Đánh dấu đã trả";
            btnMarkReturned.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(485, 7);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 32);
            btnClear.TabIndex = 4;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(210, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(105, 7);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 32);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(cboFilterStatus);
            pnlFilter.Controls.Add(label9);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(label8);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(3, 283);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1256, 44);
            pnlFilter.TabIndex = 1;
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(530, 8);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(160, 28);
            cboFilterStatus.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(415, 12);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 2;
            label9.Text = "Lọc trạng thái:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(150, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 27);
            txtSearch.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 12);
            label8.Name = "label8";
            label8.Size = new Size(135, 20);
            label8.TabIndex = 0;
            label8.Text = "Tìm kiếm (SV/TB):";
            // 
            // dgvBorrows
            // 
            dgvBorrows.AllowUserToAddRows = false;
            dgvBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrows.Columns.AddRange(new DataGridViewColumn[] { colBorrowId, colStudentId, colStudentName, colEquipmentName, colQuantity, colBorrowDate, colDueDate, colReturnDate, colStatus });
            dgvBorrows.Dock = DockStyle.Fill;
            dgvBorrows.Location = new Point(3, 333);
            dgvBorrows.MultiSelect = false;
            dgvBorrows.Name = "dgvBorrows";
            dgvBorrows.ReadOnly = true;
            dgvBorrows.RowHeadersWidth = 51;
            dgvBorrows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrows.Size = new Size(1256, 283);
            dgvBorrows.TabIndex = 2;
            // 
            // colBorrowId
            // 
            colBorrowId.DataPropertyName = "BorrowId";
            colBorrowId.HeaderText = "Mã Phiếu";
            colBorrowId.MinimumWidth = 6;
            colBorrowId.Name = "colBorrowId";
            colBorrowId.ReadOnly = true;
            colBorrowId.Width = 110;
            // 
            // colStudentId
            // 
            colStudentId.DataPropertyName = "StudentId";
            colStudentId.HeaderText = "Mã SV";
            colStudentId.MinimumWidth = 6;
            colStudentId.Name = "colStudentId";
            colStudentId.ReadOnly = true;
            colStudentId.Width = 110;
            // 
            // colStudentName
            // 
            colStudentName.DataPropertyName = "StudentName";
            colStudentName.HeaderText = "Họ Tên SV";
            colStudentName.MinimumWidth = 6;
            colStudentName.Name = "colStudentName";
            colStudentName.ReadOnly = true;
            colStudentName.Width = 160;
            // 
            // colEquipmentName
            // 
            colEquipmentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEquipmentName.DataPropertyName = "EquipmentName";
            colEquipmentName.HeaderText = "Thiết Bị Mượn";
            colEquipmentName.MinimumWidth = 6;
            colEquipmentName.Name = "colEquipmentName";
            colEquipmentName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Số Lượng";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 90;
            // 
            // colBorrowDate
            // 
            colBorrowDate.DataPropertyName = "BorrowDate";
            colBorrowDate.HeaderText = "Ngày Mượn";
            colBorrowDate.MinimumWidth = 6;
            colBorrowDate.Name = "colBorrowDate";
            colBorrowDate.ReadOnly = true;
            colBorrowDate.Width = 120;
            // 
            // colDueDate
            // 
            colDueDate.DataPropertyName = "DueDate";
            colDueDate.HeaderText = "Hạn Trả";
            colDueDate.MinimumWidth = 6;
            colDueDate.Name = "colDueDate";
            colDueDate.ReadOnly = true;
            colDueDate.Width = 120;
            // 
            // colReturnDate
            // 
            colReturnDate.DataPropertyName = "ReturnDate";
            colReturnDate.HeaderText = "Ngày Trả";
            colReturnDate.MinimumWidth = 6;
            colReturnDate.Name = "colReturnDate";
            colReturnDate.ReadOnly = true;
            colReturnDate.Width = 120;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Trạng Thái";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 120;
            // 
            // epValidate
            // 
            epValidate.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(tlpMain);
            Controls.Add(ssStatus);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Mượn Trả Thiết Bị Phòng Thực Hành";
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ssStatus.ResumeLayout(false);
            ssStatus.PerformLayout();
            tlpMain.ResumeLayout(false);
            gbInput.ResumeLayout(false);
            tlpInput.ResumeLayout(false);
            tlpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            pnlButtons.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).EndInit();
            ((System.ComponentModel.ISupportInitialize)epValidate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem menuExportCsv;
        private StatusStrip ssStatus;
        private ToolStripStatusLabel lblStatusTotal;
        private ToolStripStatusLabel lblStatusOverdue;
        private ToolStripStatusLabel lblStatusFiltered;
        private TableLayoutPanel tlpMain;
        private GroupBox gbInput;
        private TableLayoutPanel tlpInput;
        private Label label1;
        private TextBox txtBorrowId;
        private Label label2;
        private TextBox txtStudentId;
        private Label label3;
        private TextBox txtStudentName;
        private Label label4;
        private ComboBox cboEquipment;
        private Label label5;
        private NumericUpDown nudQuantity;
        private Label label6;
        private DateTimePicker dtpBorrowDate;
        private Label label7;
        private DateTimePicker dtpDueDate;
        private CheckBox chkReturnDate;
        private DateTimePicker dtpReturnDate;
        private Label lblStatus;
        private Panel pnlButtons;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnMarkReturned;
        private Panel pnlFilter;
        private TextBox txtSearch;
        private Label label8;
        private ComboBox cboFilterStatus;
        private Label label9;
        private DataGridView dgvBorrows;
        private ErrorProvider epValidate;
        private DataGridViewTextBoxColumn colBorrowId;
        private DataGridViewTextBoxColumn colStudentId;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colEquipmentName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colBorrowDate;
        private DataGridViewTextBoxColumn colDueDate;
        private DataGridViewTextBoxColumn colReturnDate;
        private DataGridViewTextBoxColumn colStatus;
    }
}