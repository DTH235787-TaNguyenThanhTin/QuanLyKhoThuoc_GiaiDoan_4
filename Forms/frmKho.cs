using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhoThuoc.Forms
{
    public partial class frmKho : Form
    {
        private bool isAdding = false;

        public frmKho()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            dgvKho.AutoGenerateColumns = false;
            LoadData();
            SetControlState(false);
        }

        // 1. Tải dữ liệu từ SQL lên lưới
        private void LoadData()
        {
            string sql = "SELECT _maKho, _tenKho, _ghiChu FROM Kho";
            dgvKho.DataSource = Functions.GetDataToTable(sql);
        }

        // 2. Trạng thái các nút và ô nhập liệu
        private void SetControlState(bool editing)
        {
            txtMaKho.Enabled = false; // Mã kho tự sinh
            txtTenKho.Enabled = editing;
            txtGhiChu.Enabled = editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnThoat.Enabled = !editing;
        }

        // 3. Xóa trắng các ô nhập
        private void ResetValues()
        {
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtGhiChu.Text = "";
        }

        // 4. Click chọn dòng trên Grid đổ lên TextBox
        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isAdding || e.RowIndex < 0) return;

            if (dgvKho.CurrentRow != null)
            {
                txtMaKho.Text = dgvKho.CurrentRow.Cells[0].Value?.ToString() ?? "";
                txtTenKho.Text = dgvKho.CurrentRow.Cells[1].Value?.ToString() ?? "";
                txtGhiChu.Text = dgvKho.CurrentRow.Cells[2].Value?.ToString() ?? "";
            }
        }

        // 5. Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetControlState(true);
            ResetValues();

            // Tự sinh mã KHO01, KHO02...
            string lastId = Functions.GetFieldValues("SELECT TOP 1 _maKho FROM Kho ORDER BY _maKho DESC") ?? "";
            int nextNum = 1;
            if (!string.IsNullOrEmpty(lastId) && lastId.Length > 3)
            {
                nextNum = int.Parse(lastId.Substring(3)) + 1;
            }
            txtMaKho.Text = "KHO" + nextNum.ToString("D2");
            txtTenKho.Focus();
        }

        // 6. Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKho.Text)) return;
            isAdding = false;
            SetControlState(true);
            txtTenKho.Focus();
        }

        // 7. Nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKho.Text))
            {
                MessageBox.Show("Vui lòng nhập tên kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKho.Focus();
                return;
            }

            string sql;
            if (isAdding)
            {
                sql = $"INSERT INTO Kho (_maKho, _tenKho, _ghiChu) " +
                      $"VALUES ('{txtMaKho.Text}', N'{txtTenKho.Text}', N'{txtGhiChu.Text}')";
            }
            else
            {
                sql = $"UPDATE Kho SET _tenKho = N'{txtTenKho.Text}', _ghiChu = N'{txtGhiChu.Text}' " +
                      $"WHERE _maKho = '{txtMaKho.Text}'";
            }

            Functions.RunSQL(sql);
            LoadData();
            SetControlState(false);
            isAdding = false;
        }

        // 8. Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKho.Text)) return;

            if (MessageBox.Show("Xác nhận xóa kho này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM Kho WHERE _maKho = '{txtMaKho.Text}'";
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

        // 9. Phím Enter nhảy ô
        private void frmKho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.ActiveControl is TextBox txt && txt.Multiline) return;
                this.ProcessTabKey(true);
                e.SuppressKeyPress = true;
            }
        }
    }
}