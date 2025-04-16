using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(50)]
        public string ChucVu { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        [Index(IsUnique = true)]
        public string SoDienThoai { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime NgayVaoLam { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }
    }
}