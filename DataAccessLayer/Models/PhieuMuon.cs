using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    [Table("PhieuMuon")]
    public class PhieuMuon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhieu { get; set; }

        [Required]
        [StringLength(10)]
        public string MaThanhVien { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime NgayMuon { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime HanTra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTraThucTe { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        [Required]
        [StringLength(20)]
        public string MaSach { get; set; }

        [Required]
        public int SoLuong { get; set; }

        // Navigation properties
        [ForeignKey("MaThanhVien")]
        public virtual ThanhVien ThanhVien { get; set; }

        [ForeignKey("MaSach")]
        public virtual Sach Sach { get; set; }
    }
}