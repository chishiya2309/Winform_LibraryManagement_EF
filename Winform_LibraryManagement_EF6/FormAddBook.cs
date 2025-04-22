using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;

namespace Winform_LibraryManagement_EF6
{
    public partial class FormAddBook : Form
    {
        private readonly ISachService _sachService;
        private readonly IDanhMucSachService _danhMucSachService;
        private List<DanhMucSach> _danhMucList;

        public FormAddBook()
        {
            InitializeComponent();
            _sachService = new SachService();
            _danhMucSachService = new DanhMucSachService();
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                _danhMucList = _danhMucSachService.GetAllDanhMucDTO()
                    .Select(dto => new DanhMucSach
                    {
                        MaDanhMuc = dto.MaDanhMuc,
                        TenDanhMuc = dto.TenDanhMuc
                    }).ToList();

                cmbDanhMuc.DataSource = _danhMucList;
                cmbDanhMuc.DisplayMember = "TenDanhMuc";
                cmbDanhMuc.ValueMember = "MaDanhMuc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddBook_Load(object sender, EventArgs e)
        {
            // Form đã được tải dữ liệu trong constructor
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                // Tạo đối tượng Sach từ dữ liệu form
                Sach sach = new Sach
                {
                    MaSach = txtMaSach.Text.Trim(),
                    ISBN = txtISBN.Text.Trim(),
                    TenSach = txtTenSach.Text.Trim(),
                    TacGia = txtTacGia.Text.Trim(),
                    MaDanhMuc = cmbDanhMuc.SelectedValue.ToString(),
                    NamXuatBan = Convert.ToInt32(txtNamXuatBan.Text.Trim()),
                    NXB = txtNXB.Text.Trim(),
                    SoBan = Convert.ToInt32(txtSoBan.Text.Trim()),
                    KhaDung = Convert.ToInt32(txtSoBan.Text.Trim()), // Khi thêm mới, KhaDung = SoBan
                    ViTri = txtViTri.Text.Trim()
                };

                // Thêm sách thông qua service
                _sachService.AddSach(sach);

                MessageBox.Show("Thêm sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Vui lòng nhập mã ISBN!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTacGia.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTacGia.Focus();
                return false;
            }

            // Kiểm tra định dạng số
            if (!int.TryParse(txtNamXuatBan.Text, out _))
            {
                MessageBox.Show("Năm xuất bản phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamXuatBan.Focus();
                return false;
            }

            if (!int.TryParse(txtSoBan.Text, out int soBan) || soBan <= 0)
            {
                MessageBox.Show("Số bản phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoBan.Focus();
                return false;
            }

            // Kiểm tra mã sách và ISBN đã tồn tại chưa
            if (_sachService.SachExists(txtMaSach.Text.Trim()))
            {
                MessageBox.Show("Mã sách đã tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                return false;
            }

            if (_sachService.ISBNExists(txtISBN.Text.Trim()))
            {
                MessageBox.Show("ISBN đã tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
