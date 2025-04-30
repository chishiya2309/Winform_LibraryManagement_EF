using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_expiringMembers : UserControl
    {
        private readonly IThanhVienService _thanhVienService;

        public AdminControl_expiringMembers()
        {
            InitializeComponent();
            _thanhVienService = new ThanhVienService();
            LoadData();
            lblNoData.Location = new Point(
                membersGridView.Location.X + (membersGridView.Width - lblNoData.Width) / 2,
                membersGridView.Location.Y + (membersGridView.Height - lblNoData.Height) / 2
            );
        }

        private void LoadData()
        {
            var thanhVienSapHetHan = _thanhVienService.GetThanhVienSapHetHan(30);

            // Tạo DataTable từ danh sách thành viên
            DataTable dtThanhVien = new DataTable();
            dtThanhVien.Columns.Add("MaThanhVien", typeof(string));
            dtThanhVien.Columns.Add("HoTen", typeof(string));
            dtThanhVien.Columns.Add("GioiTinh", typeof(string));
            dtThanhVien.Columns.Add("SoDienThoai", typeof(string));
            dtThanhVien.Columns.Add("Email", typeof(string));
            dtThanhVien.Columns.Add("LoaiThanhVien", typeof(string));
            dtThanhVien.Columns.Add("NgayDangKy", typeof(DateTime));
            dtThanhVien.Columns.Add("NgayHetHan", typeof(DateTime));
            dtThanhVien.Columns.Add("TrangThai", typeof(string));

            foreach (var tv in thanhVienSapHetHan)
            {
                dtThanhVien.Rows.Add(
                    tv.MaThanhVien,
                    tv.HoTen,
                    tv.GioiTinh,
                    tv.SoDienThoai,
                    tv.Email,
                    tv.LoaiThanhVien,
                    tv.NgayDangKy,
                    tv.NgayHetHan,
                    tv.TrangThai
                );
            }

            // Kiểm tra nếu không có dữ liệu thì ẩn DataGridView, hiển thị Label
            if (dtThanhVien.Rows.Count == 0)
            {
                lblNoData.Visible = true;
                membersGridView.Visible = false;
            }
            else
            {
                lblNoData.Visible = false;
                membersGridView.Visible = true;
            }

            membersGridView.DataSource = dtThanhVien;
        }

        private void membersGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (membersGridView.Columns[e.ColumnIndex].Name == "NgayHetHan")
            {
                e.CellStyle.ForeColor = Color.Orange;
            }
        }

        private void membersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không cần xử lý
        }
    }
}
