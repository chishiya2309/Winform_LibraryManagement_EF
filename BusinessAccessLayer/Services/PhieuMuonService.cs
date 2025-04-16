using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.DAL;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public class PhieuMuonService : IPhieuMuonService
    {
        private readonly UnitOfWork _unitOfWork;

        public PhieuMuonService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<PhieuMuon> GetAllPhieuMuon()
        {
            return _unitOfWork.PhieuMuonRepository.GetAll();
        }

        public PhieuMuon GetPhieuMuonById(int maPhieu)
        {
            return _unitOfWork.PhieuMuonRepository.GetById(maPhieu);
        }

        public IEnumerable<PhieuMuon> GetPhieuMuonByStatus(string trangThai)
        {
            return _unitOfWork.PhieuMuonRepository.Find(p => p.TrangThai == trangThai);
        }

        public IEnumerable<PhieuMuon> GetPhieuMuonByDate(DateTime fromDate, DateTime toDate)
        {
            return _unitOfWork.PhieuMuonRepository.Find(p =>
                p.NgayMuon >= fromDate && p.NgayMuon <= toDate);
        }

        public void AddPhieuMuon(PhieuMuon phieuMuon)
        {
            if (phieuMuon == null)
                throw new ArgumentNullException("phieuMuon");

            // Kiểm tra thông tin
            var thanhVien = _unitOfWork.ThanhVienRepository.GetById(phieuMuon.MaThanhVien);
            if (thanhVien == null)
                throw new Exception("Thành viên không tồn tại.");

            if (thanhVien.TrangThai != "Hoạt động")
                throw new Exception("Thành viên không trong trạng thái hoạt động, không thể mượn sách.");

            var sach = _unitOfWork.SachRepository.GetById(phieuMuon.MaSach);
            if (sach == null)
                throw new Exception("Sách không tồn tại.");

            if (sach.KhaDung < phieuMuon.SoLuong)
                throw new Exception("Số lượng sách không đủ để cho mượn.");

            // Thiết lập tự động
            if (string.IsNullOrEmpty(phieuMuon.TrangThai))
                phieuMuon.TrangThai = "Đang mượn";

            if (phieuMuon.NgayMuon == DateTime.MinValue)
                phieuMuon.NgayMuon = DateTime.Now;

            if (phieuMuon.HanTra == DateTime.MinValue)
                phieuMuon.HanTra = DateTime.Now.AddDays(14); // Mặc định 14 ngày

            // Cập nhật số lượng sách khả dụng
            sach.KhaDung -= phieuMuon.SoLuong;
            _unitOfWork.SachRepository.Update(sach);

            _unitOfWork.PhieuMuonRepository.Add(phieuMuon);
            _unitOfWork.Save();
        }

        public void UpdatePhieuMuon(PhieuMuon phieuMuon)
        {
            if (phieuMuon == null)
                throw new ArgumentNullException("phieuMuon");

            var phieuMuonHienTai = _unitOfWork.PhieuMuonRepository.GetById(phieuMuon.MaPhieu);
            if (phieuMuonHienTai == null)
                throw new Exception("Không tìm thấy phiếu mượn cần cập nhật.");

            // Nếu thay đổi số lượng, cập nhật số lượng sách khả dụng
            if (phieuMuon.SoLuong != phieuMuonHienTai.SoLuong)
            {
                var sach = _unitOfWork.SachRepository.GetById(phieuMuon.MaSach);
                if (sach != null)
                {
                    int chenhLech = phieuMuonHienTai.SoLuong - phieuMuon.SoLuong;
                    sach.KhaDung += chenhLech;

                    if (sach.KhaDung < 0)
                        throw new Exception("Số lượng sách không đủ để cho mượn thêm.");

                    _unitOfWork.SachRepository.Update(sach);
                }
            }

            // Cập nhật trạng thái dựa vào hạn trả
            if (phieuMuon.HanTra < DateTime.Now && phieuMuon.TrangThai == "Đang mượn")
                phieuMuon.TrangThai = "Quá hạn";

            _unitOfWork.PhieuMuonRepository.Update(phieuMuon);
            _unitOfWork.Save();
        }

        public void DeletePhieuMuon(int maPhieu)
        {
            var phieuMuon = _unitOfWork.PhieuMuonRepository.GetById(maPhieu);
            if (phieuMuon != null)
            {
                // Nếu phiếu mượn đang trong trạng thái "Đang mượn", cập nhật lại số lượng sách
                if (phieuMuon.TrangThai == "Đang mượn")
                {
                    var sach = _unitOfWork.SachRepository.GetById(phieuMuon.MaSach);
                    if (sach != null)
                    {
                        sach.KhaDung += phieuMuon.SoLuong;
                        _unitOfWork.SachRepository.Update(sach);
                    }
                }

                _unitOfWork.PhieuMuonRepository.Remove(phieuMuon);
                _unitOfWork.Save();
            }
        }

        public void TraSach(int maPhieu, DateTime ngayTraThucTe)
        {
            var phieuMuon = _unitOfWork.PhieuMuonRepository.GetById(maPhieu);
            if (phieuMuon == null)
                throw new Exception("Không tìm thấy phiếu mượn.");

            if (phieuMuon.TrangThai == "Đã trả")
                throw new Exception("Phiếu mượn này đã được trả sách.");

            // Cập nhật thông tin phiếu mượn
            phieuMuon.NgayTraThucTe = ngayTraThucTe;
            phieuMuon.TrangThai = "Đã trả";

            // Cập nhật số lượng sách khả dụng
            var sach = _unitOfWork.SachRepository.GetById(phieuMuon.MaSach);
            if (sach != null)
            {
                sach.KhaDung += phieuMuon.SoLuong;
                _unitOfWork.SachRepository.Update(sach);
            }

            _unitOfWork.PhieuMuonRepository.Update(phieuMuon);
            _unitOfWork.Save();
        }

        public IEnumerable<PhieuMuon> GetPhieuMuonQuaHan()
        {
            return _unitOfWork.PhieuMuonRepository.Find(p =>
                p.HanTra < DateTime.Now && p.TrangThai == "Đang mượn");
        }

        public int CountSachByThanhVien(string maThanhVien)
        {
            return _unitOfWork.PhieuMuonRepository.Find(p =>
                p.MaThanhVien == maThanhVien && p.TrangThai == "Đang mượn")
                .Sum(p => p.SoLuong);
        }
    }
}