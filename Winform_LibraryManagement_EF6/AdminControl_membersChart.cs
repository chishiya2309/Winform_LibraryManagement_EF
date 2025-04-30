using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessAccessLayer.Services;
using System.Linq;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_membersChart : UserControl
    {
        private readonly IThanhVienService _thanhVienService;

        public AdminControl_membersChart()
        {
            InitializeComponent();
            _thanhVienService = new ThanhVienService();
            LoadData();
        }

        private void LoadData()
        {
            var thongKeThanhVien = _thanhVienService.ThongKeThanhVienTheoLoai();

            if (!thongKeThanhVien.Any())
            {
                MessageBox.Show("Không có dữ liệu thống kê thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xóa dữ liệu cũ trên biểu đồ
            Series series = membersChart.Series.FindByName("Thống kê thành viên");
            if (series == null)
            {
                series = new Series("Thống kê thành viên");
                series.ChartType = SeriesChartType.Pie;
                membersChart.Series.Add(series);
            }

            series.Points.Clear();

            // Cập nhật Pie Chart với dữ liệu mới
            foreach (var item in thongKeThanhVien)
            {
                DataPoint point = new DataPoint();
                point.SetValueXY(item.LoaiThanhVien, item.SoLuong);
                point.Label = $"{item.LoaiThanhVien} ({item.TiLe:0.0}%)";
                point.LegendText = item.LoaiThanhVien;
                series.Points.Add(point);
            }

            // Cấu hình hiển thị biểu đồ
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "0.0%";

            // Cấu hình màu sắc tự động
            membersChart.Palette = ChartColorPalette.BrightPastel;
        }

        private void membersChart_Click(object sender, EventArgs e)
        {
            // Không cần xử lý
        }
    }
}
