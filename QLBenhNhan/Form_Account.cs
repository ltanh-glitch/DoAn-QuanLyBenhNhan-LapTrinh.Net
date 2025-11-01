using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBenhNhan
{
    public partial class Form_Account : Form
    {
        SqlConnection conn;
        SqlDataAdapter daTaiKhoan;
        SqlCommandBuilder cbTaiKhoan;
        DataSet ds = new DataSet();

        bool isAdding = false;
        bool isEditing = false;

        public Form_Account()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void SetControlsEnabled(bool enabled)
        {
            txtMaTaiKhoan.Enabled = enabled;
            txtTenDangNhap.Enabled = enabled;
            txtMatKhau.Enabled = enabled;
            rdAdmin.Enabled = enabled;
            rdUser.Enabled = enabled;
        }

        private void ClearInputs()
        {
            txtMaTaiKhoan.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            rdAdmin.Checked = false;
            rdUser.Checked = false;
        }

        private void RefreshData()
        {
            ds.Tables["tblDSTaiKhoan"].Clear();
            daTaiKhoan.Fill(ds, "tblDSTaiKhoan");
            dgvTaiKhoan.DataSource = ds.Tables["tblDSTaiKhoan"];
        }

        private void Form_Account_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
                conn = new SqlConnection(connStr);

                string query = "SELECT * FROM TaiKhoan";
                daTaiKhoan = new SqlDataAdapter(query, conn);
                cbTaiKhoan = new SqlCommandBuilder(daTaiKhoan);
                daTaiKhoan.Fill(ds, "tblDSTaiKhoan");

                DataTable tbl = ds.Tables["tblDSTaiKhoan"];
                tbl.PrimaryKey = new DataColumn[] { tbl.Columns["TaiKhoanID"] };

                dgvTaiKhoan.DataSource = tbl;

                // Disable controls ban đầu
                SetControlsEnabled(false);
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi load dữ liệu tài khoản: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable tbl = ds.Tables["tblDSTaiKhoan"];

            if (!isAdding)
            {
                isAdding = true;
                btnThem.Text = "Xác nhận";

                ClearInputs();
                SetControlsEnabled(true);

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtMaTaiKhoan.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã tài khoản!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!");
                    return;
                }
                if (!rdAdmin.Checked && !rdUser.Checked)
                {
                    MessageBox.Show("Vui lòng chọn vai trò!");
                    return;
                }

                if (tbl.Rows.Find(txtMaTaiKhoan.Text) != null)
                {
                    MessageBox.Show("Mã tài khoản đã tồn tại!");
                    return;
                }

                DataRow newRow = tbl.NewRow();
                newRow["TaiKhoanID"] = txtMaTaiKhoan.Text;
                newRow["TenDangNhap"] = txtTenDangNhap.Text;
                newRow["MatKhau"] = txtMatKhau.Text;
                newRow["VaiTro"] = rdAdmin.Checked ? 0 : 1;
                tbl.Rows.Add(newRow);

                MessageBox.Show("✅ Thêm tài khoản thành công!");

                isAdding = false;
                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                SetControlsEnabled(false);
            }
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTaiKhoan.SelectedRows[0];
                txtMaTaiKhoan.Text = row.Cells["colTaiKhoanID"].Value?.ToString();
                txtTenDangNhap.Text = row.Cells["colTenDangNhap"].Value?.ToString();
                txtMatKhau.Text = row.Cells["colMatKhau"].Value?.ToString();

                int vaiTro = row.Cells["colVaiTro"].Value != DBNull.Value
                    ? Convert.ToInt32(row.Cells["colVaiTro"].Value)
                    : 1;
                rdAdmin.Checked = vaiTro == 0;
                rdUser.Checked = vaiTro == 1;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            isEditing = false;
            btnThem.Text = "Thêm";
            btnSua.Text = "Sửa";

            SetControlsEnabled(false);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            RefreshData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlDataAdapter daSave = new SqlDataAdapter("SELECT * FROM TaiKhoan", conn))
                {
                    SqlCommandBuilder cbSave = new SqlCommandBuilder(daSave);
                    daSave.Update(ds.Tables["tblDSTaiKhoan"]);
                }

                MessageBox.Show("💾 Lưu dữ liệu thành công!");
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            var result = MessageBox.Show($"Bạn có chắc muốn xóa tài khoản {txtTenDangNhap.Text}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataTable tbl = ds.Tables["tblDSTaiKhoan"];
                DataRow row = tbl.Rows.Find(txtMaTaiKhoan.Text);
                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("🗑️ Xóa tài khoản thành công!");
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable tbl = ds.Tables["tblDSTaiKhoan"];

            if (!isEditing)
            {
                if (string.IsNullOrEmpty(txtMaTaiKhoan.Text))
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần sửa!");
                    return;
                }

                isEditing = true;
                btnSua.Text = "Xác nhận";

                SetControlsEnabled(true);
                txtMaTaiKhoan.Enabled = false;

                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
            else
            {
                DataRow row = tbl.Rows.Find(txtMaTaiKhoan.Text);
                if (row != null)
                {
                    row["TenDangNhap"] = txtTenDangNhap.Text;
                    row["MatKhau"] = txtMatKhau.Text;
                    row["VaiTro"] = rdAdmin.Checked ? 0 : 1;
                    MessageBox.Show("🟢 Cập nhật tài khoản thành công!");
                }

                isEditing = false;
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                SetControlsEnabled(false);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                RefreshData();
                return;
            }

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT * FROM TaiKhoan 
                           WHERE TaiKhoanID LIKE @kw OR TenDangNhap LIKE @kw";

                    SqlDataAdapter daSearch = new SqlDataAdapter(sql, conn);
                    daSearch.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    DataTable result = new DataTable();
                    daSearch.Fill(result);

                    dgvTaiKhoan.DataSource = result;

                    if (result.Rows.Count == 0)
                    {
                        MessageBox.Show("❌ Không tìm thấy tài khoản nào phù hợp!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();
        }
    }
}
