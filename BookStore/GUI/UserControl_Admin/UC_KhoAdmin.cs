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
    public partial class UC_KhoAdmin : UserControl
    {
        public UC_KhoAdmin()
        {
            InitializeComponent();
            btnNhaCungCap.Checked = true;
            btnNhaCungCap_Click(this, EventArgs.Empty);
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(c);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            UC_NhacungcapAdmin uC_NhacungcapAdmin = new UC_NhacungcapAdmin();
            AddControlsToPanel(uC_NhacungcapAdmin);
        }

        private void btnNhapSachMoi_Click(object sender, EventArgs e)
        {
            UC_NhapSachMoiAdmin uC_NhapSachMoiAdmin = new UC_NhapSachMoiAdmin();
            AddControlsToPanel(uC_NhapSachMoiAdmin);
        }

        private void btnNhapSachDaCo_Click(object sender, EventArgs e)
        {
            UC_NhapSachDaCo uC_NhapSachDaCo = new UC_NhapSachDaCo();
            AddControlsToPanel(uC_NhapSachDaCo);
        }

        private void btnDSPhieuNhap_Click(object sender, EventArgs e)
        {
            UC_DsPhieunhapAdmin uC_DsPhieunhapAdmin = new UC_DsPhieunhapAdmin();
            AddControlsToPanel(uC_DsPhieunhapAdmin);
        }

        private void btnChiTietSach_Click(object sender, EventArgs e)
        {
            UC_ChiTietSachTrongKho uC_ChiTietSachTrongKho = new UC_ChiTietSachTrongKho();
            AddControlsToPanel(uC_ChiTietSachTrongKho);
        }
    }
}
