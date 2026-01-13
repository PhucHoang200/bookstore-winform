using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI.UserControl_Admin
{

    public partial class UC_SachAdmin : UserControl
    {


        public UC_SachAdmin()
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
            UC_Theloaisachadmin uC_Theloaisachadmin = new UC_Theloaisachadmin();
            AddControlsToPanel(uC_Theloaisachadmin);
        }

        private void btnTacgia_Click(object sender, EventArgs e)
        {
            UC_Tacgiasachadmin uC_Tacgiasachadmin = new UC_Tacgiasachadmin();
            AddControlsToPanel(uC_Tacgiasachadmin);
        }

        private void btnNhaxuatban_Click(object sender, EventArgs e)
        {
            UC_Nxbsachadmin uC_Nxbsachadmin = new UC_Nxbsachadmin();
            AddControlsToPanel(uC_Nxbsachadmin);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            UC_Sachsachadmin uC_Sachsachadmin = new UC_Sachsachadmin();
            AddControlsToPanel(uC_Sachsachadmin);
        }

        private void btnChiTietSachTrongKho_Click(object sender, EventArgs e)
        {
            UC_ChiTietSachTrongKho uC_ChiTietSachTrongKho = new UC_ChiTietSachTrongKho();
            AddControlsToPanel(uC_ChiTietSachTrongKho);
        }
    }
}
