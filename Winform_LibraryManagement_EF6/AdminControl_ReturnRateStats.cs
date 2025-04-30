using BusinessAccessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_ReturnRateStats : UserControl
    {
        private DBLoanAndReturn dbLAR;

        public AdminControl_ReturnRateStats()
        {
            InitializeComponent();
            dbLAR = new DBLoanAndReturn();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Gọi dữ liệu từ BAL
                var (tongSoPhieu, soPhieuDungHan, soPhieuQuaHan) = dbLAR.ThongKeTraSach();

                // Xóa dữ liệu cũ trên biểu đồ
                chartReturnRate.Series.Clear();
                Series series = new Series("ReturnRate")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                    LabelFormat = "#,##0"
                };

                // Thêm dữ liệu mới vào biểu đồ
                series.Points.AddXY("Trả đúng hạn", soPhieuDungHan);
                series.Points.AddXY("Trả quá hạn", soPhieuQuaHan);

                // Cấu hình màu sắc
                series.Points[0].Color = Color.Green; // Đúng hạn
                series.Points[1].Color = Color.Red;   // Quá hạn

                chartReturnRate.Series.Add(series);
                chartReturnRate.Legends[0].Enabled = true; // Hiển thị chú thích
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
    }
}
