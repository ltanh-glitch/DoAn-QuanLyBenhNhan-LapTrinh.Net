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
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelThongTinBenhNhan = new System.Windows.Forms.Panel();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtTenChuyenKhoa = new System.Windows.Forms.TextBox();
            this.txtChuyenKhoaID = new System.Windows.Forms.TextBox();
            this.lblTenChuyenKhoa = new System.Windows.Forms.Label();
            this.labMaChuyenKhoa = new System.Windows.Forms.Label();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.colChuyenKhoaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChuyenKHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labQuanLyKhoa = new System.Windows.Forms.Label();
            this.labDanhSachBenhNhan = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panelNhomNut.SuspendLayout();
            this.panelThongTinBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
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
            this.panelNhomNut.Location = new System.Drawing.Point(851, 71);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 221);
            this.panelNhomNut.TabIndex = 41;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(148, 165);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 53);
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
            this.btnHuy.Location = new System.Drawing.Point(148, 86);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 53);
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
            this.btnLuu.Location = new System.Drawing.Point(148, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 53);
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
            this.btnXoa.Location = new System.Drawing.Point(3, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 53);
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
            this.btnSua.Location = new System.Drawing.Point(3, 86);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 53);
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
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 53);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelThongTinBenhNhan
            // 
            this.panelThongTinBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThongTinBenhNhan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelThongTinBenhNhan.Controls.Add(this.txtMoTa);
            this.panelThongTinBenhNhan.Controls.Add(this.lblDiaChi);
            this.panelThongTinBenhNhan.Controls.Add(this.txtTenChuyenKhoa);
            this.panelThongTinBenhNhan.Controls.Add(this.txtChuyenKhoaID);
            this.panelThongTinBenhNhan.Controls.Add(this.lblTenChuyenKhoa);
            this.panelThongTinBenhNhan.Controls.Add(this.labMaChuyenKhoa);
            this.panelThongTinBenhNhan.Location = new System.Drawing.Point(12, 71);
            this.panelThongTinBenhNhan.Name = "panelThongTinBenhNhan";
            this.panelThongTinBenhNhan.Size = new System.Drawing.Size(802, 221);
            this.panelThongTinBenhNhan.TabIndex = 40;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(39, 120);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(697, 98);
            this.txtMoTa.TabIndex = 19;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChi.Location = new System.Drawing.Point(35, 93);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(163, 19);
            this.lblDiaChi.TabIndex = 18;
            this.lblDiaChi.Text = "Mô Tả Chuyên Khoa:";
            // 
            // txtTenChuyenKhoa
            // 
            this.txtTenChuyenKhoa.Location = new System.Drawing.Point(208, 49);
            this.txtTenChuyenKhoa.Name = "txtTenChuyenKhoa";
            this.txtTenChuyenKhoa.Size = new System.Drawing.Size(407, 22);
            this.txtTenChuyenKhoa.TabIndex = 10;
            // 
            // txtChuyenKhoaID
            // 
            this.txtChuyenKhoaID.Location = new System.Drawing.Point(208, 3);
            this.txtChuyenKhoaID.Name = "txtChuyenKhoaID";
            this.txtChuyenKhoaID.Size = new System.Drawing.Size(407, 22);
            this.txtChuyenKhoaID.TabIndex = 9;
            // 
            // lblTenChuyenKhoa
            // 
            this.lblTenChuyenKhoa.AutoSize = true;
            this.lblTenChuyenKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenChuyenKhoa.Location = new System.Drawing.Point(35, 49);
            this.lblTenChuyenKhoa.Name = "lblTenChuyenKhoa";
            this.lblTenChuyenKhoa.Size = new System.Drawing.Size(143, 19);
            this.lblTenChuyenKhoa.TabIndex = 2;
            this.lblTenChuyenKhoa.Text = "Tên Chuyên Khoa:";
            // 
            // labMaChuyenKhoa
            // 
            this.labMaChuyenKhoa.AutoSize = true;
            this.labMaChuyenKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labMaChuyenKhoa.Location = new System.Drawing.Point(35, 3);
            this.labMaChuyenKhoa.Name = "labMaChuyenKhoa";
            this.labMaChuyenKhoa.Size = new System.Drawing.Size(140, 19);
            this.labMaChuyenKhoa.TabIndex = 1;
            this.labMaChuyenKhoa.Text = "Mã Chuyên Khoa:";
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
            this.txtTim.Location = new System.Drawing.Point(12, 316);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(345, 22);
            this.txtTim.TabIndex = 44;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Blue;
            this.btnTim.Location = new System.Drawing.Point(380, 316);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 27);
            this.btnTim.TabIndex = 43;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Form_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1118, 600);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.labDanhSachBenhNhan);
            this.Controls.Add(this.panelNhomNut);
            this.Controls.Add(this.panelThongTinBenhNhan);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.labQuanLyKhoa);
            this.Name = "Form_Khoa";
            this.Text = "Form_Khoa";
            this.Load += new System.EventHandler(this.Form_Khoa_Load);
            this.panelNhomNut.ResumeLayout(false);
            this.panelThongTinBenhNhan.ResumeLayout(false);
            this.panelThongTinBenhNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelThongTinBenhNhan;
        private System.Windows.Forms.TextBox txtTenChuyenKhoa;
        private System.Windows.Forms.TextBox txtChuyenKhoaID;
        private System.Windows.Forms.Label lblTenChuyenKhoa;
        private System.Windows.Forms.Label labMaChuyenKhoa;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Label labQuanLyKhoa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label labDanhSachBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenKhoaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChuyenKHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
    }
}