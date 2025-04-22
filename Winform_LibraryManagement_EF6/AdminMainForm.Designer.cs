using System.Drawing;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    partial class AdminMainForm
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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.buttonContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnLoanAndReturn = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainLayout.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.buttonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.headerPanel, 0, 0);
            this.mainLayout.Controls.Add(this.sidebarPanel, 0, 1);
            this.mainLayout.Controls.Add(this.contentPanel, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(900, 749);
            this.mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.mainLayout.SetColumnSpan(this.headerPanel, 2);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(894, 64);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.headerLabel.Size = new System.Drawing.Size(371, 37);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Hệ thống quản lý thư viện";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sidebarPanel.Controls.Add(this.buttonContainer);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarPanel.Location = new System.Drawing.Point(3, 73);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(214, 673);
            this.sidebarPanel.TabIndex = 1;
            // 
            // buttonContainer
            // 
            this.buttonContainer.AutoScroll = true;
            this.buttonContainer.Controls.Add(this.profilePanel);
            this.buttonContainer.Controls.Add(this.btnDashboard);
            this.buttonContainer.Controls.Add(this.btnBooks);
            this.buttonContainer.Controls.Add(this.btnCategories);
            this.buttonContainer.Controls.Add(this.btnMembers);
            this.buttonContainer.Controls.Add(this.btnStaff);
            this.buttonContainer.Controls.Add(this.btnLoanAndReturn);
            this.buttonContainer.Controls.Add(this.btnReports);
            this.buttonContainer.Controls.Add(this.btnLogout);
            this.buttonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonContainer.Location = new System.Drawing.Point(0, 0);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.buttonContainer.Size = new System.Drawing.Size(214, 673);
            this.buttonContainer.TabIndex = 0;
            this.buttonContainer.WrapContents = false;
            // 
            // profilePanel
            // 
            this.profilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.profilePanel.Location = new System.Drawing.Point(10, 20);
            this.profilePanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(200, 120);
            this.profilePanel.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(10, 165);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Trang chính";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Location = new System.Drawing.Point(10, 220);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBooks.Size = new System.Drawing.Size(200, 45);
            this.btnBooks.TabIndex = 3;
            this.btnBooks.Text = "Quản lý sách";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(10, 275);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(200, 45);
            this.btnCategories.TabIndex = 5;
            this.btnCategories.Text = "Quản lý danh mục";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Location = new System.Drawing.Point(10, 330);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(200, 45);
            this.btnMembers.TabIndex = 4;
            this.btnMembers.Text = "Quản lý thành viên";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Location = new System.Drawing.Point(10, 385);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(200, 45);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Quản lý nhân viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnLoanAndReturn
            // 
            this.btnLoanAndReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoanAndReturn.FlatAppearance.BorderSize = 0;
            this.btnLoanAndReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnLoanAndReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.btnLoanAndReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanAndReturn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanAndReturn.ForeColor = System.Drawing.Color.White;
            this.btnLoanAndReturn.Location = new System.Drawing.Point(10, 440);
            this.btnLoanAndReturn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnLoanAndReturn.Name = "btnLoanAndReturn";
            this.btnLoanAndReturn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLoanAndReturn.Size = new System.Drawing.Size(200, 45);
            this.btnLoanAndReturn.TabIndex = 10;
            this.btnLoanAndReturn.Text = "Quản lý mượn / trả sách";
            this.btnLoanAndReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoanAndReturn.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(10, 495);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(200, 45);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Báo cáo và thống kê";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 550);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(223, 73);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.contentPanel.Size = new System.Drawing.Size(674, 673);
            this.contentPanel.TabIndex = 2;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 749);
            this.Controls.Add(this.mainLayout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(754, 576);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMainForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.mainLayout.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.buttonContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private Panel sidebarPanel;
        private Panel contentPanel;
        private FlowLayoutPanel buttonContainer;
        private Panel profilePanel;
        private Button btnDashboard;
        private Button btnStaff;
        private Button btnBooks;
        private Button btnMembers;
        private Button btnCategories;
        private Button btnReports;
        private Button btnLogout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnLoanAndReturn;
    }
}