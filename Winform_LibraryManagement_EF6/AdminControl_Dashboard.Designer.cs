using System;

namespace Winform_LibraryManagement_EF6
{
    partial class AdminControl_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.backupLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.systemStatusLabel = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSachQuaHan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSachTraHomNay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cardBookBorrow = new System.Windows.Forms.Panel();
            this.lblSachMuonHomNay = new System.Windows.Forms.Label();
            this.cardTitleBookBorrow = new System.Windows.Forms.Label();
            this.colorBarBookBorrow = new System.Windows.Forms.Panel();
            this.cardCus = new System.Windows.Forms.Panel();
            this.lblThanhVien = new System.Windows.Forms.Label();
            this.cardTitleCus = new System.Windows.Forms.Label();
            this.colorBarCus = new System.Windows.Forms.Panel();
            this.cardLib = new System.Windows.Forms.Panel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cardTitleBookLib = new System.Windows.Forms.Label();
            this.colorBarLib = new System.Windows.Forms.Panel();
            this.cardBook = new System.Windows.Forms.Panel();
            this.lblSachKhaDung = new System.Windows.Forms.Label();
            this.valueLabelBook = new System.Windows.Forms.Label();
            this.cardTitleBook = new System.Windows.Forms.Label();
            this.colorBarBook = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dashboardPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cardBookBorrow.SuspendLayout();
            this.cardCus.SuspendLayout();
            this.cardLib.SuspendLayout();
            this.cardBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.statusPanel);
            this.dashboardPanel.Controls.Add(this.systemStatusLabel);
            this.dashboardPanel.Controls.Add(this.statsPanel);
            this.dashboardPanel.Controls.Add(this.titleLabel);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(634, 633);
            this.dashboardPanel.TabIndex = 1;
            this.dashboardPanel.VisibleChanged += new System.EventHandler(this.dashboardPanel_VisibleChanged);
            this.dashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboardPanel_Paint);
            this.dashboardPanel.Resize += new System.EventHandler(this.dashboardPanel_Resize);
            // 
            // statusPanel
            // 
            this.statusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusPanel.Controls.Add(this.backupLabel);
            this.statusPanel.Controls.Add(this.label5);
            this.statusPanel.Controls.Add(this.databaseLabel);
            this.statusPanel.Location = new System.Drawing.Point(20, 380);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(464, 200);
            this.statusPanel.TabIndex = 3;
            // 
            // backupLabel
            // 
            this.backupLabel.AutoSize = true;
            this.backupLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupLabel.ForeColor = System.Drawing.Color.Green;
            this.backupLabel.Location = new System.Drawing.Point(20, 78);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(140, 20);
            this.backupLabel.TabIndex = 3;
            this.backupLabel.Text = "Cập nhật lần cuối: ...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phiên bản: Library Management System v1.0";
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseLabel.ForeColor = System.Drawing.Color.Green;
            this.databaseLabel.Location = new System.Drawing.Point(20, 20);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(212, 20);
            this.databaseLabel.TabIndex = 0;
            this.databaseLabel.Text = "Cơ sở dữ liệu: Đang hoạt động";
            // 
            // systemStatusLabel
            // 
            this.systemStatusLabel.AutoSize = true;
            this.systemStatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemStatusLabel.Location = new System.Drawing.Point(20, 340);
            this.systemStatusLabel.Name = "systemStatusLabel";
            this.systemStatusLabel.Size = new System.Drawing.Size(187, 25);
            this.systemStatusLabel.TabIndex = 2;
            this.systemStatusLabel.Text = "Trạng thái hệ thống";
            // 
            // statsPanel
            // 
            this.statsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.statsPanel.ColumnCount = 3;
            this.statsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.statsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.statsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.statsPanel.Controls.Add(this.panel3, 2, 1);
            this.statsPanel.Controls.Add(this.panel1, 1, 1);
            this.statsPanel.Controls.Add(this.cardBookBorrow, 0, 1);
            this.statsPanel.Controls.Add(this.cardCus, 2, 0);
            this.statsPanel.Controls.Add(this.cardLib, 1, 0);
            this.statsPanel.Controls.Add(this.cardBook, 0, 0);
            this.statsPanel.Location = new System.Drawing.Point(20, 70);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.RowCount = 2;
            this.statsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statsPanel.Size = new System.Drawing.Size(464, 243);
            this.statsPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSachQuaHan);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(312, 125);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(148, 114);
            this.panel3.TabIndex = 5;
            // 
            // lblSachQuaHan
            // 
            this.lblSachQuaHan.AutoSize = true;
            this.lblSachQuaHan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSachQuaHan.ForeColor = System.Drawing.Color.Black;
            this.lblSachQuaHan.Location = new System.Drawing.Point(10, 40);
            this.lblSachQuaHan.Name = "lblSachQuaHan";
            this.lblSachQuaHan.Size = new System.Drawing.Size(37, 30);
            this.lblSachQuaHan.TabIndex = 2;
            this.lblSachQuaHan.Text = "28";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sách quá hạn";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 5);
            this.panel4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSachTraHomNay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(158, 125);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(147, 114);
            this.panel1.TabIndex = 4;
            // 
            // lblSachTraHomNay
            // 
            this.lblSachTraHomNay.AutoSize = true;
            this.lblSachTraHomNay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSachTraHomNay.ForeColor = System.Drawing.Color.Black;
            this.lblSachTraHomNay.Location = new System.Drawing.Point(10, 40);
            this.lblSachTraHomNay.Name = "lblSachTraHomNay";
            this.lblSachTraHomNay.Size = new System.Drawing.Size(37, 30);
            this.lblSachTraHomNay.TabIndex = 2;
            this.lblSachTraHomNay.Text = "18";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sách trả hôm nay";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 5);
            this.panel2.TabIndex = 0;
            // 
            // cardBookBorrow
            // 
            this.cardBookBorrow.Controls.Add(this.lblSachMuonHomNay);
            this.cardBookBorrow.Controls.Add(this.cardTitleBookBorrow);
            this.cardBookBorrow.Controls.Add(this.colorBarBookBorrow);
            this.cardBookBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBookBorrow.Location = new System.Drawing.Point(4, 125);
            this.cardBookBorrow.Name = "cardBookBorrow";
            this.cardBookBorrow.Padding = new System.Windows.Forms.Padding(10);
            this.cardBookBorrow.Size = new System.Drawing.Size(147, 114);
            this.cardBookBorrow.TabIndex = 3;
            // 
            // lblSachMuonHomNay
            // 
            this.lblSachMuonHomNay.AutoSize = true;
            this.lblSachMuonHomNay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSachMuonHomNay.ForeColor = System.Drawing.Color.Black;
            this.lblSachMuonHomNay.Location = new System.Drawing.Point(10, 40);
            this.lblSachMuonHomNay.Name = "lblSachMuonHomNay";
            this.lblSachMuonHomNay.Size = new System.Drawing.Size(37, 30);
            this.lblSachMuonHomNay.TabIndex = 2;
            this.lblSachMuonHomNay.Text = "24";
            // 
            // cardTitleBookBorrow
            // 
            this.cardTitleBookBorrow.AutoSize = true;
            this.cardTitleBookBorrow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTitleBookBorrow.ForeColor = System.Drawing.Color.Gray;
            this.cardTitleBookBorrow.Location = new System.Drawing.Point(10, 15);
            this.cardTitleBookBorrow.Name = "cardTitleBookBorrow";
            this.cardTitleBookBorrow.Size = new System.Drawing.Size(117, 15);
            this.cardTitleBookBorrow.TabIndex = 1;
            this.cardTitleBookBorrow.Text = "Sách mượn hôm nay";
            // 
            // colorBarBookBorrow
            // 
            this.colorBarBookBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.colorBarBookBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorBarBookBorrow.Location = new System.Drawing.Point(10, 10);
            this.colorBarBookBorrow.Name = "colorBarBookBorrow";
            this.colorBarBookBorrow.Size = new System.Drawing.Size(127, 5);
            this.colorBarBookBorrow.TabIndex = 0;
            // 
            // cardCus
            // 
            this.cardCus.Controls.Add(this.lblThanhVien);
            this.cardCus.Controls.Add(this.cardTitleCus);
            this.cardCus.Controls.Add(this.colorBarCus);
            this.cardCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCus.Location = new System.Drawing.Point(312, 4);
            this.cardCus.Name = "cardCus";
            this.cardCus.Padding = new System.Windows.Forms.Padding(10);
            this.cardCus.Size = new System.Drawing.Size(148, 114);
            this.cardCus.TabIndex = 2;
            // 
            // lblThanhVien
            // 
            this.lblThanhVien.AutoSize = true;
            this.lblThanhVien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhVien.ForeColor = System.Drawing.Color.Black;
            this.lblThanhVien.Location = new System.Drawing.Point(10, 40);
            this.lblThanhVien.Name = "lblThanhVien";
            this.lblThanhVien.Size = new System.Drawing.Size(49, 30);
            this.lblThanhVien.TabIndex = 2;
            this.lblThanhVien.Text = "852";
            // 
            // cardTitleCus
            // 
            this.cardTitleCus.AutoSize = true;
            this.cardTitleCus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTitleCus.ForeColor = System.Drawing.Color.Gray;
            this.cardTitleCus.Location = new System.Drawing.Point(10, 15);
            this.cardTitleCus.Name = "cardTitleCus";
            this.cardTitleCus.Size = new System.Drawing.Size(110, 15);
            this.cardTitleCus.TabIndex = 1;
            this.cardTitleCus.Text = "Thành viên đăng ký";
            // 
            // colorBarCus
            // 
            this.colorBarCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.colorBarCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorBarCus.Location = new System.Drawing.Point(10, 10);
            this.colorBarCus.Name = "colorBarCus";
            this.colorBarCus.Size = new System.Drawing.Size(128, 5);
            this.colorBarCus.TabIndex = 0;
            // 
            // cardLib
            // 
            this.cardLib.Controls.Add(this.lblNhanVien);
            this.cardLib.Controls.Add(this.cardTitleBookLib);
            this.cardLib.Controls.Add(this.colorBarLib);
            this.cardLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardLib.Location = new System.Drawing.Point(158, 4);
            this.cardLib.Name = "cardLib";
            this.cardLib.Padding = new System.Windows.Forms.Padding(10);
            this.cardLib.Size = new System.Drawing.Size(147, 114);
            this.cardLib.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblNhanVien.Location = new System.Drawing.Point(10, 40);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(37, 30);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "12";
            // 
            // cardTitleBookLib
            // 
            this.cardTitleBookLib.AutoSize = true;
            this.cardTitleBookLib.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTitleBookLib.ForeColor = System.Drawing.Color.Gray;
            this.cardTitleBookLib.Location = new System.Drawing.Point(10, 15);
            this.cardTitleBookLib.Name = "cardTitleBookLib";
            this.cardTitleBookLib.Size = new System.Drawing.Size(104, 15);
            this.cardTitleBookLib.TabIndex = 1;
            this.cardTitleBookLib.Text = "Tổng số nhân viên";
            // 
            // colorBarLib
            // 
            this.colorBarLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.colorBarLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorBarLib.Location = new System.Drawing.Point(10, 10);
            this.colorBarLib.Name = "colorBarLib";
            this.colorBarLib.Size = new System.Drawing.Size(127, 5);
            this.colorBarLib.TabIndex = 0;
            // 
            // cardBook
            // 
            this.cardBook.Controls.Add(this.lblSachKhaDung);
            this.cardBook.Controls.Add(this.valueLabelBook);
            this.cardBook.Controls.Add(this.cardTitleBook);
            this.cardBook.Controls.Add(this.colorBarBook);
            this.cardBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBook.Location = new System.Drawing.Point(4, 4);
            this.cardBook.Name = "cardBook";
            this.cardBook.Padding = new System.Windows.Forms.Padding(10);
            this.cardBook.Size = new System.Drawing.Size(147, 114);
            this.cardBook.TabIndex = 0;
            // 
            // lblSachKhaDung
            // 
            this.lblSachKhaDung.AutoSize = true;
            this.lblSachKhaDung.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSachKhaDung.ForeColor = System.Drawing.Color.Black;
            this.lblSachKhaDung.Location = new System.Drawing.Point(8, 40);
            this.lblSachKhaDung.Name = "lblSachKhaDung";
            this.lblSachKhaDung.Size = new System.Drawing.Size(37, 30);
            this.lblSachKhaDung.TabIndex = 3;
            this.lblSachKhaDung.Text = "12";
            // 
            // valueLabelBook
            // 
            this.valueLabelBook.AutoSize = true;
            this.valueLabelBook.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabelBook.ForeColor = System.Drawing.Color.Black;
            this.valueLabelBook.Location = new System.Drawing.Point(10, 40);
            this.valueLabelBook.Name = "valueLabelBook";
            this.valueLabelBook.Size = new System.Drawing.Size(0, 30);
            this.valueLabelBook.TabIndex = 2;
            // 
            // cardTitleBook
            // 
            this.cardTitleBook.AutoSize = true;
            this.cardTitleBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTitleBook.ForeColor = System.Drawing.Color.Gray;
            this.cardTitleBook.Location = new System.Drawing.Point(10, 15);
            this.cardTitleBook.Name = "cardTitleBook";
            this.cardTitleBook.Size = new System.Drawing.Size(129, 15);
            this.cardTitleBook.TabIndex = 1;
            this.cardTitleBook.Text = "Tổng số sách khả dụng";
            // 
            // colorBarBook
            // 
            this.colorBarBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.colorBarBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorBarBook.Location = new System.Drawing.Point(10, 10);
            this.colorBarBook.Name = "colorBarBook";
            this.colorBarBook.Size = new System.Drawing.Size(127, 5);
            this.colorBarBook.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(138, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dashboard";
            // 
            // AdminControl_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashboardPanel);
            this.Name = "AdminControl_Dashboard";
            this.Size = new System.Drawing.Size(634, 633);
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cardBookBorrow.ResumeLayout(false);
            this.cardBookBorrow.PerformLayout();
            this.cardCus.ResumeLayout(false);
            this.cardCus.PerformLayout();
            this.cardLib.ResumeLayout(false);
            this.cardLib.PerformLayout();
            this.cardBook.ResumeLayout(false);
            this.cardBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Label systemStatusLabel;
        private System.Windows.Forms.TableLayoutPanel statsPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSachQuaHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSachTraHomNay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel cardBookBorrow;
        private System.Windows.Forms.Label lblSachMuonHomNay;
        private System.Windows.Forms.Label cardTitleBookBorrow;
        private System.Windows.Forms.Panel colorBarBookBorrow;
        private System.Windows.Forms.Panel cardCus;
        private System.Windows.Forms.Label lblThanhVien;
        private System.Windows.Forms.Label cardTitleCus;
        private System.Windows.Forms.Panel colorBarCus;
        private System.Windows.Forms.Panel cardLib;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label cardTitleBookLib;
        private System.Windows.Forms.Panel colorBarLib;
        private System.Windows.Forms.Panel cardBook;
        private System.Windows.Forms.Label valueLabelBook;
        private System.Windows.Forms.Label cardTitleBook;
        private System.Windows.Forms.Panel colorBarBook;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lblSachKhaDung;
        private System.Windows.Forms.Label backupLabel;
    }
}
