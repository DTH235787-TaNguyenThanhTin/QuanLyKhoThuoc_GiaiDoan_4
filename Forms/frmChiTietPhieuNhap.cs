using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmChiTietPhieuNhap : Form
    {
        private bool isAdding = false;

        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvChiTietPhieuNhap.AutoGenerateColumns = false;

            // 1. Nạp danh sách Phiếu nhập kèm tìm kiếm nhanh (AutoComplete thiết lập trong Design)
            DataTable dtPhieu = Functions.GetDataToTable("SELECT _maPhieuNhap FROM PhieuNhap");
            cboMaPhieuNhap.DataSource = dtPhieu;
            cboMaPhieuNhap.ValueMember = "_maPhieuNhap";
            cboMaPhieuNhap.DisplayMember = "_maPhieuNhap";
            cboMaPhieuNhap.SelectedIndex = -1;

            // 2. Nạp danh sách Thuốc
            DataTable dtThuoc = Functions.GetDataToTable("SELECT _maThuoc, _tenThuoc FROM Thuoc");
            cboThuocMa.DataSource = dtThuoc;
            cboThuocMa.ValueMember = "_maThuoc";
            cboThuocMa.DisplayMember = "_tenThuoc";
            cboThuocMa.SelectedIndex = -1;

            SetControlState(false);

            // Thiết lập các ô hiển thị chỉ đọc
            txtTongTien.ReadOnly = true;
        }

        // HÀM HIỆN DỮ LIỆU LÊN LƯỚI VÀ TỔNG TIỀN
        private void LoadData()
        {
            if (cboMaPhieuNhap.SelectedValue == null) return;
            string maPN = cboMaPhieuNhap.SelectedValue.ToString();

            // SQL Join lấy thông tin chi tiết kèm tên thuốc và tính thành tiền ảo để hiển thị
            string sql = $@"SELECT CT._maPhieuNhapChiTiet, CT._thuocMa, T._tenThuoc, CT._soLo, CT._hanSuDung, 
                            CT._soLuongNhap, CT._donGiaNhap, (CT._soLuongNhap * CT._donGiaNhap) as _thanhTien
                            FROM PhieuNhapChiTiet CT 
                            JOIN Thuoc T ON CT._thuocMa = T._maThuoc
                            WHERE CT._phieuNhapMa = '{maPN}'";

            dgvChiTietPhieuNhap.DataSource = Functions.GetDataToTable(sql);

            // Tính tổng tiền từ bảng chi tiết để hiện lên ô txtTongTien
            string sqlSum = $"SELECT SUM(_soLuongNhap * _donGiaNhap) FROM PhieuNhapChiTiet WHERE _phieuNhapMa = '{maPN}'";
            string tong = Functions.GetFieldValues(sqlSum);

            // Định dạng hiển thị tiền tệ VNĐ (N0)
            txtTongTien.Text = string.IsNullOrEmpty(tong) ? "0" : decimal.Parse(tong).ToString("N0");
        }

        private void SetControlState(bool editing)
        {
            txtMaCTPN.Enabled = false;
            cboThuocMa.Enabled = editing;
            txtSoLo.Enabled = editing;
            dtpHanSuDung.Enabled = editing;
            numSoLuong.Enabled = editing;
            numDonGia.Enabled = editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
            btnThem.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnSua.Enabled = !editing;
        }

        // NÚT TÌM KIẾM: Hiển thị tất cả dữ liệu liên quan lên dgv và txtTongTien
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaPhieuNhap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã phiếu nhập cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LoadData();

            if (dgvChiTietPhieuNhap.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu thuốc cho mã phiếu này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaPhieuNhap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã phiếu nhập trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = true;
            SetControlState(true);
            ResetValues();

            // Tự sinh mã chi tiết theo thời gian thực
            txtMaCTPN.Text = "CT" + DateTime.Now.ToString("HHmmss");
            cboThuocMa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboThuocMa.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtSoLo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thuốc và số lô!");
                return;
            }

            string maPN = cboMaPhieuNhap.SelectedValue.ToString();
            string maThuoc = cboThuocMa.SelectedValue.ToString();
            string hsd = dtpHanSuDung.Value.ToString("yyyy-MM-dd");

            // Loại bỏ dấu phẩy phân cách nghìn trước khi lưu vào SQL
            string dg = numDonGia.Text.Replace(",", "");

            string sql = isAdding
                ? $@"INSERT INTO PhieuNhapChiTiet (_maPhieuNhapChiTiet, _phieuNhapMa, _thuocMa, _soLo, _hanSuDung, _soLuongNhap, _donGiaNhap)
                     VALUES ('{txtMaCTPN.Text}', '{maPN}', '{maThuoc}', '{txtSoLo.Text}', '{hsd}', {numSoLuong.Value}, {dg})"
                : $@"UPDATE PhieuNhapChiTiet SET _thuocMa='{maThuoc}', _soLo='{txtSoLo.Text}', 
                     _hanSuDung='{hsd}', _soLuongNhap={numSoLuong.Value}, _donGiaNhap={dg} 
                     WHERE _maPhieuNhapChiTiet='{txtMaCTPN.Text}'";

            Functions.RunSQL(sql);

            // Cập nhật tổng tiền bảng cha (PhieuNhap) ngay lập tức
            string sqlUpdatePN = $@"UPDATE PhieuNhap SET _tongTien = 
                                   (SELECT ISNULL(SUM(_soLuongNhap * _donGiaNhap),0) FROM PhieuNhapChiTiet WHERE _phieuNhapMa = '{maPN}')
                                   WHERE _maPhieuNhap = '{maPN}'";
            Functions.RunSQL(sqlUpdatePN);

            LoadData(); // Cập nhật lại giao diện lưới và tổng tiền
            SetControlState(false);
            isAdding = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCTPN.Text)) return;
            isAdding = false;
            SetControlState(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCTPN.Text)) return;
            if (MessageBox.Show("Xác nhận xóa dòng này khỏi phiếu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maPN = cboMaPhieuNhap.SelectedValue.ToString();
                Functions.RunSQL($"DELETE FROM PhieuNhapChiTiet WHERE _maPhieuNhapChiTiet = '{txtMaCTPN.Text}'");

                // Cập nhật lại tổng tiền sau khi xóa
                string sqlUpdatePN = $@"UPDATE PhieuNhap SET _tongTien = 
                                   (SELECT ISNULL(SUM(_soLuongNhap * _donGiaNhap),0) FROM PhieuNhapChiTiet WHERE _phieuNhapMa = '{maPN}')
                                   WHERE _maPhieuNhap = '{maPN}'";
                Functions.RunSQL(sqlUpdatePN);

                LoadData();
                ResetValues();
            }
        }

        private void dgvChiTietPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isAdding || e.RowIndex < 0) return;
            if (dgvChiTietPhieuNhap.CurrentRow != null)
            {
                // Đổ dữ liệu từ lưới lên các control nhập liệu để Sửa/Xóa
                txtMaCTPN.Text = dgvChiTietPhieuNhap.CurrentRow.Cells[0].Value.ToString();
                cboThuocMa.SelectedValue = dgvChiTietPhieuNhap.CurrentRow.Cells[1].Value.ToString();
                txtSoLo.Text = dgvChiTietPhieuNhap.CurrentRow.Cells["SoLo"].Value.ToString();
                dtpHanSuDung.Value = Convert.ToDateTime(dgvChiTietPhieuNhap.CurrentRow.Cells["HanSuDung"].Value);
                numSoLuong.Value = Convert.ToDecimal(dgvChiTietPhieuNhap.CurrentRow.Cells["SoLuong"].Value);
                numDonGia.Text = Convert.ToDecimal(dgvChiTietPhieuNhap.CurrentRow.Cells["DonGia"].Value).ToString("N0");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            ResetValues();
            SetControlState(false);
        }

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        private void ResetValues()
        {
            txtMaCTPN.Text = "";
            cboThuocMa.SelectedIndex = -1;
            txtSoLo.Text = "";
            dtpHanSuDung.Value = DateTime.Now;
            numSoLuong.Value = 0;
            numDonGia.Text = "0";
        }

        private void frmChiTietPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
                e.SuppressKeyPress = true;
            }
        }

        
        
    }
}