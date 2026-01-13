namespace GUI.UserControl_Admin
{
    partial class UC_Sachsachadmin
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
            this.btnTimkiemsach = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiemsach = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.datagridviewSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbbLocTheoGiaBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewSach)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.cbbLocTheoGiaBan);
            this.guna2Panel1.Controls.Add(this.btnTimkiemsach);
            this.guna2Panel1.Controls.Add(this.btnRefesh);
            this.guna2Panel1.Controls.Add(this.txtTimkiemsach);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1185, 76);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnTimkiemsach
            // 
            this.btnTimkiemsach.BorderRadius = 8;
            this.btnTimkiemsach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemsach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemsach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiemsach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiemsach.FillColor = System.Drawing.Color.Empty;
            this.btnTimkiemsach.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnTimkiemsach.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTimkiemsach.HoverState.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnTimkiemsach.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.btnTimkiemsach.Location = new System.Drawing.Point(300, 24);
            this.btnTimkiemsach.Name = "btnTimkiemsach";
            this.btnTimkiemsach.Size = new System.Drawing.Size(30, 28);
            this.btnTimkiemsach.TabIndex = 5;
            this.btnTimkiemsach.Click += new System.EventHandler(this.btnTimkiemsach_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BorderRadius = 8;
            this.btnRefesh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefesh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefesh.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefesh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRefesh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefesh.HoverState.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefesh.HoverState.CustomBorderColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefesh.HoverState.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefesh.HoverState.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefesh.Image = global::GUI.Properties.Resources.refresh_page_option;
            this.btnRefesh.Location = new System.Drawing.Point(546, 28);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(24, 24);
            this.btnRefesh.TabIndex = 4;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // txtTimkiemsach
            // 
            this.txtTimkiemsach.BorderRadius = 8;
            this.txtTimkiemsach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemsach.DefaultText = "";
            this.txtTimkiemsach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiemsach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiemsach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemsach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemsach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemsach.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtTimkiemsach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimkiemsach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemsach.Location = new System.Drawing.Point(25, 22);
            this.txtTimkiemsach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiemsach.Name = "txtTimkiemsach";
            this.txtTimkiemsach.PasswordChar = '\0';
            this.txtTimkiemsach.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtTimkiemsach.SelectedText = "";
            this.txtTimkiemsach.Size = new System.Drawing.Size(309, 36);
            this.txtTimkiemsach.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.datagridviewSach);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 76);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1185, 604);
            this.guna2Panel2.TabIndex = 1;
            // 
            // datagridviewSach
            // 
            this.datagridviewSach.AllowUserToAddRows = false;
            this.datagridviewSach.AllowUserToDeleteRows = false;
            this.datagridviewSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridviewSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewSach.ColumnHeadersHeight = 35;
            this.datagridviewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewSach.Location = new System.Drawing.Point(0, 0);
            this.datagridviewSach.Name = "datagridviewSach";
            this.datagridviewSach.ReadOnly = true;
            this.datagridviewSach.RowHeadersVisible = false;
            this.datagridviewSach.RowHeadersWidth = 51;
            this.datagridviewSach.RowTemplate.Height = 30;
            this.datagridviewSach.Size = new System.Drawing.Size(1185, 604);
            this.datagridviewSach.TabIndex = 0;
            this.datagridviewSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridviewSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridviewSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridviewSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridviewSach.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewSach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridviewSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridviewSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridviewSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridviewSach.ThemeStyle.HeaderStyle.Height = 35;
            this.datagridviewSach.ThemeStyle.ReadOnly = true;
            this.datagridviewSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridviewSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridviewSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridviewSach.ThemeStyle.RowsStyle.Height = 30;
            this.datagridviewSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cbbLocTheoGiaBan
            // 
            this.cbbLocTheoGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.cbbLocTheoGiaBan.BorderRadius = 8;
            this.cbbLocTheoGiaBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLocTheoGiaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocTheoGiaBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocTheoGiaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLocTheoGiaBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLocTheoGiaBan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbbLocTheoGiaBan.ItemHeight = 30;
            this.cbbLocTheoGiaBan.Location = new System.Drawing.Point(368, 22);
            this.cbbLocTheoGiaBan.Name = "cbbLocTheoGiaBan";
            this.cbbLocTheoGiaBan.Size = new System.Drawing.Size(140, 36);
            this.cbbLocTheoGiaBan.TabIndex = 6;
            this.cbbLocTheoGiaBan.SelectedIndexChanged += new System.EventHandler(this.cbbLocTheoGiaBan_SelectedIndexChanged);
            // 
            // UC_Sachsachadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_Sachsachadmin";
            this.Size = new System.Drawing.Size(1185, 680);
            this.Load += new System.EventHandler(this.UC_Sachsachadmin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemsach;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView datagridviewSach;
        private Guna.UI2.WinForms.Guna2Button btnTimkiemsach;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLocTheoGiaBan;
    }
}
