using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;

namespace Winform_LibraryManagement_EF6
{
    public partial class FormEditBook : Form
    {
        private readonly ISachService _sachService;
        private readonly IDanhMucSachService _danhMucSachService;
        private List<DanhMucSach> _danhMucList;
        private string _maSach;
        private Sach _sachHienTai;

        public FormEditBook(Sach sach)
        {
            InitializeComponent();
            _sachService = new SachService();
            _danhMucSachService = new DanhMucSachService();

            _maSach = sach.MaSach;
            _sachHienTai = sach;

            LoadCategories();
            PopulateBookData();
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

        private void PopulateBookData()
        {
            txtMaSach.Text = _sachHienTai.MaSach;
            txtMaSach.ReadOnly = true; // Không cho phép sửa mã sách
            txtISBN.Text = _sachHienTai.ISBN;
            txtTenSach.Text = _sachHienTai.TenSach;
            txtTacGia.Text = _sachHienTai.TacGia;

            // Thiết lập giá trị cho ComboBox danh mục
            if (!string.IsNullOrEmpty(_sachHienTai.MaDanhMuc))
            {
                cmbDanhMuc.SelectedValue = _sachHienTai.MaDanhMuc;
            }

            txtNamXuatBan.Text = _sachHienTai.NamXuatBan.ToString();
            txtNXB.Text = _sachHienTai.NXB;
            txtSoBan.Text = _sachHienTai.SoBan.ToString();
            txtKhaDung.Text = _sachHienTai.KhaDung.ToString();
            txtViTri.Text = _sachHienTai.ViTri;
        }

        private void FormEditBook_Load(object sender, EventArgs e)
        {
            // Form đã được tải dữ liệu trong constructor
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                // Cập nhật thông tin từ form vào đối tượng sách hiện tại
                _sachHienTai.ISBN = txtISBN.Text.Trim();
                _sachHienTai.TenSach = txtTenSach.Text.Trim();
                _sachHienTai.TacGia = txtTacGia.Text.Trim();
                _sachHienTai.MaDanhMuc = cmbDanhMuc.SelectedValue.ToString();
                _sachHienTai.NamXuatBan = Convert.ToInt32(txtNamXuatBan.Text.Trim());
                _sachHienTai.NXB = txtNXB.Text.Trim();
                _sachHienTai.SoBan = Convert.ToInt32(txtSoBan.Text.Trim());
                _sachHienTai.KhaDung = Convert.ToInt32(txtKhaDung.Text.Trim());
                _sachHienTai.ViTri = txtViTri.Text.Trim();

                // Cập nhật sách thông qua service
                _sachService.UpdateSach(_sachHienTai);

                MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Kiểm tra thông tin bắt buộc
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

            if (!int.TryParse(txtSoBan.Text, out int soBan) || soBan < 0)
            {
                MessageBox.Show("Số bản phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoBan.Focus();
                return false;
            }

            if (!int.TryParse(txtKhaDung.Text, out int khaDung) || khaDung < 0)
            {
                MessageBox.Show("Số lượng khả dụng phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhaDung.Focus();
                return false;
            }

            if (khaDung > soBan)
            {
                MessageBox.Show("Số lượng khả dụng không thể lớn hơn tổng số bản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhaDung.Focus();
                return false;
            }

            // Kiểm tra xem nếu đổi ISBN thì ISBN mới không được trùng với ISBN sách khác
            string newISBN = txtISBN.Text.Trim();
            if (newISBN != _sachHienTai.ISBN && _sachService.ISBNExists(newISBN))
            {
                MessageBox.Show("ISBN đã tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                return false;
            }

            return true;
        }
    }
}
