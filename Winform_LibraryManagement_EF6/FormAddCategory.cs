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
using BusinessAccessLayer;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;

namespace Winform_LibraryManagement_EF6
{
    public partial class FormAddCategory : Form
    {
        private readonly IDanhMucSachService _danhMucSachService;
        private List<DanhMucSach> _danhMucList;

        public FormAddCategory()
        {
            InitializeComponent();
            _danhMucSachService = new DanhMucSachService();
            LoadParentCatengories();
        }

        private void LoadParentCatengories()
        {
            try
            {
                // Lấy danh sách danh mục từ service
                _danhMucList = _danhMucSachService.GetAllDanhMucDTO()
                    .Select(dto => new DanhMucSach
                    {
                        MaDanhMuc = dto.MaDanhMuc,
                        TenDanhMuc = dto.TenDanhMuc,
                        MoTa = dto.MoTa,
                        DanhMucCha = dto.DanhMucCha,
                        SoLuongSach = dto.SoLuongSach,
                        NgayTao = dto.NgayTao,
                        CapNhatLanCuoi = dto.CapNhatLanCuoi,
                        TrangThai = dto.TrangThai
                    }).ToList();

                // Tạo bản sao để không làm ảnh hưởng đến dữ liệu gốc
                var displayList = new List<DanhMucSach>(_danhMucList);

                // Thêm tùy chọn "Không có danh mục cha"
                displayList.Insert(0, new DanhMucSach
                {
                    MaDanhMuc = null,
                    TenDanhMuc = "-- Không có danh mục cha --"
                });

                cmbDanhMucCha.DataSource = displayList;
                cmbDanhMucCha.DisplayMember = "TenDanhMuc";
                cmbDanhMucCha.ValueMember = "MaDanhMuc";
                cmbDanhMucCha.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục cha: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                string maDanhMuc = txtMaDanhMuc.Text.Trim();
                string tenDanhMuc = txtTenDanhMuc.Text.Trim();
                string moTa = txtMoTa.Text.Trim();

                // Xử lý danh mục cha (có thể là null)
                string danhMucCha = cmbDanhMucCha.SelectedValue as string;
                int soLuongSach = Convert.ToInt32(txtSoLuongSach.Text.Trim());
                string trangThai = cmbTrangThai.SelectedItem as string;

                // Tạo đối tượng DanhMucSach mới
                var danhMuc = new DanhMucSach
                {
                    MaDanhMuc = maDanhMuc,
                    TenDanhMuc = tenDanhMuc,
                    MoTa = moTa,
                    DanhMucCha = danhMucCha,
                    SoLuongSach = soLuongSach,
                    TrangThai = trangThai
                };

                try
                {
                    // Thêm danh mục mới thông qua service
                    _danhMucSachService.AddDanhMuc(danhMuc);
                    MessageBox.Show("Thêm danh mục mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {
            // Khởi tạo các giá trị mặc định
            txtSoLuongSach.Text = "0";
            cmbTrangThai.SelectedIndex = 0; //Cho trạng thái mặc định là Hoạt động
        }

        private bool ValidateInputs()
        {
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaDanhMuc.Text))
            {
                MessageBox.Show("Vui lòng nhập mã danh mục!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDanhMuc.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenDanhMuc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDanhMuc.Focus();
                return false;
            }

            // Kiểm tra định dạng số lượng sách
            if (!int.TryParse(txtSoLuongSach.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng sách phải là số nguyên không âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongSach.Focus();
                return false;
            }

            // Kiểm tra trùng mã danh mục
            if (_danhMucSachService.DanhMucExists(txtMaDanhMuc.Text.Trim()))
            {
                MessageBox.Show("Mã danh mục đã tồn tại, vui lòng chọn mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDanhMuc.Focus();
                return false;
            }

            return true;
        }
    }
}
