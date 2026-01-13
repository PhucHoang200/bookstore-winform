namespace GUI.UserControl_Admin
{
    partial class UC_QLDonhangAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDanhsachdonhang = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonhangmoi = new Guna.UI2.WinForms.Guna2Button();
            this.container = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnDanhsachdonhang);
            this.guna2Panel1.Controls.Add(this.btnDonhangmoi);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1185, 60);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnDanhsachdonhang
            // 
            this.btnDanhsachdonhang.BorderRadius = 8;
            this.btnDanhsachdonhang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDanhsachdonhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhsachdonhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhsachdonhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDanhsachdonhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDanhsachdonhang.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnDanhsachdonhang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnDanhsachdonhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDanhsachdonhang.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDanhsachdonhang.Location = new System.Drawing.Point(190, 0);
            this.btnDanhsachdonhang.Name = "btnDanhsachdonhang";
            this.btnDanhsachdonhang.Size = new System.Drawing.Size(245, 60);
            this.btnDanhsachdonhang.TabIndex = 1;
            this.btnDanhsachdonhang.Text = "Danh sách đơn hàng";
            this.btnDanhsachdonhang.Click += new System.EventHandler(this.btnDanhsachdonhang_Click);
            // 
            // btnDonhangmoi
            // 
            this.btnDonhangmoi.BorderRadius = 8;
            this.btnDonhangmoi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDonhangmoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonhangmoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonhangmoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonhangmoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonhangmoi.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnDonhangmoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnDonhangmoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDonhangmoi.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDonhangmoi.Location = new System.Drawing.Point(0, 0);
            this.btnDonhangmoi.Name = "btnDonhangmoi";
            this.btnDonhangmoi.Size = new System.Drawing.Size(190, 60);
            this.btnDonhangmoi.TabIndex = 0;
            this.btnDonhangmoi.Text = "Đơn hàng mới";
            this.btnDonhangmoi.Click += new System.EventHandler(this.btnDonhangmoi_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 60);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1185, 680);
            this.container.TabIndex = 1;
            this.container.Text = "guna2ContainerControl1";
            // 
            // UC_QLDonhangAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.container);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_QLDonhangAdmin";
            this.Size = new System.Drawing.Size(1185, 740);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDanhsachdonhang;
        private Guna.UI2.WinForms.Guna2Button btnDonhangmoi;
        private Guna.UI2.WinForms.Guna2ContainerControl container;
    }
}
