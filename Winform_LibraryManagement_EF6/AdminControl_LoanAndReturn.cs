using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessAccessLayer.Services;
using BusinessAccessLayer.DTOs;
using System.Collections.Generic;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_LoanAndReturn : UserControl
    {
        private readonly IThanhVienService _thanhVienService;
        private List<ThanhVienDTO> _thanhVienList;

        private readonly ISachService _sachService;
        private List<SachDTO> _sachList;

        private readonly IPhieuMuonService _phieuMuonService;
        private List<PhieuMuonDTO> _phieuMuonList;

        public AdminControl_LoanAndReturn()
        {
            InitializeComponent();
            Adjust();
            _thanhVienService = new ThanhVienService();
            _sachService = new SachService();
            _phieuMuonService = new PhieuMuonService();
            LoadData();
        }

        private void Adjust()
        {
            searchPanel.Width = panel.Width - 40;
            larGridView.Size = new Size(panel.Width - 40, panel.Height - 280);
            MenuButton.Width = panel.Width - 40;
            lblNoData.Location = new Point(
        larGridView.Location.X + (larGridView.Width - lblNoData.Width) / 2,
       larGridView.Location.Y + (larGridView.Height - lblNoData.Height) / 2);
        }

        private void LoadData()
        {
            _thanhVienList = _thanhVienService.GetAllThanhVienDTO().ToList();
            (larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn).DataSource = _thanhVienList;
            (larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";
            (larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn).ValueMember = "MaThanhVien";

            _sachList = _sachService.GetAllSachDTO().ToList();
            (larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn).DataSource = _sachList;
            (larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn).DisplayMember = "TenSach";
            (larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn).ValueMember = "MaSach";;

            _phieuMuonList = _phieuMuonService.GetAllPhieuMuonDTO().ToList();
            larGridView.DataSource = _phieuMuonList;
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            using (MuonSach form = new MuonSach())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Nếu thêm thành công, cập nhật lại dữ liệu
                    LoadData();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            using (TraSach form = new TraSach())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Nếu thêm thành công, cập nhật lại dữ liệu
                    LoadData();
                }
            }
        }

        private void btnEditLAR_Click(object sender, EventArgs e)
        {
            //if (larGridView.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn phiếu mượn cần chỉnh sửa!", "Thông báo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //try
            //{
            //    // Lấy dòng đã chọn
            //    DataGridViewRow selectedRow = larGridView.SelectedRows[0];

            //    // Lấy mã sách để tìm kiếm trong DataTable
            //    int maPhieu = (int)selectedRow.Cells["MaPhieu"].Value;

            //    // Tìm dòng dữ liệu trong DataTable
            //    DataRow[] rows = dtPhieuMuon.Select($"MaPhieu = '{maPhieu}'");
            //    if (rows.Length > 0)
            //    {
            //        // Tạo và hiển thị form chỉnh sửa với dữ liệu phiếu mượn đã chọn
            //        FormEditLoansAndReturns form = new FormEditLoansAndReturns(rows[0]);

            //        if (form.ShowDialog() == DialogResult.OK)
            //        {
            //            // Cập nhật dữ liệu trong DataGridView
            //            LoadData();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không tìm thấy thông tin phiếu mượn!", "Lỗi",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi chỉnh sửa thông tin phiếu mượn: " + ex.Message, "Lỗi",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnDeleteLAR_Click(object sender, EventArgs e)
        {
            //if (larGridView.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Vui lòng phiếu mượn cần xóa!", "Thông báo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //try
            //{
            //    // Lấy dòng đã chọn
            //    DataGridViewRow selectedRow = larGridView.SelectedRows[0];
            //    // Lấy mã phiếu mượn cần xóa
            //    int maPhieu = (int)selectedRow.Cells["MaPhieu"].Value;

            //    DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa phiếu mượn '{maPhieu}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        string err = "";
            //        // Thực hiện xóa phiếu mượn từ cơ sở dữ liệu
            //        bool success = dBLAR.XoaPhieuMuon(ref err, maPhieu);

            //        if (success)
            //        {
            //            // Cập nhật dữ liệu trong DataGridView sau khi xóa
            //            LoadData();

            //            MessageBox.Show($"Đã xóa phiếu mượn '{maPhieu}' thành công!", "Thông báo",
            //                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Không thể xóa phiếu mượn này!", "Lỗi",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi xóa phiếu mượn: " + ex.Message, "Lỗi",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void larGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cột hiện tại có phải là cột "TrangThai" không
            if (larGridView.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value is string trangThai)
            {
                switch (trangThai)
                {
                    case "Đang mượn":
                        e.CellStyle.ForeColor = Color.Orange;
                        break;
                    case "Đã trả":
                        e.CellStyle.ForeColor = Color.Green; // Đổi màu từ Yellow sang Orange để dễ nhìn hơn
                        break;
                    case "Quá hạn":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                    default:
                        e.CellStyle.ForeColor = Color.Black; // Mặc định nếu có giá trị khác
                        break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadPhieuMuon(searchTerm);
        }

        private void LoadPhieuMuon(string searchTerm)
        {
            try
            {
                if (string.IsNullOrEmpty(searchTerm))
                {
                    // Nếu không có từ khóa tìm kiếm, tải lại tất cả dữ liệu
                    _phieuMuonList = _phieuMuonService.GetAllPhieuMuonDTO().ToList();
                } else
                {
                    // Nếu có từ khóa tìm kiếm, tìm kiếm trong danh sách phiếu mượn
                    var searchResults = _phieuMuonService.SearchPhieuMuon(searchTerm);
                    _phieuMuonList = searchResults.Select(pm => new PhieuMuonDTO
                    {
                        MaPhieu = pm.MaPhieu,
                        MaSach = pm.MaSach,
                        MaThanhVien = pm.MaThanhVien,
                        NgayMuon = pm.NgayMuon,
                        HanTra = pm.HanTra,
                        TrangThai = pm.TrangThai,
                        SoLuong = pm.SoLuong
                    }).ToList();
                }
                larGridView.DataSource = _phieuMuonList;
                UpdateDataGridViewVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridViewVisibility()
        {
            bool hasData = _phieuMuonList != null && _phieuMuonList.Any();
            lblNoData.Visible = !hasData;
            larGridView.Visible = hasData;
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void larGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
