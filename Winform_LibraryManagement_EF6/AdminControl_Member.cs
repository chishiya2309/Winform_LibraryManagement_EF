using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BusinessAccessLayer;
using DataAccessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using BusinessAccessLayer.Services;
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

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedMember();
        }

        private void EditSelectedMember()
        {
            //if (membersGridView.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn một thành viên để chỉnh sửa", "Thông báo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //// Lấy dòng đã chọn
            //DataGridViewRow row = membersGridView.SelectedRows[0];

            //// Lấy MaThanhVien từ dòng đã chọn
            //string maThanhVien = row.Cells["MaThanhVien"].Value.ToString();

            //// Mở form chỉnh sửa với thông tin thành viên đã chọn
            //using (FormEditMember form = new FormEditMember(maThanhVien))
            //{
            //    if (form.ShowDialog() == DialogResult.OK)
            //    {
            //        // Nếu chỉnh sửa thành công, cập nhật lại dữ liệu
            //        LoadData();
            //    }
            //}
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

        private void giaHạnThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewMembership();
        }

        private void RenewMembership()
        {
            MessageBox.Show("Chức năng gia hạn thẻ thành viên sẽ được triển khai sau.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sáchĐangMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMemberLoans();
        }

        private void ViewMemberLoans()
        {
            if (membersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một thành viên để xem sách đang mượn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maThanhVien = membersGridView.SelectedRows[0].Cells["MaThanhVien"].Value.ToString();
            var phieuMuonList = _thanhVienService.GetPhieuMuonByThanhVien(maThanhVien);

            if (phieuMuonList.Any())
            {
                // Thực hiện hiển thị danh sách phiếu mượn/sách đang mượn
                MessageBox.Show($"Thành viên đang mượn {phieuMuonList.Count()} sách. Chức năng xem chi tiết sẽ được triển khai sau.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thành viên này hiện không mượn sách nào.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void inThẻThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintMemberCard();
        }

        private void PrintMemberCard()
        {
            MessageBox.Show("Chức năng in thẻ thành viên sẽ được triển khai sau.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void membersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewMemberDetails();
        }

        private void ViewMemberDetails()
        {
            MessageBox.Show("Chức năng xem chi tiết thành viên sẽ được triển khai sau.", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadData()
        {
            try
            {
                // Lấy danh sách thành viên từ service
                _thanhVienList = _thanhVienService.GetAllThanhVienDTO().ToList();

                // Đưa dữ liệu lên DataGridView  
                membersGridView.DataSource = _thanhVienList;

                // Kiểm tra và hiển thị thông báo khi không có dữ liệu
                UpdateDataGridViewVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thành viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridViewVisibility()
        {
            bool hasData = _thanhVienList != null && _thanhVienList.Any();
            lblNoData.Visible = !hasData;
            membersGridView.Visible = hasData;
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
                   try
                   {
                        //Thực hiện xóa thành viên thông qua service
                        _thanhVienService.DeleteThanhVien(maThanhVien);

                        // Cập nhật lại dữ liệu sau khi xóa
                        LoadData();

                        MessageBox.Show($"Đã xóa thành viên '{tenThanhVien}' thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                   {
                        MessageBox.Show("Không thể xóa thành viên này. Thành viên này có thể đang mượn sách hoặc ràng buộc khác!", "Lỗi",
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
                if(string.IsNullOrEmpty(searchTerm))
                {
                    // Nếu không có từ khóa tìm kiếm, tải lại toàn bộ danh sách
                    _thanhVienList = _thanhVienService.GetAllThanhVienDTO().ToList();
                }else
                {
                    // Tìm kiếm theo từ khóa
                    searchTerm = searchTerm.ToLower();
                    _thanhVienList = _thanhVienService.GetAllThanhVienDTO()
                        .Where(tv =>
                            tv.MaThanhVien.ToLower().Contains(searchTerm) ||
                            tv.HoTen.ToLower().Contains(searchTerm) ||
                            tv.SoDienThoai.ToLower().Contains(searchTerm) ||
                            tv.Email.ToLower().Contains(searchTerm))
                        .ToList();
                }

                membersGridView.DataSource = _thanhVienList;
                UpdateDataGridViewVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm thành viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
