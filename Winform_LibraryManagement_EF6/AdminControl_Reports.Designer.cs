namespace Winform_LibraryManagement_EF6
{
    partial class AdminControl_Reports
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
            this.panel = new System.Windows.Forms.Panel();
            this.reportPreviewPanel = new System.Windows.Forms.Panel();
            this.placeholderLabel = new System.Windows.Forms.Label();
            this.reportPreviewTitleLabel = new System.Windows.Forms.Label();
            this.reportOptionsPanel = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.dateRangeComboBox = new System.Windows.Forms.ComboBox();
            this.dateRangeLabel = new System.Windows.Forms.Label();
            this.reportOptionsTitleLabel = new System.Windows.Forms.Label();
            this.reportTypePanel = new System.Windows.Forms.Panel();
            this.reportTypeList = new System.Windows.Forms.ListBox();
            this.reportTypeTitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.reportPreviewPanel.SuspendLayout();
            this.reportOptionsPanel.SuspendLayout();
            this.reportTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.reportPreviewPanel);
            this.panel.Controls.Add(this.reportOptionsPanel);
            this.panel.Controls.Add(this.reportTypePanel);
            this.panel.Controls.Add(this.titleLabel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(878, 622);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.Resize += new System.EventHandler(this.panel_Resize);
            // 
            // reportPreviewPanel
            // 
            this.reportPreviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportPreviewPanel.Controls.Add(this.placeholderLabel);
            this.reportPreviewPanel.Controls.Add(this.reportPreviewTitleLabel);
            this.reportPreviewPanel.Location = new System.Drawing.Point(340, 270);
            this.reportPreviewPanel.Name = "reportPreviewPanel";
            this.reportPreviewPanel.Size = new System.Drawing.Size(493, 310);
            this.reportPreviewPanel.TabIndex = 3;
            // 
            // placeholderLabel
            // 
            this.placeholderLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderLabel.ForeColor = System.Drawing.Color.Gray;
            this.placeholderLabel.Location = new System.Drawing.Point(100, 150);
            this.placeholderLabel.Name = "placeholderLabel";
            this.placeholderLabel.Size = new System.Drawing.Size(384, 20);
            this.placeholderLabel.TabIndex = 1;
            this.placeholderLabel.Text = "Chọn loại báo cáo và nhấn \'Tạo báo cáo\' để xem kết quả";
            this.placeholderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportPreviewTitleLabel
            // 
            this.reportPreviewTitleLabel.AutoSize = true;
            this.reportPreviewTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportPreviewTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.reportPreviewTitleLabel.Location = new System.Drawing.Point(15, 15);
            this.reportPreviewTitleLabel.Name = "reportPreviewTitleLabel";
            this.reportPreviewTitleLabel.Size = new System.Drawing.Size(153, 21);
            this.reportPreviewTitleLabel.TabIndex = 0;
            this.reportPreviewTitleLabel.Text = "Xem trước báo cáo";
            // 
            // reportOptionsPanel
            // 
            this.reportOptionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.reportOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportOptionsPanel.Controls.Add(this.btnGenerateReport);
            this.reportOptionsPanel.Controls.Add(this.endDatePicker);
            this.reportOptionsPanel.Controls.Add(this.endDateLabel);
            this.reportOptionsPanel.Controls.Add(this.startDatePicker);
            this.reportOptionsPanel.Controls.Add(this.startDateLabel);
            this.reportOptionsPanel.Controls.Add(this.dateRangeComboBox);
            this.reportOptionsPanel.Controls.Add(this.dateRangeLabel);
            this.reportOptionsPanel.Controls.Add(this.reportOptionsTitleLabel);
            this.reportOptionsPanel.Location = new System.Drawing.Point(340, 70);
            this.reportOptionsPanel.Name = "reportOptionsPanel";
            this.reportOptionsPanel.Size = new System.Drawing.Size(493, 180);
            this.reportOptionsPanel.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(367, 79);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 35);
            this.btnGenerateReport.TabIndex = 7;
            this.btnGenerateReport.Text = "Tạo báo cáo";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(150, 118);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 25);
            this.endDatePicker.TabIndex = 6;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(15, 120);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(66, 17);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "Đến ngày:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(150, 83);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 25);
            this.startDatePicker.TabIndex = 4;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(15, 85);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 17);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Từ ngày:";
            // 
            // dateRangeComboBox
            // 
            this.dateRangeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateRangeComboBox.FormattingEnabled = true;
            this.dateRangeComboBox.Items.AddRange(new object[] {
            "Hôm nay",
            "7 ngày qua",
            "30 ngày qua",
            "Năm hiện tại",
            "Tùy chỉnh"});
            this.dateRangeComboBox.Location = new System.Drawing.Point(150, 48);
            this.dateRangeComboBox.Name = "dateRangeComboBox";
            this.dateRangeComboBox.Size = new System.Drawing.Size(200, 21);
            this.dateRangeComboBox.TabIndex = 2;
            this.dateRangeComboBox.SelectedIndexChanged += new System.EventHandler(this.dateRangeComboBox_SelectedIndexChanged);
            // 
            // dateRangeLabel
            // 
            this.dateRangeLabel.AutoSize = true;
            this.dateRangeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRangeLabel.Location = new System.Drawing.Point(15, 50);
            this.dateRangeLabel.Name = "dateRangeLabel";
            this.dateRangeLabel.Size = new System.Drawing.Size(111, 17);
            this.dateRangeLabel.TabIndex = 1;
            this.dateRangeLabel.Text = "Khoảng thời gian:";
            // 
            // reportOptionsTitleLabel
            // 
            this.reportOptionsTitleLabel.AutoSize = true;
            this.reportOptionsTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportOptionsTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.reportOptionsTitleLabel.Location = new System.Drawing.Point(15, 15);
            this.reportOptionsTitleLabel.Name = "reportOptionsTitleLabel";
            this.reportOptionsTitleLabel.Size = new System.Drawing.Size(143, 21);
            this.reportOptionsTitleLabel.TabIndex = 0;
            this.reportOptionsTitleLabel.Text = "Tùy chọn báo cáo";
            // 
            // reportTypePanel
            // 
            this.reportTypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.reportTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportTypePanel.Controls.Add(this.reportTypeList);
            this.reportTypePanel.Controls.Add(this.reportTypeTitleLabel);
            this.reportTypePanel.Location = new System.Drawing.Point(20, 70);
            this.reportTypePanel.Name = "reportTypePanel";
            this.reportTypePanel.Size = new System.Drawing.Size(300, 301);
            this.reportTypePanel.TabIndex = 1;
            // 
            // reportTypeList
            // 
            this.reportTypeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.reportTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportTypeList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeList.FormattingEnabled = true;
            this.reportTypeList.HorizontalScrollbar = true;
            this.reportTypeList.IntegralHeight = false;
            this.reportTypeList.ItemHeight = 20;
            this.reportTypeList.Items.AddRange(new object[] {
            "Sách có số lượng khả dụng thấp",
            "Danh sách thành viên sắp hết hạn",
            "Thống kê số lượng thành viên theo loại",
            "Danh sách phiếu mượn quá hạn",
            "Lịch sử mượn sách của thành viên cụ thể",
            "Top thành viên đang mượn nhiều sách nhất",
            "Top sách phổ biến nhất",
            "Thống kê sách mượn",
            "Tỷ lệ trả sách đúng/quá hạn"});
            this.reportTypeList.Location = new System.Drawing.Point(15, 50);
            this.reportTypeList.Name = "reportTypeList";
            this.reportTypeList.Size = new System.Drawing.Size(280, 207);
            this.reportTypeList.TabIndex = 1;
            this.reportTypeList.SelectedIndexChanged += new System.EventHandler(this.reportTypeList_SelectedIndexChanged);
            // 
            // reportTypeTitleLabel
            // 
            this.reportTypeTitleLabel.AutoSize = true;
            this.reportTypeTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.reportTypeTitleLabel.Location = new System.Drawing.Point(15, 15);
            this.reportTypeTitleLabel.Name = "reportTypeTitleLabel";
            this.reportTypeTitleLabel.Size = new System.Drawing.Size(106, 21);
            this.reportTypeTitleLabel.TabIndex = 0;
            this.reportTypeTitleLabel.Text = "Loại báo cáo";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(229, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Báo cáo - thống kê";
            // 
            // AdminControl_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "AdminControl_Reports";
            this.Size = new System.Drawing.Size(878, 622);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.reportPreviewPanel.ResumeLayout(false);
            this.reportPreviewPanel.PerformLayout();
            this.reportOptionsPanel.ResumeLayout(false);
            this.reportOptionsPanel.PerformLayout();
            this.reportTypePanel.ResumeLayout(false);
            this.reportTypePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel reportTypePanel;
        private System.Windows.Forms.Label reportTypeTitleLabel;
        private System.Windows.Forms.ListBox reportTypeList;
        private System.Windows.Forms.Panel reportOptionsPanel;
        private System.Windows.Forms.ComboBox dateRangeComboBox;
        private System.Windows.Forms.Label dateRangeLabel;
        private System.Windows.Forms.Label reportOptionsTitleLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Panel reportPreviewPanel;
        private System.Windows.Forms.Label placeholderLabel;
        private System.Windows.Forms.Label reportPreviewTitleLabel;
    }
}
