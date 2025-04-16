using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    [Table("DanhMucSach")]
    public class DanhMucSach
    {
        public DanhMucSach()
        {
            Sachs = new HashSet<Sach>();
            DanhMucCons = new HashSet<DanhMucSach>();
        }

        [Key]
        [StringLength(20)]
        public string MaDanhMuc { get; set; }

        [Required]
        [StringLength(255)]
        public string TenDanhMuc { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        [StringLength(20)]
        public string DanhMucCha { get; set; }

        [Required]
        [DefaultValue(0)]
        public int SoLuongSach { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime CapNhatLanCuoi { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }

        // Navigation properties
        [ForeignKey("DanhMucCha")]
        public virtual DanhMucSach DanhMucChaNavigation { get; set; }
        public virtual ICollection<DanhMucSach> DanhMucCons { get; set; }
        public virtual ICollection<Sach> Sachs { get; set; }
    }
}