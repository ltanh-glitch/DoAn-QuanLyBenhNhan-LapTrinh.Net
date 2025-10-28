namespace QLBenhNhan
{
    partial class Form_Doctor
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.txtChuyenKhoa = new System.Windows.Forms.TextBox();
            this.labSĐT = new System.Windows.Forms.Label();
            this.labChuyenKhoa = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtIDBacSi = new System.Windows.Forms.TextBox();
            this.labTrinhDo = new System.Windows.Forms.Label();
            this.labHoTen = new System.Windows.Forms.Label();
            this.labIDBacSi = new System.Windows.Forms.Label();
            this.panelThongTinBacSi = new System.Windows.Forms.Panel();
            this.DgViewBacSi = new System.Windows.Forms.DataGridView();
            this.labDanhSachBacSi = new System.Windows.Forms.Label();
            this.labQuanLyBacSi = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlDoctor = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelNhomNut.SuspendLayout();
            this.panelThongTinBacSi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBacSi)).BeginInit();
            this.pnlDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(148, 136);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 39);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Location = new System.Drawing.Point(148, 77);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 39);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Location = new System.Drawing.Point(148, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 39);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(3, 136);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 39);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(3, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 39);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNhomNut.BackColor = System.Drawing.Color.SeaShell;
            this.panelNhomNut.Controls.Add(this.btnThoat);
            this.panelNhomNut.Controls.Add(this.btnHuy);
            this.panelNhomNut.Controls.Add(this.btnLuu);
            this.panelNhomNut.Controls.Add(this.btnXoa);
            this.panelNhomNut.Controls.Add(this.btnSua);
            this.panelNhomNut.Controls.Add(this.btnThem);
            this.panelNhomNut.Location = new System.Drawing.Point(870, 99);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 186);
            this.panelNhomNut.TabIndex = 37;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Location = new System.Drawing.Point(3, 77);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 39);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 35);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 27);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(516, 58);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(227, 35);
            this.txtSĐT.TabIndex = 14;
            // 
            // txtChuyenKhoa
            // 
            this.txtChuyenKhoa.Location = new System.Drawing.Point(516, 14);
            this.txtChuyenKhoa.Name = "txtChuyenKhoa";
            this.txtChuyenKhoa.Size = new System.Drawing.Size(227, 35);
            this.txtChuyenKhoa.TabIndex = 13;
            // 
            // labSĐT
            // 
            this.labSĐT.AutoSize = true;
            this.labSĐT.Location = new System.Drawing.Point(404, 62);
            this.labSĐT.Name = "labSĐT";
            this.labSĐT.Size = new System.Drawing.Size(60, 27);
            this.labSĐT.TabIndex = 5;
            this.labSĐT.Text = "SĐT:";
            // 
            // labChuyenKhoa
            // 
            this.labChuyenKhoa.AutoSize = true;
            this.labChuyenKhoa.Location = new System.Drawing.Point(404, 18);
            this.labChuyenKhoa.Name = "labChuyenKhoa";
            this.labChuyenKhoa.Size = new System.Drawing.Size(151, 27);
            this.labChuyenKhoa.TabIndex = 4;
            this.labChuyenKhoa.Text = "Chuyên Khoa:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(118, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(227, 35);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtIDBacSi
            // 
            this.txtIDBacSi.Location = new System.Drawing.Point(118, 14);
            this.txtIDBacSi.Name = "txtIDBacSi";
            this.txtIDBacSi.Size = new System.Drawing.Size(227, 35);
            this.txtIDBacSi.TabIndex = 9;
            // 
            // labTrinhDo
            // 
            this.labTrinhDo.AutoSize = true;
            this.labTrinhDo.Location = new System.Drawing.Point(404, 108);
            this.labTrinhDo.Name = "labTrinhDo";
            this.labTrinhDo.Size = new System.Drawing.Size(104, 27);
            this.labTrinhDo.TabIndex = 6;
            this.labTrinhDo.Text = "Trình Độ:";
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Location = new System.Drawing.Point(13, 62);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(125, 27);
            this.labHoTen.TabIndex = 2;
            this.labHoTen.Text = "Họ và  Tên:";
            // 
            // labIDBacSi
            // 
            this.labIDBacSi.AutoSize = true;
            this.labIDBacSi.Location = new System.Drawing.Point(13, 18);
            this.labIDBacSi.Name = "labIDBacSi";
            this.labIDBacSi.Size = new System.Drawing.Size(108, 27);
            this.labIDBacSi.TabIndex = 1;
            this.labIDBacSi.Text = "ID Bác sĩ:";
            // 
            // panelThongTinBacSi
            // 
            this.panelThongTinBacSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThongTinBacSi.BackColor = System.Drawing.Color.SeaShell;
            this.panelThongTinBacSi.Controls.Add(this.comboBox1);
            this.panelThongTinBacSi.Controls.Add(this.txtEmail);
            this.panelThongTinBacSi.Controls.Add(this.lblEmail);
            this.panelThongTinBacSi.Controls.Add(this.txtSĐT);
            this.panelThongTinBacSi.Controls.Add(this.txtChuyenKhoa);
            this.panelThongTinBacSi.Controls.Add(this.labSĐT);
            this.panelThongTinBacSi.Controls.Add(this.labChuyenKhoa);
            this.panelThongTinBacSi.Controls.Add(this.txtHoTen);
            this.panelThongTinBacSi.Controls.Add(this.txtIDBacSi);
            this.panelThongTinBacSi.Controls.Add(this.labTrinhDo);
            this.panelThongTinBacSi.Controls.Add(this.labHoTen);
            this.panelThongTinBacSi.Controls.Add(this.labIDBacSi);
            this.panelThongTinBacSi.Location = new System.Drawing.Point(30, 99);
            this.panelThongTinBacSi.Name = "panelThongTinBacSi";
            this.panelThongTinBacSi.Size = new System.Drawing.Size(794, 221);
            this.panelThongTinBacSi.TabIndex = 36;
            // 
            // DgViewBacSi
            // 
            this.DgViewBacSi.AllowUserToOrderColumns = true;
            this.DgViewBacSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewBacSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewBacSi.BackgroundColor = System.Drawing.Color.White;
            this.DgViewBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewBacSi.Location = new System.Drawing.Point(21, 407);
            this.DgViewBacSi.Name = "DgViewBacSi";
            this.DgViewBacSi.RowHeadersVisible = false;
            this.DgViewBacSi.RowHeadersWidth = 62;
            this.DgViewBacSi.RowTemplate.Height = 28;
            this.DgViewBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewBacSi.Size = new System.Drawing.Size(1113, 222);
            this.DgViewBacSi.TabIndex = 35;
            // 
            // labDanhSachBacSi
            // 
            this.labDanhSachBacSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachBacSi.AutoSize = true;
            this.labDanhSachBacSi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachBacSi.Location = new System.Drawing.Point(21, 379);
            this.labDanhSachBacSi.Name = "labDanhSachBacSi";
            this.labDanhSachBacSi.Size = new System.Drawing.Size(201, 26);
            this.labDanhSachBacSi.TabIndex = 34;
            this.labDanhSachBacSi.Text = "Danh Sách Bác Sĩ:";
            // 
            // labQuanLyBacSi
            // 
            this.labQuanLyBacSi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labQuanLyBacSi.AutoSize = true;
            this.labQuanLyBacSi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyBacSi.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyBacSi.Location = new System.Drawing.Point(409, 51);
            this.labQuanLyBacSi.Name = "labQuanLyBacSi";
            this.labQuanLyBacSi.Size = new System.Drawing.Size(347, 45);
            this.labQuanLyBacSi.TabIndex = 33;
            this.labQuanLyBacSi.Text = "QUẢN LÝ BÁC SĨ";
            this.labQuanLyBacSi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDoctor
            // 
            this.pnlDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDoctor.BackColor = System.Drawing.Color.SeaShell;
            this.pnlDoctor.Controls.Add(this.panelNhomNut);
            this.pnlDoctor.Controls.Add(this.panelThongTinBacSi);
            this.pnlDoctor.Controls.Add(this.DgViewBacSi);
            this.pnlDoctor.Controls.Add(this.labDanhSachBacSi);
            this.pnlDoctor.Controls.Add(this.labQuanLyBacSi);
            this.pnlDoctor.Location = new System.Drawing.Point(1, 1);
            this.pnlDoctor.Name = "pnlDoctor";
            this.pnlDoctor.Size = new System.Drawing.Size(1155, 608);
            this.pnlDoctor.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bs Đa Khoa",
            "Bs Chuyên Khoa I",
            "Bs Chuyên Khoa II",
            "Bs Chuyên Khoa III",
            "Ths y học",
            "Ts y học",
            "Giáo sư",
            "Phó giáo sư"});
            this.comboBox1.Location = new System.Drawing.Point(515, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 35);
            this.comboBox1.TabIndex = 20;
            // 
            // Form_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.pnlDoctor);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Doctor";
            this.Text = "Quản lý bác sĩ";
            this.panelNhomNut.ResumeLayout(false);
            this.panelThongTinBacSi.ResumeLayout(false);
            this.panelThongTinBacSi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBacSi)).EndInit();
            this.pnlDoctor.ResumeLayout(false);
            this.pnlDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.TextBox txtChuyenKhoa;
        private System.Windows.Forms.Label labSĐT;
        private System.Windows.Forms.Label labChuyenKhoa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtIDBacSi;
        private System.Windows.Forms.Label labTrinhDo;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label labIDBacSi;
        private System.Windows.Forms.Panel panelThongTinBacSi;
        private System.Windows.Forms.DataGridView DgViewBacSi;
        private System.Windows.Forms.Label labDanhSachBacSi;
        private System.Windows.Forms.Label labQuanLyBacSi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlDoctor;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}