using BusinessAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_TopBorrowers : UserControl
    {
        private DBLoanAndReturn dBLAR;

        public AdminControl_TopBorrowers()
        {
            InitializeComponent();
            dBLAR = new DBLoanAndReturn();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataTable dtTopBorrowers = dBLAR.LayTop5ThanhVienMuonNhieuNhat();

                if (dtTopBorrowers != null && dtTopBorrowers.Rows.Count > 0)
                {
                    dgvTopBorrowers.DataSource = dtTopBorrowers;
                }
                else
                {
                    dgvTopBorrowers.DataSource = new DataTable(); // Gán bảng rỗng nếu không có dữ liệu
                    MessageBox.Show("Không có dữ liệu thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách mượn sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTopBorrowers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
