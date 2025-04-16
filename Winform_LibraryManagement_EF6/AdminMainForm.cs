using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;
using DataAccessLayer;
using Winform_LibraryManagement_EF6;
namespace Winform_LibraryManagement_EF6
{
    public partial class AdminMainForm : Form
    {
        private Panel currentPanel = null;
        private Dictionary<Button, UserControl> menuMapping;

        private void LoadUserControl(UserControl uc)
        {
            contentPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(uc);
        }

        public AdminMainForm()
        {
            InitializeComponent(); ;
            this.Text = "Hệ thống Quản lý Thư viện";
            LoadUserControl(new AdminControl_Dashboard());
            Adjust();
            // Khởi tạo danh sách Button - UserControl
            menuMapping = new Dictionary<Button, UserControl>()
            {
                { btnDashboard, new AdminControl_Dashboard() },
                //{ btnStaff, new AdminControl_Staff() },
                //{btnBooks, new AdminControl_Books()},
                //{btnMembers, new AdminControl_Member() },
                {btnCategories, new  AdminControl_Categories()},
                //{btnReports, new AdminControl_Reports() },
                //{btnLoanAndReturn, new AdminControl_LoanAndReturn() }
            };
        }

        private void HandleMenuClick(Button clickedButton)
        {
            // Đổi màu tất cả các nút về màu mặc định
            foreach (var btn in menuMapping.Keys)
            {
                btn.BackColor = Color.FromArgb(45, 45, 48);
            }

            // Đổi màu nút đang được chọn
            clickedButton.BackColor = Color.FromArgb(76, 40, 130);

            // Load UserControl tương ứng
            LoadUserControl(menuMapping[clickedButton]);
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void Adjust()
        {
            headerLabel.Location = new Point(20, (headerPanel.Height - headerLabel.Height) / 2);
            profilePanel.Width = sidebarPanel.Width - 20;
            btnBooks.Width = sidebarPanel.Width - 20;
            btnCategories.Width = sidebarPanel.Width - 20;
            btnLogout.Width = sidebarPanel.Width - 20;
            btnMembers.Width = sidebarPanel.Width - 20;
            btnReports.Width = sidebarPanel.Width - 20;
            btnStaff.Width = sidebarPanel.Width - 20;
            btnDashboard.Width = sidebarPanel.Width - 20;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HandleMenuClick(btnDashboard);
        }

        private void AdminMainForm_Resize(object sender, EventArgs e)
        {
            Adjust();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            HandleMenuClick(btnStaff);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            HandleMenuClick(btnBooks);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            HandleMenuClick(btnMembers);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            HandleMenuClick(btnCategories);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            HandleMenuClick(btnReports);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide(); // Ẩn form hiện tại, không đóng ứng dụng
            }
        }

        private void btnLoanAndReturn_Click(object sender, EventArgs e)
        {
            HandleMenuClick(btnLoanAndReturn);
        }

        private void AdminMainForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
