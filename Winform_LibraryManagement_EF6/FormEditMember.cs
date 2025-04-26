using BusinessAccessLayer;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class FormEditMember : Form
    {
        private readonly IThanhVienService _thanhVienService;
        private string _maThanhVien;
        private ThanhVien _thanhVienHienTai;
        public FormEditMember(ThanhVien thanhVien)
        {
            InitializeComponent();
            _maThanhVien = thanhVien.MaThanhVien;
            _thanhVienService = new ThanhVienService();
            _thanhVienHienTai = thanhVien;
            LoadData();
        }

        private void LoadData()
        {
           txtMaThanhVien.Text = _thanhVienHienTai.MaThanhVien;
            txtMaThanhVien.Enabled = false;
            txtHoTen.Text = _thanhVienHienTai.HoTen;
            cmbGioiTinh.SelectedItem = _thanhVienHienTai.GioiTinh;
            txtSoDienThoai.Text = _thanhVienHienTai.SoDienThoai;
            txtEmail.Text = _thanhVienHienTai.Email;
            cmbLoaiThanhVien.SelectedItem = _thanhVienHienTai.LoaiThanhVien;
            dtpNgayDangKy.Value = _thanhVienHienTai.NgayDangKy;
            dtpNgayHetHan.Value = _thanhVienHienTai.NgayHetHan;
            cmbTrangThai.SelectedItem = _thanhVienHienTai.TrangThai;
        }

        private void FormEditMember_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                // Cập nhật thông tin thành viên
                _thanhVienHienTai.HoTen = txtHoTen.Text.Trim();
                _thanhVienHienTai.GioiTinh = cmbGioiTinh.SelectedItem.ToString();
                _thanhVienHienTai.SoDienThoai = txtSoDienThoai.Text.Trim();
                _thanhVienHienTai.Email = txtEmail.Text.Trim();
                _thanhVienHienTai.LoaiThanhVien = cmbLoaiThanhVien.SelectedItem.ToString();
                _thanhVienHienTai.NgayDangKy = dtpNgayDangKy.Value;
                _thanhVienHienTai.NgayHetHan = dtpNgayHetHan.Value;
                _thanhVienHienTai.TrangThai = cmbTrangThai.SelectedItem.ToString();

                // Cập nhật thông tin qua service
                _thanhVienService.UpdateThanhVien(_thanhVienHienTai);

                MessageBox.Show("Cập nhật thông tin thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin thành viên: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateInputs()
        {
            // Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên thành viên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }

            // Kiểm tra định dạng số điện thoại
            string phonePattern = @"^0\d{9,10}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSoDienThoai.Text, phonePattern))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Số điện thoại phải bắt đầu bằng số 0 và có 10-11 chữ số.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }

            // Kiểm tra số điện thoại đã tồn tại nếu thay đổi
            if (_thanhVienHienTai.SoDienThoai != txtSoDienThoai.Text.Trim())
            {
                if (_thanhVienService.SoDienThoaiExists(txtSoDienThoai.Text.Trim()))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoDienThoai.Focus();
                    return false;
                }
            }

            // Kiểm tra email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Kiểm tra định dạng email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Kiểm tra email đã tồn tại nếu thay đổi
            if (_thanhVienHienTai.Email != txtEmail.Text.Trim())
            {
                if (_thanhVienService.EmailExists(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email đã tồn tại trong hệ thống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            // Kiểm tra ngày hết hạn không được nhỏ hơn ngày đăng ký
            if (dtpNgayHetHan.Value < dtpNgayDangKy.Value)
            {
                MessageBox.Show("Ngày hết hạn không được nhỏ hơn ngày đăng ký!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayHetHan.Focus();
                return false;
            }
            return true;
        }
    }
}
