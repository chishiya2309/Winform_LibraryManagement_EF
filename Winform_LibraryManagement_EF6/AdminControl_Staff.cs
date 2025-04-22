using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_Staff : UserControl
    {
        private INhanVienService _nhanVienService;
        private List<NhanVien> _nhanViens;
 
        public AdminControl_Staff()
        {
            InitializeComponent();
            Adjust();
            _nhanVienService = new NhanVienService();
            LoadData();
        }

        private void staffPanel_Resize(object sender, EventArgs e)
        {
            Adjust();
        }

        private void Adjust()
        {
            searchPanel.Width = staffPanel.Width - 40;
            MenuButton.Width = staffPanel.Width - 40;
            staffGridView.Size = new Size(staffPanel.Width - 40, staffPanel.Height - 270);
            lblNoData.Location = new Point(
                staffGridView.Location.X + (staffGridView.Width - lblNoData.Width) / 2,
                staffGridView.Location.Y + (staffGridView.Height - lblNoData.Height) / 2);
        }

        private void staffGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cột hiện tại có phải là cột "TrangThai" không
            if (staffGridView.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value is string trangThai)
            {
                switch (trangThai)
                {
                    case "Đang làm việc":
                        e.CellStyle.ForeColor = Color.Green;
                        break;
                    case "Tạm nghỉ":
                        e.CellStyle.ForeColor = Color.Orange;
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
            LoadStaff(searchTerm);
        }

        private void LoadStaff(string searchTerm)
        {
            try
            {
                // Tìm kiếm nhân viên dựa trên từ khóa
                _nhanViens = string.IsNullOrWhiteSpace(searchTerm)
                    ? _nhanVienService.GetAllNhanVien().ToList()
                    : _nhanVienService.SearchNhanVien(searchTerm).ToList();

                // Cập nhật datagridview
                staffGridView.DataSource = _nhanViens;

                // Hiển thị / ẩn thông báo không có dữ liệu
                if (_nhanViens.Count == 0)
                {
                    lblNoData.Visible = true;
                    staffGridView.Visible = false;
                }
                else
                {
                    lblNoData.Visible = false;
                    staffGridView.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                // Lấy tất cả nhân viên từ service
                _nhanViens = _nhanVienService.GetAllNhanVien().ToList();

                // Đưa dữ liệu lên DataGridView
                staffGridView.DataSource = _nhanViens;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            using (FormAddStaff form = new FormAddStaff())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Nếu thêm thành công, cập nhật lại dữ liệu
                    LoadData();
                }
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (staffGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = staffGridView.SelectedRows[0];

                // Lấy mã nhân viên để tìm kiếm
                string maNhanVien = selectedRow.Cells["ID"].Value.ToString();

                // Tìm nhân viên bằng ID
                NhanVien nhanVien = _nhanVienService.GetNhanVienById(maNhanVien);

                if (nhanVien != null)
                {
                    // Tạo và hiển thị form chỉnh sửa với dữ liệu nhân viên đã chọn
                    FormEditStaff formEditStaff = new FormEditStaff(nhanVien);

                    if (formEditStaff.ShowDialog() == DialogResult.OK)
                    {
                        // Cập nhật dữ liệu trong DataGridView
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chỉnh sửa thông tin nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (staffGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = staffGridView.SelectedRows[0];

                // Lấy mã nhân viên cần xóa
                string maNhanVien = selectedRow.Cells["ID"].Value.ToString();
                string hoTen = selectedRow.Cells["HoTen"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {hoTen} có mã là {maNhanVien}?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Thực hiện xóa nhân viên từ cơ sở dữ liệu
                        _nhanVienService.DeleteNhanVien(maNhanVien);

                        // Cập nhật dữ liệu trong DataGridView sau khi xóa
                        LoadData();

                        MessageBox.Show($"Đã xóa nhân viên '{hoTen}' thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa nhân viên: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
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
