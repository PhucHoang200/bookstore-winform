namespace GUI.UserControl_Employee
{
    partial class UC_SachsachEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimkiemsach = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiemsach = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.datagridviewSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewSach)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnRefesh);
            this.guna2Panel1.Controls.Add(this.btnTimkiemsach);
            this.guna2Panel1.Controls.Add(this.txtTimkiemsach);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(816, 76);
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
            this.btnRefesh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Image = global::GUI.Properties.Resources.refresh_page_option;
            this.btnRefesh.Location = new System.Drawing.Point(397, 22);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(24, 36);
            this.btnRefesh.TabIndex = 2;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnTimkiemsach
            // 
            this.btnTimkiemsach.BorderRadius = 8;
            this.btnTimkiemsach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemsach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemsach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiemsach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiemsach.FillColor = System.Drawing.Color.White;
            this.btnTimkiemsach.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnTimkiemsach.ForeColor = System.Drawing.Color.White;
            this.btnTimkiemsach.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.btnTimkiemsach.Location = new System.Drawing.Point(344, 26);
            this.btnTimkiemsach.Name = "btnTimkiemsach";
            this.btnTimkiemsach.Size = new System.Drawing.Size(30, 27);
            this.btnTimkiemsach.TabIndex = 1;
            this.btnTimkiemsach.Click += new System.EventHandler(this.btnTimkiemsach_Click);
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
            this.txtTimkiemsach.Size = new System.Drawing.Size(351, 36);
            this.txtTimkiemsach.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.datagridviewSach);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 76);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(816, 401);
            this.guna2Panel2.TabIndex = 1;
            // 
            // datagridviewSach
            // 
            this.datagridviewSach.AllowUserToAddRows = false;
            this.datagridviewSach.AllowUserToDeleteRows = false;
            this.datagridviewSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.datagridviewSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridviewSach.ColumnHeadersHeight = 35;
            this.datagridviewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewSach.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagridviewSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewSach.Location = new System.Drawing.Point(0, 0);
            this.datagridviewSach.Name = "datagridviewSach";
            this.datagridviewSach.ReadOnly = true;
            this.datagridviewSach.RowHeadersVisible = false;
            this.datagridviewSach.RowHeadersWidth = 51;
            this.datagridviewSach.RowTemplate.Height = 30;
            this.datagridviewSach.Size = new System.Drawing.Size(816, 401);
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
            // UC_SachsachEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_SachsachEmployee";
            this.Size = new System.Drawing.Size(816, 477);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemsach;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
        private Guna.UI2.WinForms.Guna2Button btnTimkiemsach;
        private Guna.UI2.WinForms.Guna2DataGridView datagridviewSach;
    }
}
