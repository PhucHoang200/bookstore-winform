using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using GUI.UserControl_Admin;

namespace GUI
{
    public partial class fDashboardAdmin : Form
    {
        private LoginViewModel currentUser;
        public fDashboardAdmin(LoginViewModel user)
        {
            InitializeComponent();
            currentUser = user;
        }
        public fDashboardAdmin()
        {
            InitializeComponent();
            
        }

        private void fDashboardAdmin_Load(object sender, EventArgs e)
        {
            // Khởi tạo Timer
            Timer timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi 1 giây
            timer.Tick += Timer_Tick;
            timer.Start();
            label1.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy hh:mm:ss tt");
            AddHomeAdminControl();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật ngày giờ hiện tại vào Label
            label1.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy hh:mm:ss tt");
        }

        private void AddHomeAdminControl()
        {
            UC_HomeAdmin uC_HomeAdmin = new UC_HomeAdmin(currentUser);
            AddControlsToPanel(uC_HomeAdmin);
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock= DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                // Tạo và hiển thị lại form Login
                fLogin loginForm = new fLogin(); // Tên form Login
                loginForm.Show();

                // Đóng form hiện tại
                this.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_HomeAdmin uC_HomeAdmin = new UC_HomeAdmin(currentUser);
            AddControlsToPanel(uC_HomeAdmin);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSach);
            UC_SachAdmin uC_SachAdmin = new UC_SachAdmin();
            AddControlsToPanel(uC_SachAdmin);
        }

        private void btnDonhang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDonhang);
            UC_QLDonhangAdmin uC_QLDonhangAdmin = new UC_QLDonhangAdmin(currentUser);
            AddControlsToPanel(uC_QLDonhangAdmin);
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnKhachhang);
            UC_KhachhangAdmin uC_KhachhangAdmin = new UC_KhachhangAdmin();
            AddControlsToPanel(uC_KhachhangAdmin);
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTaikhoan);
            UC_TaikhoanAdmin uC_TaikhoanAdmin = new UC_TaikhoanAdmin(); 
            AddControlsToPanel(uC_TaikhoanAdmin);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnKho);
            UC_KhoAdmin uC_KhoAdmin = new UC_KhoAdmin();
            AddControlsToPanel(uC_KhoAdmin);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnThongke);
            UC_ThongkeAdmin uC_ThongkeAdmin = new UC_ThongkeAdmin();
            AddControlsToPanel(uC_ThongkeAdmin);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDoanhThu);
            UC_BCDoanhThuAdmin uC_BCDoanhThuAdmin = new UC_BCDoanhThuAdmin();
            AddControlsToPanel(uC_BCDoanhThuAdmin);
        }
    }
}
