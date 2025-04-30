using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessAccessLayer.Services;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_LowStockBooks : UserControl
    {
        private readonly ISachService _sachService;
        private readonly IDanhMucSachService _danhMucService;

        public AdminControl_LowStockBooks()
        {
            InitializeComponent();
            _sachService = new SachService();
            _danhMucService = new DanhMucSachService();
            LoadData();
            lblNoData.Location = new Point(
                booksGridView.Location.X + (booksGridView.Width - lblNoData.Width) / 2,
                booksGridView.Location.Y + (booksGridView.Height - lblNoData.Height) / 2
            );
        }

        private void LoadData()
        {
            // Lấy danh sách danh mục
            var danhMucs = _danhMucService.GetAllDanhMucDTO();
            (booksGridView.Columns["MaDanhMuc"] as DataGridViewComboBoxColumn).DataSource = danhMucs;
            (booksGridView.Columns["MaDanhMuc"] as DataGridViewComboBoxColumn).DisplayMember = "TenDanhMuc";
            (booksGridView.Columns["MaDanhMuc"] as DataGridViewComboBoxColumn).ValueMember = "MaDanhMuc";

            // Lấy danh sách sách có số lượng khả dụng < 3
            var lowStockBooks = _sachService.GetAllSachDTO()
                .Where(s => s.KhaDung < 3)
                .ToList();

            // Tạo DataTable từ danh sách sách
            DataTable dtSach = new DataTable();
            dtSach.Columns.Add("MaSach", typeof(string));
            dtSach.Columns.Add("ISBN", typeof(string));
            dtSach.Columns.Add("TenSach", typeof(string));
            dtSach.Columns.Add("TacGia", typeof(string));
            dtSach.Columns.Add("MaDanhMuc", typeof(string));
            dtSach.Columns.Add("NamXuatBan", typeof(int));
            dtSach.Columns.Add("NXB", typeof(string));
            dtSach.Columns.Add("SoBan", typeof(int));
            dtSach.Columns.Add("KhaDung", typeof(int));
            dtSach.Columns.Add("ViTri", typeof(string));

            foreach (var sach in lowStockBooks)
            {
                dtSach.Rows.Add(
                    sach.MaSach,
                    sach.ISBN,
                    sach.TenSach,
                    sach.TacGia,
                    sach.MaDanhMuc,
                    sach.NamXuatBan,
                    sach.NXB,
                    sach.SoBan,
                    sach.KhaDung,
                    sach.ViTri
                );
            }

            // Kiểm tra nếu không có dữ liệu thì ẩn DataGridView, hiển thị Label
            if (dtSach.Rows.Count == 0)
            {
                lblNoData.Visible = true;
                booksGridView.Visible = false;
            }
            else
            {
                lblNoData.Visible = false;
                booksGridView.Visible = true;
            }

            booksGridView.DataSource = dtSach;
        }

        private void AdminControl_LowStockBooks_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
