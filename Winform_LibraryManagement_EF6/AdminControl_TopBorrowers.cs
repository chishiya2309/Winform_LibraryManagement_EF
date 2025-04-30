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
    public partial class AdminControl_TopBorrowers : UserControl
    {
        private readonly IPhieuMuonService _phieuMuonService;
        private List<TopThanhVienMuonDTO> _topThanhVienMuonList;

        public AdminControl_TopBorrowers()
        {
            InitializeComponent();
            _phieuMuonService = new PhieuMuonService();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _topThanhVienMuonList = _phieuMuonService.GetTop5ThanhVienMuonNhieuNhat().ToList();

                if (_topThanhVienMuonList.Any())
                {
                    dgvTopBorrowers.DataSource = _topThanhVienMuonList;
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
