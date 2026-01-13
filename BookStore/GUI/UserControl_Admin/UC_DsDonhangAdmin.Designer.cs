namespace GUI.UserControl_Admin
{
    partial class UC_DsDonhangAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.cbbLocTheoThoiGianVaTongTien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvDsDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnRefesh);
            this.guna2Panel1.Controls.Add(this.btnXoa);
            this.guna2Panel1.Controls.Add(this.cbbLocTheoThoiGianVaTongTien);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1185, 54);
            this.guna2Panel1.TabIndex = 0;
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
            this.btnRefesh.Image = global::GUI.Properties.Resources.refresh_page_option;
            this.btnRefesh.Location = new System.Drawing.Point(365, 8);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(24, 36);
            this.btnRefesh.TabIndex = 2;
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
            this.btnXoa.Image = global::GUI.Properties.Resources.remove1;
            this.btnXoa.Location = new System.Drawing.Point(237, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 36);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbbLocTheoThoiGianVaTongTien
            // 
            this.cbbLocTheoThoiGianVaTongTien.BackColor = System.Drawing.Color.Transparent;
            this.cbbLocTheoThoiGianVaTongTien.BorderRadius = 8;
            this.cbbLocTheoThoiGianVaTongTien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLocTheoThoiGianVaTongTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocTheoThoiGianVaTongTien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocTheoThoiGianVaTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocTheoThoiGianVaTongTien.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cbbLocTheoThoiGianVaTongTien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbbLocTheoThoiGianVaTongTien.ItemHeight = 30;
            this.cbbLocTheoThoiGianVaTongTien.Location = new System.Drawing.Point(13, 8);
            this.cbbLocTheoThoiGianVaTongTien.Name = "cbbLocTheoThoiGianVaTongTien";
            this.cbbLocTheoThoiGianVaTongTien.Size = new System.Drawing.Size(184, 36);
            this.cbbLocTheoThoiGianVaTongTien.TabIndex = 0;
            this.cbbLocTheoThoiGianVaTongTien.SelectedIndexChanged += new System.EventHandler(this.cbbLocTheoThoiGianVaTongTien_SelectedIndexChanged);
            // 
            // dgvDsDonHang
            // 
            this.dgvDsDonHang.AllowUserToAddRows = false;
            this.dgvDsDonHang.AllowUserToDeleteRows = false;
            this.dgvDsDonHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDsDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDsDonHang.ColumnHeadersHeight = 35;
            this.dgvDsDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDsDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDsDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDsDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsDonHang.Location = new System.Drawing.Point(0, 54);
            this.dgvDsDonHang.Name = "dgvDsDonHang";
            this.dgvDsDonHang.ReadOnly = true;
            this.dgvDsDonHang.RowHeadersVisible = false;
            this.dgvDsDonHang.Size = new System.Drawing.Size(1185, 623);
            this.dgvDsDonHang.TabIndex = 7;
            this.dgvDsDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDsDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDsDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDsDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDsDonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsDonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsDonHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDsDonHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDsDonHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDsDonHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDsDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDsDonHang.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDsDonHang.ThemeStyle.ReadOnly = true;
            this.dgvDsDonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsDonHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDsDonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDsDonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDsDonHang.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDsDonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsDonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDsDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsDonHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Column1";
            this.Column1.HeaderText = "Mã đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Column2";
            this.Column2.HeaderText = "Ngày mua hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Column3";
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Column4";
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // UC_DsDonhangAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.dgvDsDonHang);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_DsDonhangAdmin";
            this.Size = new System.Drawing.Size(1185, 677);
            this.Load += new System.EventHandler(this.UC_DsDonhangAdmin_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDsDonHang;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLocTheoThoiGianVaTongTien;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
