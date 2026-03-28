namespace QuanLyKhoThuoc.Forms
{
    partial class frmPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnLuu = new Button();
            dtpNgayNhap = new DateTimePicker();
            btnThoat = new Button();
            cboMaNhaCungCap = new ComboBox();
            btnSua = new Button();
            btnXoa = new Button();
            label5 = new Label();
            btnHuy = new Button();
            txtTongTien = new TextBox();
            btnThem = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMaPhieuNhap = new TextBox();
            cboMaNhanVien = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvPhieuNhap = new DataGridView();
            MaPhieuNhap = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 246);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(dtpNgayNhap);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(cboMaNhaCungCap);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaPhieuNhap);
            groupBox1.Controls.Add(cboMaNhanVien);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1108, 246);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(984, 117);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(512, 119);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(193, 31);
            dtpNgayNhap.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(984, 169);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 89;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // cboMaNhaCungCap
            // 
            cboMaNhaCungCap.FormattingEnabled = true;
            cboMaNhaCungCap.Location = new Point(167, 119);
            cboMaNhaCungCap.Name = "cboMaNhaCungCap";
            cboMaNhaCungCap.Size = new Size(193, 33);
            cboMaNhaCungCap.TabIndex = 1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(858, 117);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 88;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(732, 169);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 87;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 178);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 81;
            label5.Text = "Tổng tiền";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(858, 169);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 86;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(167, 175);
            txtTongTien.Multiline = true;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(538, 31);
            txtTongTien.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(732, 117);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 85;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 117);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 80;
            label4.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 119);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 79;
            label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 72);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 78;
            label2.Text = "Nhân viên";
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.Location = new Point(167, 66);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.Size = new Size(193, 31);
            txtMaPhieuNhap.TabIndex = 76;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(512, 66);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(193, 33);
            cboMaNhanVien.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 66);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 74;
            label1.Text = "Mã phiếu nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 246);
            panel2.Name = "panel2";
            panel2.Size = new Size(1108, 387);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvPhieuNhap);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1108, 387);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToDeleteRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { MaPhieuNhap, MaNhanVien, MaNhaCungCap, NgayNhap, TongTien });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.Location = new Point(3, 27);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersWidth = 62;
            dgvPhieuNhap.Size = new Size(1102, 357);
            dgvPhieuNhap.TabIndex = 1;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            // 
            // MaPhieuNhap
            // 
            MaPhieuNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaPhieuNhap.DataPropertyName = "_maPhieuNhap";
            MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            MaPhieuNhap.MinimumWidth = 8;
            MaPhieuNhap.Name = "MaPhieuNhap";
            MaPhieuNhap.ReadOnly = true;
            MaPhieuNhap.Width = 167;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "_nhanVienMa";
            MaNhanVien.HeaderText = "Nhân viên";
            MaNhanVien.MinimumWidth = 8;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // MaNhaCungCap
            // 
            MaNhaCungCap.DataPropertyName = "_nhaCungCapMa";
            MaNhaCungCap.HeaderText = "Nhà cung cấp";
            MaNhaCungCap.MinimumWidth = 8;
            MaNhaCungCap.Name = "MaNhaCungCap";
            MaNhaCungCap.ReadOnly = true;
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "_ngayNhap";
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 8;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "_tongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 8;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 633);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            MinimizeBox = false;
            Name = "frmPhieuNhap";
            Text = "Phiếu nhập";
            Load += frmPhieuNhap_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridView dgvPhieuNhap;
        private GroupBox groupBox1;
        private Button btnLuu;
        private DateTimePicker dtpNgayNhap;
        private Button btnThoat;
        private ComboBox cboMaNhaCungCap;
        private Button btnSua;
        private Button btnXoa;
        private Label label5;
        private Button btnHuy;
        private TextBox txtTongTien;
        private Button btnThem;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMaPhieuNhap;
        private ComboBox cboMaNhanVien;
        private Label label1;
        private DataGridViewTextBoxColumn MaPhieuNhap;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn TongTien;
    }
}