using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccessLayer.DAL;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public class ThongKeService : IThongKeService
    {
        private readonly UnitOfWork _unitOfWork;

        public ThongKeService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public DataRow LayThongKeTongQuan()
        {
            DataTable result = new DataTable();
            result.Columns.Add("TongSachKhaDung", typeof(int));
            result.Columns.Add("TongThanhVien", typeof(int));
            result.Columns.Add("TongNhanVien", typeof(int));
            result.Columns.Add("SachMuonHomNay", typeof(int));
            result.Columns.Add("SachTraHomNay", typeof(int));
            result.Columns.Add("SachQuaHan", typeof(int));

            DataRow row = result.NewRow();
            row["TongSachKhaDung"] = GetTongSachKhaDung();
            row["TongThanhVien"] = GetTongThanhVien();
            row["TongNhanVien"] = GetTongNhanVien();
            row["SachMuonHomNay"] = GetSachMuonHomNay();
            row["SachTraHomNay"] = GetSachTraHomNay();
            row["SachQuaHan"] = GetSachQuaHan();

            result.Rows.Add(row);
            return row;
        }

        public int GetTongSachKhaDung()
        {
            return _unitOfWork.SachRepository.GetAll().Sum(s => s.KhaDung);
        }

        public int GetTongThanhVien()
        {
            return _unitOfWork.ThanhVienRepository.GetAll().Count();
        }

        public int GetTongNhanVien()
        {
            return _unitOfWork.NhanVienRepository.GetAll().Count();
        }

        public int GetSachMuonHomNay()
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            return _unitOfWork.PhieuMuonRepository
                .Find(p => p.NgayMuon >= today && p.NgayMuon < tomorrow)
                .Sum(p => p.SoLuong);
        }


        public int GetSachTraHomNay()
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            return _unitOfWork.PhieuMuonRepository
                .Find(p => p.NgayTraThucTe.HasValue
                           && p.NgayTraThucTe.Value >= today
                           && p.NgayTraThucTe.Value < tomorrow)
                .Sum(p => p.SoLuong);
        }


        public int GetSachQuaHan()
        {
            DateTime today = DateTime.Today;

            return _unitOfWork.PhieuMuonRepository
                .Find(p => p.HanTra < today && p.TrangThai == "Đang mượn")
                .Sum(p => p.SoLuong);
        }
    }
}