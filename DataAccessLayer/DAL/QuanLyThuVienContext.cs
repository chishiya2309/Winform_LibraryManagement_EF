using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DataAccessLayer.Models;

namespace DataAccessLayer.DAL
{
    public class QuanLyThuVienContext : DbContext
    {
        public QuanLyThuVienContext() : base("name=QuanLyThuVienContext")
        {
            // Sử dụng DatabaseInitializer tùy chỉnh
            Database.SetInitializer(new DbInitializer());

            // Hiển thị SQL queries trong output window (development only)
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public virtual DbSet<DanhMucSach> DanhMucSachs { get; set; }
        public virtual DbSet<Sach> Sachs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Remove plural table name convention
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Self-referencing relationship for DanhMucSach
            modelBuilder.Entity<DanhMucSach>()
                .HasOptional(d => d.DanhMucChaNavigation)
                .WithMany(d => d.DanhMucCons)
                .HasForeignKey(d => d.DanhMucCha);

            // Relationship between Sach and DanhMucSach
            modelBuilder.Entity<Sach>()
                .HasRequired(s => s.DanhMuc)
                .WithMany(d => d.Sachs)
                .HasForeignKey(s => s.MaDanhMuc);

            // Relationship between PhieuMuon and ThanhVien
            modelBuilder.Entity<PhieuMuon>()
                .HasRequired(p => p.ThanhVien)
                .WithMany(t => t.PhieuMuons)
                .HasForeignKey(p => p.MaThanhVien);

            // Relationship between PhieuMuon and Sach
            modelBuilder.Entity<PhieuMuon>()
                .HasRequired(p => p.Sach)
                .WithMany(s => s.PhieuMuons)
                .HasForeignKey(p => p.MaSach);

            base.OnModelCreating(modelBuilder);
        }
    }
}