using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    [Table("Sach")]
    public class Sach
    {
        public Sach()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
        }

        [Key]
        [StringLength(20)]
        public string MaSach { get; set; }

        [Required]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string ISBN { get; set; }

        [Required]
        [StringLength(255)]
        public string TenSach { get; set; }

        [Required]
        [StringLength(255)]
        public string TacGia { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDanhMuc { get; set; }

        [Required]
        public int NamXuatBan { get; set; }

        [Required]
        [StringLength(255)]
        public string NXB { get; set; }

        [Required]
        public int SoBan { get; set; }

        [Required]
        public int KhaDung { get; set; }

        [Required]
        [StringLength(255)]
        public string ViTri { get; set; }

        // Navigation properties
        [ForeignKey("MaDanhMuc")]
        public virtual DanhMucSach DanhMuc { get; set; }
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}