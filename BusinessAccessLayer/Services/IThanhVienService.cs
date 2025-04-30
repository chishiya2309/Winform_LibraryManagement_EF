using System.Collections.Generic;
using BusinessAccessLayer.DTOs;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public interface IThanhVienService
    {
        IEnumerable<ThanhVienDTO> GetAllThanhVienDTO();
        ThanhVien GetThanhVienById(string maThanhVien);
        IEnumerable<ThanhVien> SearchThanhVien(string keyword);
        void AddThanhVien(ThanhVien thanhVien);
        void UpdateThanhVien(ThanhVien thanhVien);
        void DeleteThanhVien(string maThanhVien);
        bool ThanhVienExists(string maThanhVien);
        bool EmailExists(string email);
        bool SoDienThoaiExists(string soDienThoai);
        IEnumerable<PhieuMuon> GetPhieuMuonByThanhVien(string maThanhVien);
        IEnumerable<ThanhVien> GetThanhVienSapHetHan(int days);
    }
}