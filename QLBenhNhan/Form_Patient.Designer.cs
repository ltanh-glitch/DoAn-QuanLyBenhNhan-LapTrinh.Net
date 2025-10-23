namespace QLBenhNhan
{
    partial class Form_Patient
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
            this.labQuanLyBenhNhan = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.labHoTen = new System.Windows.Forms.Label();
            this.labGioiTinh = new System.Windows.Forms.Label();
            this.labSĐT = new System.Windows.Forms.Label();
            this.labCCCD = new System.Windows.Forms.Label();
            this.labTenThanNhan = new System.Windows.Forms.Label();
            this.labNgaySinh = new System.Windows.Forms.Label();
            this.labSĐTThanNhan = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSĐTThanNhan = new System.Windows.Forms.TextBox();
            this.txtTenThanNhan = new System.Windows.Forms.TextBox();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.labDanhSachBenhNhan = new System.Windows.Forms.Label();
            this.DgViewBenhNhan = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelThongTinBenhNhan = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBenhNhan)).BeginInit();
            this.panelThongTinBenhNhan.SuspendLayout();
            this.panelNhomNut.SuspendLayout();
            this.SuspendLayout();
            // 
            // labQuanLyBenhNhan
            // 
            this.labQuanLyBenhNhan.AutoSize = true;
            this.labQuanLyBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuanLyBenhNhan.Location = new System.Drawing.Point(348, 30);
            this.labQuanLyBenhNhan.Name = "labQuanLyBenhNhan";
            this.labQuanLyBenhNhan.Size = new System.Drawing.Size(277, 26);
            this.labQuanLyBenhNhan.TabIndex = 0;
            this.labQuanLyBenhNhan.Text = "QUẢN LÝ BỆNH NHÂN ";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(13, 8);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(36, 22);
            this.labID.TabIndex = 1;
            this.labID.Text = "ID:";
            this.labID.Click += new System.EventHandler(this.labID_Click);
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Location = new System.Drawing.Point(13, 44);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(104, 22);
            this.labHoTen.TabIndex = 2;
            this.labHoTen.Text = "Họ và  Tên:";
            this.labHoTen.Click += new System.EventHandler(this.labHoTen_Click);
            // 
            // labGioiTinh
            // 
            this.labGioiTinh.AutoSize = true;
            this.labGioiTinh.Location = new System.Drawing.Point(13, 85);
            this.labGioiTinh.Name = "labGioiTinh";
            this.labGioiTinh.Size = new System.Drawing.Size(87, 22);
            this.labGioiTinh.TabIndex = 3;
            this.labGioiTinh.Text = "Giới tính:";
            // 
            // labSĐT
            // 
            this.labSĐT.AutoSize = true;
            this.labSĐT.Location = new System.Drawing.Point(366, 8);
            this.labSĐT.Name = "labSĐT";
            this.labSĐT.Size = new System.Drawing.Size(52, 22);
            this.labSĐT.TabIndex = 4;
            this.labSĐT.Text = "SĐT:";
            // 
            // labCCCD
            // 
            this.labCCCD.AutoSize = true;
            this.labCCCD.Location = new System.Drawing.Point(366, 44);
            this.labCCCD.Name = "labCCCD";
            this.labCCCD.Size = new System.Drawing.Size(69, 22);
            this.labCCCD.TabIndex = 5;
            this.labCCCD.Text = "CCCD:";
            // 
            // labTenThanNhan
            // 
            this.labTenThanNhan.AutoSize = true;
            this.labTenThanNhan.Location = new System.Drawing.Point(13, 122);
            this.labTenThanNhan.Name = "labTenThanNhan";
            this.labTenThanNhan.Size = new System.Drawing.Size(124, 22);
            this.labTenThanNhan.TabIndex = 6;
            this.labTenThanNhan.Text = "Tên thân nhân:";
            // 
            // labNgaySinh
            // 
            this.labNgaySinh.AutoSize = true;
            this.labNgaySinh.Location = new System.Drawing.Point(366, 85);
            this.labNgaySinh.Name = "labNgaySinh";
            this.labNgaySinh.Size = new System.Drawing.Size(94, 22);
            this.labNgaySinh.TabIndex = 7;
            this.labNgaySinh.Text = "Ngày sinh:";
            // 
            // labSĐTThanNhan
            // 
            this.labSĐTThanNhan.AutoSize = true;
            this.labSĐTThanNhan.Location = new System.Drawing.Point(366, 122);
            this.labSĐTThanNhan.Name = "labSĐTThanNhan";
            this.labSĐTThanNhan.Size = new System.Drawing.Size(138, 22);
            this.labSĐTThanNhan.TabIndex = 8;
            this.labSĐTThanNhan.Text = "SĐT Thân nhân:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(55, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(295, 30);
            this.txtID.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(123, 36);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(227, 30);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtSĐTThanNhan
            // 
            this.txtSĐTThanNhan.Location = new System.Drawing.Point(510, 119);
            this.txtSĐTThanNhan.Name = "txtSĐTThanNhan";
            this.txtSĐTThanNhan.Size = new System.Drawing.Size(227, 30);
            this.txtSĐTThanNhan.TabIndex = 11;
            // 
            // txtTenThanNhan
            // 
            this.txtTenThanNhan.Location = new System.Drawing.Point(143, 115);
            this.txtTenThanNhan.Name = "txtTenThanNhan";
            this.txtTenThanNhan.Size = new System.Drawing.Size(207, 30);
            this.txtTenThanNhan.TabIndex = 12;
            // 
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(424, 3);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(313, 30);
            this.txtSĐT.TabIndex = 13;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(441, 41);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(296, 30);
            this.txtCCCD.TabIndex = 14;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(466, 79);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(271, 30);
            this.dateTimePickerNgaySinh.TabIndex = 15;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(143, 81);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(72, 26);
            this.radNam.TabIndex = 16;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(274, 81);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(60, 26);
            this.radNu.TabIndex = 17;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(19, 61);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 30);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(19, 118);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 30);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labDanhSachBenhNhan
            // 
            this.labDanhSachBenhNhan.AutoSize = true;
            this.labDanhSachBenhNhan.Location = new System.Drawing.Point(26, 245);
            this.labDanhSachBenhNhan.Name = "labDanhSachBenhNhan";
            this.labDanhSachBenhNhan.Size = new System.Drawing.Size(174, 22);
            this.labDanhSachBenhNhan.TabIndex = 24;
            this.labDanhSachBenhNhan.Text = "Danh sách bệnh nhân";
            // 
            // DgViewBenhNhan
            // 
            this.DgViewBenhNhan.AllowUserToOrderColumns = true;
            this.DgViewBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewBenhNhan.Location = new System.Drawing.Point(30, 271);
            this.DgViewBenhNhan.Name = "DgViewBenhNhan";
            this.DgViewBenhNhan.RowHeadersVisible = false;
            this.DgViewBenhNhan.RowHeadersWidth = 62;
            this.DgViewBenhNhan.RowTemplate.Height = 28;
            this.DgViewBenhNhan.Size = new System.Drawing.Size(973, 222);
            this.DgViewBenhNhan.TabIndex = 25;
            this.DgViewBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgViewBenhNhan_CellClick);
            this.DgViewBenhNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgViewBenhNhan_CellContentClick);
            // 
            // panelThongTinBenhNhan
            // 
            this.panelThongTinBenhNhan.Controls.Add(this.txtSĐTThanNhan);
            this.panelThongTinBenhNhan.Controls.Add(this.labNgaySinh);
            this.panelThongTinBenhNhan.Controls.Add(this.txtCCCD);
            this.panelThongTinBenhNhan.Controls.Add(this.dateTimePickerNgaySinh);
            this.panelThongTinBenhNhan.Controls.Add(this.txtSĐT);
            this.panelThongTinBenhNhan.Controls.Add(this.labCCCD);
            this.panelThongTinBenhNhan.Controls.Add(this.labSĐTThanNhan);
            this.panelThongTinBenhNhan.Controls.Add(this.labSĐT);
            this.panelThongTinBenhNhan.Controls.Add(this.txtTenThanNhan);
            this.panelThongTinBenhNhan.Controls.Add(this.txtHoTen);
            this.panelThongTinBenhNhan.Controls.Add(this.txtID);
            this.panelThongTinBenhNhan.Controls.Add(this.labTenThanNhan);
            this.panelThongTinBenhNhan.Controls.Add(this.labGioiTinh);
            this.panelThongTinBenhNhan.Controls.Add(this.labHoTen);
            this.panelThongTinBenhNhan.Controls.Add(this.labID);
            this.panelThongTinBenhNhan.Controls.Add(this.radNam);
            this.panelThongTinBenhNhan.Controls.Add(this.radNu);
            this.panelThongTinBenhNhan.Location = new System.Drawing.Point(30, 74);
            this.panelThongTinBenhNhan.Name = "panelThongTinBenhNhan";
            this.panelThongTinBenhNhan.Size = new System.Drawing.Size(740, 168);
            this.panelThongTinBenhNhan.TabIndex = 27;
            this.panelThongTinBenhNhan.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGioiTinh_Paint);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(19, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 30);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(121, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 30);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(121, 61);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 30);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(121, 118);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 30);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Controls.Add(this.btnThoat);
            this.panelNhomNut.Controls.Add(this.btnHuy);
            this.panelNhomNut.Controls.Add(this.btnLuu);
            this.panelNhomNut.Controls.Add(this.btnXoa);
            this.panelNhomNut.Controls.Add(this.btnSua);
            this.panelNhomNut.Controls.Add(this.btnThem);
            this.panelNhomNut.Location = new System.Drawing.Point(787, 74);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(216, 168);
            this.panelNhomNut.TabIndex = 32;
            // 
            // Form_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 495);
            this.Controls.Add(this.panelNhomNut);
            this.Controls.Add(this.panelThongTinBenhNhan);
            this.Controls.Add(this.DgViewBenhNhan);
            this.Controls.Add(this.labDanhSachBenhNhan);
            this.Controls.Add(this.labQuanLyBenhNhan);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Patient";
            this.Text = "Form_Patient";
            this.Load += new System.EventHandler(this.Form_Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBenhNhan)).EndInit();
            this.panelThongTinBenhNhan.ResumeLayout(false);
            this.panelThongTinBenhNhan.PerformLayout();
            this.panelNhomNut.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labQuanLyBenhNhan;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label labGioiTinh;
        private System.Windows.Forms.Label labSĐT;
        private System.Windows.Forms.Label labCCCD;
        private System.Windows.Forms.Label labTenThanNhan;
        private System.Windows.Forms.Label labNgaySinh;
        private System.Windows.Forms.Label labSĐTThanNhan;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSĐTThanNhan;
        private System.Windows.Forms.TextBox txtTenThanNhan;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label labDanhSachBenhNhan;
        private System.Windows.Forms.DataGridView DgViewBenhNhan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelThongTinBenhNhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panelNhomNut;
    }
}