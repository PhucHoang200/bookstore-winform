namespace GUI
{
    partial class ResetPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtXacNhanMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xác nhận mật khẩu mới:";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BorderRadius = 8;
            this.txtMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauMoi.DefaultText = "";
            this.txtMatKhauMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhauMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhauMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhauMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhauMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(196, 51);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '•';
            this.txtMatKhauMoi.PlaceholderText = "";
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(227, 27);
            this.txtMatKhauMoi.TabIndex = 2;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.BorderRadius = 8;
            this.txtXacNhanMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhanMatKhau.DefaultText = "";
            this.txtXacNhanMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXacNhanMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXacNhanMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacNhanMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacNhanMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(196, 113);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '•';
            this.txtXacNhanMatKhau.PlaceholderText = "";
            this.txtXacNhanMatKhau.SelectedText = "";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(227, 27);
            this.txtXacNhanMatKhau.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderRadius = 8;
            this.btnXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(135, 166);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(180, 45);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập mật khẩu mới";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(435, 231);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResetPassword_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtXacNhanMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private System.Windows.Forms.Label label3;
    }
}