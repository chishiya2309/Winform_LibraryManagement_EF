using BusinessAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_PopularBooks : UserControl
    {
        private DBLoanAndReturn dbLAR;

        public AdminControl_PopularBooks()
        {
            InitializeComponent();
            dbLAR = new DBLoanAndReturn();
            LoadData();
        }

        void LoadData()
        {
            try
            {
                DataTable dtPopularBooks = dbLAR.LayTop10SachPhoBien();

                if (dtPopularBooks != null && dtPopularBooks.Rows.Count > 0)
                {
                    dgvPopularBooks.DataSource = dtPopularBooks;
                }
                else
                {
                    dgvPopularBooks.DataSource = new DataTable(); // Gán bảng rỗng nếu không có dữ liệu
                    MessageBox.Show("Không có dữ liệu thống kê sách phổ biến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sách phổ biến: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPopularBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
