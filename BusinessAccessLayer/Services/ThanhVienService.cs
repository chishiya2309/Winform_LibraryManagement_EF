using System;
using System.Collections.Generic;
using System.Linq;
using BusinessAccessLayer.DTOs;
using DataAccessLayer.DAL;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public class ThanhVienService : IThanhVienService
    {
        private readonly UnitOfWork _unitOfWork;

        public ThanhVienService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<ThanhVienDTO> GetAllThanhVienDTO()
        {
            return _unitOfWork.ThanhVienRepository.GetAll()
                .Select(tv => new ThanhVienDTO
                {
                    MaThanhVien = tv.MaThanhVien,
                    HoTen = tv.HoTen,
                    GioiTinh = tv.GioiTinh,
                    SoDienThoai = tv.SoDienThoai,
                    Email = tv.Email,
                    LoaiThanhVien = tv.LoaiThanhVien,
                    NgayDangKy = tv.NgayDangKy,
                    NgayHetHan = tv.NgayHetHan,
                    TrangThai = tv.TrangThai
                }).ToList();

        }

        public ThanhVien GetThanhVienById(string maThanhVien)
        {
            return _unitOfWork.ThanhVienRepository.GetById(maThanhVien);
        }

        public IEnumerable<ThanhVien> SearchThanhVien(string keyword)
        {
            keyword = keyword.ToLower();
            return _unitOfWork.ThanhVienRepository.Find(t =>
                t.MaThanhVien.ToLower().Contains(keyword) ||
                t.HoTen.ToLower().Contains(keyword) ||
                t.Email.ToLower().Contains(keyword) ||
                t.SoDienThoai.Contains(keyword));
        }

        public void AddThanhVien(ThanhVien thanhVien)
        {
            if (thanhVien == null)
                throw new ArgumentNullException("thanhVien");

            // Kiểm tra trùng lặp
            if (EmailExists(thanhVien.Email))
                throw new Exception("Email đã tồn tại trong hệ thống.");

            if (SoDienThoaiExists(thanhVien.SoDienThoai))
                throw new Exception("Số điện thoại đã tồn tại trong hệ thống.");

            // Kiểm tra và thiết lập tự động
            if (string.IsNullOrEmpty(thanhVien.TrangThai))
                thanhVien.TrangThai = "Hoạt động";

            if (thanhVien.NgayDangKy == DateTime.MinValue)
                thanhVien.NgayDangKy = DateTime.Now;

            _unitOfWork.ThanhVienRepository.Add(thanhVien);
            _unitOfWork.Save();
        }

        public void UpdateThanhVien(ThanhVien thanhVien)
        {
            if (thanhVien == null)
                throw new ArgumentNullException("thanhVien");

            // Lấy thông tin hiện tại
            var thanhVienHienTai = _unitOfWork.ThanhVienRepository.GetById(thanhVien.MaThanhVien);
            if (thanhVienHienTai == null)
                throw new Exception("Không tìm thấy thành viên cần cập nhật.");

            // Kiểm tra trùng lặp email
            if (thanhVien.Email != thanhVienHienTai.Email && EmailExists(thanhVien.Email))
                throw new Exception("Email đã tồn tại trong hệ thống.");

            // Kiểm tra trùng lặp số điện thoại
            if (thanhVien.SoDienThoai != thanhVienHienTai.SoDienThoai && SoDienThoaiExists(thanhVien.SoDienThoai))
                throw new Exception("Số điện thoại đã tồn tại trong hệ thống.");

            // Cập nhật tự động trạng thái nếu ngày hết hạn đã qua
            if (thanhVien.NgayHetHan < DateTime.Now && thanhVien.TrangThai == "Hoạt động")
                thanhVien.TrangThai = "Hết hạn";

            thanhVienHienTai.HoTen = thanhVien.HoTen;
            thanhVienHienTai.GioiTinh = thanhVien.GioiTinh;
            thanhVienHienTai.SoDienThoai = thanhVien.SoDienThoai;
            thanhVienHienTai.Email = thanhVien.Email;
            thanhVienHienTai.LoaiThanhVien = thanhVien.LoaiThanhVien;
            thanhVienHienTai.NgayDangKy = thanhVien.NgayDangKy;
            thanhVienHienTai.NgayHetHan = thanhVien.NgayHetHan;
            thanhVienHienTai.TrangThai = thanhVien.TrangThai;

            _unitOfWork.Save();
        }

        public void DeleteThanhVien(string maThanhVien)
        {
            var thanhVien = _unitOfWork.ThanhVienRepository.GetById(maThanhVien);
            if (thanhVien != null)
            {
                // Kiểm tra xem thành viên có phiếu mượn đang mượn không
                var phieuMuonDangMuon = _unitOfWork.PhieuMuonRepository.Find(
                    p => p.MaThanhVien == maThanhVien && p.TrangThai == "Đang mượn").Any();

                if (phieuMuonDangMuon)
                    throw new Exception("Không thể xóa thành viên đang có sách đang mượn.");

                _unitOfWork.ThanhVienRepository.Remove(thanhVien);
                _unitOfWork.Save();
            }
        }

        public bool ThanhVienExists(string maThanhVien)
        {
            return _unitOfWork.ThanhVienRepository.GetById(maThanhVien) != null;
        }

        public bool EmailExists(string email)
        {
            return _unitOfWork.ThanhVienRepository.Find(t => t.Email == email).Any();
        }

        public bool SoDienThoaiExists(string soDienThoai)
        {
            return _unitOfWork.ThanhVienRepository.Find(t => t.SoDienThoai == soDienThoai).Any();
        }

        public IEnumerable<PhieuMuon> GetPhieuMuonByThanhVien(string maThanhVien)
        {
            return _unitOfWork.PhieuMuonRepository.Find(p => p.MaThanhVien == maThanhVien);
        }

        public IEnumerable<ThanhVien> GetAllThanhVien()
        {
            return _unitOfWork.ThanhVienRepository.GetAll();
        }
    }
}