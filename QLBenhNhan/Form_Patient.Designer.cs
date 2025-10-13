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
            this.lbQLBN = new System.Windows.Forms.Label();
            this.lbMaSo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbQLBN
            // 
            this.lbQLBN.AutoSize = true;
            this.lbQLBN.BackColor = System.Drawing.Color.Transparent;
            this.lbQLBN.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLBN.Location = new System.Drawing.Point(544, 18);
            this.lbQLBN.Name = "lbQLBN";
            this.lbQLBN.Size = new System.Drawing.Size(344, 35);
            this.lbQLBN.TabIndex = 0;
            this.lbQLBN.Text = "QUẢN LÝ BỆNH NHÂN";
            // 
            // lbMaSo
            // 
            this.lbMaSo.AutoSize = true;
            this.lbMaSo.Location = new System.Drawing.Point(97, 114);
            this.lbMaSo.Name = "lbMaSo";
            this.lbMaSo.Size = new System.Drawing.Size(47, 16);
            this.lbMaSo.TabIndex = 1;
            this.lbMaSo.Text = "Mã số:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(308, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // Form_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 780);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbMaSo);
            this.Controls.Add(this.lbQLBN);
            this.Name = "Form_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bệnh Nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQLBN;
        private System.Windows.Forms.Label lbMaSo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}