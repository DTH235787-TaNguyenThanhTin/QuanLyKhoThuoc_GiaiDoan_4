using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhoThuoc // Đảm bảo namespace này khớp với project của bạn
{
    public class Functions
    {
        private static SqlConnection Con;

        // --- 1. HÀM KẾT NỐI CSDL ---
        public static void Connect()
        {
            // Chỉ tạo mới kết nối nếu nó chưa được khởi tạo
            if (Con == null) 
            {
                string strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLKhoThuoc;Integrated Security=True;TrustServerCertificate=True;";
                Con = new SqlConnection(strCon);
            }

            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        // --- 2. HÀM ĐÓNG KẾT NỐI ---
        public static void Disconnect()
        {
            if (Con != null && Con.State == ConnectionState.Open)
            {
                Con.Close();   // Đóng kết nối
                Con.Dispose(); // Giải phóng tài nguyên
                Con = null;
            }
        }

        // --- 3. HÀM LẤY DỮ LIỆU ĐỔ VÀO DATATABLE (Dùng cho lệnh SELECT) ---
        public static DataTable GetDataToTable(string sql)
        {
            DataTable table = new DataTable();
            using (SqlDataAdapter dap = new SqlDataAdapter(sql, Con))
            {
                dap.Fill(table);
            }
            return table;
        }

        // --- 4. HÀM THỰC THI LỆNH (Dùng cho INSERT, UPDATE, DELETE) ---
        public static void RunSQL(string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, Con))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- 5. HÀM LẤY RA 1 GIÁ TRỊ DUY NHẤT (Rất hữu ích để sinh mã tự động) ---
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            using (SqlCommand cmd = new SqlCommand(sql, Con))
            {
                // ExecuteScalar dùng để lấy một giá trị (dòng 1, cột 1 của Result Set)
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    ma = result.ToString();
                }
            }
            return ma;
        }

        // --- 6. HÀM ĐỔ DỮ LIỆU VÀO COMBOBOX ---
        public static void FillCombo(string sql, ComboBox cbo, string valueField, string displayField)
        {
            DataTable dt = GetDataToTable(sql);
            cbo.DataSource = dt;
            cbo.ValueMember = valueField;
            cbo.DisplayMember = displayField;
        }
    }
}