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
            //try
            //{
            //    int maPhieu = Convert.ToInt32(txtMaPhieu.Text.ToString());
            //    DateTime NgayMuon = dtpNgayMuon.Value;
            //    DateTime HanTra = dtpHanTra.Value;
            //    int soLuong = Convert.ToInt32(nudSoLuong.Value);
            //    string trangThai = cmbTrangThai.SelectedItem.ToString();
            //    DateTime? ngayTraThucTe = null;
            //    if (trangThai == "Đang mượn" || trangThai == "Quá hạn")
            //    {
            //        ngayTraThucTe = null;
            //    }
            //    else
            //    {
            //        if (dtpNgayTraThucTe.Checked)
            //        {
            //            ngayTraThucTe = dtpNgayTraThucTe.Value;
            //        }
            //    }


            //    string err = "";
            //    bool success = dblar.SuaPhieuMuon(ref err, maPhieu, NgayMuon, HanTra,
            //        ngayTraThucTe, trangThai, soLuong);

            //    if (success)
            //    {
            //        MessageBox.Show("Cập nhật thông tin phiếu mượn thành công!", "Thông báo",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        DialogResult = DialogResult.OK;
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Lỗi khi cập nhật thông tin phiếu mượn: " + err, "Lỗi",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void FormEditLoansAndReturns_Load(object sender, EventArgs e)
        {

        }
    }
}
