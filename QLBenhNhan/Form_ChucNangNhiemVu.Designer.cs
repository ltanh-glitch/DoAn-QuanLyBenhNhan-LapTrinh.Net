namespace QLBenhNhan
{
    partial class Form_ChucNangNhiemVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChucNangNhiemVu));
            this.btnTroVe = new System.Windows.Forms.Button();
            this.lblNDChucNangNhiemVu = new System.Windows.Forms.Label();
            this.lblChucNangNhiemVu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(556, 529);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(131, 62);
            this.btnTroVe.TabIndex = 7;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // lblNDChucNangNhiemVu
            // 
            this.lblNDChucNangNhiemVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNDChucNangNhiemVu.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNDChucNangNhiemVu.Location = new System.Drawing.Point(19, 107);
            this.lblNDChucNangNhiemVu.Name = "lblNDChucNangNhiemVu";
            this.lblNDChucNangNhiemVu.Size = new System.Drawing.Size(1218, 387);
            this.lblNDChucNangNhiemVu.TabIndex = 6;
            this.lblNDChucNangNhiemVu.Text = resources.GetString("lblNDChucNangNhiemVu.Text");
            // 
            // lblChucNangNhiemVu
            // 
            this.lblChucNangNhiemVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChucNangNhiemVu.AutoSize = true;
            this.lblChucNangNhiemVu.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChucNangNhiemVu.ForeColor = System.Drawing.Color.Black;
            this.lblChucNangNhiemVu.Location = new System.Drawing.Point(415, 53);
            this.lblChucNangNhiemVu.Name = "lblChucNangNhiemVu";
            this.lblChucNangNhiemVu.Size = new System.Drawing.Size(400, 37);
            this.lblChucNangNhiemVu.TabIndex = 5;
            this.lblChucNangNhiemVu.Text = "CHỨC NĂNG NHIỆM VỤ\r\n";
            this.lblChucNangNhiemVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_ChucNangNhiemVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1254, 625);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.lblNDChucNangNhiemVu);
            this.Controls.Add(this.lblChucNangNhiemVu);
            this.Name = "Form_ChucNangNhiemVu";
            this.Text = "Chức Năng Nhiệm Vụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Label lblNDChucNangNhiemVu;
        private System.Windows.Forms.Label lblChucNangNhiemVu;
    }
}