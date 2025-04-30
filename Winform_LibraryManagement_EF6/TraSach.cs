using BusinessAccessLayer.DTOs;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class TraSach : Form
    {
        private readonly IPhieuMuonService _phieuMuonService;
        private PhieuMuon _phieuMuonHienTai;
        private int _maPhieuMuon;

        public TraSach(PhieuMuon phieuMuon)
        {
            InitializeComponent();
            _phieuMuonService = new PhieuMuonService();

            _maPhieuMuon = phieuMuon.MaPhieu;
            _phieuMuonHienTai = phieuMuon;

            LoadData();
        }

        public void LoadData()
        {
            // Kiểm tra trạng thái phiếu mượn
            if (_phieuMuonHienTai.TrangThai == "Đã trả")
            {
                MessageBox.Show("Sách này đã được trả trước đó!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            txtMaPhieu.Text = _phieuMuonHienTai.MaPhieu.ToString();

            // Hiển thị thông tin phiếu mượn
            lblPhieuMuonInfo.Text = $"Hạn trả: {_phieuMuonHienTai.HanTra.ToShortDateString()}, Trạng thái: {_phieuMuonHienTai.TrangThai}";

            // Kiểm tra nếu quá hạn
            if (DateTime.Now > _phieuMuonHienTai.HanTra && _phieuMuonHienTai.TrangThai == "Quá hạn")
            {
                lblPhieuMuonInfo.ForeColor = Color.Red;
            }

            dtpNgayTra.Value = DateTime.Now;
            lblNgayTraInfo.Text = "Lưu ý: Ngày trả thực tế sẽ được ghi nhận khi bạn ấn nút 'Lưu'";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _phieuMuonHienTai.NgayTraThucTe = dtpNgayTra.Value;
                _phieuMuonHienTai.TrangThai = "Đã trả";

                _phieuMuonService.TraSach(_phieuMuonHienTai);

                MessageBox.Show("Ghi nhận trả sách thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi nhận trả sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
