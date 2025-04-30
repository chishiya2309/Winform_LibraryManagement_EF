using BusinessAccessLayer;
using BusinessAccessLayer.DTOs;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_PhieuMuonQuaHan : UserControl
    {
        private readonly IThanhVienService _thanhVienService;
        private readonly ISachService _sachService;
        private readonly IPhieuMuonService _phieuMuonService;

        private List<ThanhVien> _thanhVienList;
        private List<Sach> _sachList;
        private List<PhieuMuonDTO> _phieuMuonList;

        public AdminControl_PhieuMuonQuaHan()
        {
            InitializeComponent();
            _thanhVienService = new ThanhVienService();
            _sachService = new SachService();
            _phieuMuonService = new PhieuMuonService();
            LoadData();
            lblNoData.Location = new Point(
                larGridView.Location.X + (larGridView.Width - lblNoData.Width) / 2,
                larGridView.Location.Y + (larGridView.Height - lblNoData.Height) / 2
            );
        }

        private void LoadData()
        {
            _thanhVienList = _thanhVienService.GetAllThanhVienDTO()
                .Select(dto => new ThanhVien
                {
                    MaThanhVien = dto.MaThanhVien,
                    HoTen = dto.HoTen
                }).ToList();

            (larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn).DataSource = _thanhVienList;
            (larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";
            (larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn).ValueMember = "MaThanhVien";

            _sachList = _sachService.GetAllSachDTO()
                .Select(dto => new Sach
                {
                    MaSach = dto.MaSach,
                    TenSach = dto.TenSach
                }).ToList();

            (larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn).DataSource = _sachList;
            (larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn).ValueMember = "MaSach";
            (larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn).DisplayMember = "TenSach";

            _phieuMuonList = _phieuMuonService.GetPhieuMuonQuaHanDTO().ToList();

            if (_phieuMuonList.Any())
            {
                lblNoData.Visible = false;
                larGridView.Visible = true;
            }
            else
            {
                lblNoData.Visible = true;
                larGridView.Visible = false;
            }

            larGridView.DataSource = _phieuMuonList;
        }

        private void larGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (larGridView.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value is string trangThai)
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void larGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
