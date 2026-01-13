namespace GUI.UserControl_Admin
{
    partial class UC_ChiTietSachTrongKho
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
            this.cbbLocTheoThoiGianVaSoLuongTon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvChiTietSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSach)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.cbbLocTheoThoiGianVaSoLuongTon);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1185, 66);
            this.guna2Panel1.TabIndex = 0;
            // 
            // cbbLocTheoThoiGianVaSoLuongTon
            // 
            this.cbbLocTheoThoiGianVaSoLuongTon.BackColor = System.Drawing.Color.Transparent;
            this.cbbLocTheoThoiGianVaSoLuongTon.BorderRadius = 8;
            this.cbbLocTheoThoiGianVaSoLuongTon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLocTheoThoiGianVaSoLuongTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocTheoThoiGianVaSoLuongTon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocTheoThoiGianVaSoLuongTon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocTheoThoiGianVaSoLuongTon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLocTheoThoiGianVaSoLuongTon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbbLocTheoThoiGianVaSoLuongTon.ItemHeight = 30;
            this.cbbLocTheoThoiGianVaSoLuongTon.Location = new System.Drawing.Point(15, 13);
            this.cbbLocTheoThoiGianVaSoLuongTon.Name = "cbbLocTheoThoiGianVaSoLuongTon";
            this.cbbLocTheoThoiGianVaSoLuongTon.Size = new System.Drawing.Size(216, 36);
            this.cbbLocTheoThoiGianVaSoLuongTon.TabIndex = 0;
            this.cbbLocTheoThoiGianVaSoLuongTon.SelectedIndexChanged += new System.EventHandler(this.cbbLocTheoThoiGianVaSoLuongTon_SelectedIndexChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvChiTietSach);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 66);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1185, 614);
            this.guna2Panel2.TabIndex = 1;
            // 
            // dgvChiTietSach
            // 
            this.dgvChiTietSach.AllowUserToAddRows = false;
            this.dgvChiTietSach.AllowUserToDeleteRows = false;
            this.dgvChiTietSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvChiTietSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietSach.ColumnHeadersHeight = 35;
            this.dgvChiTietSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiTietSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvChiTietSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTietSach.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietSach.Name = "dgvChiTietSach";
            this.dgvChiTietSach.ReadOnly = true;
            this.dgvChiTietSach.RowHeadersVisible = false;
            this.dgvChiTietSach.Size = new System.Drawing.Size(1185, 614);
            this.dgvChiTietSach.TabIndex = 9;
            this.dgvChiTietSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTietSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChiTietSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChiTietSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChiTietSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChiTietSach.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTietSach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTietSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChiTietSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChiTietSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChiTietSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiTietSach.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvChiTietSach.ThemeStyle.ReadOnly = true;
            this.dgvChiTietSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTietSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTietSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChiTietSach.ThemeStyle.RowsStyle.Height = 22;
            this.dgvChiTietSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTietSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChiTietSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietSach_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Column1";
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Column2";
            this.Column2.HeaderText = "Tên sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Column3";
            this.Column3.HeaderText = "Số lượng tồn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Column4";
            this.Column4.HeaderText = "Ngày nhập cuối cùng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // UC_ChiTietSachTrongKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_ChiTietSachTrongKho";
            this.Size = new System.Drawing.Size(1185, 680);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiTietSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLocTheoThoiGianVaSoLuongTon;
    }
}
