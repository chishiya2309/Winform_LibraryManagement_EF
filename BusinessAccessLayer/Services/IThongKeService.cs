using System;
using System.Data;

namespace BusinessAccessLayer.Services
{
    public interface IThongKeService
    {
        DataRow LayThongKeTongQuan();
        int GetTongSachKhaDung();
        int GetTongThanhVien();
        int GetTongNhanVien();
        int GetSachMuonHomNay();
        int GetSachTraHomNay();
        int GetSachQuaHan();
    }
}