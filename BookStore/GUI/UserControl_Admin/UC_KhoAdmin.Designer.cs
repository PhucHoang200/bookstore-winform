namespace GUI.UserControl_Admin
{
    partial class UC_KhoAdmin
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
            this.btnChiTietSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDSPhieuNhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapSachDaCo = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapSachMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhaCungCap = new Guna.UI2.WinForms.Guna2Button();
            this.container = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnChiTietSach);
            this.guna2Panel1.Controls.Add(this.btnDSPhieuNhap);
            this.guna2Panel1.Controls.Add(this.btnNhapSachDaCo);
            this.guna2Panel1.Controls.Add(this.btnNhapSachMoi);
            this.guna2Panel1.Controls.Add(this.btnNhaCungCap);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1185, 60);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnChiTietSach
            // 
            this.btnChiTietSach.BorderRadius = 8;
            this.btnChiTietSach.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChiTietSach.CustomBorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnChiTietSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTietSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTietSach.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnChiTietSach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnChiTietSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnChiTietSach.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnChiTietSach.Location = new System.Drawing.Point(830, 0);
            this.btnChiTietSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiTietSach.Name = "btnChiTietSach";
            this.btnChiTietSach.Size = new System.Drawing.Size(170, 60);
            this.btnChiTietSach.TabIndex = 5;
            this.btnChiTietSach.Text = "Chi tiết sách";
            this.btnChiTietSach.Click += new System.EventHandler(this.btnChiTietSach_Click);
            // 
            // btnDSPhieuNhap
            // 
            this.btnDSPhieuNhap.BorderRadius = 8;
            this.btnDSPhieuNhap.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDSPhieuNhap.CustomBorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnDSPhieuNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDSPhieuNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDSPhieuNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDSPhieuNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDSPhieuNhap.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnDSPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnDSPhieuNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDSPhieuNhap.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDSPhieuNhap.Location = new System.Drawing.Point(570, 0);
            this.btnDSPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDSPhieuNhap.Name = "btnDSPhieuNhap";
            this.btnDSPhieuNhap.Size = new System.Drawing.Size(260, 60);
            this.btnDSPhieuNhap.TabIndex = 4;
            this.btnDSPhieuNhap.Text = "Danh sách phiếu nhập";
            this.btnDSPhieuNhap.Click += new System.EventHandler(this.btnDSPhieuNhap_Click);
            // 
            // btnNhapSachDaCo
            // 
            this.btnNhapSachDaCo.BorderRadius = 8;
            this.btnNhapSachDaCo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhapSachDaCo.CustomBorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnNhapSachDaCo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapSachDaCo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapSachDaCo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhapSachDaCo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhapSachDaCo.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnNhapSachDaCo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnNhapSachDaCo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNhapSachDaCo.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhapSachDaCo.Location = new System.Drawing.Point(370, 0);
            this.btnNhapSachDaCo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapSachDaCo.Name = "btnNhapSachDaCo";
            this.btnNhapSachDaCo.Size = new System.Drawing.Size(200, 60);
            this.btnNhapSachDaCo.TabIndex = 3;
            this.btnNhapSachDaCo.Text = "Nhập sách đã có";
            this.btnNhapSachDaCo.Click += new System.EventHandler(this.btnNhapSachDaCo_Click);
            // 
            // btnNhapSachMoi
            // 
            this.btnNhapSachMoi.BorderRadius = 8;
            this.btnNhapSachMoi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhapSachMoi.CustomBorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnNhapSachMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapSachMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapSachMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhapSachMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhapSachMoi.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnNhapSachMoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnNhapSachMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNhapSachMoi.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhapSachMoi.Location = new System.Drawing.Point(180, 0);
            this.btnNhapSachMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapSachMoi.Name = "btnNhapSachMoi";
            this.btnNhapSachMoi.Size = new System.Drawing.Size(190, 60);
            this.btnNhapSachMoi.TabIndex = 2;
            this.btnNhapSachMoi.Text = "Nhập sách mới";
            this.btnNhapSachMoi.Click += new System.EventHandler(this.btnNhapSachMoi_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BorderRadius = 8;
            this.btnNhaCungCap.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhaCungCap.CustomBorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnNhaCungCap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhaCungCap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhaCungCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhaCungCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhaCungCap.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNhaCungCap.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhaCungCap.Location = new System.Drawing.Point(0, 0);
            this.btnNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(180, 60);
            this.btnNhaCungCap.TabIndex = 1;
            this.btnNhaCungCap.Text = "Nhà cung cấp";
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 60);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1185, 680);
            this.container.TabIndex = 2;
            this.container.Text = "guna2ContainerControl1";
            // 
            // UC_KhoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.container);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_KhoAdmin";
            this.Size = new System.Drawing.Size(1185, 740);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnChiTietSach;
        private Guna.UI2.WinForms.Guna2Button btnDSPhieuNhap;
        private Guna.UI2.WinForms.Guna2Button btnNhapSachDaCo;
        private Guna.UI2.WinForms.Guna2Button btnNhapSachMoi;
        private Guna.UI2.WinForms.Guna2Button btnNhaCungCap;
        private Guna.UI2.WinForms.Guna2ContainerControl container;
    }
}
