using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;
using System.Collections.Generic;
using BusinessAccessLayer.DTOs;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_Member : UserControl
    {
        private readonly IThanhVienService _thanhVienService;
        private List<ThanhVienDTO> _thanhVienList;

        public AdminControl_Member()
        {
            InitializeComponent();
            Adjust();
            _thanhVienService = new ThanhVienService();
            LoadData();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            using (FormAddMember form = new FormAddMember())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Nếu thêm thành công, cập nhật lại dữ liệu
                    LoadData();
                }
            }
        }

        private void Adjust()
        {
            searchPanel.Width = panel.Width - 40;
            MenuButton.Width = panel.Width - 40;
            membersGridView.Size = new Size(panel.Width - 40, panel.Height - 280);
            lblNoData.Location = new Point(
       membersGridView.Location.X + (membersGridView.Width - lblNoData.Width) / 2,
      membersGridView.Location.Y + (membersGridView.Height - lblNoData.Height) / 2);
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            Adjust();
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMemberDetails();
        }

        private void ViewMemberDetails()
        {
            MessageBox.Show("Chức năng xem chi tiết thành viên sẽ được triển khai sau.", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedMember();
        }

        private void EditSelectedMember()
        {
            if (membersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thành viên cần chỉnh sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = membersGridView.SelectedRows[0];

                string maThanhVien = selectedRow.Cells["MaThanhVien"].Value.ToString();

                //Lấy thông tin thành viên từ service
                ThanhVien thanhVien = _thanhVienService.GetThanhVienById(maThanhVien);

                if (thanhVien != null)
                {
                    // Tạo và hiển thị form chỉnh sửa với thông tin thành viên đã chọn
                    FormEditMember formEditMember = new FormEditMember(thanhVien);

                    if (formEditMember.ShowDialog() == DialogResult.OK)
                    {
                        // Cập nhật dữ liệu trong DataGridView sau khi chỉnh sửa
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin thành viên!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chỉnh sửa thông tin thành viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedMember();
        }

        private void DeleteSelectedMember()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thành viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Chức năng xóa thành viên sẽ được triển khai sau.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadData()
        {   try
            {

            
            //Lấy danh sách thành viên từ service
            _thanhVienList = _thanhVienService.GetAllThanhVienDTO().ToList();

            //Hiển thị dữ liệu lên DataGridView
            membersGridView.DataSource = _thanhVienList;

            // Kiểm tra nếu không có dữ liệu
            if (_thanhVienList.Count == 0)
            {
                lblNoData.Visible = true;
                membersGridView.Visible = false;
            }
            else
            {
                lblNoData.Visible = false;
                membersGridView.Visible = true;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void membersGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cột hiện tại có phải là cột "TrangThai" không
            if (membersGridView.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value is string trangThai)
            {
                switch (trangThai)
                {
                    case "Hoạt động":
                        e.CellStyle.ForeColor = Color.Green;
                        break;
                    case "Hết hạn":
                        e.CellStyle.ForeColor = Color.Orange; // Đổi màu từ Yellow sang Orange để dễ nhìn hơn
                        break;
                    case "Khóa":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                    default:
                        e.CellStyle.ForeColor = Color.Black; // Mặc định nếu có giá trị khác
                        break;
                }
            }
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            EditSelectedMember();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (membersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thành viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = membersGridView.SelectedRows[0];
                // Lấy mã thành viên cần xóa
                string maThanhVien = selectedRow.Cells["MaThanhVien"].Value.ToString();
                string tenThanhVien = selectedRow.Cells["HoTen"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa thành viên '{tenThanhVien}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa thành viên từ cơ sở dữ liệu qua service
                    try
                    {
                        _thanhVienService.DeleteThanhVien(maThanhVien);

                        // Cập nhật dữ liệu trong DataGridView sau khi xóa
                        LoadData();

                        MessageBox.Show($"Đã xóa thành viên '{tenThanhVien}' thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa thành viên này: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa thành viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadMember(searchTerm);
        }

        private void LoadMember(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    // Nếu không có từ khóa tìm kiếm, hiển thị tất cả
                    _thanhVienList = _thanhVienService.GetAllThanhVienDTO().ToList();
                }
                else
                {
                    var searchResults = _thanhVienService.SearchThanhVien(searchTerm);
                    _thanhVienList = searchResults.Select(s => new ThanhVienDTO
                    {
                        MaThanhVien = s.MaThanhVien,
                        HoTen = s.HoTen,
                        GioiTinh = s.GioiTinh,
                        SoDienThoai = s.SoDienThoai,
                        Email = s.Email,
                        LoaiThanhVien = s.LoaiThanhVien,
                        NgayDangKy = s.NgayDangKy,
                        NgayHetHan = s.NgayHetHan,
                        TrangThai = s.TrangThai
                    }).ToList();
                }

                // Hiển thị kết quả tìm kiếm
                membersGridView.DataSource = _thanhVienList;

                // Kiểm tra nếu không có dữ liệu thì ẩn DataGridView, hiển thị Label
                if (!_thanhVienList.Any())
                {
                    lblNoData.Visible = true;
                    membersGridView.Visible = false;
                }
                else
                {
                    lblNoData.Visible = false;
                    membersGridView.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm thành viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}
