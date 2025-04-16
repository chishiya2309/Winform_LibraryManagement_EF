using System;
using System.Collections.Generic;
using System.Data.Entity;
using DataAccessLayer.Models;

namespace DataAccessLayer.DAL
{
    public class DbInitializer : CreateDatabaseIfNotExists<QuanLyThuVienContext>
    {
        protected override void Seed(QuanLyThuVienContext context)
        {
            // Khởi tạo dữ liệu mẫu cho DanhMucSach
            var danhMucList = new List<DanhMucSach>
            {
                new DanhMucSach {
                    MaDanhMuc = "DM001",
                    TenDanhMuc = "Văn học Việt Nam",
                    MoTa = "Các tác phẩm văn học Việt Nam",
                    DanhMucCha = null,
                    SoLuongSach = 100,
                    NgayTao = DateTime.Now,
                    CapNhatLanCuoi = DateTime.Now,
                    TrangThai = "Hoạt động"
                },
                new DanhMucSach {
                    MaDanhMuc = "DM002",
                    TenDanhMuc = "Văn học nước ngoài",
                    MoTa = "Các tác phẩm văn học nước ngoài",
                    DanhMucCha = null,
                    SoLuongSach = 150,
                    NgayTao = DateTime.Now,
                    CapNhatLanCuoi = DateTime.Now,
                    TrangThai = "Hoạt động"
                },
                new DanhMucSach {
                    MaDanhMuc = "DM003",
                    TenDanhMuc = "Khoa học công nghệ",
                    MoTa = "Sách khoa học và công nghệ",
                    DanhMucCha = null,
                    SoLuongSach = 80,
                    NgayTao = DateTime.Now,
                    CapNhatLanCuoi = DateTime.Now,
                    TrangThai = "Hoạt động"
                },
                new DanhMucSach {
                    MaDanhMuc = "DM004",
                    TenDanhMuc = "Kinh tế",
                    MoTa = "Sách kinh tế và kinh doanh",
                    DanhMucCha = null,
                    SoLuongSach = 120,
                    NgayTao = DateTime.Now,
                    CapNhatLanCuoi = DateTime.Now,
                    TrangThai = "Hoạt động"
                },
                new DanhMucSach {
                    MaDanhMuc = "DM005",
                    TenDanhMuc = "Thiếu nhi",
                    MoTa = "Sách dành cho thiếu nhi",
                    DanhMucCha = null,
                    SoLuongSach = 90,
                    NgayTao = DateTime.Now,
                    CapNhatLanCuoi = DateTime.Now,
                    TrangThai = "Hoạt động"
                }
            };
            context.DanhMucSachs.AddRange(danhMucList);

            // Khởi tạo dữ liệu mẫu cho Sach
            var sachList = new List<Sach>
            {
                new Sach {
                    MaSach = "S001",
                    ISBN = "9781234567897",
                    TenSach = "Truyện Kiều",
                    TacGia = "Nguyễn Du",
                    MaDanhMuc = "DM001",
                    NamXuatBan = 2020,
                    NXB = "NXB Văn học",
                    SoBan = 10,
                    KhaDung = 8,
                    ViTri = "Kệ A1"
                },
                new Sach {
                    MaSach = "S002",
                    ISBN = "9781234567898",
                    TenSach = "Đắc Nhân Tâm",
                    TacGia = "Dale Carnegie",
                    MaDanhMuc = "DM002",
                    NamXuatBan = 2018,
                    NXB = "NXB Tổng hợp",
                    SoBan = 15,
                    KhaDung = 12,
                    ViTri = "Kệ B2"
                },
                new Sach {
                    MaSach = "S003",
                    ISBN = "9781234567899",
                    TenSach = "Lập trình C#",
                    TacGia = "Microsoft",
                    MaDanhMuc = "DM003",
                    NamXuatBan = 2019,
                    NXB = "NXB Trẻ",
                    SoBan = 8,
                    KhaDung = 5,
                    ViTri = "Kệ C3"
                }
            };
            context.Sachs.AddRange(sachList);

            // Khởi tạo dữ liệu mẫu cho NhanVien
            var nhanVienList = new List<NhanVien>
            {
                new NhanVien {
                    ID = "NV001",
                    HoTen = "Nguyễn Văn An",
                    GioiTinh = "Nam",
                    ChucVu = "Quản lý",
                    Email = "an@example.com",
                    SoDienThoai = "0987654321",
                    NgayVaoLam = DateTime.Now.AddYears(-2),
                    TrangThai = "Đang làm việc"
                },
                new NhanVien {
                    ID = "NV002",
                    HoTen = "Trần Thị Bình",
                    GioiTinh = "Nữ",
                    ChucVu = "Nhân viên",
                    Email = "binh@example.com",
                    SoDienThoai = "0912345678",
                    NgayVaoLam = DateTime.Now.AddYears(-1),
                    TrangThai = "Đang làm việc"
                }
            };
            context.NhanViens.AddRange(nhanVienList);

            // Khởi tạo dữ liệu mẫu cho ThanhVien
            var thanhVienList = new List<ThanhVien>
            {
                new ThanhVien {
                    MaThanhVien = "TV001",
                    HoTen = "Lê Văn Cường",
                    GioiTinh = "Nam",
                    SoDienThoai = "0923456789",
                    Email = "cuong@example.com",
                    LoaiThanhVien = "Sinh viên",
                    NgayDangKy = DateTime.Now.AddMonths(-6),
                    NgayHetHan = DateTime.Now.AddMonths(6),
                    TrangThai = "Hoạt động"
                },
                new ThanhVien {
                    MaThanhVien = "TV002",
                    HoTen = "Phạm Thị Dung",
                    GioiTinh = "Nữ",
                    SoDienThoai = "0934567890",
                    Email = "dung@example.com",
                    LoaiThanhVien = "Giảng viên",
                    NgayDangKy = DateTime.Now.AddMonths(-3),
                    NgayHetHan = DateTime.Now.AddMonths(9),
                    TrangThai = "Hoạt động"
                }
            };
            context.ThanhViens.AddRange(thanhVienList);

            context.SaveChanges();

            // Khởi tạo dữ liệu mẫu cho PhieuMuon (cần lưu trước các bảng có liên kết)
            var phieuMuonList = new List<PhieuMuon>
            {
                new PhieuMuon {
                    MaThanhVien = "TV001",
                    MaSach = "S001",
                    NgayMuon = DateTime.Now.AddDays(-10),
                    HanTra = DateTime.Now.AddDays(20),
                    NgayTraThucTe = null,
                    TrangThai = "Đang mượn",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "TV002",
                    MaSach = "S002",
                    NgayMuon = DateTime.Now.AddDays(-5),
                    HanTra = DateTime.Now.AddDays(25),
                    NgayTraThucTe = null,
                    TrangThai = "Đang mượn",
                    SoLuong = 1
                }
            };
            context.PhieuMuons.AddRange(phieuMuonList);

            // Lưu thay đổi vào database
            context.SaveChanges();
        }
    }
}