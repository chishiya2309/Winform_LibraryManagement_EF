using System;
using System.Windows.Forms;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;
using System.Linq;

namespace Winform_LibraryManagement_EF6
{
    public partial class frmMain : Form
    {
        private readonly DanhMucSachService _danhMucService;
        private readonly SachService _sachService;

        public frmMain()
        {
            InitializeComponent();
            _danhMucService = new DanhMucSachService();
            _sachService = new SachService();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDanhMucToComboBox();
            LoadSachToListView();
        }

        private void LoadDanhMucToComboBox()
        {
            try
            {
                var danhMucs = _danhMucService.GetAllDanhMuc().ToList();
                cmbDanhMuc.DataSource = danhMucs;
                cmbDanhMuc.DisplayMember = "TenDanhMuc";
                cmbDanhMuc.ValueMember = "MaDanhMuc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSachToListView()
        {
            try
            {
                lvSach.Items.Clear();
                var sachs = _sachService.GetAllSach().ToList();

                foreach (var sach in sachs)
                {
                    var item = new ListViewItem(sach.MaSach);
                    item.SubItems.Add(sach.TenSach);
                    item.SubItems.Add(sach.TacGia);
                    item.SubItems.Add(sach.NXB);
                    item.SubItems.Add(sach.NamXuatBan.ToString());
                    item.SubItems.Add(sach.SoBan.ToString());
                    item.SubItems.Add(sach.KhaDung.ToString());
                    item.Tag = sach;
                    lvSach.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDanhMuc.SelectedValue != null)
            {
                try
                {
                    string maDanhMuc = cmbDanhMuc.SelectedValue.ToString();
                    var sachs = _sachService.GetSachByDanhMuc(maDanhMuc).ToList();

                    lvSach.Items.Clear();
                    foreach (var sach in sachs)
                    {
                        var item = new ListViewItem(sach.MaSach);
                        item.SubItems.Add(sach.TenSach);
                        item.SubItems.Add(sach.TacGia);
                        item.SubItems.Add(sach.NXB);
                        item.SubItems.Add(sach.NamXuatBan.ToString());
                        item.SubItems.Add(sach.SoBan.ToString());
                        item.SubItems.Add(sach.KhaDung.ToString());
                        item.Tag = sach;
                        lvSach.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lọc sách theo danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                {
                    LoadSachToListView();
                    return;
                }

                var sachs = _sachService.SearchSach(keyword).ToList();

                lvSach.Items.Clear();
                foreach (var sach in sachs)
                {
                    var item = new ListViewItem(sach.MaSach);
                    item.SubItems.Add(sach.TenSach);
                    item.SubItems.Add(sach.TacGia);
                    item.SubItems.Add(sach.NXB);
                    item.SubItems.Add(sach.NamXuatBan.ToString());
                    item.SubItems.Add(sach.SoBan.ToString());
                    item.SubItems.Add(sach.KhaDung.ToString());
                    item.Tag = sach;
                    lvSach.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSachToListView();
            cmbDanhMuc.SelectedIndex = -1;
            txtTimKiem.Clear();
        }
    }
}