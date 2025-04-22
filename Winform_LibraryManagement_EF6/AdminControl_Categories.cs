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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using BusinessAccessLayer.DTOs;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_Categories : UserControl
    {
        private readonly IDanhMucSachService _danhMucSachService;
        private List<DanhMucSachDTO> _danhMucs;
        // Đối tượng đưa dữ liệu vào DataTable dtDanhMuc
        DataTable dtDanhMuc = null;
        public AdminControl_Categories()
        {
            InitializeComponent();
            Adjust();
            _danhMucSachService = new DanhMucSachService();
            LoadData();
        }



        private void Adjust()
        {
            searchPanel.Size = new Size(panel.Width - 40, 60);
            categoriesGridView.Size = new Size(panel.Width - 40, panel.Height - 280);
            MenuButton.Width = panel.Width - 40;
            lblNoData.Location = new Point(
       categoriesGridView.Location.X + (categoriesGridView.Width - lblNoData.Width) / 2,
      categoriesGridView.Location.Y + (categoriesGridView.Height - lblNoData.Height) / 2);
        }

        private void membersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            ShowAddCategoryForm();
        }

        private void ShowAddCategoryForm()
        {
            FormAddCategory formAddCategory = new FormAddCategory();
            if (formAddCategory.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                _danhMucs = _danhMucSachService.GetAllDanhMucDTO().ToList(); 

                // Configure ComboBox column for parent categories
                var danhMucChaColumn = categoriesGridView.Columns["DanhMucCha"] as DataGridViewComboBoxColumn;
                if (danhMucChaColumn != null)
                {
                    danhMucChaColumn.DataSource = _danhMucs;
                    danhMucChaColumn.DisplayMember = "TenDanhMuc";
                    danhMucChaColumn.ValueMember = "MaDanhMuc";
                }

                categoriesGridView.DataSource = _danhMucs;
                UpdateDataGridViewVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridViewVisibility()
        {
            bool hasData = _danhMucs != null && _danhMucs.Any();
            lblNoData.Visible = !hasData;
            categoriesGridView.Visible = hasData;
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            Adjust();
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCategoryDetails();
        }

        private void ViewCategoryDetails()
        {
            MessageBox.Show("Chức năng xem chi tiết danh mục sẽ được triển khai sau.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void categoriesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) ViewCategoryDetails();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedCategory();
        }

        private void EditSelectedCategory()
        {
            if (categoriesGridView.SelectedRows.Count == 0) return;

            DataGridViewRow selectedRow = categoriesGridView.SelectedRows[0];
            string maDanhMuc = selectedRow.Cells["MaDanhMuc"].Value.ToString();

            FormEditCategory formEditCategory = new FormEditCategory(maDanhMuc);
            if (formEditCategory.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedCategory();
        }

        private void DeleteSelectedCategory()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa danh mục này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Chức năng xóa danh mục sẽ được triển khai sau.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void xemSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCategoryBooks();
        }

        private void ViewCategoryBooks()
        {
            MessageBox.Show("Chức năng xem sách trong danh mục sẽ được triển khai sau.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (categoriesGridView.SelectedRows.Count > 0)
            {
                EditSelectedCategory();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một danh mục để chỉnh sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (categoriesGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataGridViewRow selectedRow = categoriesGridView.SelectedRows[0];
                string maDanhMuc = selectedRow.Cells["MaDanhMuc"].Value.ToString();
                string tenDanhMuc = selectedRow.Cells["TenDanhMuc"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa danh mục '{tenDanhMuc}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _danhMucSachService.DeleteDanhMuc(maDanhMuc);
                    LoadData();
                    MessageBox.Show($"Đã xóa danh mục '{tenDanhMuc}' thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa danh mục: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadCategory(searchTerm);
        }

        private void LoadCategory(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    _danhMucs = _danhMucSachService.GetAllDanhMucDTO().ToList();
                }
                else
                {
                    searchTerm = searchTerm.ToLower();
                    _danhMucs = _danhMucSachService.GetAllDanhMucDTO()
                        .Where(d => d.MaDanhMuc.ToLower().Contains(searchTerm) ||
                                  d.TenDanhMuc.ToLower().Contains(searchTerm) ||
                                  d.MoTa.ToLower().Contains(searchTerm))
                        .ToList();
                }

                categoriesGridView.DataSource = _danhMucs;
                UpdateDataGridViewVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm danh mục: {ex.Message}", "Lỗi",
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

        private void categoriesGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (categoriesGridView.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value is string trangThai)
            {
                switch (trangThai)
                {
                    case "Hoạt động":
                        e.CellStyle.ForeColor = Color.Green;
                        break;
                    case "Không hoạt động":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                    default:
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
