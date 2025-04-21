using System.Collections.Generic;
using BusinessAccessLayer.DTOs;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public interface ISachService
    {
        IEnumerable<SachDTO> GetAllSachDTO();
        Sach GetSachById(string maSach);
        IEnumerable<Sach> GetSachByDanhMuc(string maDanhMuc);
        IEnumerable<Sach> SearchSach(string keyword);
        void AddSach(Sach sach);
        void UpdateSach(Sach sach);
        void DeleteSach(string maSach);
        bool SachExists(string maSach);
        bool ISBNExists(string isbn);
        int CountAvailable(string maSach);
    }
}