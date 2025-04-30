using BusinessAccessLayer.Services;
using DataAccessLayer.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class FormEditLoansAndReturns : Form
    {
        private readonly IPhieuMuonService _phieuMuonService;
        private int _maPhieu;
        private PhieuMuon _phieuMuonHienTai;
        public FormEditLoansAndReturns(PhieuMuon phieuMuon)
        {
            InitializeComponent();
            _phieuMuonService = new PhieuMuonService();
            _maPhieu = phieuMuon.MaPhieu;
            _phieuMuonHienTai = phieuMuon;
            LoadLarData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadLarData()
        {
            txtMaPhieu.Text = _phieuMuonHienTai.MaPhieu.ToString();
            txtMaPhieu.ReadOnly = true;
            dtpNgayMuon.Focus();
            dtpNgayMuon.Value = _phieuMuonHienTai.NgayMuon;
            dtpHanTra.Value = _phieuMuonHienTai.HanTra;

            if (_phieuMuonHienTai.NgayTraThucTe != null)
            {
                dtpNgayTraThucTe.Value = (DateTime)_phieuMuonHienTai.NgayTraThucTe;
                dtpNgayTraThucTe.Checked = true;
            }
            else
            {
                dtpNgayTraThucTe.Checked = false;
            }

            cmbTrangThai.SelectedItem = _phieuMuonHienTai.TrangThai;

            nudSoLuong.Value = _phieuMuonHienTai.SoLuong;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                _phieuMuonHienTai.NgayMuon = dtpNgayMuon.Value;
                _phieuMuonHienTai.HanTra = dtpHanTra.Value;
                _phieuMuonHienTai.SoLuong = Convert.ToInt32(nudSoLuong.Value);
                _phieuMuonHienTai.TrangThai = cmbTrangThai.SelectedItem.ToString();
                DateTime? ngayTraThucTe = null;
                if (_phieuMuonHienTai.TrangThai == "Đang mượn" || _phieuMuonHienTai.TrangThai == "Quá hạn")
                {
                    ngayTraThucTe = null;
                }
                else
                {
                    if (dtpNgayTraThucTe.Checked)
                    {
                        ngayTraThucTe = dtpNgayTraThucTe.Value;
                    }
                }

                _phieuMuonHienTai.NgayTraThucTe = ngayTraThucTe;


                _phieuMuonService.UpdatePhieuMuon(_phieuMuonHienTai);

                    MessageBox.Show("Cập nhật thông tin phiếu mượn thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin phiếu mượn: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEditLoansAndReturns_Load(object sender, EventArgs e)
        {

        }
    }
}
