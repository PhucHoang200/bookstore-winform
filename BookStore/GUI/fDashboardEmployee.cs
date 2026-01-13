using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using GUI.UserControl_Admin;
using GUI.UserControl_Employee;

namespace GUI
{
    public partial class fDashboardEmployee : Form
    {
        private LoginViewModel currentUser;

        // Constructor thêm mới
        public fDashboardEmployee(LoginViewModel user)
        {
            InitializeComponent();
            currentUser = user;
        }

        public fDashboardEmployee()
        {
            InitializeComponent();          
        } 

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
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
            UC_SachEmployee uC_SachEmployee=new UC_SachEmployee();
            AddControlsToPanel(uC_SachEmployee );
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
            UC_KhachhangEmployee uC_KhachhangEmployee=new UC_KhachhangEmployee();   
            AddControlsToPanel(uC_KhachhangEmployee );
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

        private void fDashboardEmployee_Load(object sender, EventArgs e)
        {
            // lblTenNhanVien.Text = $"{_viewModel.HoTenNV}";
            // Khởi tạo Timer
            Timer timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi 1 giây
            timer.Tick += Timer_Tick;
            timer.Start();
            label1.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy hh:mm:ss tt");

            UC_HomeAdmin uC_HomeAdmin = new UC_HomeAdmin(currentUser);
            AddControlsToPanel(uC_HomeAdmin);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật ngày giờ hiện tại vào Label
            label1.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy hh:mm:ss tt");
        }

        private void lblTenNhanVien_Click(object sender, EventArgs e)
        {

        }

    }
}
