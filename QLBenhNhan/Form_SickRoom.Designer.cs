namespace QLBenhNhan
{
    partial class Form_SickRoom
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
            this.pnlSickRoom = new System.Windows.Forms.Panel();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelThongTinPhongBenh = new System.Windows.Forms.Panel();
            this.labNgayNhapVien = new System.Windows.Forms.Label();
            this.txtSoGiuong = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayNhapVien = new System.Windows.Forms.DateTimePicker();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.labSoGiuong = new System.Windows.Forms.Label();
            this.labSoPhong = new System.Windows.Forms.Label();
            this.txtIDBenhNhan = new System.Windows.Forms.TextBox();
            this.txtIDPhongBenh = new System.Windows.Forms.TextBox();
            this.labIDBenhNhan = new System.Windows.Forms.Label();
            this.labIDPhongBenh = new System.Windows.Forms.Label();
            this.DgViewPhongBenh = new System.Windows.Forms.DataGridView();
            this.labDanhSachPhongBenh = new System.Windows.Forms.Label();
            this.labQuanLyPhongBenh = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labNgayRaVien = new System.Windows.Forms.Label();
            this.dateTimePickerNgayRaVien = new System.Windows.Forms.DateTimePicker();
            this.pnlSickRoom.SuspendLayout();
            this.panelNhomNut.SuspendLayout();
            this.panelThongTinPhongBenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewPhongBenh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSickRoom
            // 
            this.pnlSickRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSickRoom.BackColor = System.Drawing.Color.SeaShell;
            this.pnlSickRoom.Controls.Add(this.panelNhomNut);
            this.pnlSickRoom.Controls.Add(this.panelThongTinPhongBenh);
            this.pnlSickRoom.Controls.Add(this.DgViewPhongBenh);
            this.pnlSickRoom.Controls.Add(this.labDanhSachPhongBenh);
            this.pnlSickRoom.Controls.Add(this.labQuanLyPhongBenh);
            this.pnlSickRoom.Location = new System.Drawing.Point(2, 3);
            this.pnlSickRoom.Name = "pnlSickRoom";
            this.pnlSickRoom.Size = new System.Drawing.Size(1152, 605);
            this.pnlSickRoom.TabIndex = 2;
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
            this.panelNhomNut.Location = new System.Drawing.Point(869, 97);
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
            // panelThongTinPhongBenh
            // 
            this.panelThongTinPhongBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThongTinPhongBenh.BackColor = System.Drawing.Color.SeaShell;
            this.panelThongTinPhongBenh.Controls.Add(this.dateTimePickerNgayRaVien);
            this.panelThongTinPhongBenh.Controls.Add(this.labNgayRaVien);
            this.panelThongTinPhongBenh.Controls.Add(this.labNgayNhapVien);
            this.panelThongTinPhongBenh.Controls.Add(this.txtSoGiuong);
            this.panelThongTinPhongBenh.Controls.Add(this.dateTimePickerNgayNhapVien);
            this.panelThongTinPhongBenh.Controls.Add(this.txtSoPhong);
            this.panelThongTinPhongBenh.Controls.Add(this.labSoGiuong);
            this.panelThongTinPhongBenh.Controls.Add(this.labSoPhong);
            this.panelThongTinPhongBenh.Controls.Add(this.txtIDBenhNhan);
            this.panelThongTinPhongBenh.Controls.Add(this.txtIDPhongBenh);
            this.panelThongTinPhongBenh.Controls.Add(this.labIDBenhNhan);
            this.panelThongTinPhongBenh.Controls.Add(this.labIDPhongBenh);
            this.panelThongTinPhongBenh.Location = new System.Drawing.Point(29, 97);
            this.panelThongTinPhongBenh.Name = "panelThongTinPhongBenh";
            this.panelThongTinPhongBenh.Size = new System.Drawing.Size(794, 221);
            this.panelThongTinPhongBenh.TabIndex = 36;
            // 
            // labNgayNhapVien
            // 
            this.labNgayNhapVien.AutoSize = true;
            this.labNgayNhapVien.Location = new System.Drawing.Point(13, 107);
            this.labNgayNhapVien.Name = "labNgayNhapVien";
            this.labNgayNhapVien.Size = new System.Drawing.Size(177, 27);
            this.labNgayNhapVien.TabIndex = 7;
            this.labNgayNhapVien.Text = "Ngày Nhập Viện:";
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.Location = new System.Drawing.Point(516, 58);
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.Size = new System.Drawing.Size(227, 35);
            this.txtSoGiuong.TabIndex = 14;
            // 
            // dateTimePickerNgayNhapVien
            // 
            this.dateTimePickerNgayNhapVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayNhapVien.Location = new System.Drawing.Point(196, 100);
            this.dateTimePickerNgayNhapVien.Name = "dateTimePickerNgayNhapVien";
            this.dateTimePickerNgayNhapVien.Size = new System.Drawing.Size(141, 35);
            this.dateTimePickerNgayNhapVien.TabIndex = 15;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(516, 14);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(227, 35);
            this.txtSoPhong.TabIndex = 13;
            // 
            // labSoGiuong
            // 
            this.labSoGiuong.AutoSize = true;
            this.labSoGiuong.Location = new System.Drawing.Point(404, 62);
            this.labSoGiuong.Name = "labSoGiuong";
            this.labSoGiuong.Size = new System.Drawing.Size(120, 27);
            this.labSoGiuong.TabIndex = 5;
            this.labSoGiuong.Text = "Số Giường:";
            // 
            // labSoPhong
            // 
            this.labSoPhong.AutoSize = true;
            this.labSoPhong.Location = new System.Drawing.Point(404, 18);
            this.labSoPhong.Name = "labSoPhong";
            this.labSoPhong.Size = new System.Drawing.Size(109, 27);
            this.labSoPhong.TabIndex = 4;
            this.labSoPhong.Text = "Số Phòng:";
            // 
            // txtIDBenhNhan
            // 
            this.txtIDBenhNhan.Location = new System.Drawing.Point(118, 58);
            this.txtIDBenhNhan.Name = "txtIDBenhNhan";
            this.txtIDBenhNhan.Size = new System.Drawing.Size(227, 35);
            this.txtIDBenhNhan.TabIndex = 10;
            // 
            // txtIDPhongBenh
            // 
            this.txtIDPhongBenh.Location = new System.Drawing.Point(118, 14);
            this.txtIDPhongBenh.Name = "txtIDPhongBenh";
            this.txtIDPhongBenh.Size = new System.Drawing.Size(227, 35);
            this.txtIDPhongBenh.TabIndex = 9;
            // 
            // labIDBenhNhan
            // 
            this.labIDBenhNhan.AutoSize = true;
            this.labIDBenhNhan.Location = new System.Drawing.Point(13, 62);
            this.labIDBenhNhan.Name = "labIDBenhNhan";
            this.labIDBenhNhan.Size = new System.Drawing.Size(153, 27);
            this.labIDBenhNhan.TabIndex = 2;
            this.labIDBenhNhan.Text = "ID Bệnh nhân:";
            // 
            // labIDPhongBenh
            // 
            this.labIDPhongBenh.AutoSize = true;
            this.labIDPhongBenh.Location = new System.Drawing.Point(13, 18);
            this.labIDPhongBenh.Name = "labIDPhongBenh";
            this.labIDPhongBenh.Size = new System.Drawing.Size(163, 27);
            this.labIDPhongBenh.TabIndex = 1;
            this.labIDPhongBenh.Text = "ID Phòng bệnh:";
            // 
            // DgViewPhongBenh
            // 
            this.DgViewPhongBenh.AllowUserToOrderColumns = true;
            this.DgViewPhongBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewPhongBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewPhongBenh.BackgroundColor = System.Drawing.Color.White;
            this.DgViewPhongBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewPhongBenh.Location = new System.Drawing.Point(20, 405);
            this.DgViewPhongBenh.Name = "DgViewPhongBenh";
            this.DgViewPhongBenh.RowHeadersVisible = false;
            this.DgViewPhongBenh.RowHeadersWidth = 62;
            this.DgViewPhongBenh.RowTemplate.Height = 28;
            this.DgViewPhongBenh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewPhongBenh.Size = new System.Drawing.Size(1113, 222);
            this.DgViewPhongBenh.TabIndex = 35;
            // 
            // labDanhSachPhongBenh
            // 
            this.labDanhSachPhongBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachPhongBenh.AutoSize = true;
            this.labDanhSachPhongBenh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachPhongBenh.Location = new System.Drawing.Point(20, 377);
            this.labDanhSachPhongBenh.Name = "labDanhSachPhongBenh";
            this.labDanhSachPhongBenh.Size = new System.Drawing.Size(260, 26);
            this.labDanhSachPhongBenh.TabIndex = 34;
            this.labDanhSachPhongBenh.Text = "Danh Sách Phòng Bệnh:";
            // 
            // labQuanLyPhongBenh
            // 
            this.labQuanLyPhongBenh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labQuanLyPhongBenh.AutoSize = true;
            this.labQuanLyPhongBenh.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyPhongBenh.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyPhongBenh.Location = new System.Drawing.Point(408, 51);
            this.labQuanLyPhongBenh.Name = "labQuanLyPhongBenh";
            this.labQuanLyPhongBenh.Size = new System.Drawing.Size(485, 45);
            this.labQuanLyPhongBenh.TabIndex = 33;
            this.labQuanLyPhongBenh.Text = "QUẢN LÝ PHÒNG BỆNH";
            this.labQuanLyPhongBenh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labNgayRaVien
            // 
            this.labNgayRaVien.AutoSize = true;
            this.labNgayRaVien.Location = new System.Drawing.Point(404, 106);
            this.labNgayRaVien.Name = "labNgayRaVien";
            this.labNgayRaVien.Size = new System.Drawing.Size(152, 27);
            this.labNgayRaVien.TabIndex = 20;
            this.labNgayRaVien.Text = "Ngày Ra Viện:";
            // 
            // dateTimePickerNgayRaVien
            // 
            this.dateTimePickerNgayRaVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayRaVien.Location = new System.Drawing.Point(602, 99);
            this.dateTimePickerNgayRaVien.Name = "dateTimePickerNgayRaVien";
            this.dateTimePickerNgayRaVien.Size = new System.Drawing.Size(141, 35);
            this.dateTimePickerNgayRaVien.TabIndex = 21;
            // 
            // Form_SickRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSickRoom);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_SickRoom";
            this.Text = "QUẢN LÝ PHÒNG BỆNH";
            this.pnlSickRoom.ResumeLayout(false);
            this.pnlSickRoom.PerformLayout();
            this.panelNhomNut.ResumeLayout(false);
            this.panelThongTinPhongBenh.ResumeLayout(false);
            this.panelThongTinPhongBenh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewPhongBenh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSickRoom;
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelThongTinPhongBenh;
        private System.Windows.Forms.Label labNgayNhapVien;
        private System.Windows.Forms.TextBox txtSoGiuong;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhapVien;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label labSoGiuong;
        private System.Windows.Forms.Label labSoPhong;
        private System.Windows.Forms.TextBox txtIDBenhNhan;
        private System.Windows.Forms.TextBox txtIDPhongBenh;
        private System.Windows.Forms.Label labIDBenhNhan;
        private System.Windows.Forms.Label labIDPhongBenh;
        private System.Windows.Forms.DataGridView DgViewPhongBenh;
        private System.Windows.Forms.Label labDanhSachPhongBenh;
        private System.Windows.Forms.Label labQuanLyPhongBenh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayRaVien;
        private System.Windows.Forms.Label labNgayRaVien;
    }
}