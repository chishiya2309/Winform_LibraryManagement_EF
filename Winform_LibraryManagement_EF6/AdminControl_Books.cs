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
using DataAccessLayer;
using BusinessAccessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;
using BusinessAccessLayer.DTOs;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_Books : UserControl
    {
        private readonly ISachService _sachService;
        private readonly IDanhMucSachService _danhMucSachService;
        private List<SachDTO> _sachList;
        private List<DanhMucSach> _danhMucList;
        public AdminControl_Books()
        {
            InitializeComponent();
            Adjust();
            _sachService = new SachService();
            _danhMucSachService = new DanhMucSachService();

            // Lấy danh sách danh mục để hiển thị trong combobox
            _danhMucList = _danhMucSachService.GetAllDanhMucDTO()
                .Select(dto => new DanhMucSach
                {
                    MaDanhMuc = dto.MaDanhMuc,
                    TenDanhMuc = dto.TenDanhMuc
                }).ToList();

            //Thiết lập DataSource cho cột MaDanhMuc
            (booksGridView.Columns["MaDanhMuc"] as DataGridViewComboBoxColumn).DataSource = _danhMucList;
            (booksGridView.Columns["MaDanhMuc"] as DataGridViewComboBoxColumn).DisplayMember = "TenDanhMuc";
            (booksGridView.Columns["MaDanhMuc"] as DataGridViewComboBoxColumn).ValueMember = "MaDanhMuc";

            // Lấy danh sách sách
            LoadData();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            ShowAddBookForm();
        }

        private void ShowAddBookForm()
        {
            FormAddBook formAddBook = new FormAddBook();
            if (formAddBook.ShowDialog() == DialogResult.OK)
            {
                // Reload lại dữ liệu
                LoadData();
            }
        }

        private void Adjust()
        {
            searchPanel.Width = panel.Width - 40;
            booksGridView.Size = new Size(panel.Width - 40, panel.Height - 280);
            MenuButton.Width = panel.Width - 40;
            lblNoData.Location = new Point(
        booksGridView.Location.X + (booksGridView.Width - lblNoData.Width) / 2,
        booksGridView.Location.Y + (booksGridView.Height - lblNoData.Height) / 2
    );
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            Adjust();
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookDetails();
        }

        private void ViewBookDetails()
        {
            MessageBox.Show("Chức năng xem chi tiết sách vẫn đang được phát triển. Vui lòng đợi thêm.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void booksGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ViewBookDetails();
            }
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedBook();
        }

        private void EditSelectedBook()
        {
            if (booksGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần chỉnh sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = booksGridView.SelectedRows[0];

                // Lấy mã sách để tìm kiếm trong DataTable
                string maSach = selectedRow.Cells["MaSach"].Value.ToString();

                //Lấy thông tin sách từ service
                Sach sach = _sachService.GetSachById(maSach);

                if (sach != null)
                {
                    // Tạo và hiển thị form chỉnh sửa với thông tin sách đã chọn
                    FormEditBook formEditBook = new FormEditBook(sach);

                    if (formEditBook.ShowDialog() == DialogResult.OK)
                    {
                        // Cập nhật dữ liệu trong DataGridView sau khi chỉnh sửa
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin sách!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chỉnh sửa thông tin sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteBook_Click(sender, e);
        }

        private void cậpNhậtTrạngTháiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng cập nhật trạng thái sách vẫn đang được phát triển.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Lấy danh sách danh mục mới nhất
                _danhMucList = _danhMucSachService.GetAllDanhMucDTO()
                    .Select(dto => new DanhMucSach
                    {
                        MaDanhMuc = dto.MaDanhMuc,
                        TenDanhMuc = dto.TenDanhMuc
                    }).ToList();

                //Cập nhật DataSource cho cột MaDanhMuc
                (booksGridView.Columns["MaDanhMuc"] as DataGridViewComboBoxColumn).DataSource = _danhMucList;

                //Lấy danh sách sách từ service
                _sachList = _sachService.GetAllSachDTO().ToList();

                //Đưa dữ liệu lên DataGridView
                booksGridView.DataSource = _sachList;

                // Cập nhật hiển thị
                UpdateDataGridViewVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridViewVisibility()
        {
            bool hasData = _sachList != null && _sachList.Any();
            lblNoData.Visible = !hasData;
            booksGridView.Visible = hasData;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadBooks(searchTerm);
        }

        private void LoadBooks(string searchTerm = "")
        {
            try
            {
                if (string.IsNullOrEmpty(searchTerm))
                {
                    // Nếu không có từ khóa tìm kiếm, hiển thị tất cả
                    _sachList = _sachService.GetAllSachDTO().ToList();
                }
                else
                {
                    var searchResults = _sachService.SearchSach(searchTerm);
                    _sachList = searchResults.Select(s => new SachDTO
                    {
                        MaSach = s.MaSach,
                        ISBN = s.ISBN,
                        TenSach = s.TenSach,
                        TacGia = s.TacGia,
                        MaDanhMuc = s.MaDanhMuc,
                        NamXuatBan = s.NamXuatBan,
                        NXB = s.NXB,
                        SoBan = s.SoBan,
                        KhaDung = s.KhaDung,
                        ViTri = s.ViTri
                    }).ToList();
                }
                // Cập nhật DataGridView
                booksGridView.DataSource = _sachList;
                UpdateDataGridViewVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (booksGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = booksGridView.SelectedRows[0];

                // Lấy mã sách cần xóa
                string maSach = selectedRow.Cells["MaSach"].Value.ToString();
                string tenSach = selectedRow.Cells["TenSach"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa sách '{tenSach}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //Thực hiện xóa sách thông qua service
                        _sachService.DeleteSach(maSach);

                        // Cập nhật dữ liệu trong DataGridView sau khi xóa
                        LoadData();

                        MessageBox.Show($"Đã xóa sách '{tenSach}' thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa sách. Sách có thể đang được mượn hoặc có ràng buộc dữ liệu khác!\nLỗi: " + ex.Message,
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            EditSelectedBook();
        }
    }
}
