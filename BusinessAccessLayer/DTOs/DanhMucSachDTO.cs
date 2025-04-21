using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.DTOs
{
    public class DanhMucSachDTO
    {
        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public string MoTa { get; set; }
        public string DanhMucCha { get; set; }
        public int SoLuongSach { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime CapNhatLanCuoi { get; set; }
        public string TrangThai { get; set; }
    }
}
