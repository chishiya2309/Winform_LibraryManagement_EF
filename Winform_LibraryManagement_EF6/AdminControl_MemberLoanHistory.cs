using BusinessAccessLayer.DTOs;
using BusinessAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_MemberLoanHistory : UserControl
    {
        private string _maThanhVien;
        private readonly IThanhVienService _thanhVienService;
        private readonly ISachService _sachService;
        private readonly IPhieuMuonService _phieuMuonService;

        private List<ThanhVienDTO> _thanhVienList;
        private List<SachDTO> _sachList;
        private List<PhieuMuonDTO> _phieuMuonList;

        public AdminControl_MemberLoanHistory()
        {
            InitializeComponent();
            _thanhVienService = new ThanhVienService();
            _sachService = new SachService();
            _phieuMuonService = new PhieuMuonService();
            LoadMembers(); // Chỉ load thành viên trước
        }

        private void LoadMembers()
        {
            _thanhVienList = _thanhVienService.GetAllThanhVienDTO().ToList();
            if(!_thanhVienList.Any())
            {
                MessageBox.Show("Không có dữ liệu thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmbThanhVien.DataSource = _thanhVienList;
            cmbThanhVien.DisplayMember = "HoTen";
            cmbThanhVien.ValueMember = "MaThanhVien";

            if (cmbThanhVien.Items.Count > 0)
            {
                cmbThanhVien.SelectedIndex = 0;
                _maThanhVien = cmbThanhVien.SelectedValue.ToString();
                LoadData(_maThanhVien);
            }
        }

        private void LoadData(string maThanhVien)
        {
            if (string.IsNullOrEmpty(maThanhVien)) return;

            try
            {
                _sachList = _sachService.GetAllSachDTO().ToList();

                (larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn).DataSource = _sachList;
                (larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn).DisplayMember = "TenSach";
                (larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn).ValueMember = "MaSach";

                _thanhVienList = _thanhVienService.GetAllThanhVienDTO().ToList();

                (larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn).DataSource = _thanhVienList;
                (larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";
                (larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn).ValueMember = "MaThanhVien";

                _phieuMuonList = _phieuMuonService.GetLichSuMuonTheoThanhVien(maThanhVien).ToList();
                larGridView.DataSource = _phieuMuonList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThanhVien.SelectedValue != null)
            {
                _maThanhVien = cmbThanhVien.SelectedValue.ToString();
                LoadData(_maThanhVien);
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
