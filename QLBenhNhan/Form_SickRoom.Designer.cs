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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelThongTinPhongBenh = new System.Windows.Forms.Panel();
            this.dateTimePickerNgayRaVien = new System.Windows.Forms.DateTimePicker();
            this.labNgayRaVien = new System.Windows.Forms.Label();
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
            this.colPhongBenhID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBenhNhanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiuongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhapVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayXuatVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panelNhomNut.SuspendLayout();
            this.panelThongTinPhongBenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewPhongBenh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNhomNut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelNhomNut.Controls.Add(this.btnThoat);
            this.panelNhomNut.Controls.Add(this.btnHuy);
            this.panelNhomNut.Controls.Add(this.btnLuu);
            this.panelNhomNut.Controls.Add(this.btnXoa);
            this.panelNhomNut.Controls.Add(this.btnSua);
            this.panelNhomNut.Controls.Add(this.btnThem);
            this.panelNhomNut.Location = new System.Drawing.Point(866, 114);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 186);
            this.panelNhomNut.TabIndex = 42;
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
            // panelThongTinPhongBenh
            // 
            this.panelThongTinPhongBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThongTinPhongBenh.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.panelThongTinPhongBenh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelThongTinPhongBenh.Location = new System.Drawing.Point(26, 114);
            this.panelThongTinPhongBenh.Name = "panelThongTinPhongBenh";
            this.panelThongTinPhongBenh.Size = new System.Drawing.Size(794, 186);
            this.panelThongTinPhongBenh.TabIndex = 41;
            // 
            // dateTimePickerNgayRaVien
            // 
            this.dateTimePickerNgayRaVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayRaVien.Location = new System.Drawing.Point(530, 136);
            this.dateTimePickerNgayRaVien.Name = "dateTimePickerNgayRaVien";
            this.dateTimePickerNgayRaVien.Size = new System.Drawing.Size(213, 28);
            this.dateTimePickerNgayRaVien.TabIndex = 21;
            // 
            // labNgayRaVien
            // 
            this.labNgayRaVien.AutoSize = true;
            this.labNgayRaVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labNgayRaVien.Location = new System.Drawing.Point(404, 135);
            this.labNgayRaVien.Name = "labNgayRaVien";
            this.labNgayRaVien.Size = new System.Drawing.Size(125, 22);
            this.labNgayRaVien.TabIndex = 20;
            this.labNgayRaVien.Text = "Ngày Ra Viện:";
            // 
            // labNgayNhapVien
            // 
            this.labNgayNhapVien.AutoSize = true;
            this.labNgayNhapVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labNgayNhapVien.Location = new System.Drawing.Point(13, 135);
            this.labNgayNhapVien.Name = "labNgayNhapVien";
            this.labNgayNhapVien.Size = new System.Drawing.Size(145, 22);
            this.labNgayNhapVien.TabIndex = 7;
            this.labNgayNhapVien.Text = "Ngày Nhập Viện:";
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.Location = new System.Drawing.Point(516, 77);
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.Size = new System.Drawing.Size(227, 28);
            this.txtSoGiuong.TabIndex = 14;
            // 
            // dateTimePickerNgayNhapVien
            // 
            this.dateTimePickerNgayNhapVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayNhapVien.Location = new System.Drawing.Point(164, 136);
            this.dateTimePickerNgayNhapVien.Name = "dateTimePickerNgayNhapVien";
            this.dateTimePickerNgayNhapVien.Size = new System.Drawing.Size(213, 28);
            this.dateTimePickerNgayNhapVien.TabIndex = 15;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(516, 18);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(227, 28);
            this.txtSoPhong.TabIndex = 13;
            // 
            // labSoGiuong
            // 
            this.labSoGiuong.AutoSize = true;
            this.labSoGiuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labSoGiuong.Location = new System.Drawing.Point(404, 81);
            this.labSoGiuong.Name = "labSoGiuong";
            this.labSoGiuong.Size = new System.Drawing.Size(102, 22);
            this.labSoGiuong.TabIndex = 5;
            this.labSoGiuong.Text = "Số Giường:";
            // 
            // labSoPhong
            // 
            this.labSoPhong.AutoSize = true;
            this.labSoPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labSoPhong.Location = new System.Drawing.Point(404, 22);
            this.labSoPhong.Name = "labSoPhong";
            this.labSoPhong.Size = new System.Drawing.Size(90, 22);
            this.labSoPhong.TabIndex = 4;
            this.labSoPhong.Text = "Số Phòng:";
            // 
            // txtIDBenhNhan
            // 
            this.txtIDBenhNhan.Location = new System.Drawing.Point(150, 77);
            this.txtIDBenhNhan.Name = "txtIDBenhNhan";
            this.txtIDBenhNhan.Size = new System.Drawing.Size(227, 28);
            this.txtIDBenhNhan.TabIndex = 10;
            // 
            // txtIDPhongBenh
            // 
            this.txtIDPhongBenh.Location = new System.Drawing.Point(150, 18);
            this.txtIDPhongBenh.Name = "txtIDPhongBenh";
            this.txtIDPhongBenh.Size = new System.Drawing.Size(227, 28);
            this.txtIDPhongBenh.TabIndex = 9;
            // 
            // labIDBenhNhan
            // 
            this.labIDBenhNhan.AutoSize = true;
            this.labIDBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labIDBenhNhan.Location = new System.Drawing.Point(13, 81);
            this.labIDBenhNhan.Name = "labIDBenhNhan";
            this.labIDBenhNhan.Size = new System.Drawing.Size(122, 22);
            this.labIDBenhNhan.TabIndex = 2;
            this.labIDBenhNhan.Text = "ID Bệnh nhân:";
            // 
            // labIDPhongBenh
            // 
            this.labIDPhongBenh.AutoSize = true;
            this.labIDPhongBenh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labIDPhongBenh.Location = new System.Drawing.Point(13, 22);
            this.labIDPhongBenh.Name = "labIDPhongBenh";
            this.labIDPhongBenh.Size = new System.Drawing.Size(131, 22);
            this.labIDPhongBenh.TabIndex = 1;
            this.labIDPhongBenh.Text = "ID Phòng bệnh:";
            // 
            // DgViewPhongBenh
            // 
            this.DgViewPhongBenh.AllowUserToOrderColumns = true;
            this.DgViewPhongBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewPhongBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewPhongBenh.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgViewPhongBenh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DgViewPhongBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewPhongBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhongBenhID,
            this.colBenhNhanID,
            this.colPhongSo,
            this.colGiuongSo,
            this.colNgayNhapVien,
            this.colNgayXuatVien});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgViewPhongBenh.DefaultCellStyle = dataGridViewCellStyle12;
            this.DgViewPhongBenh.Location = new System.Drawing.Point(1, 420);
            this.DgViewPhongBenh.Name = "DgViewPhongBenh";
            this.DgViewPhongBenh.RowHeadersVisible = false;
            this.DgViewPhongBenh.RowHeadersWidth = 62;
            this.DgViewPhongBenh.RowTemplate.Height = 28;
            this.DgViewPhongBenh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewPhongBenh.Size = new System.Drawing.Size(1141, 266);
            this.DgViewPhongBenh.TabIndex = 40;
            this.DgViewPhongBenh.SelectionChanged += new System.EventHandler(this.DgViewPhongBenh_SelectionChanged);
            // 
            // labDanhSachPhongBenh
            // 
            this.labDanhSachPhongBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachPhongBenh.AutoSize = true;
            this.labDanhSachPhongBenh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachPhongBenh.Location = new System.Drawing.Point(17, 394);
            this.labDanhSachPhongBenh.Name = "labDanhSachPhongBenh";
            this.labDanhSachPhongBenh.Size = new System.Drawing.Size(211, 23);
            this.labDanhSachPhongBenh.TabIndex = 39;
            this.labDanhSachPhongBenh.Text = "Danh Sách Phòng Bệnh:";
            // 
            // labQuanLyPhongBenh
            // 
            this.labQuanLyPhongBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labQuanLyPhongBenh.AutoSize = true;
            this.labQuanLyPhongBenh.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyPhongBenh.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyPhongBenh.Location = new System.Drawing.Point(374, 32);
            this.labQuanLyPhongBenh.Name = "labQuanLyPhongBenh";
            this.labQuanLyPhongBenh.Size = new System.Drawing.Size(398, 37);
            this.labQuanLyPhongBenh.TabIndex = 38;
            this.labQuanLyPhongBenh.Text = "QUẢN LÝ PHÒNG BỆNH";
            // 
            // colPhongBenhID
            // 
            this.colPhongBenhID.DataPropertyName = "PhongBenhID";
            this.colPhongBenhID.HeaderText = "Mã Phòng Bệnh";
            this.colPhongBenhID.MinimumWidth = 6;
            this.colPhongBenhID.Name = "colPhongBenhID";
            // 
            // colBenhNhanID
            // 
            this.colBenhNhanID.DataPropertyName = "BenhNhanID";
            this.colBenhNhanID.HeaderText = "Mã Bệnh Nhân";
            this.colBenhNhanID.MinimumWidth = 6;
            this.colBenhNhanID.Name = "colBenhNhanID";
            // 
            // colPhongSo
            // 
            this.colPhongSo.DataPropertyName = "PhongSo";
            this.colPhongSo.HeaderText = "Số Phòng";
            this.colPhongSo.MinimumWidth = 6;
            this.colPhongSo.Name = "colPhongSo";
            // 
            // colGiuongSo
            // 
            this.colGiuongSo.DataPropertyName = "GiuongSo";
            this.colGiuongSo.HeaderText = "Số Giường";
            this.colGiuongSo.MinimumWidth = 6;
            this.colGiuongSo.Name = "colGiuongSo";
            // 
            // colNgayNhapVien
            // 
            this.colNgayNhapVien.DataPropertyName = "NgayNhapVien";
            this.colNgayNhapVien.HeaderText = "Ngày Nhập Viện";
            this.colNgayNhapVien.MinimumWidth = 6;
            this.colNgayNhapVien.Name = "colNgayNhapVien";
            // 
            // colNgayXuatVien
            // 
            this.colNgayXuatVien.DataPropertyName = "NgayXuatVien";
            this.colNgayXuatVien.HeaderText = "Ngày Xuất Viện";
            this.colNgayXuatVien.MinimumWidth = 6;
            this.colNgayXuatVien.Name = "colNgayXuatVien";
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Location = new System.Drawing.Point(26, 358);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(345, 22);
            this.txtTim.TabIndex = 48;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Blue;
            this.btnTim.Location = new System.Drawing.Point(394, 358);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 27);
            this.btnTim.TabIndex = 47;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Form_SickRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1146, 676);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.panelNhomNut);
            this.Controls.Add(this.panelThongTinPhongBenh);
            this.Controls.Add(this.DgViewPhongBenh);
            this.Controls.Add(this.labDanhSachPhongBenh);
            this.Controls.Add(this.labQuanLyPhongBenh);
            this.Name = "Form_SickRoom";
            this.Text = "Quản Lý Phòng Bệnh";
            this.Load += new System.EventHandler(this.Form_SickRoom_Load);
            this.panelNhomNut.ResumeLayout(false);
            this.panelThongTinPhongBenh.ResumeLayout(false);
            this.panelThongTinPhongBenh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewPhongBenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelThongTinPhongBenh;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayRaVien;
        private System.Windows.Forms.Label labNgayRaVien;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongBenhID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBenhNhanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiuongSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhapVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayXuatVien;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
    }
}