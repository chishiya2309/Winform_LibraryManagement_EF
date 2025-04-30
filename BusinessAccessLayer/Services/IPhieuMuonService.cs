using System;
using System.Collections.Generic;
using DataAccessLayer.Models;
using BusinessAccessLayer.DTOs;

namespace BusinessAccessLayer.Services
{
    public interface IPhieuMuonService
    {
        IEnumerable<PhieuMuonDTO> GetAllPhieuMuonDTO();
        PhieuMuon GetPhieuMuonById(int maPhieu);
        IEnumerable<PhieuMuon> GetPhieuMuonByStatus(string trangThai);
        IEnumerable<PhieuMuon> GetPhieuMuonByDate(DateTime fromDate, DateTime toDate);

        IEnumerable<PhieuMuon> SearchPhieuMuon(string keyword);
        void AddPhieuMuon(PhieuMuon phieuMuon);
        void UpdatePhieuMuon(PhieuMuon phieuMuon);
        void DeletePhieuMuon(int maPhieu);
        void TraSach(PhieuMuon phieuMuon);
        IEnumerable<PhieuMuon> GetPhieuMuonQuaHan();
        int CountSachByThanhVien(string maThanhVien);
    }
}