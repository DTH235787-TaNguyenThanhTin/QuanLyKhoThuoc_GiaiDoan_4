using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmPhieuNhap : Form
    {
        private bool isAdding = false;

        public frmPhieuNhap()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.AutoGenerateColumns = false;

            // 1. Nạp dữ liệu vào các ComboBox từ Database
            LoadCombos();

            // 2. Tải danh sách phiếu nhập lên lưới
            LoadData();

            SetControlState(false);
        }

        // Hàm nạp dữ liệu cho cả 2 ComboBox
        private void LoadCombos()
        {
            // Nạp Nhân viên
            DataTable dtNV = Functions.GetDataToTable("SELECT _maNhanVien, _hoTen FROM NhanVien");
            cboMaNhanVien.DataSource = dtNV;
            cboMaNhanVien.ValueMember = "_maNhanVien";   // Giá trị ẩn để lưu vào DB
            cboMaNhanVien.DisplayMember = "_hoTen";      // Giá trị hiện để người dùng chọn
            cboMaNhanVien.SelectedIndex = -1;

            // Nạp Nhà cung cấp
            DataTable dtNCC = Functions.GetDataToTable("SELECT _maNhaCungCap, _tenNhaCungCap FROM NhaCungCap");
            cboMaNhaCungCap.DataSource = dtNCC;
            cboMaNhaCungCap.ValueMember = "_maNhaCungCap";
            cboMaNhaCungCap.DisplayMember = "_tenNhaCungCap";
            cboMaNhaCungCap.SelectedIndex = -1;
        }

        private void LoadData()
        {
            // Lấy dữ liệu đúng theo các cột trong bảng PhieuNhap
            string sql = "SELECT _maPhieuNhap, _nhanVienMa, _nhaCungCapMa, _ngayNhap, _tongTien FROM PhieuNhap";
            dgvPhieuNhap.DataSource = Functions.GetDataToTable(sql);
        }

        private void SetControlState(bool editing)
        {
            txtMaPhieuNhap.Enabled = false; // Luôn khóa vì tự sinh
            cboMaNhanVien.Enabled = editing;
            cboMaNhaCungCap.Enabled = editing;
            dtpNgayNhap.Enabled = editing;
            txtTongTien.Enabled = editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnThoat.Enabled = !editing;
        }

        private void ResetValues()
        {
            txtMaPhieuNhap.Text = "";
            cboMaNhanVien.SelectedIndex = -1;
            cboMaNhaCungCap.SelectedIndex = -1;
            dtpNgayNhap.Value = DateTime.Now;
            txtTongTien.Text = "0"; // Mặc định là 0 khi tạo mới
            
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isAdding || e.RowIndex < 0) return;

            if (dgvPhieuNhap.CurrentRow != null)
            {
                // Lấy dữ liệu từ dòng được chọn đổ lên các ô nhập liệu
                txtMaPhieuNhap.Text = dgvPhieuNhap.CurrentRow.Cells[0].Value?.ToString();

                // ComboBox tự nhảy đúng giá trị dựa theo mã khóa ngoại
                cboMaNhanVien.SelectedValue = dgvPhieuNhap.CurrentRow.Cells[1].Value?.ToString();
                cboMaNhaCungCap.SelectedValue = dgvPhieuNhap.CurrentRow.Cells[2].Value?.ToString();

                dtpNgayNhap.Value = Convert.ToDateTime(dgvPhieuNhap.CurrentRow.Cells[3].Value);
                txtTongTien.Text = dgvPhieuNhap.CurrentRow.Cells[4].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetControlState(true);
            ResetValues();

            // Tự sinh mã phiếu theo ngày giờ (Ví dụ: PN202603281700)
            txtMaPhieuNhap.Text = "PN" + DateTime.Now.ToString("yyyyMMddHHmmss");
            cboMaNhanVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuNhap.Text)) return;
            isAdding = false;
            SetControlState(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra chọn ComboBox chưa
            if (cboMaNhanVien.SelectedValue == null || cboMaNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Nhân viên và Nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = cboMaNhanVien.SelectedValue.ToString();
            string maNCC = cboMaNhaCungCap.SelectedValue.ToString();
            string ngay = dtpNgayNhap.Value.ToString("yyyy-MM-dd HH:mm:ss");
            decimal tongTien = decimal.Parse(string.IsNullOrEmpty(txtTongTien.Text) ? "0" : txtTongTien.Text);

            string sql;
            if (isAdding)
            {
                sql = $"INSERT INTO PhieuNhap (_maPhieuNhap, _nhanVienMa, _nhaCungCapMa, _ngayNhap, _tongTien) " +
                      $"VALUES ('{txtMaPhieuNhap.Text}', '{maNV}', '{maNCC}', '{ngay}', {tongTien})";
            }
            else
            {
                sql = $"UPDATE PhieuNhap SET _nhanVienMa='{maNV}', _nhaCungCapMa='{maNCC}', " +
                      $"_ngayNhap='{ngay}', _tongTien={tongTien} WHERE _maPhieuNhap='{txtMaPhieuNhap.Text}'";
            }

            Functions.RunSQL(sql);
            LoadData();
            SetControlState(false);
            isAdding = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuNhap.Text)) return;

            if (MessageBox.Show("Bạn có muốn xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM PhieuNhap WHERE _maPhieuNhap = '{txtMaPhieuNhap.Text}'";
                Functions.RunSQL(sql);
                LoadData();
                ResetValues();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            ResetValues();
            SetControlState(false);
        }

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        private void frmPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
                e.SuppressKeyPress = true;
            }
        }

       
    }
}