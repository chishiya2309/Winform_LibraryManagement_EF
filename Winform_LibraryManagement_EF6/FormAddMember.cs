//using BusinessAccessLayer;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//namespace Winform_LibraryManagement_EF6
//{
//    public partial class FormAddMember : Form
//    {
//        DBMembers dbMembers;
//        public FormAddMember()
//        {
//            InitializeComponent();
//            dbMembers = new DBMembers();
//            InitializeForm();
//        }

//        private void InitializeForm()
//        {
//            // Thiết lập giá trị mặc định
//            dtpNgayDangKy.Value = DateTime.Now;
//            dtpNgayHetHan.Value = DateTime.Now.AddYears(2);

//            cmbGioiTinh.SelectedIndex = 0;
//            cmbLoaiThanhVien.SelectedIndex = 0;
//            cmbTrangThai.SelectedIndex = 0;
//        }

//        private void FormAddMember_Load(object sender, EventArgs e)
//        {

//        }

//        private void btnCancel_Click(object sender, EventArgs e)
//        {
//            DialogResult = DialogResult.Cancel;
//            this.Close();
//        }

//        private void btnSave_Click(object sender, EventArgs e)
//        {
//            if (!ValidateInputs())
//            {
//                return;
//            }

//            try
//            {
//                string maThanhVien = txtMaThanhVien.Text.Trim();
//                string hoTen = txtHoTen.Text.Trim();
//                string gioiTinh = cmbGioiTinh.SelectedItem.ToString();
//                string soDienThoai = txtSoDienThoai.Text.Trim();
//                string email = txtEmail.Text.Trim();
//                string loaiThanhVien = cmbLoaiThanhVien.SelectedItem.ToString();
//                DateTime ngayDangKy = dtpNgayDangKy.Value;
//                DateTime ngayHetHan = dtpNgayHetHan.Value;
//                string trangThai = cmbTrangThai.SelectedItem.ToString();

//                string err = "";
//                bool success = dbMembers.ThemThanhVien(ref err, maThanhVien, hoTen, gioiTinh, soDienThoai, email, loaiThanhVien, ngayDangKy, ngayHetHan, trangThai);

//                if (success)
//                {
//                    MessageBox.Show("Thêm thành viên mới thành công!", "Thông báo",
//                        MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    DialogResult = DialogResult.OK;
//                    this.Close();
//                }
//                else
//                {
//                    MessageBox.Show("Lỗi khi thêm thành viên: " + err, "Lỗi",
//                        MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private bool ValidateInputs()
//        {
//            // Kiểm tra mã thành viên
//            if (string.IsNullOrWhiteSpace(txtMaThanhVien.Text))
//            {
//                MessageBox.Show("Vui lòng nhập mã thành viên!", "Lỗi",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtMaThanhVien.Focus();
//                return false;
//            }

//            // Kiểm tra họ tên
//            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
//            {
//                MessageBox.Show("Vui lòng nhập họ tên thành viên!", "Lỗi",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtHoTen.Focus();
//                return false;
//            }

//            // Kiểm tra số điện thoại
//            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
//            {
//                MessageBox.Show("Vui lòng nhập số điện thoại!", "Lỗi",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtSoDienThoai.Focus();
//                return false;
//            }

//            // Kiểm tra định dạng số điện thoại
//            string phonePattern = @"^0\d{9,10}$";
//            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSoDienThoai.Text, phonePattern))
//            {
//                MessageBox.Show("Số điện thoại không hợp lệ! Số điện thoại phải bắt đầu bằng số 0 và có 10-11 chữ số.",
//                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtSoDienThoai.Focus();
//                return false;
//            }

//            // Kiểm tra email
//            if (string.IsNullOrWhiteSpace(txtEmail.Text))
//            {
//                MessageBox.Show("Vui lòng nhập địa chỉ email!", "Lỗi",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtEmail.Focus();
//                return false;
//            }

//            // Kiểm tra định dạng email
//            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
//            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
//            {
//                MessageBox.Show("Địa chỉ email không hợp lệ!", "Lỗi",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtEmail.Focus();
//                return false;
//            }

//            // Kiểm tra ngày hết hạn phải lớn hơn ngày đăng ký
//            if (dtpNgayHetHan.Value <= dtpNgayDangKy.Value)
//            {
//                MessageBox.Show("Ngày hết hạn phải lớn hơn ngày đăng ký!", "Lỗi",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                dtpNgayHetHan.Focus();
//                return false;
//            }

//            return true;
//        }
//    }
//}
