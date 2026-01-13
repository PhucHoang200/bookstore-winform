namespace GUI.UserControl_Employee
{
    partial class UC_NxbsachEmployee
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
            this.btnTimkiemNxb = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiemNxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.datagridviewNxb = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewNxb)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnRefesh);
            this.guna2Panel1.Controls.Add(this.btnTimkiemNxb);
            this.guna2Panel1.Controls.Add(this.txtTimkiemNxb);
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
            this.btnRefesh.Location = new System.Drawing.Point(358, 22);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(24, 36);
            this.btnRefesh.TabIndex = 2;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnTimkiemNxb
            // 
            this.btnTimkiemNxb.BorderRadius = 8;
            this.btnTimkiemNxb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemNxb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemNxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiemNxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiemNxb.FillColor = System.Drawing.Color.White;
            this.btnTimkiemNxb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemNxb.ForeColor = System.Drawing.Color.White;
            this.btnTimkiemNxb.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.btnTimkiemNxb.Location = new System.Drawing.Point(300, 28);
            this.btnTimkiemNxb.Name = "btnTimkiemNxb";
            this.btnTimkiemNxb.Size = new System.Drawing.Size(30, 27);
            this.btnTimkiemNxb.TabIndex = 1;
            this.btnTimkiemNxb.Click += new System.EventHandler(this.btnTimkiemNxb_Click);
            // 
            // txtTimkiemNxb
            // 
            this.txtTimkiemNxb.BorderRadius = 8;
            this.txtTimkiemNxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemNxb.DefaultText = "";
            this.txtTimkiemNxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiemNxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiemNxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemNxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemNxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemNxb.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtTimkiemNxb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimkiemNxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemNxb.Location = new System.Drawing.Point(25, 22);
            this.txtTimkiemNxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiemNxb.Name = "txtTimkiemNxb";
            this.txtTimkiemNxb.PasswordChar = '\0';
            this.txtTimkiemNxb.PlaceholderText = "Nhập tên NXB";
            this.txtTimkiemNxb.SelectedText = "";
            this.txtTimkiemNxb.Size = new System.Drawing.Size(309, 36);
            this.txtTimkiemNxb.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.datagridviewNxb);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 76);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(816, 401);
            this.guna2Panel2.TabIndex = 1;
            // 
            // datagridviewNxb
            // 
            this.datagridviewNxb.AllowUserToAddRows = false;
            this.datagridviewNxb.AllowUserToDeleteRows = false;
            this.datagridviewNxb.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridviewNxb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewNxb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewNxb.ColumnHeadersHeight = 35;
            this.datagridviewNxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewNxb.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewNxb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewNxb.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewNxb.Location = new System.Drawing.Point(0, 0);
            this.datagridviewNxb.Name = "datagridviewNxb";
            this.datagridviewNxb.ReadOnly = true;
            this.datagridviewNxb.RowHeadersVisible = false;
            this.datagridviewNxb.RowHeadersWidth = 51;
            this.datagridviewNxb.RowTemplate.Height = 30;
            this.datagridviewNxb.Size = new System.Drawing.Size(816, 401);
            this.datagridviewNxb.TabIndex = 0;
            this.datagridviewNxb.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewNxb.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridviewNxb.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridviewNxb.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridviewNxb.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridviewNxb.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewNxb.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewNxb.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridviewNxb.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewNxb.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridviewNxb.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridviewNxb.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridviewNxb.ThemeStyle.HeaderStyle.Height = 35;
            this.datagridviewNxb.ThemeStyle.ReadOnly = true;
            this.datagridviewNxb.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewNxb.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridviewNxb.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridviewNxb.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridviewNxb.ThemeStyle.RowsStyle.Height = 30;
            this.datagridviewNxb.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewNxb.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_NxbsachEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_NxbsachEmployee";
            this.Size = new System.Drawing.Size(816, 477);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewNxb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTimkiemNxb;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemNxb;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView datagridviewNxb;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
    }
}
