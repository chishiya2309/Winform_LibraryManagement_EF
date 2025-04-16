using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_Categories: UserControl
    {
        private readonly DanhMucSachService _danhMucSachService;
        private List<DanhMucSach> _danhMucSachs;
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

        private void LoadData()
        {
            try
            {
                _danhMucSachs = _danhMucSachService.GetAllDanhMuc().ToList();

                // Configure ComboBox column for parent categories
                var danhMucChaColumn = categoriesGridView.Columns["DanhMucCha"] as DataGridViewComboBoxColumn;
                if (danhMucChaColumn != null)
                {
                    danhMucChaColumn.DataSource = _danhMucSachs;
                    danhMucChaColumn.DisplayMember = "TenDanhMuc";
                    danhMucChaColumn.ValueMember = "MaDanhMuc";
                }

                categoriesGridView.DataSource = _danhMucSachs;
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
            bool hasData = _danhMucSachs != null && _danhMucSachs.Any();
            lblNoData.Visible = !hasData;
            categoriesGridView.Visible = hasData;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
