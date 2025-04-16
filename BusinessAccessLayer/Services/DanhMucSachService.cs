using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.DAL;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public class DanhMucSachService : IDanhMucSachService
    {
        private readonly UnitOfWork _unitOfWork;

        public DanhMucSachService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<DanhMucSach> GetAllDanhMuc()
        {
            return _unitOfWork.DanhMucSachRepository.GetAll();
        }

        public DanhMucSach GetDanhMucById(string maDanhMuc)
        {
            return _unitOfWork.DanhMucSachRepository.GetById(maDanhMuc);
        }

        public IEnumerable<DanhMucSach> GetDanhMucCon(string maDanhMucCha)
        {
            return _unitOfWork.DanhMucSachRepository.Find(d => d.DanhMucCha == maDanhMucCha);
        }

        public void AddDanhMuc(DanhMucSach danhMuc)
        {
            if (danhMuc == null)
                throw new ArgumentNullException("danhMuc");

            danhMuc.NgayTao = DateTime.Now;
            danhMuc.CapNhatLanCuoi = DateTime.Now;
            
            if (string.IsNullOrEmpty(danhMuc.TrangThai))
                danhMuc.TrangThai = "Hoạt động";

            _unitOfWork.DanhMucSachRepository.Add(danhMuc);
            _unitOfWork.Save();
        }

        public void UpdateDanhMuc(DanhMucSach danhMuc)
        {
            if (danhMuc == null)
                throw new ArgumentNullException("danhMuc");

            danhMuc.CapNhatLanCuoi = DateTime.Now;

            _unitOfWork.DanhMucSachRepository.Update(danhMuc);
            _unitOfWork.Save();
        }

        public void DeleteDanhMuc(string maDanhMuc)
        {
            var danhMuc = _unitOfWork.DanhMucSachRepository.GetById(maDanhMuc);
            if (danhMuc != null)
            {
                _unitOfWork.DanhMucSachRepository.Remove(danhMuc);
                _unitOfWork.Save();
            }
        }

        public bool DanhMucExists(string maDanhMuc)
        {
            return _unitOfWork.DanhMucSachRepository.GetById(maDanhMuc) != null;
        }

        public int CountSachInDanhMuc(string maDanhMuc)
        {
            return _unitOfWork.SachRepository.Find(s => s.MaDanhMuc == maDanhMuc).Count();
        }
    }
}