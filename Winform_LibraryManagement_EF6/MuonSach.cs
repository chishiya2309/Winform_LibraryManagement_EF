using BusinessAccessLayer.DTOs;
using BusinessAccessLayer.Services;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{

    public partial class MuonSach : Form
    {
        private readonly IThanhVienService _thanhVienService;
        private List<ThanhVienDTO> _thanhVienList;

        private readonly ISachService _sachService;
        private List<SachDTO> _sachList;

        private readonly IPhieuMuonService _phieuMuonService;
        public MuonSach()
        {
            InitializeComponent();
            _thanhVienService = new ThanhVienService();
            _sachService = new SachService();
            _phieuMuonService = new PhieuMuonService();
            LoadData();

            // Thêm sự kiện ValueChanged cho DateTimePicker
            dtpNgayMuon.ValueChanged += DateTimePicker_ValueChanged;
            dtpHanTra.ValueChanged += DateTimePicker_ValueChanged;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ValidateReturnDate();
        }

        private void ValidateReturnDate()
        {
            // Đảm bảo hạn trả lớn hơn ngày mượn ít nhất 1 ngày
            if (dtpHanTra.Value <= dtpNgayMuon.Value)
            {
                MessageBox.Show("Hạn trả phải lớn hơn ngày mượn ít nhất 1 ngày!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpHanTra.Value = dtpNgayMuon.Value.AddDays(1);
            }
        }

        private void LoadData()
        {
            _thanhVienList = _thanhVienService.GetAllThanhVienDTO().ToList();
            cboThanhVien.DataSource = _thanhVienList;
            cboThanhVien.DisplayMember = "HoTen";
            cboThanhVien.ValueMember = "MaThanhVien";

            _sachList = _sachService.GetAllSachDTO().ToList();
            cboSach.DataSource = _sachList;
            cboSach.DisplayMember = "TenSach";
            cboSach.ValueMember = "MaSach";

            dtpNgayMuon.Value = DateTime.Now;
            dtpHanTra.Value = DateTime.Now.AddDays(14);
        }

        private void MuonSach_Load(object sender, EventArgs e)
        {

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
                // Kiểm tra hạn trả một lần nữa
                if (dtpHanTra.Value <= dtpNgayMuon.Value)
                {
                    MessageBox.Show("Hạn trả phải lớn hơn ngày mượn ít nhất 1 ngày!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Tạo đối tượng phiếu mượn mới
                PhieuMuon phieuMuon = new PhieuMuon
                {
                    MaThanhVien = cboThanhVien.SelectedValue.ToString(),
                    MaSach = cboSach.SelectedValue.ToString(),
                    SoLuong = Convert.ToInt32(nudSoLuong.Value),
                    NgayMuon = dtpNgayMuon.Value,
                    HanTra = dtpHanTra.Value,
                    TrangThai = "Đang mượn"
                };

                _phieuMuonService.AddPhieuMuon(phieuMuon);

                MessageBox.Show("Ghi nhận lượt mượn sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi nhận lượt mượn sách: " + ex.Message, "Lỗi",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
