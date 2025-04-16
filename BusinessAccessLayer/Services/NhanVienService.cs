using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.DAL;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public class NhanVienService : INhanVienService
    {
        private readonly UnitOfWork _unitOfWork;

        public NhanVienService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<NhanVien> GetAllNhanVien()
        {
            return _unitOfWork.NhanVienRepository.GetAll();
        }

        public NhanVien GetNhanVienById(string id)
        {
            return _unitOfWork.NhanVienRepository.GetById(id);
        }

        public IEnumerable<NhanVien> SearchNhanVien(string keyword)
        {
            keyword = keyword.ToLower();
            return _unitOfWork.NhanVienRepository.Find(n =>
                n.HoTen.ToLower().Contains(keyword) ||
                n.Email.ToLower().Contains(keyword) ||
                n.SoDienThoai.Contains(keyword));
        }

        public void AddNhanVien(NhanVien nhanVien)
        {
            if (nhanVien == null)
                throw new ArgumentNullException("nhanVien");

            // Kiểm tra trùng lặp
            if (EmailExists(nhanVien.Email))
                throw new Exception("Email đã tồn tại trong hệ thống.");

            if (SoDienThoaiExists(nhanVien.SoDienThoai))
                throw new Exception("Số điện thoại đã tồn tại trong hệ thống.");

            // Kiểm tra và thiết lập tự động
            if (string.IsNullOrEmpty(nhanVien.TrangThai))
                nhanVien.TrangThai = "Đang làm";

            if (nhanVien.NgayVaoLam == DateTime.MinValue)
                nhanVien.NgayVaoLam = DateTime.Now;

            _unitOfWork.NhanVienRepository.Add(nhanVien);
            _unitOfWork.Save();
        }

        public void UpdateNhanVien(NhanVien nhanVien)
        {
            if (nhanVien == null)
                throw new ArgumentNullException("nhanVien");

            // Lấy thông tin hiện tại
            var nhanVienHienTai = _unitOfWork.NhanVienRepository.GetById(nhanVien.ID);
            if (nhanVienHienTai == null)
                throw new Exception("Không tìm thấy nhân viên cần cập nhật.");

            // Kiểm tra trùng lặp email
            if (nhanVien.Email != nhanVienHienTai.Email && EmailExists(nhanVien.Email))
                throw new Exception("Email đã tồn tại trong hệ thống.");

            // Kiểm tra trùng lặp số điện thoại
            if (nhanVien.SoDienThoai != nhanVienHienTai.SoDienThoai && SoDienThoaiExists(nhanVien.SoDienThoai))
                throw new Exception("Số điện thoại đã tồn tại trong hệ thống.");

            _unitOfWork.NhanVienRepository.Update(nhanVien);
            _unitOfWork.Save();
        }

        public void DeleteNhanVien(string id)
        {
            var nhanVien = _unitOfWork.NhanVienRepository.GetById(id);
            if (nhanVien != null)
            {
                // Không xóa nhân viên là Admin
                if (nhanVien.ChucVu == "Admin")
                    throw new Exception("Không thể xóa tài khoản Admin.");

                _unitOfWork.NhanVienRepository.Remove(nhanVien);
                _unitOfWork.Save();
            }
        }

        public bool NhanVienExists(string id)
        {
            return _unitOfWork.NhanVienRepository.GetById(id) != null;
        }

        public bool EmailExists(string email)
        {
            return _unitOfWork.NhanVienRepository.Find(n => n.Email == email).Any();
        }

        public bool SoDienThoaiExists(string soDienThoai)
        {
            return _unitOfWork.NhanVienRepository.Find(n => n.SoDienThoai == soDienThoai).Any();
        }

        public IEnumerable<NhanVien> GetNhanVienByChucVu(string chucVu)
        {
            return _unitOfWork.NhanVienRepository.Find(n => n.ChucVu == chucVu);
        }
    }
}