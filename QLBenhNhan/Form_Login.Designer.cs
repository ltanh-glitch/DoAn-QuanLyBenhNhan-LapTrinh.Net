using System;
using System.Windows.Forms;
namespace QLBenhNhan
{
    partial class Form_Login : Form
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labTenDangNhap = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.labMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.bntThoat = new System.Windows.Forms.Button();
            this.linkQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.chkDieuKien = new System.Windows.Forms.CheckBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QLBenhNhan.Properties.Resources.bacsi;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(467, 98);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(60, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // labTenDangNhap
            // 
            this.labTenDangNhap.AutoSize = true;
            this.labTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labTenDangNhap.Location = new System.Drawing.Point(33, 147);
            this.labTenDangNhap.Name = "labTenDangNhap";
            this.labTenDangNhap.Size = new System.Drawing.Size(117, 20);
            this.labTenDangNhap.TabIndex = 3;
            this.labTenDangNhap.Text = "Tên đăng nhập";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(46, 245);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(158, 44);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(46, 169);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(373, 22);
            this.txtTenDangNhap.TabIndex = 5;
            // 
            // labMatKhau
            // 
            this.labMatKhau.AutoSize = true;
            this.labMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labMatKhau.Location = new System.Drawing.Point(33, 196);
            this.labMatKhau.Name = "labMatKhau";
            this.labMatKhau.Size = new System.Drawing.Size(78, 20);
            this.labMatKhau.TabIndex = 6;
            this.labMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(46, 219);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatKhau.Size = new System.Drawing.Size(373, 22);
            this.txtMatKhau.TabIndex = 7;
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkHienMatKhau.Location = new System.Drawing.Point(294, 199);
            this.chkHienMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(105, 19);
            this.chkHienMatKhau.TabIndex = 8;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bntThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntThoat.ForeColor = System.Drawing.Color.White;
            this.bntThoat.Location = new System.Drawing.Point(261, 245);
            this.bntThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(158, 44);
            this.bntThoat.TabIndex = 9;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // linkQuenMatKhau
            // 
            this.linkQuenMatKhau.AutoSize = true;
            this.linkQuenMatKhau.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkQuenMatKhau.Location = new System.Drawing.Point(181, 291);
            this.linkQuenMatKhau.Name = "linkQuenMatKhau";
            this.linkQuenMatKhau.Size = new System.Drawing.Size(93, 15);
            this.linkQuenMatKhau.TabIndex = 10;
            this.linkQuenMatKhau.TabStop = true;
            this.linkQuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // chkDieuKien
            // 
            this.chkDieuKien.AutoSize = true;
            this.chkDieuKien.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkDieuKien.Location = new System.Drawing.Point(46, 309);
            this.chkDieuKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDieuKien.Name = "chkDieuKien";
            this.chkDieuKien.Size = new System.Drawing.Size(200, 19);
            this.chkDieuKien.TabIndex = 11;
            this.chkDieuKien.Text = "Điều kiện và điều khoản dịch vụ";
            this.chkDieuKien.UseVisualStyleBackColor = true;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.Controls.Add(this.pictureBox2);
            this.pnlLogin.Controls.Add(this.chkDieuKien);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.chkHienMatKhau);
            this.pnlLogin.Controls.Add(this.linkQuenMatKhau);
            this.pnlLogin.Controls.Add(this.labTenDangNhap);
            this.pnlLogin.Controls.Add(this.bntThoat);
            this.pnlLogin.Controls.Add(this.btnDangNhap);
            this.pnlLogin.Controls.Add(this.txtTenDangNhap);
            this.pnlLogin.Controls.Add(this.labMatKhau);
            this.pnlLogin.Controls.Add(this.txtMatKhau);
            this.pnlLogin.Location = new System.Drawing.Point(425, 172);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(467, 341);
            this.pnlLogin.TabIndex = 12;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBenhNhan.Properties.Resources.Aesthetic_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1289, 723);
            this.Controls.Add(this.pnlLogin);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTenDangNhap;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label labMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.LinkLabel linkQuenMatKhau;
        private System.Windows.Forms.CheckBox chkDieuKien;
        private Panel pnlLogin;
    }
}

