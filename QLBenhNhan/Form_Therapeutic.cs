using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBenhNhan
{
    public partial class Form_Therapeutic : Form
    {
        SqlConnection conn;
        SqlDataAdapter daDieuTri;
        SqlDataAdapter daHoSo;
        SqlDataAdapter daBenhNhan;
        SqlDataAdapter daBacSi;
        DataSet ds = new DataSet();

        private bool isAdding = false;
        private bool Editing = false; // Biến này chưa dùng, có thể dùng cho nút Sửa

        public Form_Therapeutic()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Gắn sự kiện SelectionChanged
            DgViewDieuTri.SelectionChanged += DgViewDieuTri_SelectionChanged;
        }

        private void Form_Therapeutic_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Kết nối CSDL
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
                conn = new SqlConnection(connStr);

                // 2. Load bảng Hồ sơ bệnh án
                daHoSo = new SqlDataAdapter("SELECT * FROM HoSoBenhAn", conn);
                daHoSo.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daHoSo.Fill(ds, "tblDSHoSoBenhAn");
                ds.Tables["tblDSHoSoBenhAn"].PrimaryKey = new DataColumn[] { ds.Tables["tblDSHoSoBenhAn"].Columns["HoSoID"] };

                // 3. Load bảng Bệnh nhân
                daBenhNhan = new SqlDataAdapter("SELECT * FROM BenhNhan", conn);
                daBenhNhan.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daBenhNhan.Fill(ds, "tblDSBenhNhan");
                ds.Tables["tblDSBenhNhan"].PrimaryKey = new DataColumn[] { ds.Tables["tblDSBenhNhan"].Columns["BenhNhanID"] };

                // 4. Load bảng Bác sĩ
                daBacSi = new SqlDataAdapter("SELECT * FROM BacSi", conn);
                daBacSi.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daBacSi.Fill(ds, "tblDSBacSi");

                // === SỬA LỖI (TYPO) ===
                // Tên bảng phải là "tblDSBacSi" (chữ S hoa) như đã Fill ở trên
                ds.Tables["tblDSBacSi"].PrimaryKey = new DataColumn[] { ds.Tables["tblDSBacSi"].Columns["BacSiID"] };

                // 5. Load bảng Điều trị (có join để lấy tên bác sĩ + tên bệnh nhân + chuẩn đoán)
                string sQueryDieuTri = @"
                    SELECT dt.DieuTriID, dt.HoSoID, dt.BacSiID,
                           bs.HoTen AS TenBacSi,
                           bn.HoTen AS TenBenhNhan,
                           hs.ChuanDoan AS ChuanDoan,
                           dt.NgayDieuTri, dt.PhuongPhap, dt.Thuoc, dt.ChiPhi, dt.KetQua
                    FROM DieuTri dt
                    LEFT JOIN BacSi bs ON dt.BacSiID = bs.BacSiID
                    LEFT JOIN HoSoBenhAn hs ON dt.HoSoID = hs.HoSoID
                    LEFT JOIN BenhNhan bn ON hs.BenhNhanID = bn.BenhNhanID";

                daDieuTri = new SqlDataAdapter(sQueryDieuTri, conn);
                daDieuTri.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daDieuTri.Fill(ds, "tblDieuTri");
                ds.Tables["tblDieuTri"].PrimaryKey = new DataColumn[] { ds.Tables["tblDieuTri"].Columns["DieuTriID"] };

                // 6. Gán DataGridView
                DgViewDieuTri.DataSource = ds.Tables["tblDieuTri"];

                // 7. Hiển thị tên cột
                DgViewDieuTri.Columns["TenBacSi"].HeaderText = "Tên Bác Sĩ";
                DgViewDieuTri.Columns["TenBenhNhan"].HeaderText = "Tên Bệnh Nhân";
                DgViewDieuTri.Columns["ChuanDoan"].HeaderText = "Chuẩn Đoán";

                // 8. Disable TextBox lúc load
                txtIDDieuTri.Enabled = false;
                txtIDHoSo.Enabled = false;
                txtIDBacSi.Enabled = false;
                dateTimePickerNgayDieuTri.Enabled = false;
                txtPhuongPhap.Enabled = false;
                txtThuoc.Enabled = false;
                txtChiPhi.Enabled = false;
                txtKQ.Enabled = false;

                // Disable nút Lưu, Hủy
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                // Chọn dòng đầu tiên
                if (DgViewDieuTri.Rows.Count > 0)
                    DgViewDieuTri.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi load dữ liệu điều trị: " + ex.Message);
            }
        }

        // Sự kiện SelectionChanged
        private void DgViewDieuTri_SelectionChanged(object sender, EventArgs e)
        {
            if (DgViewDieuTri.SelectedRows.Count > 0 && !isAdding) // Thêm !isAdding để không load khi đang thêm mới
            {
                DataGridViewRow row = DgViewDieuTri.SelectedRows[0];

                // === SỬA LỖI (TÊN CỘT) ===
                // Tên cột phải khớp với tên trong câu SELECT (ví dụ: "DieuTriID")
                txtIDDieuTri.Text = row.Cells["colDieuTriID"].Value?.ToString();
                txtIDHoSo.Text = row.Cells["colHoSoID"].Value?.ToString();
                txtIDBacSi.Text = row.Cells["colBacSiID"].Value?.ToString();

                // Thêm kiểm tra DBNull.Value
                if (row.Cells["colNgayDieuTri"].Value != DBNull.Value && row.Cells["colNgayDieuTri"].Value != null)
                    dateTimePickerNgayDieuTri.Value = Convert.ToDateTime(row.Cells["colNgayDieuTri"].Value);
                else
                    dateTimePickerNgayDieuTri.Value = DateTime.Now; // Giá trị mặc định

                txtPhuongPhap.Text = row.Cells["colPhuongPhap"].Value?.ToString();
                txtThuoc.Text = row.Cells["colThuoc"].Value?.ToString();
                txtChiPhi.Text = row.Cells["colChiPhi"].Value?.ToString();
                txtKQ.Text = row.Cells["colKetQua"].Value?.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // === Lấy các bảng từ DataSet với tên chính xác ===
            DataTable tblDieuTri = ds.Tables["tblDieuTri"];
            DataTable tblDSHoSoBenhAn = ds.Tables["tblDSHoSoBenhAn"];
            DataTable tblDSBacSi = ds.Tables["tblDSBacSi"];
            DataTable tblDSBenhNhan = ds.Tables["tblDSBenhNhan"];   // Cần bảng này để lấy Tên Bệnh Nhân

            if (!isAdding)
            {
                // ================= BẮT ĐẦU THÊM MỚI =================
                isAdding = true;
                btnThem.Text = "Xác nhận";

                // === Enable nhập liệu ===
                txtIDDieuTri.Enabled = true;
                txtIDHoSo.Enabled = true;
                txtIDBacSi.Enabled = true;
                dateTimePickerNgayDieuTri.Enabled = true;
                txtPhuongPhap.Enabled = true;
                txtThuoc.Enabled = true;
                txtChiPhi.Enabled = true;
                txtKQ.Enabled = true;

                // Button điều khiển
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                // === Xóa trắng nội dung ===
                txtIDDieuTri.Clear();
                txtIDHoSo.Clear();
                txtIDBacSi.Clear();
                dateTimePickerNgayDieuTri.Value = DateTime.Now;
                txtPhuongPhap.Clear();
                txtThuoc.Clear();
                txtChiPhi.Clear();
                txtKQ.Clear();

                // Focus vào ô đầu tiên
                txtIDDieuTri.Focus();
            }
            else
            {
                // ================= KIỂM TRA DỮ LIỆU =================

                // --- Kiểm tra các trường bắt buộc ---
                if (string.IsNullOrWhiteSpace(txtIDDieuTri.Text))
                {
                    MessageBox.Show("Vui lòng nhập ID điều trị!", "Thông báo");
                    txtIDDieuTri.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtIDHoSo.Text))
                {
                    MessageBox.Show("Vui lòng nhập ID hồ sơ!", "Thông báo");
                    txtIDHoSo.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtIDBacSi.Text))
                {
                    MessageBox.Show("Vui lòng nhập ID bác sĩ!", "Thông báo");
                    txtIDBacSi.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPhuongPhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập phương pháp điều trị!", "Thông báo");
                    txtPhuongPhap.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtThuoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập thuốc!", "Thông báo");
                    txtThuoc.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtChiPhi.Text))
                {
                    MessageBox.Show("Vui lòng nhập chi phí!", "Thông báo");
                    txtChiPhi.Focus();
                    return;
                }

                // --- Kiểm tra logic/kiểu dữ liệu ---

                // 1. Kiểm tra chi phí (phải là số và >= 0)
                decimal chiPhi;
                if (!decimal.TryParse(txtChiPhi.Text, out chiPhi) || chiPhi < 0)
                {
                    MessageBox.Show("Chi phí phải là một số hợp lệ và không được âm!", "Lỗi chi phí", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChiPhi.Focus();
                    return;
                }

                // 2. Kiểm tra ngày điều trị (không được lớn hơn ngày hiện tại)
                if (dateTimePickerNgayDieuTri.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày điều trị không được lớn hơn ngày hiện tại!", "Lỗi ngày điều trị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePickerNgayDieuTri.Focus();
                    return;
                }

                // --- Kiểm tra ràng buộc khóa ---

                // 1. Kiểm tra trùng ID Điều Trị (Khóa chính)
                if (tblDieuTri.Rows.Find(txtIDDieuTri.Text) != null)
                {
                    MessageBox.Show("Mã điều trị đã tồn tại!", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDDieuTri.Focus();
                    return;
                }

                // 2. Kiểm tra ID Hồ Sơ tồn tại (Khóa ngoại)
                if (tblDSHoSoBenhAn.Rows.Find(txtIDHoSo.Text) == null)
                {
                    MessageBox.Show("Mã hồ sơ bệnh án không tồn tại!", "Lỗi mã hồ sơ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDHoSo.Focus();
                    return;
                }

                // 3. Kiểm tra ID Bác Sĩ tồn tại (Khóa ngoại)
                if (tblDSBacSi.Rows.Find(txtIDBacSi.Text) == null)
                {
                    MessageBox.Show("Mã bác sĩ không tồn tại!", "Lỗi mã bác sĩ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDBacSi.Focus();
                    return;
                }

                // ================= THÊM ĐIỀU TRỊ =================
                DataRow newRow = tblDieuTri.NewRow();

                // Gán các cột từ Textbox
                newRow["DieuTriID"] = txtIDDieuTri.Text;
                newRow["HoSoID"] = txtIDHoSo.Text;
                newRow["BacSiID"] = txtIDBacSi.Text;
                newRow["NgayDieuTri"] = dateTimePickerNgayDieuTri.Value.Date;
                newRow["PhuongPhap"] = txtPhuongPhap.Text;
                newRow["Thuoc"] = txtThuoc.Text;
                newRow["ChiPhi"] = chiPhi; // Sử dụng biến decimal đã parse

                // Xử lý trường KetQua (có thể NULL)
                if (string.IsNullOrWhiteSpace(txtKQ.Text))
                {
                    newRow["KetQua"] = DBNull.Value;
                }
                else
                {
                    newRow["KetQua"] = txtKQ.Text;
                }

                // === SỬA LỖI (LOGIC) ===
                // Tự động điền các cột JOIN (TenBacSi, TenBenhNhan, ChuanDoan)
                // để hàng mới hiển thị đầy đủ trên DataGridView

                // 1. Lấy Tên Bác Sĩ
                DataRow[] bacSiRow = tblDSBacSi.Select($"BacSiID = '{txtIDBacSi.Text}'");
                if (bacSiRow.Length > 0)
                {
                    newRow["TenBacSi"] = bacSiRow[0]["HoTen"];
                }

                // 2. Lấy Tên Bệnh Nhân và Chuẩn Đoán từ Hồ Sơ
                DataRow[] hoSoRow = tblDSHoSoBenhAn.Select($"HoSoID = '{txtIDHoSo.Text}'");
                if (hoSoRow.Length > 0)
                {
                    newRow["ChuanDoan"] = hoSoRow[0]["ChuanDoan"];

                    // Lấy BenhNhanID từ hồ sơ
                    string benhNhanID = hoSoRow[0]["BenhNhanID"].ToString();

                    // Tìm Tên Bệnh Nhân trong bảng Bệnh Nhân
                    DataRow[] benhNhanRow = tblDSBenhNhan.Select($"BenhNhanID = '{benhNhanID}'");
                    if (benhNhanRow.Length > 0)
                    {
                        newRow["TenBenhNhan"] = benhNhanRow[0]["HoTen"];
                    }
                }

                // Thêm hàng mới vào Bảng
                tblDieuTri.Rows.Add(newRow);

                MessageBox.Show("Thêm thông tin điều trị thành công!", "Thông báo");

                // ================= RESET TRẠNG THÁI =================
                isAdding = false;
                btnThem.Text = "Thêm";

                btnLuu.Enabled = true;
                btnHuy.Enabled = false; // Tắt nút Hủy vì đã thêm xong
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                // === Disable nhập liệu ===
                txtIDDieuTri.Enabled = false;
                txtIDHoSo.Enabled = false;
                txtIDBacSi.Enabled = false;
                dateTimePickerNgayDieuTri.Enabled = false;
                txtPhuongPhap.Enabled = false;
                txtThuoc.Enabled = false;
                txtChiPhi.Enabled = false;
                txtKQ.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable tblDieuTri = ds.Tables["tblDieuTri"];

            // Bảng này cần để lấy lại tên bác sĩ, bệnh nhân nếu bạn cho phép sửa FK
            // Nhưng theo code mẫu, chúng ta sẽ khóa FK
            // DataTable tblDSHoSoBenhAn = ds.Tables["tblDSHoSoBenhAn"];
            // DataTable tblDSBacSi = ds.Tables["tblDSBacSi"];
            // DataTable tblDSBenhNhan = ds.Tables["tblDSBenhNhan"];

            if (!Editing)
            {
                // ================= LẦN 1: NHẤN "SỬA" =================
                // Kiểm tra xem đã chọn dòng nào chưa
                if (string.IsNullOrEmpty(txtIDDieuTri.Text) || DgViewDieuTri.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một mục điều trị cần sửa!", "Thông báo");
                    return;
                }

                Editing = true;
                btnSua.Text = "Xác nhận";

                // === Enable các ô được phép sửa ===
                // (Theo logic, không nên sửa khóa chính và khóa ngoại)
                dateTimePickerNgayDieuTri.Enabled = true;
                txtPhuongPhap.Enabled = true;
                txtThuoc.Enabled = true;
                txtChiPhi.Enabled = true;
                txtKQ.Enabled = true; // Tên textbox Kết Quả của bạn

                // === Khóa các ô không được sửa (Khóa chính, Khóa ngoại) ===
                txtIDDieuTri.Enabled = false;
                txtIDHoSo.Enabled = false;
                txtIDBacSi.Enabled = false;

                // === Vô hiệu hóa các nút khác ===
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = true; // Bật nút Hủy

                // Focus vào ô đầu tiên có thể sửa
                dateTimePickerNgayDieuTri.Focus();
            }
            else
            {
                // ================= LẦN 2: NHẤN "XÁC NHẬN" =================

                // --- Kiểm tra dữ liệu (tương tự btnThem) ---
                if (string.IsNullOrWhiteSpace(txtPhuongPhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập phương pháp điều trị!", "Thông báo");
                    txtPhuongPhap.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtThuoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập thuốc!", "Thông báo");
                    txtThuoc.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtChiPhi.Text))
                {
                    MessageBox.Show("Vui lòng nhập chi phí!", "Thông báo");
                    txtChiPhi.Focus();
                    return;
                }

                // --- Kiểm tra logic/kiểu dữ liệu ---
                decimal chiPhi;
                if (!decimal.TryParse(txtChiPhi.Text, out chiPhi) || chiPhi < 0)
                {
                    MessageBox.Show("Chi phí phải là một số hợp lệ và không được âm!", "Lỗi chi phí", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChiPhi.Focus();
                    return;
                }

                if (dateTimePickerNgayDieuTri.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày điều trị không được lớn hơn ngày hiện tại!", "Lỗi ngày điều trị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePickerNgayDieuTri.Focus();
                    return;
                }

                // --- Tìm và cập nhật DataRow ---
                DataRow row = tblDieuTri.Rows.Find(txtIDDieuTri.Text);
                if (row != null)
                {
                    row["NgayDieuTri"] = dateTimePickerNgayDieuTri.Value.Date;
                    row["PhuongPhap"] = txtPhuongPhap.Text;
                    row["Thuoc"] = txtThuoc.Text;
                    row["ChiPhi"] = chiPhi; // Dùng biến decimal đã parse

                    if (string.IsNullOrWhiteSpace(txtKQ.Text))
                    {
                        row["KetQua"] = DBNull.Value;
                    }
                    else
                    {
                        row["KetQua"] = txtKQ.Text;
                    }

                    // Lưu ý: Các cột JOIN (TenBacSi, TenBenhNhan, ChuanDoan) không cần
                    // cập nhật vì chúng ta đã khóa các ID (HoSoID, BacSiID)

                    MessageBox.Show("Cập nhật thông tin điều trị thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mục điều trị cần sửa!", "Lỗi");
                }

                // ================= RESET TRẠNG THÁI =================
                Editing = false;
                btnSua.Text = "Sửa";

                // Khóa lại các ô nhập liệu
                dateTimePickerNgayDieuTri.Enabled = false;
                txtPhuongPhap.Enabled = false;
                txtThuoc.Enabled = false;
                txtChiPhi.Enabled = false;
                txtKQ.Enabled = false;

                // Bật lại các nút
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
                btnHuy.Enabled = false; // Tắt nút Hủy

                // Refresh DataGridView (tùy chọn, vì nó nên tự cập nhật)
                DgViewDieuTri.Refresh();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn mục cần xóa chưa
            if (string.IsNullOrEmpty(txtIDDieuTri.Text) || DgViewDieuTri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin điều trị cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maDieuTri = txtIDDieuTri.Text;

            // 2. Hỏi người dùng xác nhận xóa
            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn xóa thông tin điều trị có mã '{maDieuTri}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                try
                {
                    DataTable tblDieuTri = ds.Tables["tblDieuTri"];

                    // 3. Tìm dòng cần xóa trong DataSet
                    // (Khóa chính đã được đặt trong Form_Load, không cần đặt lại ở đây)
                    DataRow row = tblDieuTri.Rows.Find(maDieuTri);

                    if (row != null)
                    {
                        // 4. Xóa dòng
                        row.Delete();
                        MessageBox.Show("Đã xóa thông tin điều trị khỏi danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Cho phép lưu thay đổi xuống CSDL
                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true; // Bật Hủy để có thể hoàn tác
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin điều trị cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // 1. Hủy trạng thái Thêm hoặc Sửa
            if (isAdding)
            {
                isAdding = false;
                btnThem.Text = "Thêm";
            }
            else if (Editing) // Sử dụng biến 'Editing' của bạn
            {
                Editing = false;
                btnSua.Text = "Sửa";
            }

            // 2. Reset các TextBox và DateTimePicker
            txtIDDieuTri.Clear();
            txtIDHoSo.Clear();
            txtIDBacSi.Clear();
            txtPhuongPhap.Clear();
            txtThuoc.Clear();
            txtChiPhi.Clear();
            txtKQ.Clear(); // Textbox Kết quả của bạn
            dateTimePickerNgayDieuTri.Value = DateTime.Now;

            // 3. Khóa các TextBox & DateTimePicker
            txtIDDieuTri.Enabled = false;
            txtIDHoSo.Enabled = false;
            txtIDBacSi.Enabled = false;
            dateTimePickerNgayDieuTri.Enabled = false;
            txtPhuongPhap.Enabled = false;
            txtThuoc.Enabled = false;
            txtChiPhi.Enabled = false;
            txtKQ.Enabled = false;

            // 4. Bật lại các nút chính
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            // 5. Khóa nút Lưu và Hủy (vì không còn thao tác)
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            // 6. Làm mới dữ liệu từ database
            // Tải lại bảng 'tblDieuTri' bằng 'daDieuTri' để hủy mọi thay đổi
            try
            {
                ds.Tables["tblDieuTri"].Clear();
                daDieuTri.Fill(ds, "tblDieuTri");

                // Gán lại DataSource (để đảm bảo)
                DgViewDieuTri.DataSource = ds.Tables["tblDieuTri"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 7. Nếu có dữ liệu thì chọn dòng đầu tiên và hiển thị lên textbox
            if (ds.Tables["tblDieuTri"].Rows.Count > 0)
            {
                DgViewDieuTri.Rows[0].Selected = true;
                // Gọi lại sự kiện SelectionChanged để điền dữ liệu (đã bị khóa)
                DgViewDieuTri_SelectionChanged(null, new EventArgs());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 💾 Cập nhật xuống CSDL
                // Sử dụng một SqlDataAdapter MỚI chỉ trỏ đến BẢNG GỐC 'DieuTri'.
                // SqlCommandBuilder sẽ tự động tạo lệnh INSERT, UPDATE, DELETE.
                using (SqlDataAdapter daSave = new SqlDataAdapter("SELECT * FROM DieuTri", conn))
                {
                    SqlCommandBuilder cbSave = new SqlCommandBuilder(daSave);

                    // Lệnh Update sẽ khớp các cột trong 'tblDieuTri' (trong DataSet)
                    // với các cột trong 'DieuTri' (trong CSDL)
                    // và tự động BỎ QUA các cột join (TenBacSi, TenBenhNhan, ChuanDoan)
                    daSave.Update(ds.Tables["tblDieuTri"]);
                }

                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 2. 🔘 Reset trạng thái các nút
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                // 3. 🔄 Tải lại dữ liệu (Quan trọng)
                // Phải tải lại bảng 'tblDieuTri' bằng adapter 'daDieuTri' (adapter có JOIN)
                // để đảm bảo DataGridView hiển thị đúng dữ liệu mới nhất.
                ds.Tables["tblDieuTri"].Clear();
                daDieuTri.Fill(ds, "tblDieuTri");

                // Gán lại DataSource (để đảm bảo)
                DgViewDieuTri.DataSource = ds.Tables["tblDieuTri"];

                // Chọn lại dòng đầu tiên nếu có
                if (ds.Tables["tblDieuTri"].Rows.Count > 0)
                {
                    DgViewDieuTri.Rows[0].Selected = true;
                    DgViewDieuTri_SelectionChanged(null, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Nếu lưu thất bại, nên gọi Hủy để tải lại dữ liệu gốc từ DB
                // btnHuy_Click(null, new EventArgs());
            }
        }
        private void LoadDieuTri()
        {
            try
            {
                // Xóa bảng 'tblDieuTri' hiện tại trong DataSet
                ds.Tables["tblDieuTri"].Clear();

                // Dùng adapter 'daDieuTri' (đã có từ Form_Load) để điền lại
                daDieuTri.Fill(ds, "tblDieuTri");

                // Gán lại DataSource (để chắc chắn)
                DgViewDieuTri.DataSource = ds.Tables["tblDieuTri"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách điều trị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Giả sử tên TextBox tìm kiếm của bạn là 'txtTim'
            if (txtTim.Text.Trim() == "")
            {
                // Nếu không nhập gì -> Load lại toàn bộ
                LoadDieuTri(); // Gọi hàm helper để load lại
                return;
            }

            try
            {
                // Lấy chuỗi kết nối (bạn đã có conn ở class level, nhưng dùng 'using' an toàn hơn)
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Câu query này PHẢI GIỐNG HỆT câu query trong Form_Load
                    // chỉ thêm mệnh đề WHERE
                    string query = @"
                SELECT dt.DieuTriID, dt.HoSoID, dt.BacSiID,
                       bs.HoTen AS TenBacSi,
                       bn.HoTen AS TenBenhNhan,
                       hs.ChuanDoan AS ChuanDoan,
                       dt.NgayDieuTri, dt.PhuongPhap, dt.Thuoc, dt.ChiPhi, dt.KetQua
                FROM DieuTri dt
                LEFT JOIN BacSi bs ON dt.BacSiID = bs.BacSiID
                LEFT JOIN HoSoBenhAn hs ON dt.HoSoID = hs.HoSoID
                LEFT JOIN BenhNhan bn ON hs.BenhNhanID = bn.BenhNhanID
                WHERE 
                    bn.HoTen LIKE @TuKhoa OR      
                    bs.HoTen LIKE @TuKhoa OR      
                    hs.ChuanDoan LIKE @TuKhoa OR  
                    dt.DieuTriID LIKE @TuKhoa OR 
                    dt.HoSoID LIKE @TuKhoa"; /*Tìm theo ID Hồ Sơ*/
        
            SqlDataAdapter daTim = new SqlDataAdapter(query, conn);
                    daTim.SelectCommand.Parameters.AddWithValue("@TuKhoa", "%" + txtTim.Text.Trim() + "%");

                    // Xóa và điền vào bảng 'tblDieuTri' trong DataSet
                    ds.Tables["tblDieuTri"].Clear();
                    daTim.Fill(ds, "tblDieuTri");

                    // Gán lại nguồn cho DataGridView
                    DgViewDieuTri.DataSource = ds.Tables["tblDieuTri"];

                    if (ds.Tables["tblDieuTri"].Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin điều trị phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}