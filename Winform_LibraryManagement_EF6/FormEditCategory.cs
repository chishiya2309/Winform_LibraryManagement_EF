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
    public partial class FormEditCategory : Form
    {
        private readonly IDanhMucSachService _danhMucSachService;
        private List<DanhMucSach> _danhMucList;
        private string _maDanhMuc;
        private DanhMucSach _danhMucSach;

        public FormEditCategory(string maDanhMuc)
        {
            InitializeComponent();
            _danhMucSachService = new DanhMucSachService();
            _maDanhMuc = maDanhMuc;
            LoadData();
        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {
            txtTenDanhMuc.Focus();

        }

        private void LoadData()
        {
            try
            {
                //Lấy danh mục cần chỉnh sửa
                _danhMucSach = _danhMucSachService.GetDanhMucById(_maDanhMuc);

                if(_danhMucSach == null)
                {
                    MessageBox.Show("Không tìm thấy danh mục cần chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }    

                //Lấy danh sách tất cả danh mục để hiển thị trong combobox danh mục cha
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

                // Tạo bản sao để không ảnh hưởng đến dữ liệu gốc
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

                //Điền dữ liệu vào các control
                txtMaDanhMuc.Text = _danhMucSach.MaDanhMuc;
                txtMaDanhMuc.ReadOnly = true; // Không cho phép sửa mã danh mục
                txtTenDanhMuc.Text = _danhMucSach.TenDanhMuc;
                txtMoTa.Text = _danhMucSach.MoTa;

                // Chọn danh mục cha
                if (string.IsNullOrEmpty(_danhMucSach.DanhMucCha))
                {
                    cmbDanhMucCha.SelectedIndex = 0; // Chọn "Không có danh mục cha"
                }
                else
                {
                    //Tìm index của danh mục cha trong danh sách
                    var selectedIndex  = displayList.FindIndex(d => d.MaDanhMuc == _danhMucSach.DanhMucCha);
                    if(selectedIndex >= 0)
                    {
                        cmbDanhMucCha.SelectedIndex = selectedIndex;
                    }
                    else
                    {
                        cmbDanhMucCha.SelectedIndex = 0; // Nếu không tìm thấy, chọn "Không có danh mục cha"
                    }
                } 
                    
                txtSoLuongSach.Text = _danhMucSach.SoLuongSach.ToString();
                cmbTrangThai.SelectedIndex = (_danhMucSach.TrangThai == "Hoạt động") ? 0 : 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
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
                string tenDanhMuc = txtTenDanhMuc.Text.Trim();
                string moTa = txtMoTa.Text.Trim();

                // Xử lý danh mục cha (có thể là null)
                string danhMucCha = cmbDanhMucCha.SelectedValue as string;

                // Kiểm tra không cho phép chọn chính nó làm danh mục cha
                if (danhMucCha == _maDanhMuc)
                {
                    MessageBox.Show("Không thể chọn chính danh mục này làm danh mục cha!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int soLuongSach = Convert.ToInt32(txtSoLuongSach.Text.Trim());
                string trangThai = cmbTrangThai.SelectedItem.ToString();

                // Cập nhật danh mục
                _danhMucSach.TenDanhMuc = tenDanhMuc;
                _danhMucSach.MoTa = moTa;
                _danhMucSach.DanhMucCha = danhMucCha;
                _danhMucSach.SoLuongSach = soLuongSach;
                _danhMucSach.TrangThai = trangThai;

                //Cập nhật thông qua service
                _danhMucSachService.UpdateDanhMuc(_danhMucSach);

                MessageBox.Show("Cập nhật danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTenDanhMuc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDanhMuc.Focus();
                return false;
            }

            if (txtTenDanhMuc.Text.Length > 255)
            {
                MessageBox.Show("Tên danh mục không được vượt quá 255 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDanhMuc.Focus();
                return false;
            }

            if (txtMoTa.Text.Length > 500)
            {
                MessageBox.Show("Mô tả không được vượt quá 500 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTa.Focus();
                return false;
            }

            if (!int.TryParse(txtSoLuongSach.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng sách phải là số nguyên không âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongSach.Focus();
                return false;
            }
            return true;
        }
    }
}
