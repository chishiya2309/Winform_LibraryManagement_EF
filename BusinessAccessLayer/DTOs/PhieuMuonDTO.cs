﻿using System;

namespace BusinessAccessLayer.DTOs
{
    public class PhieuMuonDTO
    {
        public int MaPhieu { get; set; }

        public string MaThanhVien { get; set; }

        public DateTime NgayMuon { get; set; }

        public DateTime HanTra { get; set; }

        public DateTime? NgayTraThucTe { get; set; }

        public string TrangThai { get; set; }

        public string MaSach { get; set; }

        public int SoLuong { get; set; }
    }
}
