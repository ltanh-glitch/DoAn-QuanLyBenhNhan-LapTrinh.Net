using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBenhNhan
{
    public partial class Form_Patient : Form
    {
        public Form_Patient()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form_Patient_Load(object sender, EventArgs e)
        {
            /* khu bảng bệnh nhân */
            DataTable dtBenhNhan = new DataTable();
            // thêm cột
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("ID");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Giới Tính");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Số Điện Thoại");
            dt.Columns.Add("Tên Thân Nhân");
            dt.Columns.Add("SĐT Thân Nhân");

            DgViewBenhNhan.DataSource = dt;


            // Tự động điều chỉnh độ rộng cột để phù hợp với nội dung
            DgViewBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in DgViewBenhNhan.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DgViewBenhNhan.Columns["STT"].Width = 50;
            // Căn giữa nội dung trong các ô
            DgViewBenhNhan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // tắt thêm cột tự động của DgView
            DgViewBenhNhan.RowHeadersVisible = false;
            // tắt cột tiêu đề dòng
            DgViewBenhNhan.RowHeadersVisible = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại để trở về form chính
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Hủy bỏ các Thông tin đã nhập (textbook)
            this.txtID.Clear();
            this.txtHoTen.Clear();
            this.txtCCCD.Clear();
            this.txtSĐT.Clear();
            this.txtTenThanNhan.Clear();
            this.txtSĐTThanNhan.Clear();
            if (radNam.Checked)
            {
                radNam.Checked = false;
            }
            if (radNu.Checked)
            {
                radNu.Checked = false;
            }
            this.dateTimePickerNgaySinh.Value = DateTime.Now;
            this.txtID.Focus();

        }
    }
}
