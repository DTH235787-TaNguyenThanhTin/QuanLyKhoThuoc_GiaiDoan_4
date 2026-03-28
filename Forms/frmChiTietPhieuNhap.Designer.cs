namespace QuanLyKhoThuoc.Forms
{
    partial class frmChiTietPhieuNhap
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnTimKiem = new Button();
            cboMaPhieuNhap = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            btnLuu = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnThem = new Button();
            txtTongTien = new TextBox();
            numDonGia = new NumericUpDown();
            dtpHanSuDung = new DateTimePicker();
            cboThuocMa = new ComboBox();
            numSoLuong = new NumericUpDown();
            txtSoLo = new TextBox();
            txtMaCTPN = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            dgvChiTietPhieuNhap = new DataGridView();
            MaChiTietPN = new DataGridViewTextBoxColumn();
            MaThuoc = new DataGridViewTextBoxColumn();
            SoLo = new DataGridViewTextBoxColumn();
            HanSuDung = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1203, 122);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(cboMaPhieuNhap);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1203, 122);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(544, 57);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 44;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboMaPhieuNhap
            // 
            cboMaPhieuNhap.FormattingEnabled = true;
            cboMaPhieuNhap.Location = new Point(223, 59);
            cboMaPhieuNhap.Name = "cboMaPhieuNhap";
            cboMaPhieuNhap.Size = new Size(260, 33);
            cboMaPhieuNhap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 63);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 6;
            label1.Text = "Mã phiếu nhập";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(1203, 315);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(numDonGia);
            groupBox2.Controls.Add(dtpHanSuDung);
            groupBox2.Controls.Add(cboThuocMa);
            groupBox2.Controls.Add(numSoLuong);
            groupBox2.Controls.Add(txtSoLo);
            groupBox2.Controls.Add(txtMaCTPN);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1203, 315);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1068, 99);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1068, 155);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 43;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1068, 47);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 42;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(942, 99);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 41;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(942, 155);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 40;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(942, 47);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 39;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(505, 241);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(205, 31);
            txtTongTien.TabIndex = 19;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(656, 166);
            numDonGia.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(260, 31);
            numDonGia.TabIndex = 5;
            numDonGia.ThousandsSeparator = true;
            // 
            // dtpHanSuDung
            // 
            dtpHanSuDung.Format = DateTimePickerFormat.Short;
            dtpHanSuDung.Location = new Point(656, 111);
            dtpHanSuDung.Name = "dtpHanSuDung";
            dtpHanSuDung.Size = new Size(260, 31);
            dtpHanSuDung.TabIndex = 3;
            // 
            // cboThuocMa
            // 
            cboThuocMa.FormattingEnabled = true;
            cboThuocMa.Location = new Point(656, 51);
            cboThuocMa.Name = "cboThuocMa";
            cboThuocMa.Size = new Size(260, 33);
            cboThuocMa.TabIndex = 1;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(278, 162);
            numSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(205, 31);
            numSoLuong.TabIndex = 4;
            numSoLuong.ThousandsSeparator = true;
            // 
            // txtSoLo
            // 
            txtSoLo.Location = new Point(278, 107);
            txtSoLo.Name = "txtSoLo";
            txtSoLo.Size = new Size(205, 31);
            txtSoLo.TabIndex = 2;
            // 
            // txtMaCTPN
            // 
            txtMaCTPN.Location = new Point(278, 49);
            txtMaCTPN.Name = "txtMaCTPN";
            txtMaCTPN.Size = new Size(205, 31);
            txtMaCTPN.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(392, 247);
            label10.Name = "label10";
            label10.Size = new Size(87, 25);
            label10.TabIndex = 13;
            label10.Text = "Tổng tiền";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(79, 55);
            label9.Name = "label9";
            label9.Size = new Size(188, 25);
            label9.TabIndex = 12;
            label9.Text = "Mã phiếu nhập chi tiết";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(79, 113);
            label8.Name = "label8";
            label8.Size = new Size(53, 25);
            label8.TabIndex = 11;
            label8.Text = "Số lô";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 168);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 10;
            label7.Text = "Số lượng nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 55);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 9;
            label6.Text = "Tên thuốc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 117);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 8;
            label5.Text = "Hạn sử dụng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 172);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 7;
            label4.Text = "Đơn giá nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(1203, 327);
            panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvChiTietPhieuNhap);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1203, 327);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách chi tiết";
            // 
            // dgvChiTietPhieuNhap
            // 
            dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            dgvChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { MaChiTietPN, MaThuoc, SoLo, HanSuDung, SoLuong, DonGia, ThanhTien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvChiTietPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTietPhieuNhap.Dock = DockStyle.Fill;
            dgvChiTietPhieuNhap.Location = new Point(3, 27);
            dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            dgvChiTietPhieuNhap.RowHeadersWidth = 62;
            dgvChiTietPhieuNhap.Size = new Size(1197, 297);
            dgvChiTietPhieuNhap.TabIndex = 2;
            dgvChiTietPhieuNhap.CellClick += dgvChiTietPhieuNhap_CellClick;
            // 
            // MaChiTietPN
            // 
            MaChiTietPN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaChiTietPN.DataPropertyName = "_maPhieuNhapChiTiet";
            MaChiTietPN.HeaderText = "Mã chi tiết phiếu nhập";
            MaChiTietPN.MinimumWidth = 8;
            MaChiTietPN.Name = "MaChiTietPN";
            MaChiTietPN.Width = 169;
            // 
            // MaThuoc
            // 
            MaThuoc.DataPropertyName = "_thuocMa";
            MaThuoc.HeaderText = "Mã thuốc";
            MaThuoc.MinimumWidth = 8;
            MaThuoc.Name = "MaThuoc";
            // 
            // SoLo
            // 
            SoLo.DataPropertyName = "_soLo";
            SoLo.HeaderText = "Số lô";
            SoLo.MinimumWidth = 8;
            SoLo.Name = "SoLo";
            // 
            // HanSuDung
            // 
            HanSuDung.DataPropertyName = "_hanSuDung";
            HanSuDung.HeaderText = "HSD";
            HanSuDung.MinimumWidth = 8;
            HanSuDung.Name = "HanSuDung";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "_soLuongNhap";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "_donGiaNhap";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 8;
            DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "_thanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // frmChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 764);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "frmChiTietPhieuNhap";
            Text = "Chi tiết phiếu nhập";
            Load += frmChiTietPhieuNhap_Load;
            KeyDown += frmChiTietPhieuNhap_KeyDown;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ComboBox cboMaPhieuNhap;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtMaCTPN;
        private TextBox txtTongTien;
        private NumericUpDown numDonGia;
        private DateTimePicker dtpHanSuDung;
        private ComboBox cboThuocMa;
        private NumericUpDown numSoLuong;
        private TextBox txtSoLo;
        private Panel panel2;
        private GroupBox groupBox3;
        private DataGridView dgvChiTietPhieuNhap;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnThem;
        private DataGridViewTextBoxColumn MaChiTietPN;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn SoLo;
        private DataGridViewTextBoxColumn HanSuDung;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnTimKiem;
    }
}