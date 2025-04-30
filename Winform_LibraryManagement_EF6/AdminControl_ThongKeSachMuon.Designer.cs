//namespace Winform_LibraryManagement_EF6
//{
//    partial class AdminControl_ThongKeSachMuon
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
//            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
//            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.cmbYearFilter = new System.Windows.Forms.ComboBox();
//            this.btnFilter = new System.Windows.Forms.Button();
//            this.chartLoansByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
//            this.panel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.chartLoansByMonth)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // panel1
//            // 
//            this.panel1.Controls.Add(this.chartLoansByMonth);
//            this.panel1.Controls.Add(this.btnFilter);
//            this.panel1.Controls.Add(this.cmbYearFilter);
//            this.panel1.Controls.Add(this.label2);
//            this.panel1.Controls.Add(this.label1);
//            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panel1.Location = new System.Drawing.Point(0, 0);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(539, 594);
//            this.panel1.TabIndex = 0;
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.Location = new System.Drawing.Point(20, 20);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(138, 17);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Thống kê sách mượn";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.Location = new System.Drawing.Point(20, 70);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(71, 17);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "Chọn năm";
//            // 
//            // cmbYearFilter
//            // 
//            this.cmbYearFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.cmbYearFilter.FormattingEnabled = true;
//            this.cmbYearFilter.Location = new System.Drawing.Point(97, 67);
//            this.cmbYearFilter.Name = "cmbYearFilter";
//            this.cmbYearFilter.Size = new System.Drawing.Size(156, 25);
//            this.cmbYearFilter.TabIndex = 2;
//            this.cmbYearFilter.SelectedIndexChanged += new System.EventHandler(this.cmbYearFilter_SelectedIndexChanged);
//            // 
//            // btnFilter
//            // 
//            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
//            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.btnFilter.FlatAppearance.BorderSize = 0;
//            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnFilter.ForeColor = System.Drawing.Color.White;
//            this.btnFilter.Location = new System.Drawing.Point(277, 67);
//            this.btnFilter.Name = "btnFilter";
//            this.btnFilter.Size = new System.Drawing.Size(90, 25);
//            this.btnFilter.TabIndex = 9;
//            this.btnFilter.Text = "Lọc";
//            this.btnFilter.UseVisualStyleBackColor = false;
//            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
//            // 
//            // chartLoansByMonth
//            // 
//            this.chartLoansByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//            | System.Windows.Forms.AnchorStyles.Right)));
//            chartArea1.Name = "ChartArea1";
//            this.chartLoansByMonth.ChartAreas.Add(chartArea1);
//            legend1.Name = "Legend1";
//            this.chartLoansByMonth.Legends.Add(legend1);
//            this.chartLoansByMonth.Location = new System.Drawing.Point(25, 139);
//            this.chartLoansByMonth.Name = "chartLoansByMonth";
//            series1.ChartArea = "ChartArea1";
//            series1.IsValueShownAsLabel = true;
//            series1.Legend = "Legend1";
//            series1.Name = "Số sách mượn";
//            this.chartLoansByMonth.Series.Add(series1);
//            this.chartLoansByMonth.Size = new System.Drawing.Size(400, 163);
//            this.chartLoansByMonth.TabIndex = 10;
//            this.chartLoansByMonth.Text = "chart1";
//            // 
//            // AdminControl_ThongKeSachMuon
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.panel1);
//            this.Name = "AdminControl_ThongKeSachMuon";
//            this.Size = new System.Drawing.Size(539, 594);
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.chartLoansByMonth)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.ComboBox cmbYearFilter;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoansByMonth;
//        private System.Windows.Forms.Button btnFilter;
//    }
//}
