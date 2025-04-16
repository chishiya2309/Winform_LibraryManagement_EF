using System.Collections.Generic;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public interface INhanVienService
    {
        IEnumerable<NhanVien> GetAllNhanVien();
        NhanVien GetNhanVienById(string id);
        IEnumerable<NhanVien> SearchNhanVien(string keyword);
        void AddNhanVien(NhanVien nhanVien);
        void UpdateNhanVien(NhanVien nhanVien);
        void DeleteNhanVien(string id);
        bool NhanVienExists(string id);
        bool EmailExists(string email);
        bool SoDienThoaiExists(string soDienThoai);
        IEnumerable<NhanVien> GetNhanVienByChucVu(string chucVu);
    }
}