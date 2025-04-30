using BusinessAccessLayer;
using BusinessAccessLayer.DTOs;
using BusinessAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_PopularBooks : UserControl
    {
        private readonly IPhieuMuonService _phieuMuonService;
        private List<TopSachPhoBienDTO> _topSachPhoBienList;

        public AdminControl_PopularBooks()
        {
            InitializeComponent();
            _phieuMuonService = new PhieuMuonService();
            LoadData();
        }

        void LoadData()
        {
            try
            {
                _topSachPhoBienList = _phieuMuonService.GetTop10SachPhoBien().ToList();

                if (_topSachPhoBienList.Any())
                {
                    dgvPopularBooks.DataSource = _topSachPhoBienList;
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
