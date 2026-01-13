namespace GUI.UserControl_Admin
{
    partial class UC_NhacungcapAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimkiemNCC = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiemNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvNhaCungCap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.guna2Panel1.Controls.Add(this.btnTimkiemNCC);
            this.guna2Panel1.Controls.Add(this.txtTimkiemNCC);
            this.guna2Panel1.Controls.Add(this.btnRefesh);
            this.guna2Panel1.Controls.Add(this.btnXoa);
            this.guna2Panel1.Controls.Add(this.btnSua);
            this.guna2Panel1.Controls.Add(this.btnThem);
            this.guna2Panel1.Controls.Add(this.txtTenNCC);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1185, 126);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnTimkiemNCC
            // 
            this.btnTimkiemNCC.BorderRadius = 8;
            this.btnTimkiemNCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemNCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiemNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiemNCC.FillColor = System.Drawing.Color.White;
            this.btnTimkiemNCC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemNCC.ForeColor = System.Drawing.Color.White;
            this.btnTimkiemNCC.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.btnTimkiemNCC.Location = new System.Drawing.Point(310, 80);
            this.btnTimkiemNCC.Name = "btnTimkiemNCC";
            this.btnTimkiemNCC.Size = new System.Drawing.Size(30, 28);
            this.btnTimkiemNCC.TabIndex = 7;
            this.btnTimkiemNCC.Click += new System.EventHandler(this.btnTimkiemNCC_Click);
            // 
            // txtTimkiemNCC
            // 
            this.txtTimkiemNCC.BorderRadius = 8;
            this.txtTimkiemNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemNCC.DefaultText = "";
            this.txtTimkiemNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiemNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiemNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemNCC.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtTimkiemNCC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimkiemNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemNCC.Location = new System.Drawing.Point(18, 77);
            this.txtTimkiemNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiemNCC.Name = "txtTimkiemNCC";
            this.txtTimkiemNCC.PasswordChar = '\0';
            this.txtTimkiemNCC.PlaceholderText = "Nhập tên nhà cung cấp\r\n";
            this.txtTimkiemNCC.SelectedText = "";
            this.txtTimkiemNCC.Size = new System.Drawing.Size(327, 36);
            this.txtTimkiemNCC.TabIndex = 6;
            this.txtTimkiemNCC.TextChanged += new System.EventHandler(this.txtTimkiemNCC_TextChanged);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BorderRadius = 8;
            this.btnRefesh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefesh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefesh.FillColor = System.Drawing.Color.White;
            this.btnRefesh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Image = global::GUI.Properties.Resources.refresh_page_option1;
            this.btnRefesh.Location = new System.Drawing.Point(382, 77);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(24, 36);
            this.btnRefesh.TabIndex = 5;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::GUI.Properties.Resources.remove3;
            this.btnXoa.Location = new System.Drawing.Point(519, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 36);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::GUI.Properties.Resources.service__1_1;
            this.btnSua.Location = new System.Drawing.Point(382, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::GUI.Properties.Resources.plus__1_;
            this.btnThem.Location = new System.Drawing.Point(245, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 36);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.BorderRadius = 8;
            this.txtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNCC.DefaultText = "";
            this.txtTenNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtTenNCC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.Location = new System.Drawing.Point(18, 21);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.PasswordChar = '\0';
            this.txtTenNCC.PlaceholderText = "Tên nhà cung cấp";
            this.txtTenNCC.SelectedText = "";
            this.txtTenNCC.Size = new System.Drawing.Size(195, 36);
            this.txtTenNCC.TabIndex = 1;
            this.txtTenNCC.TextChanged += new System.EventHandler(this.txtTenNCC_TextChanged);
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.AllowUserToAddRows = false;
            this.dgvNhaCungCap.AllowUserToDeleteRows = false;
            this.dgvNhaCungCap.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgvNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvNhaCungCap.ColumnHeadersHeight = 35;
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhaCungCap.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhaCungCap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhaCungCap.Location = new System.Drawing.Point(0, 126);
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.ReadOnly = true;
            this.dgvNhaCungCap.RowHeadersVisible = false;
            this.dgvNhaCungCap.RowHeadersWidth = 51;
            this.dgvNhaCungCap.RowTemplate.Height = 30;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(1185, 551);
            this.dgvNhaCungCap.TabIndex = 1;
            this.dgvNhaCungCap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhaCungCap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhaCungCap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhaCungCap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhaCungCap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhaCungCap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhaCungCap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhaCungCap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNhaCungCap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhaCungCap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhaCungCap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhaCungCap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhaCungCap.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvNhaCungCap.ThemeStyle.ReadOnly = true;
            this.dgvNhaCungCap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhaCungCap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhaCungCap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhaCungCap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhaCungCap.ThemeStyle.RowsStyle.Height = 30;
            this.dgvNhaCungCap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhaCungCap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCap_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Column1";
            this.Column1.HeaderText = "Mã nhà cung cấp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Column2";
            this.Column2.HeaderText = "Tên nhà cung cấp";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // UC_NhacungcapAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvNhaCungCap);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_NhacungcapAdmin";
            this.Size = new System.Drawing.Size(1185, 677);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhaCungCap;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNCC;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemNCC;
        private Guna.UI2.WinForms.Guna2Button btnTimkiemNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
