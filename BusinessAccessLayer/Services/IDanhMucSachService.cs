using System.Collections.Generic;
using DataAccessLayer.Models;
using BusinessAccessLayer.DTOs;

namespace BusinessAccessLayer.Services
{
    public interface IDanhMucSachService
    {
        IEnumerable<DanhMucSachDTO> GetAllDanhMucDTO();
        DanhMucSach GetDanhMucById(string maDanhMuc);
        IEnumerable<DanhMucSach> GetDanhMucCon(string maDanhMucCha);
        IEnumerable<DanhMucSach> SearchDanhMucSach(string keyword);
        void AddDanhMuc(DanhMucSach danhMuc);
        void UpdateDanhMuc(DanhMucSach danhMuc);
        void DeleteDanhMuc(string maDanhMuc);
        bool DanhMucExists(string maDanhMuc);
        int CountSachInDanhMuc(string maDanhMuc);
    }
}