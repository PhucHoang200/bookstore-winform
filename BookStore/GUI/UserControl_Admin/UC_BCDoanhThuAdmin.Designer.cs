namespace GUI.UserControl_Admin
{
    partial class UC_BCDoanhThuAdmin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnXuatBCDoanhThu = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewReport = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnXuatBCDoanhThu);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnViewReport);
            this.guna2Panel1.Controls.Add(this.dtpEndDate);
            this.guna2Panel1.Controls.Add(this.dtpStartDate);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1185, 97);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 27);
            this.label1.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 8;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(447, 13);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 27);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.Value = new System.DateTime(2025, 1, 5, 20, 5, 27, 914);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderRadius = 8;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(99, 13);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 27);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.Value = new System.DateTime(2025, 1, 5, 20, 5, 27, 914);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.chartRevenue);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 97);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1185, 643);
            this.guna2Panel2.TabIndex = 1;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(0, 0);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(1185, 643);
            this.chartRevenue.TabIndex = 4;
            // 
            // btnXuatBCDoanhThu
            // 
            this.btnXuatBCDoanhThu.BorderRadius = 8;
            this.btnXuatBCDoanhThu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatBCDoanhThu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatBCDoanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatBCDoanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatBCDoanhThu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnXuatBCDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnXuatBCDoanhThu.Image = global::GUI.Properties.Resources.paper;
            this.btnXuatBCDoanhThu.Location = new System.Drawing.Point(237, 46);
            this.btnXuatBCDoanhThu.Name = "btnXuatBCDoanhThu";
            this.btnXuatBCDoanhThu.Size = new System.Drawing.Size(255, 36);
            this.btnXuatBCDoanhThu.TabIndex = 8;
            this.btnXuatBCDoanhThu.Text = "Xuất báo cáo doanh thu";
            this.btnXuatBCDoanhThu.Click += new System.EventHandler(this.btnXuatBCDoanhThu_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.BorderRadius = 8;
            this.btnViewReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewReport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.ForeColor = System.Drawing.Color.White;
            this.btnViewReport.Image = global::GUI.Properties.Resources.salary;
            this.btnViewReport.Location = new System.Drawing.Point(21, 46);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(180, 36);
            this.btnViewReport.TabIndex = 3;
            this.btnViewReport.Text = "Xem doanh thu";
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // UC_BCDoanhThuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_BCDoanhThuAdmin";
            this.Size = new System.Drawing.Size(1185, 740);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2Button btnViewReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnXuatBCDoanhThu;
    }
}
