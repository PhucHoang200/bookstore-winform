using GUI.UserControl_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControl_Employee
{
    public partial class UC_SachEmployee : UserControl
    {
        public UC_SachEmployee()
        {
            InitializeComponent();
            btnLoaisach.Checked = true;
            btnLoaisach_Click(this, EventArgs.Empty);
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(c);
        }

        private void btnLoaisach_Click(object sender, EventArgs e)
        {
            UC_TheloaisachEmployee uC_TheloaisachEmployee = new UC_TheloaisachEmployee();
            AddControlsToPanel(uC_TheloaisachEmployee);
        }

        private void btnTacgia_Click(object sender, EventArgs e)
        {
            UC_TacgiasachEmployee uC_TacgiasachEmployee = new UC_TacgiasachEmployee();
            AddControlsToPanel(uC_TacgiasachEmployee);
        }

        private void btnNhaxuatban_Click(object sender, EventArgs e)
        {
            UC_NxbsachEmployee uC_NxbsachEmployee = new UC_NxbsachEmployee();
            AddControlsToPanel(uC_NxbsachEmployee);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            UC_Sachsachadmin uC_Sachsachadmin = new UC_Sachsachadmin();
            AddControlsToPanel(uC_Sachsachadmin);
        }
    }
}
