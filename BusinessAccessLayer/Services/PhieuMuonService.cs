using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.DAL;
using DataAccessLayer.Models;
using BusinessAccessLayer.DTOs;

namespace BusinessAccessLayer.Services
{
    public class PhieuMuonService : IPhieuMuonService
    {
        private readonly UnitOfWork _unitOfWork;

        public PhieuMuonService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<PhieuMuonDTO> GetAllPhieuMuonDTO()
        {
            return _unitOfWork.PhieuMuonRepository.GetAll()
                .Select(p => new PhieuMuonDTO
                {
                    MaPhieu = p.MaPhieu,
                    MaThanhVien = p.MaThanhVien,
                    NgayMuon = p.NgayMuon,
                    HanTra = p.HanTra,
                    NgayTraThucTe = p.NgayTraThucTe,
                    TrangThai = p.TrangThai,
                    MaSach = p.MaSach,
                    SoLuong = p.SoLuong
                });
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

        public IEnumerable<PhieuMuon> SearchPhieuMuon(string keyword)
        {
            keyword = keyword.ToLower();
            return _unitOfWork.PhieuMuonRepository.Find(pm =>
                pm.MaPhieu.ToString().Contains(keyword) ||
                pm.MaThanhVien.ToLower().Contains(keyword) ||
                pm.MaSach.ToLower().Contains(keyword));
        }

        public void AddPhieuMuon(PhieuMuon phieuMuon)
        {
            if (phieuMuon == null)
                throw new ArgumentNullException("phieuMuon");

            // Thiết lập giá trị mặc định
            if (phieuMuon.NgayMuon == DateTime.MinValue)
                phieuMuon.NgayMuon = DateTime.Now;

            if (phieuMuon.HanTra == DateTime.MinValue)
                phieuMuon.HanTra = phieuMuon.NgayMuon.AddDays(14); // Mặc định 14 ngày

            if (string.IsNullOrEmpty(phieuMuon.TrangThai))
                phieuMuon.TrangThai = "Đang mượn";

            // Kiểm tra hạn trả phải lớn hơn ngày mượn ít nhất 1 ngày
            if (phieuMuon.HanTra <= phieuMuon.NgayMuon)
                throw new Exception("Hạn trả phải lớn hơn ngày mượn ít nhất 1 ngày.");

            // Kiểm tra thành viên có tồn tại không
            var thanhVien = _unitOfWork.ThanhVienRepository.GetById(phieuMuon.MaThanhVien);
            if (thanhVien == null)
                throw new Exception("Mã thành viên không tồn tại!");

            // Kiểm tra thành viên có bị khóa hoặc hết hạn không
            if (thanhVien.TrangThai == "Khóa" || thanhVien.TrangThai == "Hết hạn")
                throw new Exception("Thành viên đã bị khóa hoặc tài khoản đã hết hạn!");

            // Kiểm tra sách có tồn tại không
            var sach = _unitOfWork.SachRepository.GetById(phieuMuon.MaSach);
            if (sach == null)
                throw new Exception("Mã sách không tồn tại!");

            // Kiểm tra số lượng sách còn đủ không
            if (sach.KhaDung < phieuMuon.SoLuong)
                throw new Exception($"Số lượng sách không đủ để mượn! Hiện có {sach.KhaDung} cuốn khả dụng.");

            // Kiểm tra số lượng sách thành viên đã mượn (giới hạn mỗi thành viên mượn tối đa 5 sách)
            int soSachDangMuon = CountSachByThanhVien(phieuMuon.MaThanhVien);
            if ((soSachDangMuon + phieuMuon.SoLuong) > 5)
                throw new Exception($"Thành viên đã mượn {soSachDangMuon} cuốn, không thể mượn thêm {phieuMuon.SoLuong} cuốn nữa! Tối đa là 5 cuốn.");

            // Kiểm tra thành viên có phiếu mượn quá hạn không
            bool coPhieuMuonQuaHan = _unitOfWork.PhieuMuonRepository.Find(p =>
                p.MaThanhVien == phieuMuon.MaThanhVien && p.TrangThai == "Quá hạn").Any();

            if (coPhieuMuonQuaHan)
                throw new Exception("Thành viên có sách mượn quá hạn chưa trả, không thể mượn thêm!");

            // Thêm phiếu mượn
            _unitOfWork.PhieuMuonRepository.Add(phieuMuon);

            // Cập nhật số lượng sách khả dụng
            sach.KhaDung -= phieuMuon.SoLuong;
            _unitOfWork.SachRepository.Update(sach);

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