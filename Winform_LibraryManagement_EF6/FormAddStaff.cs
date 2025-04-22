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
    public partial class FormAddStaff : Form
    {
        private readonly INhanVienService _nhanVienService;
        public FormAddStaff()
        {
            InitializeComponent();
            InitializeForm();
            _nhanVienService = new NhanVienService();
        }

        private void InitializeForm()
        {
            cmbGioiTinh.SelectedIndex = 0;
            cmbChucVu.SelectedIndex = 0;

            dtpNgayVaoLam.Value = DateTime.Now;

            cmbTrangThai.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormAddStaff_Load(object sender, EventArgs e)
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
                // Tạo đối tượng nhân viên mới với dữ liệu từ Form
                NhanVien nhanVien = new NhanVien
                {
                    ID = txtID.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    GioiTinh = cmbGioiTinh.SelectedItem.ToString(),
                    ChucVu = cmbChucVu.SelectedItem.ToString(),
                    Email = txtEmail.Text.Trim(),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    NgayVaoLam = dtpNgayVaoLam.Value,
                    TrangThai = cmbTrangThai.SelectedItem.ToString()
                };

                _nhanVienService.AddNhanVien(nhanVien);

                MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Kiểm tra mã nhân viên
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Vui lòng nhập ID của nhân viên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return false;
            }

            // Kiểm tra họ tên nhân viên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên của nhân viên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return false;
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

            // Kiểm tra email đã tồn tại chưa
            if (_nhanVienService.EmailExists(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email này đã được sử dụng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
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

            // Kiểm tra số điện thoại đã tồn tại chưa
            if (_nhanVienService.SoDienThoaiExists(txtSoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }
            return true;
        }
    }
}
