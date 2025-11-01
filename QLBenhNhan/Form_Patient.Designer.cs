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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Patient));
            this.labQuanLyBenhNhan = new System.Windows.Forms.Label();
            this.labDanhSachBenhNhan = new System.Windows.Forms.Label();
            this.DgViewBenhNhan = new System.Windows.Forms.DataGridView();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pnlPatient = new System.Windows.Forms.Panel();
            this.groupBoxDieuTri = new System.Windows.Forms.GroupBox();
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
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBenhNhan)).BeginInit();
            this.panelNhomNut.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlPatient.SuspendLayout();
            this.groupBoxDieuTri.SuspendLayout();
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
            this.DgViewBenhNhan.SelectionChanged += new System.EventHandler(this.DgViewBenhNhan_SelectionChanged);
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNhomNut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelNhomNut.Controls.Add(this.groupBox1);
            this.panelNhomNut.Location = new System.Drawing.Point(852, 122);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 221);
            this.panelNhomNut.TabIndex = 37;
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
            this.groupBox1.Size = new System.Drawing.Size(255, 221);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng:";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(134, 159);
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
            this.btnHuy.Location = new System.Drawing.Point(134, 96);
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
            this.btnThem.Location = new System.Drawing.Point(25, 34);
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
            this.btnLuu.Location = new System.Drawing.Point(134, 34);
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
            this.btnSua.Location = new System.Drawing.Point(25, 97);
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
            this.btnXoa.Location = new System.Drawing.Point(25, 159);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 49);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = " &Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pnlPatient
            // 
            this.pnlPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPatient.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlPatient.Controls.Add(this.groupBoxDieuTri);
            this.pnlPatient.Controls.Add(this.txtTim);
            this.pnlPatient.Controls.Add(this.btnTim);
            this.pnlPatient.Controls.Add(this.panelNhomNut);
            this.pnlPatient.Controls.Add(this.DgViewBenhNhan);
            this.pnlPatient.Controls.Add(this.labDanhSachBenhNhan);
            this.pnlPatient.Controls.Add(this.labQuanLyBenhNhan);
            this.pnlPatient.Location = new System.Drawing.Point(0, 0);
            this.pnlPatient.Name = "pnlPatient";
            this.pnlPatient.Size = new System.Drawing.Size(1119, 655);
            this.pnlPatient.TabIndex = 0;
            // 
            // groupBoxDieuTri
            // 
            this.groupBoxDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDieuTri.Controls.Add(this.txtDiaChi);
            this.groupBoxDieuTri.Controls.Add(this.lblDiaChi);
            this.groupBoxDieuTri.Controls.Add(this.txtSĐTThanNhan);
            this.groupBoxDieuTri.Controls.Add(this.labNgaySinh);
            this.groupBoxDieuTri.Controls.Add(this.txtCCCD);
            this.groupBoxDieuTri.Controls.Add(this.dateTimePickerNgaySinh);
            this.groupBoxDieuTri.Controls.Add(this.txtSĐT);
            this.groupBoxDieuTri.Controls.Add(this.labCCCD);
            this.groupBoxDieuTri.Controls.Add(this.labSĐTThanNhan);
            this.groupBoxDieuTri.Controls.Add(this.labSĐT);
            this.groupBoxDieuTri.Controls.Add(this.txtTenThanNhan);
            this.groupBoxDieuTri.Controls.Add(this.txtHoTen);
            this.groupBoxDieuTri.Controls.Add(this.txtID);
            this.groupBoxDieuTri.Controls.Add(this.labTenThanNhan);
            this.groupBoxDieuTri.Controls.Add(this.labGioiTinh);
            this.groupBoxDieuTri.Controls.Add(this.labHoTen);
            this.groupBoxDieuTri.Controls.Add(this.labID);
            this.groupBoxDieuTri.Controls.Add(this.radNam);
            this.groupBoxDieuTri.Controls.Add(this.radNu);
            this.groupBoxDieuTri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxDieuTri.Location = new System.Drawing.Point(12, 107);
            this.groupBoxDieuTri.Name = "groupBoxDieuTri";
            this.groupBoxDieuTri.Size = new System.Drawing.Size(818, 251);
            this.groupBoxDieuTri.TabIndex = 46;
            this.groupBoxDieuTri.TabStop = false;
            this.groupBoxDieuTri.Text = "Thông tin:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(148, 169);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(227, 30);
            this.txtDiaChi.TabIndex = 38;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChi.Location = new System.Drawing.Point(43, 172);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(78, 22);
            this.lblDiaChi.TabIndex = 37;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // txtSĐTThanNhan
            // 
            this.txtSĐTThanNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSĐTThanNhan.Location = new System.Drawing.Point(546, 169);
            this.txtSĐTThanNhan.Name = "txtSĐTThanNhan";
            this.txtSĐTThanNhan.Size = new System.Drawing.Size(227, 30);
            this.txtSĐTThanNhan.TabIndex = 30;
            // 
            // labNgaySinh
            // 
            this.labNgaySinh.AutoSize = true;
            this.labNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labNgaySinh.Location = new System.Drawing.Point(43, 215);
            this.labNgaySinh.Name = "labNgaySinh";
            this.labNgaySinh.Size = new System.Drawing.Size(97, 22);
            this.labNgaySinh.TabIndex = 26;
            this.labNgaySinh.Text = "Ngày Sinh:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCCCD.Location = new System.Drawing.Point(546, 85);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(227, 30);
            this.txtCCCD.TabIndex = 33;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(148, 209);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(141, 30);
            this.dateTimePickerNgaySinh.TabIndex = 34;
            // 
            // txtSĐT
            // 
            this.txtSĐT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSĐT.Location = new System.Drawing.Point(546, 41);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(227, 30);
            this.txtSĐT.TabIndex = 32;
            // 
            // labCCCD
            // 
            this.labCCCD.AutoSize = true;
            this.labCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labCCCD.Location = new System.Drawing.Point(434, 89);
            this.labCCCD.Name = "labCCCD";
            this.labCCCD.Size = new System.Drawing.Size(69, 22);
            this.labCCCD.TabIndex = 24;
            this.labCCCD.Text = "CCCD:";
            // 
            // labSĐTThanNhan
            // 
            this.labSĐTThanNhan.AutoSize = true;
            this.labSĐTThanNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labSĐTThanNhan.Location = new System.Drawing.Point(434, 173);
            this.labSĐTThanNhan.Name = "labSĐTThanNhan";
            this.labSĐTThanNhan.Size = new System.Drawing.Size(143, 22);
            this.labSĐTThanNhan.TabIndex = 27;
            this.labSĐTThanNhan.Text = "SĐT Thân Nhân:";
            // 
            // labSĐT
            // 
            this.labSĐT.AutoSize = true;
            this.labSĐT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labSĐT.Location = new System.Drawing.Point(434, 45);
            this.labSĐT.Name = "labSĐT";
            this.labSĐT.Size = new System.Drawing.Size(52, 22);
            this.labSĐT.TabIndex = 23;
            this.labSĐT.Text = "SĐT:";
            // 
            // txtTenThanNhan
            // 
            this.txtTenThanNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenThanNhan.Location = new System.Drawing.Point(546, 131);
            this.txtTenThanNhan.Name = "txtTenThanNhan";
            this.txtTenThanNhan.Size = new System.Drawing.Size(227, 30);
            this.txtTenThanNhan.TabIndex = 31;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.Location = new System.Drawing.Point(148, 85);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(227, 30);
            this.txtHoTen.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Location = new System.Drawing.Point(148, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 30);
            this.txtID.TabIndex = 28;
            // 
            // labTenThanNhan
            // 
            this.labTenThanNhan.AutoSize = true;
            this.labTenThanNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labTenThanNhan.Location = new System.Drawing.Point(434, 135);
            this.labTenThanNhan.Name = "labTenThanNhan";
            this.labTenThanNhan.Size = new System.Drawing.Size(136, 22);
            this.labTenThanNhan.TabIndex = 25;
            this.labTenThanNhan.Text = "Tên Thân Nhân:";
            // 
            // labGioiTinh
            // 
            this.labGioiTinh.AutoSize = true;
            this.labGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labGioiTinh.Location = new System.Drawing.Point(43, 135);
            this.labGioiTinh.Name = "labGioiTinh";
            this.labGioiTinh.Size = new System.Drawing.Size(94, 22);
            this.labGioiTinh.TabIndex = 22;
            this.labGioiTinh.Text = "Giới Tính:";
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labHoTen.Location = new System.Drawing.Point(43, 89);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(104, 22);
            this.labHoTen.TabIndex = 21;
            this.labHoTen.Text = "Họ và  Tên:";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labID.Location = new System.Drawing.Point(43, 45);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(36, 22);
            this.labID.TabIndex = 20;
            this.labID.Text = "ID:";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNam.Location = new System.Drawing.Point(162, 133);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(68, 26);
            this.radNam.TabIndex = 35;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNu.Location = new System.Drawing.Point(289, 133);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(56, 26);
            this.radNu.TabIndex = 36;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Location = new System.Drawing.Point(662, 374);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(345, 27);
            this.txtTim.TabIndex = 40;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Green;
            this.btnTim.Location = new System.Drawing.Point(1030, 374);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 27);
            this.btnTim.TabIndex = 38;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
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
            this.panelNhomNut.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlPatient.ResumeLayout(false);
            this.pnlPatient.PerformLayout();
            this.groupBoxDieuTri.ResumeLayout(false);
            this.groupBoxDieuTri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labQuanLyBenhNhan;
        private System.Windows.Forms.Label labDanhSachBenhNhan;
        private System.Windows.Forms.DataGridView DgViewBenhNhan;
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.Panel pnlPatient;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBoxDieuTri;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
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
    }
}