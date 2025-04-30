//using BusinessAccessLayer;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;

//namespace Winform_LibraryManagement_EF6
//{
//    public partial class AdminControl_ThongKeSachMuon : UserControl
//    {
//        private DBLoanAndReturn dbLAR;

//        public AdminControl_ThongKeSachMuon()
//        {
//            InitializeComponent();
//            dbLAR = new DBLoanAndReturn();
//            LoadYearsToComboBox(); // Load danh sách năm
//            LoadData(); // Load dữ liệu mặc định
//        }

//        private void LoadData(int? selectedYear = null)
//        {
//            try
//            {
//                DataTable dtThongKe = dbLAR.ThongKeSachMuonTheoThang(selectedYear);

//                if (dtThongKe == null || dtThongKe.Rows.Count == 0)
//                {
//                    MessageBox.Show("Không có dữ liệu thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    return;
//                }

//                // Hiển thị lên Chart
//                chartLoansByMonth.Series.Clear();
//                Series series = new Series("Số sách mượn")
//                {
//                    ChartType = SeriesChartType.Column,
//                    IsValueShownAsLabel = true // Hiển thị số liệu trên từng cột
//                };

//                foreach (DataRow row in dtThongKe.Rows)
//                {
//                    series.Points.AddXY(row["ThangNam"], row["SoLuongMuon"]);
//                }

//                chartLoansByMonth.Series.Add(series);

//                // Cấu hình trục X
//                chartLoansByMonth.ChartAreas[0].AxisX.Title = "Tháng/Năm";
//                chartLoansByMonth.ChartAreas[0].AxisX.Interval = 1;

//                // Cấu hình trục Y
//                chartLoansByMonth.ChartAreas[0].AxisY.Title = "Số lượng sách mượn";
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void LoadYearsToComboBox()
//        {
//            try
//            {
//                List<int> years = dbLAR.LayDanhSachNam();

//                cmbYearFilter.Items.Clear();
//                cmbYearFilter.Items.Add("Tất cả");

//                foreach (int year in years)
//                {
//                    cmbYearFilter.Items.Add(year);
//                }

//                cmbYearFilter.SelectedIndex = 0;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi khi tải danh sách năm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnFilter_Click(object sender, EventArgs e)
//        {
//            if (cmbYearFilter.SelectedItem.ToString() == "Tất cả")
//            {
//                LoadData(); // Hiển thị toàn bộ dữ liệu
//            }
//            else
//            {
//                int selectedYear = int.Parse(cmbYearFilter.SelectedItem.ToString());
//                LoadData(selectedYear); // Hiển thị dữ liệu theo năm đã chọn
//            }
//        }

//        private void cmbYearFilter_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            btnFilter_Click(sender, e);
//        }
//    }
//}
