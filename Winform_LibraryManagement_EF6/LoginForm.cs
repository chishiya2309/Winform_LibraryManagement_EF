using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class LoginForm : Form
    {
        // Biến lưu giá trị đã chọn của ComboBox
        private string selectedUserType = string.Empty;
        public LoginForm()
        {
            InitializeComponent();

            this.Tag = new LoginControls
            {
                UsernameTextBox = txtUsername,
                PasswordTextBox = txtPassword,
                RememberMeCheckBox = rememberMeCheckBox,
                ErrorLabel = errorLabel,
                ForgotPasswordLink = forgotPasswordLink,
                LoginPanel = loginPanel,
                OptionsPanel = optionsPanel
            };
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Kiểm tra nếu có thông tin đăng nhập đã lưu
            LoadSavedCredentials();
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ với quản trị viên hệ thống để đặt lại mật khẩu của bạn.",
                "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var controls = (LoginControls)this.Tag;

            string staffId = controls.UsernameTextBox.Text.Trim();
            string password = controls.PasswordTextBox.Text;

            if (string.IsNullOrEmpty(staffId) || string.IsNullOrEmpty(password))
            {
                controls.ErrorLabel.Text = "Vui lòng nhập đầy đủ mã nhân viên và mật khẩu!";
                return;
            }

            // Attempt to authenticate
            if (AuthenticateLibraryStaff(staffId, password))
            {
                // Save user preferences if remember me is checked
                if (controls.RememberMeCheckBox.Checked)
                {
                    SaveStaffCredentials(staffId);
                }

                // Show success message
                MessageBox.Show($"Đăng nhập thành công! Chào mừng đến với Hệ thống quản lý thư viện.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminMainForm mainForm = new AdminMainForm();
                mainForm.Show();


                this.Hide();
            }
            else
            {
                controls.ErrorLabel.Text = "ID nhân viên hoặc mật khẩu không chính xác. Vui lòng thử lại!";
            }
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            // Get our control references
            var controls = (LoginControls)this.Tag;

            // Reposition the forgot password link on resize
            if (controls.OptionsPanel != null && controls.ForgotPasswordLink != null)
            {
                controls.ForgotPasswordLink.Left = controls.OptionsPanel.Width - controls.ForgotPasswordLink.Width - 5;
            }

            // Adjust login panel height based on form size (keeping it proportional)
            if (controls.LoginPanel != null)
            {
                int desiredHeight = (int)(this.ClientSize.Height * 0.7);
                controls.LoginPanel.Height = Math.Min(desiredHeight, 600); // Cap the height
            }

            // Ensure the header panel is at the top
            if (headerPanel != null)
            {
                headerPanel.SendToBack();

                // Scale header height based on screen size
                headerPanel.Height = Math.Max(80, (int)(this.ClientSize.Height * 0.1));

                // Update header font size based on form width
                if (headerPanel.Controls.Count > 0 && headerPanel.Controls[0] is Label headerLabel)
                {
                    if (this.Width > 1920)
                        headerLabel.Font = new Font("Georgia", 32, FontStyle.Bold);
                    else if (this.Width > 1366)
                        headerLabel.Font = new Font("Georgia", 28, FontStyle.Bold);
                    else if (this.Width > 1024)
                        headerLabel.Font = new Font("Georgia", 24, FontStyle.Bold);
                    else
                        headerLabel.Font = new Font("Georgia", 20, FontStyle.Bold);
                }
            }

            // Ensure main layout is on top
            if (mainTableLayoutPanel != null)
            {
                mainTableLayoutPanel.BringToFront();
                mainTableLayoutPanel.Top = headerPanel.Bottom;
                mainTableLayoutPanel.Height = this.ClientSize.Height - headerPanel.Height;
            }
        }

        private class LoginControls
        {
            public TextBox UsernameTextBox { get; set; }
            public TextBox PasswordTextBox { get; set; }
            public CheckBox RememberMeCheckBox { get; set; }
            public Label ErrorLabel { get; set; }
            public LinkLabel ForgotPasswordLink { get; set; }
            public Panel LoginPanel { get; set; }
            public Panel OptionsPanel { get; set; }
        }

        #region Authentication Methods

        private bool AuthenticateLibraryStaff(string staffId, string password)
        {
            return (staffId == "admin" && password == "admin");
        }

        private void SaveStaffCredentials(string staffId)
        {
            // TODO: Implement secure credential storage
            // For demonstration purposes, we'll use Properties.Settings
            // In a real application, use secure storage methods

            // Example code (requires adding settings to project):
            Properties.Settings.Default.LastUsername = staffId;
            Properties.Settings.Default.RememberMe = true;
            Properties.Settings.Default.Save();
        }

        private void LoadSavedCredentials()
        {
            // TODO: Implement loading saved credentials
            // This would check if RememberMe was enabled previously
            // and load the saved username

            // Example code:
            if (Properties.Settings.Default.RememberMe)
            {
                var controls = (LoginControls)this.Tag;
                controls.UsernameTextBox.Text = Properties.Settings.Default.LastUsername;
                controls.RememberMeCheckBox.Checked = true;
            }
        }

        #endregion

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
