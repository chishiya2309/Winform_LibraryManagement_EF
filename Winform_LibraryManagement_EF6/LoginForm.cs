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

            if (AuthenticateLibraryStaff(staffId, password))
            {
                if (controls.RememberMeCheckBox.Checked)
                {
                    SaveStaffCredentials(staffId);
                }
                else
                {
                    ClearSavedCredentials(); // XÓA dữ liệu nếu bỏ chọn
                }

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
            var controls = (LoginControls)this.Tag;

            if (controls.OptionsPanel != null && controls.ForgotPasswordLink != null)
            {
                controls.ForgotPasswordLink.Left = controls.OptionsPanel.Width - controls.ForgotPasswordLink.Width - 5;
            }

            if (controls.LoginPanel != null)
            {
                int desiredHeight = (int)(this.ClientSize.Height * 0.7);
                controls.LoginPanel.Height = Math.Min(desiredHeight, 600);
            }

            if (headerPanel != null)
            {
                headerPanel.SendToBack();
                headerPanel.Height = Math.Max(80, (int)(this.ClientSize.Height * 0.1));

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
            Properties.Settings.Default.LastUsername = staffId;
            Properties.Settings.Default.RememberMe = true;
            Properties.Settings.Default.Save();
        }

        private void ClearSavedCredentials()
        {
            Properties.Settings.Default.LastUsername = string.Empty;
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.Save();
        }

        private void LoadSavedCredentials()
        {
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
