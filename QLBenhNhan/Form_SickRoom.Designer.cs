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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SickRoom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.DgViewPhongBenh = new System.Windows.Forms.DataGridView();
            this.colPhongBenhID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBenhNhanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiuongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhapVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayXuatVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labDanhSachPhongBenh = new System.Windows.Forms.Label();
            this.labQuanLyPhongBenh = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBoxDieuTri = new System.Windows.Forms.GroupBox();
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
            this.panelNhomNut.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewPhongBenh)).BeginInit();
            this.groupBoxDieuTri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNhomNut.Controls.Add(this.groupBox1);
            this.panelNhomNut.Location = new System.Drawing.Point(850, 106);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(268, 217);
            this.panelNhomNut.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng:";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(141, 159);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 49);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = " &Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(141, 96);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 49);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = " &Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(32, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = " &Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(141, 34);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 49);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = " &Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(32, 97);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = " &Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(32, 159);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 49);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = " &Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // DgViewPhongBenh
            // 
            this.DgViewPhongBenh.AllowUserToOrderColumns = true;
            this.DgViewPhongBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewPhongBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewPhongBenh.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgViewPhongBenh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgViewPhongBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewPhongBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhongBenhID,
            this.colBenhNhanID,
            this.colPhongSo,
            this.colGiuongSo,
            this.colNgayNhapVien,
            this.colNgayXuatVien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgViewPhongBenh.DefaultCellStyle = dataGridViewCellStyle2;
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
            // labDanhSachPhongBenh
            // 
            this.labDanhSachPhongBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachPhongBenh.AutoSize = true;
            this.labDanhSachPhongBenh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachPhongBenh.Location = new System.Drawing.Point(8, 394);
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
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Location = new System.Drawing.Point(673, 352);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(345, 22);
            this.txtTim.TabIndex = 48;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Green;
            this.btnTim.Location = new System.Drawing.Point(1041, 352);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 27);
            this.btnTim.TabIndex = 47;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBoxDieuTri
            // 
            this.groupBoxDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDieuTri.Controls.Add(this.dateTimePickerNgayRaVien);
            this.groupBoxDieuTri.Controls.Add(this.labNgayRaVien);
            this.groupBoxDieuTri.Controls.Add(this.labNgayNhapVien);
            this.groupBoxDieuTri.Controls.Add(this.txtSoGiuong);
            this.groupBoxDieuTri.Controls.Add(this.dateTimePickerNgayNhapVien);
            this.groupBoxDieuTri.Controls.Add(this.txtSoPhong);
            this.groupBoxDieuTri.Controls.Add(this.labSoGiuong);
            this.groupBoxDieuTri.Controls.Add(this.labSoPhong);
            this.groupBoxDieuTri.Controls.Add(this.txtIDBenhNhan);
            this.groupBoxDieuTri.Controls.Add(this.txtIDPhongBenh);
            this.groupBoxDieuTri.Controls.Add(this.labIDBenhNhan);
            this.groupBoxDieuTri.Controls.Add(this.labIDPhongBenh);
            this.groupBoxDieuTri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxDieuTri.Location = new System.Drawing.Point(12, 102);
            this.groupBoxDieuTri.Name = "groupBoxDieuTri";
            this.groupBoxDieuTri.Size = new System.Drawing.Size(818, 221);
            this.groupBoxDieuTri.TabIndex = 44;
            this.groupBoxDieuTri.TabStop = false;
            this.groupBoxDieuTri.Text = "Thông tin:";
            // 
            // dateTimePickerNgayRaVien
            // 
            this.dateTimePickerNgayRaVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayRaVien.Location = new System.Drawing.Point(561, 152);
            this.dateTimePickerNgayRaVien.Name = "dateTimePickerNgayRaVien";
            this.dateTimePickerNgayRaVien.Size = new System.Drawing.Size(213, 34);
            this.dateTimePickerNgayRaVien.TabIndex = 33;
            // 
            // labNgayRaVien
            // 
            this.labNgayRaVien.AutoSize = true;
            this.labNgayRaVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labNgayRaVien.Location = new System.Drawing.Point(435, 151);
            this.labNgayRaVien.Name = "labNgayRaVien";
            this.labNgayRaVien.Size = new System.Drawing.Size(125, 22);
            this.labNgayRaVien.TabIndex = 32;
            this.labNgayRaVien.Text = "Ngày Ra Viện:";
            // 
            // labNgayNhapVien
            // 
            this.labNgayNhapVien.AutoSize = true;
            this.labNgayNhapVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labNgayNhapVien.Location = new System.Drawing.Point(44, 151);
            this.labNgayNhapVien.Name = "labNgayNhapVien";
            this.labNgayNhapVien.Size = new System.Drawing.Size(145, 22);
            this.labNgayNhapVien.TabIndex = 26;
            this.labNgayNhapVien.Text = "Ngày Nhập Viện:";
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.Location = new System.Drawing.Point(547, 93);
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.Size = new System.Drawing.Size(227, 34);
            this.txtSoGiuong.TabIndex = 30;
            // 
            // dateTimePickerNgayNhapVien
            // 
            this.dateTimePickerNgayNhapVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayNhapVien.Location = new System.Drawing.Point(195, 152);
            this.dateTimePickerNgayNhapVien.Name = "dateTimePickerNgayNhapVien";
            this.dateTimePickerNgayNhapVien.Size = new System.Drawing.Size(213, 34);
            this.dateTimePickerNgayNhapVien.TabIndex = 31;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(547, 34);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(227, 34);
            this.txtSoPhong.TabIndex = 29;
            // 
            // labSoGiuong
            // 
            this.labSoGiuong.AutoSize = true;
            this.labSoGiuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labSoGiuong.Location = new System.Drawing.Point(435, 97);
            this.labSoGiuong.Name = "labSoGiuong";
            this.labSoGiuong.Size = new System.Drawing.Size(102, 22);
            this.labSoGiuong.TabIndex = 25;
            this.labSoGiuong.Text = "Số Giường:";
            // 
            // labSoPhong
            // 
            this.labSoPhong.AutoSize = true;
            this.labSoPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labSoPhong.Location = new System.Drawing.Point(435, 38);
            this.labSoPhong.Name = "labSoPhong";
            this.labSoPhong.Size = new System.Drawing.Size(90, 22);
            this.labSoPhong.TabIndex = 24;
            this.labSoPhong.Text = "Số Phòng:";
            // 
            // txtIDBenhNhan
            // 
            this.txtIDBenhNhan.Location = new System.Drawing.Point(181, 93);
            this.txtIDBenhNhan.Name = "txtIDBenhNhan";
            this.txtIDBenhNhan.Size = new System.Drawing.Size(227, 34);
            this.txtIDBenhNhan.TabIndex = 28;
            // 
            // txtIDPhongBenh
            // 
            this.txtIDPhongBenh.Location = new System.Drawing.Point(181, 34);
            this.txtIDPhongBenh.Name = "txtIDPhongBenh";
            this.txtIDPhongBenh.Size = new System.Drawing.Size(227, 34);
            this.txtIDPhongBenh.TabIndex = 27;
            // 
            // labIDBenhNhan
            // 
            this.labIDBenhNhan.AutoSize = true;
            this.labIDBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labIDBenhNhan.Location = new System.Drawing.Point(44, 97);
            this.labIDBenhNhan.Name = "labIDBenhNhan";
            this.labIDBenhNhan.Size = new System.Drawing.Size(122, 22);
            this.labIDBenhNhan.TabIndex = 23;
            this.labIDBenhNhan.Text = "ID Bệnh nhân:";
            // 
            // labIDPhongBenh
            // 
            this.labIDPhongBenh.AutoSize = true;
            this.labIDPhongBenh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labIDPhongBenh.Location = new System.Drawing.Point(44, 38);
            this.labIDPhongBenh.Name = "labIDPhongBenh";
            this.labIDPhongBenh.Size = new System.Drawing.Size(131, 22);
            this.labIDPhongBenh.TabIndex = 22;
            this.labIDPhongBenh.Text = "ID Phòng bệnh:";
            // 
            // Form_SickRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1146, 676);
            this.Controls.Add(this.groupBoxDieuTri);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.panelNhomNut);
            this.Controls.Add(this.DgViewPhongBenh);
            this.Controls.Add(this.labDanhSachPhongBenh);
            this.Controls.Add(this.labQuanLyPhongBenh);
            this.Name = "Form_SickRoom";
            this.Text = "Quản Lý Phòng Bệnh";
            this.Load += new System.EventHandler(this.Form_SickRoom_Load);
            this.panelNhomNut.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewPhongBenh)).EndInit();
            this.groupBoxDieuTri.ResumeLayout(false);
            this.groupBoxDieuTri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelNhomNut;
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
        private System.Windows.Forms.GroupBox groupBoxDieuTri;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}