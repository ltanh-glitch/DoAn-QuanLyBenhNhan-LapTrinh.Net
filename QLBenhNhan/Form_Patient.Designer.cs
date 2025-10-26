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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labQuanLyBenhNhan = new System.Windows.Forms.Label();
            this.labDanhSachBenhNhan = new System.Windows.Forms.Label();
            this.DgViewBenhNhan = new System.Windows.Forms.DataGridView();
            this.panelThongTinBenhNhan = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSĐTThanNhan = new System.Windows.Forms.TextBox();
            this.labNgaySinh = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.labCCCD = new System.Windows.Forms.Label();
            this.labSĐTThanNhan = new System.Windows.Forms.Label();
            this.labSĐT = new System.Windows.Forms.Label();
            this.txtTenThanNhan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labTenThanNhan = new System.Windows.Forms.Label();
            this.labGioiTinh = new System.Windows.Forms.Label();
            this.labHoTen = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlPatient = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBenhNhan)).BeginInit();
            this.panelThongTinBenhNhan.SuspendLayout();
            this.panelNhomNut.SuspendLayout();
            this.pnlPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // labQuanLyBenhNhan
            // 
            this.labQuanLyBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labQuanLyBenhNhan.AutoSize = true;
            this.labQuanLyBenhNhan.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyBenhNhan.Location = new System.Drawing.Point(391, 51);
            this.labQuanLyBenhNhan.Name = "labQuanLyBenhNhan";
            this.labQuanLyBenhNhan.Size = new System.Drawing.Size(382, 37);
            this.labQuanLyBenhNhan.TabIndex = 33;
            this.labQuanLyBenhNhan.Text = "QUẢN LÝ BỆNH NHÂN ";
            this.labQuanLyBenhNhan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labDanhSachBenhNhan
            // 
            this.labDanhSachBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachBenhNhan.AutoSize = true;
            this.labDanhSachBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachBenhNhan.Location = new System.Drawing.Point(3, 402);
            this.labDanhSachBenhNhan.Name = "labDanhSachBenhNhan";
            this.labDanhSachBenhNhan.Size = new System.Drawing.Size(203, 23);
            this.labDanhSachBenhNhan.TabIndex = 34;
            this.labDanhSachBenhNhan.Text = "Danh Sách Bệnh Nhân:";
            // 
            // DgViewBenhNhan
            // 
            this.DgViewBenhNhan.AllowUserToOrderColumns = true;
            this.DgViewBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewBenhNhan.BackgroundColor = System.Drawing.Color.White;
            this.DgViewBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewBenhNhan.Location = new System.Drawing.Point(3, 430);
            this.DgViewBenhNhan.Name = "DgViewBenhNhan";
            this.DgViewBenhNhan.RowHeadersVisible = false;
            this.DgViewBenhNhan.RowHeadersWidth = 62;
            this.DgViewBenhNhan.RowTemplate.Height = 28;
            this.DgViewBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewBenhNhan.Size = new System.Drawing.Size(1113, 222);
            this.DgViewBenhNhan.TabIndex = 35;
            this.DgViewBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgViewBenhNhan_CellClick);
            // 
            // panelThongTinBenhNhan
            // 
            this.panelThongTinBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThongTinBenhNhan.BackColor = System.Drawing.Color.SeaShell;
            this.panelThongTinBenhNhan.Controls.Add(this.txtDiaChi);
            this.panelThongTinBenhNhan.Controls.Add(this.lblDiaChi);
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
            this.panelThongTinBenhNhan.Location = new System.Drawing.Point(12, 122);
            this.panelThongTinBenhNhan.Name = "panelThongTinBenhNhan";
            this.panelThongTinBenhNhan.Size = new System.Drawing.Size(794, 221);
            this.panelThongTinBenhNhan.TabIndex = 36;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(118, 142);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(227, 27);
            this.txtDiaChi.TabIndex = 19;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(13, 145);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(66, 19);
            this.lblDiaChi.TabIndex = 18;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // txtSĐTThanNhan
            // 
            this.txtSĐTThanNhan.Location = new System.Drawing.Point(516, 142);
            this.txtSĐTThanNhan.Name = "txtSĐTThanNhan";
            this.txtSĐTThanNhan.Size = new System.Drawing.Size(227, 27);
            this.txtSĐTThanNhan.TabIndex = 11;
            // 
            // labNgaySinh
            // 
            this.labNgaySinh.AutoSize = true;
            this.labNgaySinh.Location = new System.Drawing.Point(13, 188);
            this.labNgaySinh.Name = "labNgaySinh";
            this.labNgaySinh.Size = new System.Drawing.Size(83, 19);
            this.labNgaySinh.TabIndex = 7;
            this.labNgaySinh.Text = "Ngày Sinh:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(516, 58);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(227, 27);
            this.txtCCCD.TabIndex = 14;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(118, 182);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(141, 27);
            this.dateTimePickerNgaySinh.TabIndex = 15;
            // 
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(516, 14);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(227, 27);
            this.txtSĐT.TabIndex = 13;
            // 
            // labCCCD
            // 
            this.labCCCD.AutoSize = true;
            this.labCCCD.Location = new System.Drawing.Point(404, 62);
            this.labCCCD.Name = "labCCCD";
            this.labCCCD.Size = new System.Drawing.Size(59, 19);
            this.labCCCD.TabIndex = 5;
            this.labCCCD.Text = "CCCD:";
            // 
            // labSĐTThanNhan
            // 
            this.labSĐTThanNhan.AutoSize = true;
            this.labSĐTThanNhan.Location = new System.Drawing.Point(404, 146);
            this.labSĐTThanNhan.Name = "labSĐTThanNhan";
            this.labSĐTThanNhan.Size = new System.Drawing.Size(119, 19);
            this.labSĐTThanNhan.TabIndex = 8;
            this.labSĐTThanNhan.Text = "SĐT Thân Nhân:";
            // 
            // labSĐT
            // 
            this.labSĐT.AutoSize = true;
            this.labSĐT.Location = new System.Drawing.Point(404, 18);
            this.labSĐT.Name = "labSĐT";
            this.labSĐT.Size = new System.Drawing.Size(43, 19);
            this.labSĐT.TabIndex = 4;
            this.labSĐT.Text = "SĐT:";
            // 
            // txtTenThanNhan
            // 
            this.txtTenThanNhan.Location = new System.Drawing.Point(516, 104);
            this.txtTenThanNhan.Name = "txtTenThanNhan";
            this.txtTenThanNhan.Size = new System.Drawing.Size(227, 27);
            this.txtTenThanNhan.TabIndex = 12;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(118, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(227, 27);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 27);
            this.txtID.TabIndex = 9;
            // 
            // labTenThanNhan
            // 
            this.labTenThanNhan.AutoSize = true;
            this.labTenThanNhan.Location = new System.Drawing.Point(404, 108);
            this.labTenThanNhan.Name = "labTenThanNhan";
            this.labTenThanNhan.Size = new System.Drawing.Size(114, 19);
            this.labTenThanNhan.TabIndex = 6;
            this.labTenThanNhan.Text = "Tên Thân Nhân:";
            // 
            // labGioiTinh
            // 
            this.labGioiTinh.AutoSize = true;
            this.labGioiTinh.Location = new System.Drawing.Point(13, 108);
            this.labGioiTinh.Name = "labGioiTinh";
            this.labGioiTinh.Size = new System.Drawing.Size(79, 19);
            this.labGioiTinh.TabIndex = 3;
            this.labGioiTinh.Text = "Giới Tính:";
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Location = new System.Drawing.Point(13, 62);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(86, 19);
            this.labHoTen.TabIndex = 2;
            this.labHoTen.Text = "Họ và  Tên:";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(13, 18);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(31, 19);
            this.labID.TabIndex = 1;
            this.labID.Text = "ID:";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(132, 106);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(62, 23);
            this.radNam.TabIndex = 16;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(259, 106);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(51, 23);
            this.radNu.TabIndex = 17;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
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
            this.panelNhomNut.Location = new System.Drawing.Point(852, 122);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 186);
            this.panelNhomNut.TabIndex = 37;
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
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlPatient
            // 
            this.pnlPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPatient.BackColor = System.Drawing.Color.SeaShell;
            this.pnlPatient.Controls.Add(this.panelNhomNut);
            this.pnlPatient.Controls.Add(this.panelThongTinBenhNhan);
            this.pnlPatient.Controls.Add(this.DgViewBenhNhan);
            this.pnlPatient.Controls.Add(this.labDanhSachBenhNhan);
            this.pnlPatient.Controls.Add(this.labQuanLyBenhNhan);
            this.pnlPatient.Location = new System.Drawing.Point(0, 0);
            this.pnlPatient.Name = "pnlPatient";
            this.pnlPatient.Size = new System.Drawing.Size(1119, 655);
            this.pnlPatient.TabIndex = 0;
            // 
            // Form_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 655);
            this.Controls.Add(this.pnlPatient);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Patient";
            this.Text = "QUẢN LÝ BỆNH NHÂN";
            this.Load += new System.EventHandler(this.Form_Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBenhNhan)).EndInit();
            this.panelThongTinBenhNhan.ResumeLayout(false);
            this.panelThongTinBenhNhan.PerformLayout();
            this.panelNhomNut.ResumeLayout(false);
            this.pnlPatient.ResumeLayout(false);
            this.pnlPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labQuanLyBenhNhan;
        private System.Windows.Forms.Label labDanhSachBenhNhan;
        private System.Windows.Forms.DataGridView DgViewBenhNhan;
        private System.Windows.Forms.Panel panelThongTinBenhNhan;
        private System.Windows.Forms.TextBox txtSĐTThanNhan;
        private System.Windows.Forms.Label labNgaySinh;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.Label labCCCD;
        private System.Windows.Forms.Label labSĐTThanNhan;
        private System.Windows.Forms.Label labSĐT;
        private System.Windows.Forms.TextBox txtTenThanNhan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labTenThanNhan;
        private System.Windows.Forms.Label labGioiTinh;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlPatient;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
    }
}