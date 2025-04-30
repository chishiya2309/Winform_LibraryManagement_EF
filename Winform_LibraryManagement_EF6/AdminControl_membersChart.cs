//using BusinessAccessLayer;
//using System;
//using System.Data;
//using System.Drawing;
//using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;

//namespace Winform_LibraryManagement_EF6
//{
//    public partial class AdminControl_membersChart : UserControl
//    {
//        private DBMembers dbtv;

//        public AdminControl_membersChart()
//        {
//            InitializeComponent();
//            dbtv = new DBMembers();
//            LoadData();
//        }

//        private void LoadData()
//        {
//            DataTable dtThongKe = dbtv.ThongKeThanhVienTheoLoai();

//            if (dtThongKe == null || dtThongKe.Rows.Count == 0)
//            {
//                MessageBox.Show("Không có dữ liệu thống kê thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            // Xóa dữ liệu cũ trên biểu đồ
//            Series series = membersChart.Series.FindByName("Thống kê thành viên");
//            if (series == null)
//            {
//                series = new Series("Thống kê thành viên");
//                series.ChartType = SeriesChartType.Pie;
//                membersChart.Series.Add(series);
//            }

//            series.Points.Clear();

//            // Cập nhật Pie Chart với dữ liệu mới
//            foreach (DataRow row in dtThongKe.Rows)
//            {
//                string loaiThanhVien = row["LoaiThanhVien"].ToString();
//                int soLuong = Convert.ToInt32(row["SoLuong"]);
//                double tiLe = Convert.ToDouble(row["TiLe"]);

//                DataPoint point = new DataPoint();
//                point.SetValueXY(loaiThanhVien, soLuong);
//                point.Label = $"{loaiThanhVien} ({tiLe:0.0}%)";
//                point.LegendText = loaiThanhVien;
//                series.Points.Add(point);
//            }

//            // Cấu hình hiển thị biểu đồ
//            series.IsValueShownAsLabel = true;
//            series.LabelFormat = "0.0%";

//            // Cấu hình màu sắc tự động
//            membersChart.Palette = ChartColorPalette.BrightPastel;
//        }

//        private void membersChart_Click(object sender, EventArgs e)
//        {
//        }
//    }
//}
