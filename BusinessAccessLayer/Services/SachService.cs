using System;
using System.Collections.Generic;
using System.Linq;
using BusinessAccessLayer.DTOs;
using DataAccessLayer.DAL;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public class SachService : ISachService
    {
        private readonly UnitOfWork _unitOfWork;

        public SachService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<Sach> GetAllSach()
        {
            return _unitOfWork.SachRepository.GetAll();
        }

        public Sach GetSachById(string maSach)
        {
            return _unitOfWork.SachRepository.GetById(maSach);
        }

        public IEnumerable<Sach> GetSachByDanhMuc(string maDanhMuc)
        {
            return _unitOfWork.SachRepository.Find(s => s.MaDanhMuc == maDanhMuc);
        }

        public IEnumerable<Sach> SearchSach(string keyword)
        {
            keyword = keyword.ToLower();
            return _unitOfWork.SachRepository.Find(s =>
                s.MaSach.ToLower().Contains(keyword) ||
                s.TenSach.ToLower().Contains(keyword) ||
                s.TacGia.ToLower().Contains(keyword) ||
                s.ISBN.ToLower().Contains(keyword) ||
                s.ViTri.ToLower().Contains(keyword) ||
                s.NXB.ToLower().Contains(keyword));
        }

        public void AddSach(Sach sach)
        {
            if (sach == null)
                throw new ArgumentNullException("sach");

            // Kiểm tra trùng lặp
            if (ISBNExists(sach.ISBN))
                throw new Exception("ISBN đã tồn tại trong hệ thống.");

            // Mặc định khả dụng = số bản nếu không được thiết lập
            if (sach.KhaDung == 0)
                sach.KhaDung = sach.SoBan;

            // Cập nhật số lượng sách trong danh mục
            var danhMuc = _unitOfWork.DanhMucSachRepository.GetById(sach.MaDanhMuc);
            if (danhMuc != null)
            {
                danhMuc.SoLuongSach += sach.SoBan;
                _unitOfWork.DanhMucSachRepository.Update(danhMuc);
            }

            _unitOfWork.SachRepository.Add(sach);
            _unitOfWork.Save();
        }

        public void UpdateSach(Sach sach)
        {
            if (sach == null)
                throw new ArgumentNullException("sach");

            // Lấy thông tin sách hiện tại
            var sachHienTai = _unitOfWork.SachRepository.GetById(sach.MaSach);
            if (sachHienTai == null)
                throw new Exception("Không tìm thấy sách cần cập nhật.");

            // Kiểm tra nếu thay đổi ISBN
            if (sach.ISBN != sachHienTai.ISBN && ISBNExists(sach.ISBN))
                throw new Exception("ISBN đã tồn tại trong hệ thống.");

            // Cập nhật thông tin từ sách mới sang sách hiện tại thay vì tạo đối tượng mới
            sachHienTai.ISBN = sach.ISBN;
            sachHienTai.TenSach = sach.TenSach;
            sachHienTai.TacGia = sach.TacGia;
            sachHienTai.NamXuatBan = sach.NamXuatBan;
            sachHienTai.NXB = sach.NXB;
            sachHienTai.ViTri = sach.ViTri;
            sachHienTai.KhaDung = sach.KhaDung;

            // Xử lý thay đổi số lượng và danh mục
            bool doiDanhMuc = sach.MaDanhMuc != sachHienTai.MaDanhMuc;
            bool doiSoLuong = sach.SoBan != sachHienTai.SoBan;

            // Nếu thay đổi danh mục, cập nhật số lượng sách trong các danh mục
            if (doiDanhMuc)
            {
                // Giảm số lượng sách trong danh mục cũ
                var danhMucCu = _unitOfWork.DanhMucSachRepository.GetById(sachHienTai.MaDanhMuc);
                if (danhMucCu != null)
                {
                    danhMucCu.SoLuongSach -= sachHienTai.SoBan;
                    _unitOfWork.DanhMucSachRepository.Update(danhMucCu);
                }

                // Tăng số lượng sách trong danh mục mới
                var danhMucMoi = _unitOfWork.DanhMucSachRepository.GetById(sach.MaDanhMuc);
                if (danhMucMoi != null)
                {
                    danhMucMoi.SoLuongSach += sach.SoBan;
                    _unitOfWork.DanhMucSachRepository.Update(danhMucMoi);
                }

                // Cập nhật mã danh mục
                sachHienTai.MaDanhMuc = sach.MaDanhMuc;
            }
            // Nếu cùng danh mục nhưng thay đổi số lượng
            else if (doiSoLuong)
            {
                var danhMuc = _unitOfWork.DanhMucSachRepository.GetById(sach.MaDanhMuc);
                if (danhMuc != null)
                {
                    danhMuc.SoLuongSach += (sach.SoBan - sachHienTai.SoBan);
                    _unitOfWork.DanhMucSachRepository.Update(danhMuc);
                }

                // Cập nhật số bản
                sachHienTai.SoBan = sach.SoBan;
            }

            _unitOfWork.SachRepository.Update(sachHienTai);
            _unitOfWork.Save();
        }

        public void DeleteSach(string maSach)
        {
            var sach = _unitOfWork.SachRepository.GetById(maSach);
            if (sach != null)
            {
                // Cập nhật số lượng sách trong danh mục
                var danhMuc = _unitOfWork.DanhMucSachRepository.GetById(sach.MaDanhMuc);
                if (danhMuc != null)
                {
                    danhMuc.SoLuongSach -= sach.SoBan;
                    _unitOfWork.DanhMucSachRepository.Update(danhMuc);
                }

                _unitOfWork.SachRepository.Remove(sach);
                _unitOfWork.Save();
            }
        }

        public bool SachExists(string maSach)
        {
            return _unitOfWork.SachRepository.GetById(maSach) != null;
        }

        public bool ISBNExists(string isbn)
        {
            return _unitOfWork.SachRepository.Find(s => s.ISBN == isbn).Any();
        }

        public int CountAvailable(string maSach)
        {
            var sach = _unitOfWork.SachRepository.GetById(maSach);
            return sach != null ? sach.KhaDung : 0;
        }

        public IEnumerable<SachDTO> GetAllSachDTO()
        {
            return _unitOfWork.SachRepository.GetAll()
                .Select(dm => new SachDTO
                {
                    MaSach = dm.MaSach,
                    ISBN = dm.ISBN,
                    TenSach = dm.TenSach,
                    TacGia = dm.TacGia,
                    MaDanhMuc = dm.MaDanhMuc,
                    NamXuatBan = dm.NamXuatBan,
                    NXB = dm.NXB,
                    SoBan = dm.SoBan,
                    KhaDung = dm.KhaDung,
                    ViTri = dm.ViTri
                }).ToList();
        }

    }
}