using System.Collections.Generic;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public interface IDanhMucSachService
    {
        IEnumerable<DanhMucSach> GetAllDanhMuc();
        DanhMucSach GetDanhMucById(string maDanhMuc);
        IEnumerable<DanhMucSach> GetDanhMucCon(string maDanhMucCha);
        void AddDanhMuc(DanhMucSach danhMuc);
        void UpdateDanhMuc(DanhMucSach danhMuc);
        void DeleteDanhMuc(string maDanhMuc);
        bool DanhMucExists(string maDanhMuc);
        int CountSachInDanhMuc(string maDanhMuc);
    }
}