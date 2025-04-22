using System;
using System.Data;
using System.Windows.Forms;
using DataAccessLayer.Models;
using BusinessAccessLayer.Services;

namespace Winform_LibraryManagement_EF6
{
    public partial class FormEditStaff : Form
    {
        private readonly INhanVienService _nhanVienService;
        private NhanVien _nhanVienHienTai;
        private string _maNhanVien;

        public FormEditStaff(NhanVien nhanVien)
        {
            InitializeComponent();
            _nhanVienService = new NhanVienService();
            _maNhanVien = nhanVien.ID;
            _nhanVienHienTai = nhanVien;
            LoadStaffData();
        }

        private void LoadStaffData()
        {
                // Hiển thị thông tin nhân viên lên form
                txtID.Text = _nhanVienHienTai.ID;
                txtID.ReadOnly = true; // Không cho phép sửa mã nhân viên
                txtHoTen.Text = _nhanVienHienTai.HoTen;

                // Thiết lập giới tính
                cmbGioiTinh.SelectedItem = _nhanVienHienTai.GioiTinh;

                // Thiết lập chức vụ
                cmbChucVu.SelectedItem = _nhanVienHienTai.ChucVu;

                txtEmail.Text = _nhanVienHienTai.Email;
                txtSoDienThoai.Text = _nhanVienHienTai.SoDienThoai;
                dtpNgayVaoLam.Value = _nhanVienHienTai.NgayVaoLam;

                // Thiết lập trạng thái
                cmbTrangThai.SelectedItem = _nhanVienHienTai.TrangThai;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                // Cập nhật thông tin nhân viên từ form
                _nhanVienHienTai.HoTen = txtHoTen.Text.Trim();
                _nhanVienHienTai.GioiTinh = cmbGioiTinh.SelectedItem.ToString();
                _nhanVienHienTai.ChucVu = cmbChucVu.SelectedItem.ToString();
                _nhanVienHienTai.Email = txtEmail.Text.Trim();
                _nhanVienHienTai.SoDienThoai = txtSoDienThoai.Text.Trim();
                _nhanVienHienTai.NgayVaoLam = dtpNgayVaoLam.Value;
                _nhanVienHienTai.TrangThai = cmbTrangThai.SelectedItem.ToString();

                // Cập nhật vào cơ sở dữ liệu thông qua service
                _nhanVienService.UpdateNhanVien(_nhanVienHienTai);

                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Kiểm tra họ tên nhân viên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên của nhân viên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
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

            // Kiểm tra email đã tồn tại chưa (nếu đã thay đổi)
            if (_nhanVienHienTai.Email != txtEmail.Text.Trim() && _nhanVienService.EmailExists(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống!", "Lỗi",
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

            // Kiểm tra số điện thoại đã tồn tại chưa (nếu đã thay đổi)
            if (_nhanVienHienTai.SoDienThoai != txtSoDienThoai.Text.Trim() && _nhanVienService.SoDienThoaiExists(txtSoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }

            return true;
        }

        private void FormEditStaff_Load(object sender, EventArgs e)
        {
            // Có thể thêm khởi tạo bổ sung tại đây nếu cần
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
