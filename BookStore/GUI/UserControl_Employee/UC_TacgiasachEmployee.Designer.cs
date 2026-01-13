namespace GUI.UserControl_Employee
{
    partial class UC_TacgiasachEmployee
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
            this.btnTimkiemtacgia = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiemtacgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.datagridviewTacgia = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewTacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnRefesh);
            this.guna2Panel1.Controls.Add(this.btnTimkiemtacgia);
            this.guna2Panel1.Controls.Add(this.txtTimkiemtacgia);
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
            this.btnRefesh.Image = global::GUI.Properties.Resources.refresh_page_option3;
            this.btnRefesh.Location = new System.Drawing.Point(373, 22);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(24, 36);
            this.btnRefesh.TabIndex = 2;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnTimkiemtacgia
            // 
            this.btnTimkiemtacgia.BorderRadius = 8;
            this.btnTimkiemtacgia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemtacgia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemtacgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiemtacgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiemtacgia.FillColor = System.Drawing.Color.White;
            this.btnTimkiemtacgia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemtacgia.ForeColor = System.Drawing.Color.White;
            this.btnTimkiemtacgia.Image = global::GUI.Properties.Resources.search_interface_symbol3;
            this.btnTimkiemtacgia.Location = new System.Drawing.Point(320, 27);
            this.btnTimkiemtacgia.Name = "btnTimkiemtacgia";
            this.btnTimkiemtacgia.Size = new System.Drawing.Size(30, 27);
            this.btnTimkiemtacgia.TabIndex = 1;
            this.btnTimkiemtacgia.Click += new System.EventHandler(this.btnTimkiemtacgia_Click);
            // 
            // txtTimkiemtacgia
            // 
            this.txtTimkiemtacgia.BorderRadius = 8;
            this.txtTimkiemtacgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemtacgia.DefaultText = "";
            this.txtTimkiemtacgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiemtacgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiemtacgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemtacgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemtacgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemtacgia.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtTimkiemtacgia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimkiemtacgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemtacgia.Location = new System.Drawing.Point(25, 22);
            this.txtTimkiemtacgia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiemtacgia.Name = "txtTimkiemtacgia";
            this.txtTimkiemtacgia.PasswordChar = '\0';
            this.txtTimkiemtacgia.PlaceholderText = "Nhập tên tác giả";
            this.txtTimkiemtacgia.SelectedText = "";
            this.txtTimkiemtacgia.Size = new System.Drawing.Size(326, 36);
            this.txtTimkiemtacgia.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.datagridviewTacgia);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 76);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(816, 401);
            this.guna2Panel2.TabIndex = 1;
            // 
            // datagridviewTacgia
            // 
            this.datagridviewTacgia.AllowUserToAddRows = false;
            this.datagridviewTacgia.AllowUserToDeleteRows = false;
            this.datagridviewTacgia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridviewTacgia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewTacgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewTacgia.ColumnHeadersHeight = 35;
            this.datagridviewTacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewTacgia.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewTacgia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewTacgia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewTacgia.Location = new System.Drawing.Point(0, 0);
            this.datagridviewTacgia.Name = "datagridviewTacgia";
            this.datagridviewTacgia.ReadOnly = true;
            this.datagridviewTacgia.RowHeadersVisible = false;
            this.datagridviewTacgia.RowHeadersWidth = 51;
            this.datagridviewTacgia.RowTemplate.Height = 30;
            this.datagridviewTacgia.Size = new System.Drawing.Size(816, 401);
            this.datagridviewTacgia.TabIndex = 0;
            this.datagridviewTacgia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewTacgia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridviewTacgia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridviewTacgia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridviewTacgia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridviewTacgia.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewTacgia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewTacgia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridviewTacgia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewTacgia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridviewTacgia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridviewTacgia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridviewTacgia.ThemeStyle.HeaderStyle.Height = 35;
            this.datagridviewTacgia.ThemeStyle.ReadOnly = true;
            this.datagridviewTacgia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewTacgia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridviewTacgia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridviewTacgia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridviewTacgia.ThemeStyle.RowsStyle.Height = 30;
            this.datagridviewTacgia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewTacgia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_TacgiasachEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_TacgiasachEmployee";
            this.Size = new System.Drawing.Size(816, 477);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewTacgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView datagridviewTacgia;
        private Guna.UI2.WinForms.Guna2Button btnTimkiemtacgia;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemtacgia;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
    }
}
