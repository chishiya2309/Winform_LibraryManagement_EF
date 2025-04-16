using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    [Table("ThanhVien")]
    public class ThanhVien
    {
        public ThanhVien()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
        }

        [Key]
        [StringLength(10)]
        public string MaThanhVien { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(15)]
        [Index(IsUnique = true)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiThanhVien { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime NgayDangKy { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime NgayHetHan { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }

        // Navigation properties
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}