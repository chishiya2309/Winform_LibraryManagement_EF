using BusinessAccessLayer.Services;
using BusinessAccessLayer.DTOs;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_ReturnRateStats : UserControl
    {
        private readonly IPhieuMuonService _phieuMuonService;

        public AdminControl_ReturnRateStats()
        {
            InitializeComponent();
            _phieuMuonService = new PhieuMuonService();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Gọi dữ liệu từ Service
                var thongKe = _phieuMuonService.GetThongKeTraSach();

                // Xóa dữ liệu cũ trên biểu đồ
                chartReturnRate.Series.Clear();
                Series series = new Series("ReturnRate")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                    LabelFormat = "#,##0"
                };

                // Thêm dữ liệu mới vào biểu đồ
                series.Points.AddXY("Trả đúng hạn", thongKe.SoPhieuDungHan);
                series.Points.AddXY("Trả quá hạn", thongKe.SoPhieuQuaHan);

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
