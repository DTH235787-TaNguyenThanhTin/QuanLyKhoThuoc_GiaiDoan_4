namespace QuanLyKhoThuoc.Forms
{
    partial class frmKho
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
            btnLuu = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnThem = new Button();
            txtGhiChu = new TextBox();
            label4 = new Label();
            txtTenKho = new TextBox();
            label3 = new Label();
            txtMaKho = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvKho = new DataGridView();
            MaKho = new DataGridViewTextBoxColumn();
            TenKho = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 264);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenKho);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaKho);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 264);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin kho";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(871, 118);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(871, 170);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 52;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(745, 118);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 51;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(619, 170);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 50;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(745, 170);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 49;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(619, 118);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 48;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(214, 169);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(359, 31);
            txtGhiChu.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 175);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 46;
            label4.Text = "Ghi chú :";
            // 
            // txtTenKho
            // 
            txtTenKho.Location = new Point(214, 118);
            txtTenKho.Name = "txtTenKho";
            txtTenKho.Size = new Size(359, 31);
            txtTenKho.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 124);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 45;
            label3.Text = "Tên kho :";
            // 
            // txtMaKho
            // 
            txtMaKho.Location = new Point(214, 68);
            txtMaKho.Name = "txtMaKho";
            txtMaKho.Size = new Size(359, 31);
            txtMaKho.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 74);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 44;
            label2.Text = "Mã kho(*) :";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 264);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 387);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvKho);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1029, 387);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách kho";
            // 
            // dgvKho
            // 
            dgvKho.AllowUserToDeleteRows = false;
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Columns.AddRange(new DataGridViewColumn[] { MaKho, TenKho, GhiChu });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKho.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKho.Dock = DockStyle.Fill;
            dgvKho.Location = new Point(3, 27);
            dgvKho.Name = "dgvKho";
            dgvKho.ReadOnly = true;
            dgvKho.RowHeadersWidth = 62;
            dgvKho.Size = new Size(1023, 357);
            dgvKho.TabIndex = 2;
            // 
            // MaKho
            // 
            MaKho.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaKho.DataPropertyName = "_maKho";
            MaKho.HeaderText = "Mã kho";
            MaKho.MinimumWidth = 8;
            MaKho.Name = "MaKho";
            MaKho.ReadOnly = true;
            MaKho.Width = 108;
            // 
            // TenKho
            // 
            TenKho.DataPropertyName = "_tenKho";
            TenKho.HeaderText = "Tên kho";
            TenKho.MinimumWidth = 8;
            TenKho.Name = "TenKho";
            TenKho.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "_ghiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 8;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            // 
            // frmKho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 651);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "frmKho";
            Text = "Kho";
            Load += frmKho_Load;
            KeyDown += frmKho_KeyDown;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridView dgvKho;
        private TextBox txtGhiChu;
        private Label label4;
        private TextBox txtTenKho;
        private Label label3;
        private TextBox txtMaKho;
        private Label label2;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnThem;
        private DataGridViewTextBoxColumn MaKho;
        private DataGridViewTextBoxColumn TenKho;
        private DataGridViewTextBoxColumn GhiChu;
    }
}