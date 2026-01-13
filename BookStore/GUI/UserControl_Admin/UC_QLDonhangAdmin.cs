using DTO;
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
    public partial class UC_QLDonhangAdmin : UserControl
    {
        private LoginViewModel _currentUser;
        public UC_QLDonhangAdmin(LoginViewModel loginViewModel)
        {
            InitializeComponent();
            _currentUser = loginViewModel;
            btnDonhangmoi.Checked = true;
            btnDonhangmoi_Click(this, EventArgs.Empty);
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(c);
        }

        private void btnDonhangmoi_Click(object sender, EventArgs e)
        {
            UC_DonhangAdmin uC_DonhangAdmin = new UC_DonhangAdmin(_currentUser);
            AddControlsToPanel(uC_DonhangAdmin);
        }

        private void btnDanhsachdonhang_Click(object sender, EventArgs e)
        {
            UC_DsDonhangAdmin uC_DsDonhangAdmin = new UC_DsDonhangAdmin();
            AddControlsToPanel(uC_DsDonhangAdmin);
        }
    }
}
