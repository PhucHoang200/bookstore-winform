namespace GUI.UserControl_Admin
{
    partial class UC_ThongkeAdmin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXuatThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewReport = new Guna.UI2.WinForms.Guna2Button();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.chartEmployeePerformance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCategoryRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeePerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnXuatThongKe);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnViewReport);
            this.guna2Panel1.Controls.Add(this.dtpEndDate);
            this.guna2Panel1.Controls.Add(this.dtpStartDate);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1580, 119);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnXuatThongKe
            // 
            this.btnXuatThongKe.BorderRadius = 8;
            this.btnXuatThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatThongKe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnXuatThongKe.ForeColor = System.Drawing.Color.White;
            this.btnXuatThongKe.Image = global::GUI.Properties.Resources.paper1;
            this.btnXuatThongKe.Location = new System.Drawing.Point(347, 57);
            this.btnXuatThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatThongKe.Name = "btnXuatThongKe";
            this.btnXuatThongKe.Size = new System.Drawing.Size(328, 44);
            this.btnXuatThongKe.TabIndex = 8;
            this.btnXuatThongKe.Text = "Xuất dữ liệu thống kê";
            this.btnXuatThongKe.Click += new System.EventHandler(this.btnXuatThongKe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1067, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 33);
            this.label1.TabIndex = 5;
            // 
            // btnViewReport
            // 
            this.btnViewReport.BorderRadius = 8;
            this.btnViewReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewReport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnViewReport.ForeColor = System.Drawing.Color.White;
            this.btnViewReport.Image = global::GUI.Properties.Resources.salary1;
            this.btnViewReport.Location = new System.Drawing.Point(28, 57);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(298, 44);
            this.btnViewReport.TabIndex = 3;
            this.btnViewReport.Text = "Xem dữ liệu thống kê";
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 8;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(596, 16);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(267, 33);
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
            this.dtpStartDate.Location = new System.Drawing.Point(132, 16);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(267, 33);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.Value = new System.DateTime(2025, 1, 5, 20, 5, 27, 914);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.chartEmployeePerformance);
            this.guna2Panel2.Controls.Add(this.chartCategoryRevenue);
            this.guna2Panel2.Controls.Add(this.chartRevenue);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 119);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1580, 792);
            this.guna2Panel2.TabIndex = 2;
            // 
            // chartEmployeePerformance
            // 
            chartArea1.Name = "ChartArea3";
            this.chartEmployeePerformance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEmployeePerformance.Legends.Add(legend1);
            this.chartEmployeePerformance.Location = new System.Drawing.Point(52, 324);
            this.chartEmployeePerformance.Margin = new System.Windows.Forms.Padding(4);
            this.chartEmployeePerformance.Name = "chartEmployeePerformance";
            this.chartEmployeePerformance.Size = new System.Drawing.Size(1528, 468);
            this.chartEmployeePerformance.TabIndex = 6;
            // 
            // chartCategoryRevenue
            // 
            chartArea2.Name = "ChartArea2";
            this.chartCategoryRevenue.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCategoryRevenue.Legends.Add(legend2);
            this.chartCategoryRevenue.Location = new System.Drawing.Point(801, 0);
            this.chartCategoryRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.chartCategoryRevenue.Name = "chartCategoryRevenue";
            this.chartCategoryRevenue.Size = new System.Drawing.Size(779, 324);
            this.chartCategoryRevenue.TabIndex = 5;
            // 
            // chartRevenue
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend3);
            this.chartRevenue.Location = new System.Drawing.Point(0, 0);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(791, 324);
            this.chartRevenue.TabIndex = 4;
            // 
            // UC_ThongkeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongkeAdmin";
            this.Size = new System.Drawing.Size(1580, 911);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeePerformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnXuatThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnViewReport;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployeePerformance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoryRevenue;
    }
}
