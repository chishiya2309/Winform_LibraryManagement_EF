using System;
using System.Collections.Generic;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services
{
    public interface IPhieuMuonService
    {
        IEnumerable<PhieuMuon> GetAllPhieuMuon();
        PhieuMuon GetPhieuMuonById(int maPhieu);
        IEnumerable<PhieuMuon> GetPhieuMuonByStatus(string trangThai);
        IEnumerable<PhieuMuon> GetPhieuMuonByDate(DateTime fromDate, DateTime toDate);
        void AddPhieuMuon(PhieuMuon phieuMuon);
        void UpdatePhieuMuon(PhieuMuon phieuMuon);
        void DeletePhieuMuon(int maPhieu);
        void TraSach(int maPhieu, DateTime ngayTraThucTe);
        IEnumerable<PhieuMuon> GetPhieuMuonQuaHan();
        int CountSachByThanhVien(string maThanhVien);
    }
}