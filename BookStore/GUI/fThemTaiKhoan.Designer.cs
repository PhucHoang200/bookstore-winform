namespace GUI
{
    partial class fThemTaiKhoan
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbVaiTro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSĐT = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm tài khoản mới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DarkGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(756, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vai trò:";
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(316, 191);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(167, 40);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu tài khoản";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 8;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtHoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(119, 45);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(200, 27);
            this.txtHoTen.TabIndex = 9;
            // 
            // cbbVaiTro
            // 
            this.cbbVaiTro.BackColor = System.Drawing.Color.Transparent;
            this.cbbVaiTro.BorderRadius = 8;
            this.cbbVaiTro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVaiTro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbVaiTro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbVaiTro.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cbbVaiTro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbbVaiTro.ItemHeight = 21;
            this.cbbVaiTro.Location = new System.Drawing.Point(575, 91);
            this.cbbVaiTro.Name = "cbbVaiTro";
            this.cbbVaiTro.Size = new System.Drawing.Size(200, 27);
            this.cbbVaiTro.TabIndex = 10;
            this.cbbVaiTro.SelectedIndexChanged += new System.EventHandler(this.cbbVaiTro_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(119, 91);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(200, 27);
            this.txtEmail.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderRadius = 8;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Location = new System.Drawing.Point(119, 142);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '•';
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(200, 27);
            this.txtMatKhau.TabIndex = 12;
            // 
            // txtSĐT
            // 
            this.txtSĐT.BorderRadius = 8;
            this.txtSĐT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSĐT.DefaultText = "";
            this.txtSĐT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSĐT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSĐT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSĐT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSĐT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSĐT.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtSĐT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSĐT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSĐT.Location = new System.Drawing.Point(575, 45);
            this.txtSĐT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.PasswordChar = '\0';
            this.txtSĐT.PlaceholderText = "";
            this.txtSĐT.SelectedText = "";
            this.txtSĐT.Size = new System.Drawing.Size(200, 27);
            this.txtSĐT.TabIndex = 13;
            // 
            // fThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.ControlBox = false;
            this.Controls.Add(this.txtSĐT);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbbVaiTro);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2ComboBox cbbVaiTro;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtSĐT;
    }
}