using System;

namespace BusinessAccessLayer.DTOs
{
    public class NhanVienDTO
    {
        public string ID { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string TrangThai { get; set; }
    }
}