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
        }
        
        private void DgViewBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void labID_Click(object sender, EventArgs e)
        {
            
        }

        private void DgViewBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form_Patient_Load(object sender, EventArgs e)
        {
            /* khu bảng bệnh nhân */
            DataTable dtBenhNhan = new DataTable();
            // thêm cột
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("ID");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Tên thân nhân");
            dt.Columns.Add("SĐT thân nhân");

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


            /* khu thông tin bệnh */
            // giúp  bảng không lệch và giãn đều khi thay đổi kích thước cửa sổ
            DgViewBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgViewBenhNhan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // giãn panel thông tin bệnh nhân và nhóm nút theo chiều ngang khi thay đổi kích thước cửa sổ
            panelThongTinBenhNhan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNhomNut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            btnThem.Size = new Size(80, 40); // 80 rộng, 40 cao
            btnSua.Size = new Size(80, 40);
            btnXoa.Size = new Size(80, 40);
            btnThoat.Size = new Size(80, 40); 
            btnHuy.Size = new Size(80, 40);
            btnLuu.Size = new Size(80, 40); 
            
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labHoTen_Click(object sender, EventArgs e)
        {

        }

        private void panelGioiTinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelNhomNut1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtID.Text = "";
            this.txtHoTen.Text = "";
            this.txtCCCD.Text = "";
            this.txtSĐT.Text = "";
            this.txtTenThanNhan.Text = "";
            
        }
    }
}
