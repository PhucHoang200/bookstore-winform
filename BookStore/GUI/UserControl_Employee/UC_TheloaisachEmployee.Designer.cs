namespace GUI.UserControl_Employee
{
    partial class UC_TheloaisachEmployee
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
            this.btnTimkiemtheloai = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiemtheloai = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.datagridviewTheloai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewTheloai)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnRefesh);
            this.guna2Panel1.Controls.Add(this.btnTimkiemtheloai);
            this.guna2Panel1.Controls.Add(this.txtTimkiemtheloai);
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
            this.btnRefesh.Location = new System.Drawing.Point(381, 22);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(24, 36);
            this.btnRefesh.TabIndex = 2;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnTimkiemtheloai
            // 
            this.btnTimkiemtheloai.BorderRadius = 8;
            this.btnTimkiemtheloai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemtheloai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiemtheloai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiemtheloai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiemtheloai.FillColor = System.Drawing.Color.White;
            this.btnTimkiemtheloai.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnTimkiemtheloai.ForeColor = System.Drawing.Color.White;
            this.btnTimkiemtheloai.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.btnTimkiemtheloai.Location = new System.Drawing.Point(332, 28);
            this.btnTimkiemtheloai.Name = "btnTimkiemtheloai";
            this.btnTimkiemtheloai.Size = new System.Drawing.Size(30, 27);
            this.btnTimkiemtheloai.TabIndex = 1;
            this.btnTimkiemtheloai.Click += new System.EventHandler(this.btnTimkiemtheloai_Click);
            // 
            // txtTimkiemtheloai
            // 
            this.txtTimkiemtheloai.BorderRadius = 8;
            this.txtTimkiemtheloai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemtheloai.DefaultText = "";
            this.txtTimkiemtheloai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiemtheloai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiemtheloai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemtheloai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemtheloai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemtheloai.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtTimkiemtheloai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimkiemtheloai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemtheloai.Location = new System.Drawing.Point(25, 22);
            this.txtTimkiemtheloai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiemtheloai.Name = "txtTimkiemtheloai";
            this.txtTimkiemtheloai.PasswordChar = '\0';
            this.txtTimkiemtheloai.PlaceholderText = "Nhập tên thể loại";
            this.txtTimkiemtheloai.SelectedText = "";
            this.txtTimkiemtheloai.Size = new System.Drawing.Size(340, 36);
            this.txtTimkiemtheloai.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.datagridviewTheloai);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 76);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(816, 401);
            this.guna2Panel2.TabIndex = 1;
            // 
            // datagridviewTheloai
            // 
            this.datagridviewTheloai.AllowUserToAddRows = false;
            this.datagridviewTheloai.AllowUserToDeleteRows = false;
            this.datagridviewTheloai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridviewTheloai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewTheloai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewTheloai.ColumnHeadersHeight = 35;
            this.datagridviewTheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewTheloai.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewTheloai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewTheloai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewTheloai.Location = new System.Drawing.Point(0, 0);
            this.datagridviewTheloai.Name = "datagridviewTheloai";
            this.datagridviewTheloai.ReadOnly = true;
            this.datagridviewTheloai.RowHeadersVisible = false;
            this.datagridviewTheloai.RowHeadersWidth = 51;
            this.datagridviewTheloai.RowTemplate.Height = 30;
            this.datagridviewTheloai.Size = new System.Drawing.Size(816, 401);
            this.datagridviewTheloai.TabIndex = 0;
            this.datagridviewTheloai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewTheloai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridviewTheloai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridviewTheloai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridviewTheloai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridviewTheloai.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewTheloai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewTheloai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridviewTheloai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewTheloai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridviewTheloai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridviewTheloai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridviewTheloai.ThemeStyle.HeaderStyle.Height = 35;
            this.datagridviewTheloai.ThemeStyle.ReadOnly = true;
            this.datagridviewTheloai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridviewTheloai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridviewTheloai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridviewTheloai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridviewTheloai.ThemeStyle.RowsStyle.Height = 30;
            this.datagridviewTheloai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridviewTheloai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_TheloaisachEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_TheloaisachEmployee";
            this.Size = new System.Drawing.Size(816, 477);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewTheloai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemtheloai;
        private Guna.UI2.WinForms.Guna2Button btnTimkiemtheloai;
        private Guna.UI2.WinForms.Guna2DataGridView datagridviewTheloai;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
    }
}
