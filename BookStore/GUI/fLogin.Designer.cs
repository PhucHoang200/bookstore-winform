namespace GUI
{
    partial class fLogin
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
            this.components = new System.ComponentModel.Container();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDangnhap = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTaikhoan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMatkhau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDangnhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuenmatkhau = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::GUI.Properties.Resources.pexels_eberhard_grossgasteiger_1624496;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(400, 452);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblDangnhap
            // 
            this.lblDangnhap.BackColor = System.Drawing.Color.Transparent;
            this.lblDangnhap.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangnhap.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDangnhap.Location = new System.Drawing.Point(538, 56);
            this.lblDangnhap.Name = "lblDangnhap";
            this.lblDangnhap.Size = new System.Drawing.Size(138, 34);
            this.lblDangnhap.TabIndex = 3;
            this.lblDangnhap.Text = "Đăng nhập";
            // 
            // lblTaikhoan
            // 
            this.lblTaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaikhoan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaikhoan.Location = new System.Drawing.Point(430, 106);
            this.lblTaikhoan.Name = "lblTaikhoan";
            this.lblTaikhoan.Size = new System.Drawing.Size(91, 25);
            this.lblTaikhoan.TabIndex = 4;
            this.lblTaikhoan.Text = "Tài khoản:";
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatkhau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(430, 211);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(87, 25);
            this.lblMatkhau.TabIndex = 5;
            this.lblMatkhau.Text = "Mật khẩu:";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.BorderRadius = 8;
            this.txtTaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaikhoan.DefaultText = "";
            this.txtTaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaikhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.Location = new System.Drawing.Point(430, 152);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.PasswordChar = '\0';
            this.txtTaikhoan.PlaceholderText = "Email ";
            this.txtTaikhoan.SelectedText = "";
            this.txtTaikhoan.Size = new System.Drawing.Size(310, 36);
            this.txtTaikhoan.TabIndex = 6;
            this.txtTaikhoan.TextChanged += new System.EventHandler(this.txtTaikhoan_TextChanged);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BorderRadius = 8;
            this.txtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau.DefaultText = "";
            this.txtMatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatkhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.Location = new System.Drawing.Point(430, 253);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '•';
            this.txtMatkhau.PlaceholderText = "Mật khẩu";
            this.txtMatkhau.SelectedText = "";
            this.txtMatkhau.Size = new System.Drawing.Size(310, 36);
            this.txtMatkhau.TabIndex = 7;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BorderRadius = 8;
            this.btnDangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangnhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDangnhap.ForeColor = System.Drawing.Color.White;
            this.btnDangnhap.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangnhap.Location = new System.Drawing.Point(534, 356);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(142, 45);
            this.btnDangnhap.TabIndex = 9;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnQuenmatkhau
            // 
            this.btnQuenmatkhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuenmatkhau.BorderRadius = 8;
            this.btnQuenmatkhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuenmatkhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuenmatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuenmatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuenmatkhau.FillColor = System.Drawing.Color.White;
            this.btnQuenmatkhau.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnQuenmatkhau.ForeColor = System.Drawing.Color.Black;
            this.btnQuenmatkhau.Location = new System.Drawing.Point(621, 295);
            this.btnQuenmatkhau.Name = "btnQuenmatkhau";
            this.btnQuenmatkhau.PressedColor = System.Drawing.Color.Bisque;
            this.btnQuenmatkhau.Size = new System.Drawing.Size(119, 18);
            this.btnQuenmatkhau.TabIndex = 10;
            this.btnQuenmatkhau.Text = "Quên mật khẩu?";
            this.btnQuenmatkhau.Click += new System.EventHandler(this.btnQuenmatkhau_Click);
            // 
            // guna2ControlBoxClose
            // 
            this.guna2ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxClose.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2ControlBoxClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBoxClose.IconColor = System.Drawing.Color.DarkGray;
            this.guna2ControlBoxClose.Location = new System.Drawing.Point(756, -1);
            this.guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            this.guna2ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBoxClose.TabIndex = 11;
            this.guna2ControlBoxClose.Click += new System.EventHandler(this.guna2ControlBoxClose_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DarkGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(705, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ControlBoxClose);
            this.Controls.Add(this.btnQuenmatkhau);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.lblMatkhau);
            this.Controls.Add(this.lblTaikhoan);
            this.Controls.Add(this.lblDangnhap);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDangnhap;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaikhoan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMatkhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTaikhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtMatkhau;
        private Guna.UI2.WinForms.Guna2Button btnDangnhap;
        private Guna.UI2.WinForms.Guna2Button btnQuenmatkhau;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}