using System.Drawing;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.formLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLable = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.formLayoutPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.Controls.Add(this.loginPanel, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 100);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(900, 561);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.formLayoutPanel);
            this.loginPanel.Controls.Add(this.titlePanel);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPanel.Location = new System.Drawing.Point(228, 3);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Padding = new System.Windows.Forms.Padding(40);
            this.loginPanel.Size = new System.Drawing.Size(444, 455);
            this.loginPanel.TabIndex = 0;
            // 
            // formLayoutPanel
            // 
            this.formLayoutPanel.AutoSize = true;
            this.formLayoutPanel.ColumnCount = 1;
            this.formLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formLayoutPanel.Controls.Add(this.usernameLabel);
            this.formLayoutPanel.Controls.Add(this.txtUsername);
            this.formLayoutPanel.Controls.Add(this.passwordLabel);
            this.formLayoutPanel.Controls.Add(this.txtPassword);
            this.formLayoutPanel.Controls.Add(this.optionsPanel, 0, 6);
            this.formLayoutPanel.Controls.Add(this.btnLogin, 0, 7);
            this.formLayoutPanel.Controls.Add(this.errorLabel, 0, 8);
            this.formLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formLayoutPanel.Location = new System.Drawing.Point(40, 120);
            this.formLayoutPanel.Name = "formLayoutPanel";
            this.formLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.formLayoutPanel.RowCount = 9;
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.Size = new System.Drawing.Size(364, 265);
            this.formLayoutPanel.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(23, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(68, 18);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Staff ID:";
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(20, 23);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(324, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(23, 64);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 18);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(20, 87);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(324, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.forgotPasswordLink);
            this.optionsPanel.Controls.Add(this.rememberMeCheckBox);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPanel.Location = new System.Drawing.Point(23, 131);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(318, 30);
            this.optionsPanel.TabIndex = 4;
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.forgotPasswordLink.Location = new System.Drawing.Point(201, 6);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(117, 16);
            this.forgotPasswordLink.TabIndex = 1;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forgot Password?";
            this.forgotPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLink_LinkClicked);
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMeCheckBox.Location = new System.Drawing.Point(0, 5);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(141, 20);
            this.rememberMeCheckBox.TabIndex = 0;
            this.rememberMeCheckBox.Text = "Remember staff ID";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(20, 184);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0, 20, 0, 15);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(324, 50);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(23, 249);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(318, 16);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.White;
            this.titlePanel.Controls.Add(this.loginLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(40, 40);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.titlePanel.Size = new System.Drawing.Size(364, 80);
            this.titlePanel.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.loginLabel.Location = new System.Drawing.Point(0, 10);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(147, 29);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Staff Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(119)))), ((int)(((byte)(58)))));
            this.headerPanel.Controls.Add(this.titleLable);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 100);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLable
            // 
            this.titleLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.titleLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLable.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.Color.White;
            this.titleLable.Location = new System.Drawing.Point(0, 0);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(900, 100);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "LIBRARY MANAGEMENT SYSTEM";
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.versionLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.Gray;
            this.versionLabel.Location = new System.Drawing.Point(0, 626);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.versionLabel.Size = new System.Drawing.Size(208, 35);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Library Management System v1.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(900, 661);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.headerPanel);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Resize += new System.EventHandler(this.LoginForm_Resize);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.formLayoutPanel.ResumeLayout(false);
            this.formLayoutPanel.PerformLayout();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel headerPanel;
        private Label titleLable;
        private Panel loginPanel;
        private Panel titlePanel;
        private Label loginLabel;
        private TableLayoutPanel formLayoutPanel;
        private Label usernameLabel;
        private TextBox txtUsername;
        private Label passwordLabel;
        private TextBox txtPassword;
        private Panel optionsPanel;
        private CheckBox rememberMeCheckBox;
        private LinkLabel forgotPasswordLink;
        private Button btnLogin;
        private Label errorLabel;
        private Label versionLabel;
    }
}