using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel; // Gói dùng để xuất Excel

namespace QLBenhNhan
{
    public partial class Form_BaoCao : Form
    {
        private SqlConnection conn;

        public Form_BaoCao()
        {
            InitializeComponent();
            SetupUI();
            LoadThongKeTongQuat();
            LoadLoaiBaoCao();
        }

        // ==========================
        // ⚙️ CẤU HÌNH GIAO DIỆN
        // ==========================
        private void SetupUI()
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

            // Style DataGridView
            dgvBaoCao.EnableHeadersVisualStyles = false;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBaoCao.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Chart mặc định
            chartBaoCao.Titles.Clear();
            chartBaoCao.Titles.Add("BIỂU ĐỒ THỐNG KÊ");
            chartBaoCao.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartBaoCao.ChartAreas[0].BackColor = Color.WhiteSmoke;
        }

        // ==========================
        // 📊 THỐNG KÊ TỔNG QUÁT
        // ==========================
        private void LoadThongKeTongQuat()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
                conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        (SELECT COUNT(*) FROM BenhNhan) AS SoBenhNhan,
                        (SELECT COUNT(*) FROM BacSi) AS SoBacSi,
                        (SELECT COUNT(*) FROM HoSoBenhAn) AS SoHoSo,
                        ISNULL(SUM(d.ChiPhi), 0) AS TongChiPhi
                    FROM DieuTri d", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblTongBenhNhan.Text = $"Bệnh nhân: {reader["SoBenhNhan"]}";
                    lblTongBacSi.Text = $"Bác sĩ: {reader["SoBacSi"]}";
                    lblTongHoSo.Text = $"Hồ sơ bệnh án: {reader["SoHoSo"]}";
                    lblTongChiPhi.Text = $"Tổng chi phí: {Convert.ToDecimal(reader["TongChiPhi"]).ToString("N0")} VNĐ";
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê tổng: " + ex.Message);
            }
        }

        // ==========================
        // 🧩 DANH SÁCH LOẠI BÁO CÁO
        // ==========================
        private void LoadLoaiBaoCao()
        {
            cbLoaiBaoCao.Items.Clear();
            cbLoaiBaoCao.Items.Add("Chi phí điều trị theo bác sĩ");
            cbLoaiBaoCao.Items.Add("Chi phí điều trị theo tháng");
            cbLoaiBaoCao.Items.Add("Số bệnh nhân theo chuyên khoa");
            cbLoaiBaoCao.Items.Add("Tổng chi phí theo bệnh nhân");
            cbLoaiBaoCao.SelectedIndex = 0;
        }

        // ==========================
        // 📈 XỬ LÝ XEM BÁO CÁO
        // ==========================
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (cbLoaiBaoCao.SelectedIndex == -1) return;

            string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
            conn = new SqlConnection(connStr);

            string query = "";
            string seriesName = "";

            // 1️⃣ Chi phí điều trị theo bác sĩ
            if (cbLoaiBaoCao.SelectedIndex == 0)
            {
                query = @"SELECT b.HoTen AS BacSi, SUM(d.ChiPhi) AS TongChiPhi
                          FROM DieuTri d
                          JOIN BacSi b ON d.BacSiID = b.BacSiID
                          GROUP BY b.HoTen
                          ORDER BY TongChiPhi DESC";
                seriesName = "Chi phí theo bác sĩ";
            }

            // 2️⃣ Chi phí điều trị theo tháng
            else if (cbLoaiBaoCao.SelectedIndex == 1)
            {
                query = @"SELECT MONTH(d.NgayDieuTri) AS Thang, SUM(d.ChiPhi) AS TongChiPhi
                          FROM DieuTri d
                          GROUP BY MONTH(d.NgayDieuTri)
                          ORDER BY Thang";
                seriesName = "Chi phí điều trị theo tháng";
            }

            // 3️⃣ Số bệnh nhân theo chuyên khoa
            else if (cbLoaiBaoCao.SelectedIndex == 2)
            {
                query = @"SELECT ck.TenChuyenKhoa AS ChuyenKhoa, COUNT(DISTINCT hs.BenhNhanID) AS SoBenhNhan
                          FROM DieuTri d
                          JOIN BacSi b ON d.BacSiID = b.BacSiID
                          JOIN ChuyenKhoa ck ON b.ChuyenKhoaID = ck.ChuyenKhoaID
                          JOIN HoSoBenhAn hs ON d.HoSoID = hs.HoSoID
                          GROUP BY ck.TenChuyenKhoa
                          ORDER BY SoBenhNhan DESC";
                seriesName = "Số bệnh nhân theo chuyên khoa";
            }

            // 4️⃣ Tổng chi phí theo bệnh nhân
            else if (cbLoaiBaoCao.SelectedIndex == 3)
            {
                query = @"SELECT bn.HoTen AS BenhNhan, SUM(d.ChiPhi) AS TongChiPhi
                          FROM DieuTri d
                          JOIN HoSoBenhAn hs ON d.HoSoID = hs.HoSoID
                          JOIN BenhNhan bn ON hs.BenhNhanID = bn.BenhNhanID
                          GROUP BY bn.HoTen
                          ORDER BY TongChiPhi DESC";
                seriesName = "Tổng chi phí theo bệnh nhân";
            }

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBaoCao.DataSource = dt;

                // Cấu hình biểu đồ
                chartBaoCao.Series.Clear();
                var series = new Series(seriesName)
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                chartBaoCao.Series.Add(series);
                chartBaoCao.DataSource = dt;

                // Thiết lập trục X/Y tự động theo loại báo cáo
                if (cbLoaiBaoCao.SelectedIndex == 0)
                {
                    series.XValueMember = "BacSi";
                    series.YValueMembers = "TongChiPhi";
                }
                else if (cbLoaiBaoCao.SelectedIndex == 1)
                {
                    series.XValueMember = "Thang";
                    series.YValueMembers = "TongChiPhi";
                }
                else if (cbLoaiBaoCao.SelectedIndex == 2)
                {
                    series.XValueMember = "ChuyenKhoa";
                    series.YValueMembers = "SoBenhNhan";
                }
                else if (cbLoaiBaoCao.SelectedIndex == 3)
                {
                    series.XValueMember = "BenhNhan";
                    series.YValueMembers = "TongChiPhi";
                }

                chartBaoCao.ChartAreas[0].AxisX.Title = cbLoaiBaoCao.SelectedItem.ToString();
                chartBaoCao.ChartAreas[0].AxisY.Title = "Giá trị";
                chartBaoCao.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem báo cáo: " + ex.Message);
            }
        }

        // ==========================
        // 📤 XUẤT EXCEL
        // ==========================
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "Excel file (*.xlsx)|*.xlsx",
                Title = "Chọn nơi lưu file báo cáo"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("BaoCao");

                        // Ghi tiêu đề cột
                        for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                            ws.Cell(1, i + 1).Value = dgvBaoCao.Columns[i].HeaderText;

                        // Ghi dữ liệu
                        for (int i = 0; i < dgvBaoCao.Rows.Count; i++)
                            for (int j = 0; j < dgvBaoCao.Columns.Count; j++)
                                ws.Cell(i + 2, j + 1).Value = dgvBaoCao.Rows[i].Cells[j].Value?.ToString();

                        ws.Columns().AdjustToContents();
                        wb.SaveAs(save.FileName);
                    }

                    MessageBox.Show("Xuất Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message);
                }
            }
        }

        // ==========================
        // 🔙 NÚT QUAY LẠI
        // ==========================
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
