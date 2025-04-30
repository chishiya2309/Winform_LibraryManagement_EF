using System;
using System.Drawing;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_Reports : UserControl
    {
        public AdminControl_Reports()
        {
            InitializeComponent();
            dateRangeComboBox.SelectedIndex = 2;
            startDatePicker.Value = DateTime.Now.AddDays(-30);
            endDatePicker.Value = DateTime.Now;
            if (reportTypeList.Items.Count > 0)
            {
                reportTypeList.SelectedIndex = 0;
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Adjust()
        {
            reportTypePanel.Size = new Size(300, panel.Height - 100);
            reportTypeList.Height = reportTypePanel.Height - 70;
            reportOptionsPanel.Width = panel.Width - 360;
            btnGenerateReport.Location = new Point(reportOptionsPanel.Width - 150, reportOptionsPanel.Height - 50);
            reportPreviewPanel.Size = new Size(panel.Width - 360, panel.Height - 300);
            placeholderLabel.Width = reportPreviewPanel.Width - 200;
            placeholderLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            Adjust();

        }

        private void reportTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateRangeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateRangeComboBox.SelectedItem.ToString() == "Tùy chỉnh")
            {
                startDatePicker.Enabled = true;
                endDatePicker.Enabled = true;
            }
            else
            {
                startDatePicker.Enabled = false;
                endDatePicker.Enabled = false;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport(reportTypeList.SelectedItem?.ToString(), reportPreviewPanel);
        }
        // Tạo báo cáo 
        private void GenerateReport(string reportType, Panel previewPanel)
        {
            if (string.IsNullOrEmpty(reportType))
            {
                MessageBox.Show("Vui lòng chọn loại báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            previewPanel.Controls.Clear();

            UserControl reportControl = null;



            switch (reportType)
            {
                case "Sách có số lượng khả dụng thấp":
                    reportControl = new AdminControl_LowStockBooks();
                    break;
                case "Danh sách thành viên sắp hết hạn":
                    reportControl = new AdminControl_expiringMembers();
                    break;
                case "Thống kê số lượng thành viên theo loại":
                    reportControl = new AdminControl_membersChart();
                    break;
                case "Danh sách phiếu mượn quá hạn":
                    reportControl = new AdminControl_PhieuMuonQuaHan();
                    break;
                //case "Lịch sử mượn sách của thành viên cụ thể":
                //    reportControl = new AdminControl_MemberLoanHistory();
                //    break;
                //case "Top thành viên đang mượn nhiều sách nhất":
                //    reportControl = new AdminControl_TopBorrowers();
                //    break;
                //case "Top sách phổ biến nhất":
                //    reportControl = new AdminControl_PopularBooks();
                //    break;
                //case "Thống kê sách mượn":
                //    reportControl = new AdminControl_ThongKeSachMuon();
                //    break;
                //case "Tỷ lệ trả sách đúng/quá hạn":
                //    reportControl = new AdminControl_ReturnRateStats();
                //    break;
                default:
                    MessageBox.Show("Loại báo cáo không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // Add the UserControl to the preview panel
            if (reportControl != null)
            {
                reportControl.Dock = DockStyle.Fill;
                previewPanel.Controls.Add(reportControl);
            }
        }
    }
}
