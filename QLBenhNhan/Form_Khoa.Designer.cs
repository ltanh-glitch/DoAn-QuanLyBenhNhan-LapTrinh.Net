namespace QLBenhNhan
{
    partial class Form_Khoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Khoa));
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.colChuyenKhoaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChuyenKHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labQuanLyKhoa = new System.Windows.Forms.Label();
            this.labDanhSachBenhNhan = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBoxDieuTri = new System.Windows.Forms.GroupBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtTenChuyenKhoa = new System.Windows.Forms.TextBox();
            this.txtChuyenKhoaID = new System.Windows.Forms.TextBox();
            this.lblTenChuyenKhoa = new System.Windows.Forms.Label();
            this.labMaChuyenKhoa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelNhomNut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.groupBoxDieuTri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNhomNut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelNhomNut.Controls.Add(this.groupBox1);
            this.panelNhomNut.Location = new System.Drawing.Point(851, 71);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 221);
            this.panelNhomNut.TabIndex = 41;
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.AllowUserToOrderColumns = true;
            this.dgvKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChuyenKhoaID,
            this.colTenChuyenKHoa,
            this.colMoTa});
            this.dgvKhoa.Location = new System.Drawing.Point(3, 379);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowHeadersVisible = false;
            this.dgvKhoa.RowHeadersWidth = 62;
            this.dgvKhoa.RowTemplate.Height = 28;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.Size = new System.Drawing.Size(1113, 222);
            this.dgvKhoa.TabIndex = 39;
            this.dgvKhoa.SelectionChanged += new System.EventHandler(this.dgvKhoa_SelectionChanged);
            // 
            // colChuyenKhoaID
            // 
            this.colChuyenKhoaID.DataPropertyName = "ChuyenKhoaID";
            this.colChuyenKhoaID.FillWeight = 45.36797F;
            this.colChuyenKhoaID.HeaderText = "Mã Chuyên Khoa";
            this.colChuyenKhoaID.MinimumWidth = 6;
            this.colChuyenKhoaID.Name = "colChuyenKhoaID";
            // 
            // colTenChuyenKHoa
            // 
            this.colTenChuyenKHoa.DataPropertyName = "TenChuyenKhoa";
            this.colTenChuyenKHoa.FillWeight = 112.2995F;
            this.colTenChuyenKHoa.HeaderText = "Tên Chuyên Khoa";
            this.colTenChuyenKHoa.MinimumWidth = 6;
            this.colTenChuyenKHoa.Name = "colTenChuyenKHoa";
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.FillWeight = 142.3326F;
            this.colMoTa.HeaderText = "Mô Tả";
            this.colMoTa.MinimumWidth = 6;
            this.colMoTa.Name = "colMoTa";
            // 
            // labQuanLyKhoa
            // 
            this.labQuanLyKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labQuanLyKhoa.AutoSize = true;
            this.labQuanLyKhoa.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyKhoa.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyKhoa.Location = new System.Drawing.Point(410, 34);
            this.labQuanLyKhoa.Name = "labQuanLyKhoa";
            this.labQuanLyKhoa.Size = new System.Drawing.Size(282, 37);
            this.labQuanLyKhoa.TabIndex = 38;
            this.labQuanLyKhoa.Text = "QUẢN LÝ KHOA ";
            this.labQuanLyKhoa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labDanhSachBenhNhan
            // 
            this.labDanhSachBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachBenhNhan.AutoSize = true;
            this.labDanhSachBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachBenhNhan.Location = new System.Drawing.Point(-1, 353);
            this.labDanhSachBenhNhan.Name = "labDanhSachBenhNhan";
            this.labDanhSachBenhNhan.Size = new System.Drawing.Size(155, 23);
            this.labDanhSachBenhNhan.TabIndex = 42;
            this.labDanhSachBenhNhan.Text = "Danh Sách Khoa:";
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Location = new System.Drawing.Point(659, 316);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(345, 22);
            this.txtTim.TabIndex = 44;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Green;
            this.btnTim.Location = new System.Drawing.Point(1027, 316);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 27);
            this.btnTim.TabIndex = 43;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBoxDieuTri
            // 
            this.groupBoxDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDieuTri.Controls.Add(this.txtMoTa);
            this.groupBoxDieuTri.Controls.Add(this.lblDiaChi);
            this.groupBoxDieuTri.Controls.Add(this.txtTenChuyenKhoa);
            this.groupBoxDieuTri.Controls.Add(this.txtChuyenKhoaID);
            this.groupBoxDieuTri.Controls.Add(this.lblTenChuyenKhoa);
            this.groupBoxDieuTri.Controls.Add(this.labMaChuyenKhoa);
            this.groupBoxDieuTri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxDieuTri.Location = new System.Drawing.Point(12, 74);
            this.groupBoxDieuTri.Name = "groupBoxDieuTri";
            this.groupBoxDieuTri.Size = new System.Drawing.Size(782, 236);
            this.groupBoxDieuTri.TabIndex = 45;
            this.groupBoxDieuTri.TabStop = false;
            this.groupBoxDieuTri.Text = "Thông tin:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(44, 145);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(728, 78);
            this.txtMoTa.TabIndex = 25;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChi.Location = new System.Drawing.Point(40, 123);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(163, 19);
            this.lblDiaChi.TabIndex = 24;
            this.lblDiaChi.Text = "Mô Tả Chuyên Khoa:";
            // 
            // txtTenChuyenKhoa
            // 
            this.txtTenChuyenKhoa.Location = new System.Drawing.Point(213, 79);
            this.txtTenChuyenKhoa.Name = "txtTenChuyenKhoa";
            this.txtTenChuyenKhoa.Size = new System.Drawing.Size(407, 34);
            this.txtTenChuyenKhoa.TabIndex = 23;
            // 
            // txtChuyenKhoaID
            // 
            this.txtChuyenKhoaID.Location = new System.Drawing.Point(213, 33);
            this.txtChuyenKhoaID.Name = "txtChuyenKhoaID";
            this.txtChuyenKhoaID.Size = new System.Drawing.Size(407, 34);
            this.txtChuyenKhoaID.TabIndex = 22;
            // 
            // lblTenChuyenKhoa
            // 
            this.lblTenChuyenKhoa.AutoSize = true;
            this.lblTenChuyenKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenChuyenKhoa.Location = new System.Drawing.Point(40, 79);
            this.lblTenChuyenKhoa.Name = "lblTenChuyenKhoa";
            this.lblTenChuyenKhoa.Size = new System.Drawing.Size(143, 19);
            this.lblTenChuyenKhoa.TabIndex = 21;
            this.lblTenChuyenKhoa.Text = "Tên Chuyên Khoa:";
            // 
            // labMaChuyenKhoa
            // 
            this.labMaChuyenKhoa.AutoSize = true;
            this.labMaChuyenKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labMaChuyenKhoa.Location = new System.Drawing.Point(40, 33);
            this.labMaChuyenKhoa.Name = "labMaChuyenKhoa";
            this.labMaChuyenKhoa.Size = new System.Drawing.Size(140, 19);
            this.labMaChuyenKhoa.TabIndex = 20;
            this.labMaChuyenKhoa.Text = "Mã Chuyên Khoa:";
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
            this.groupBox1.TabIndex = 7;
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
            // Form_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1118, 600);
            this.Controls.Add(this.groupBoxDieuTri);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labDanhSachBenhNhan);
            this.Controls.Add(this.panelNhomNut);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.labQuanLyKhoa);
            this.Name = "Form_Khoa";
            this.Text = "Form_Khoa";
            this.Load += new System.EventHandler(this.Form_Khoa_Load);
            this.panelNhomNut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.groupBoxDieuTri.ResumeLayout(false);
            this.groupBoxDieuTri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Label labQuanLyKhoa;
        private System.Windows.Forms.Label labDanhSachBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenKhoaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChuyenKHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBoxDieuTri;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtTenChuyenKhoa;
        private System.Windows.Forms.TextBox txtChuyenKhoaID;
        private System.Windows.Forms.Label lblTenChuyenKhoa;
        private System.Windows.Forms.Label labMaChuyenKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}