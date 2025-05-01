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
                MaDanhMuc = "CAT001",
                TenDanhMuc = "Văn học",
                MoTa = "Các tác phẩm văn học",
                DanhMucCha = null,
                SoLuongSach = 2100,
                NgayTao = new DateTime(2023, 1, 1),
                CapNhatLanCuoi = new DateTime(2024, 3, 5),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT002",
                TenDanhMuc = "Giáo dục",
                MoTa = "Sách giáo dục và học tập",
                DanhMucCha = null,
                SoLuongSach = 1250,
                NgayTao = new DateTime(2023, 1, 1),
                CapNhatLanCuoi = new DateTime(2024, 3, 5),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT003",
                TenDanhMuc = "Kinh tế & Kinh doanh",
                MoTa = "Sách về kinh tế và kinh doanh",
                DanhMucCha = null,
                SoLuongSach = 680,
                NgayTao = new DateTime(2023, 1, 1),
                CapNhatLanCuoi = new DateTime(2024, 3, 5),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT004",
                TenDanhMuc = "Khoa học & Công nghệ",
                MoTa = "Sách khoa học và công nghệ",
                DanhMucCha = null,
                SoLuongSach = 780,
                NgayTao = new DateTime(2023, 1, 1),
                CapNhatLanCuoi = new DateTime(2024, 3, 5),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT005",
                TenDanhMuc = "Phát triển bản thân",
                MoTa = "Sách phát triển kỹ năng cá nhân",
                DanhMucCha = null,
                SoLuongSach = 430,
                NgayTao = new DateTime(2023, 1, 1),
                CapNhatLanCuoi = new DateTime(2024, 3, 5),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT101",
                TenDanhMuc = "Tiểu thuyết",
                MoTa = "Các tác phẩm văn học dài",
                DanhMucCha = "CAT001",
                SoLuongSach = 1250,
                NgayTao = new DateTime(2023, 1, 5),
                CapNhatLanCuoi = new DateTime(2024, 3, 10),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT102",
                TenDanhMuc = "Truyện ngắn",
                MoTa = "Các truyện ngắn và tuyển tập",
                DanhMucCha = "CAT001",
                SoLuongSach = 430,
                NgayTao = new DateTime(2023, 1, 5),
                CapNhatLanCuoi = new DateTime(2024, 3, 10),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT103",
                TenDanhMuc = "Thơ ca",
                MoTa = "Các tác phẩm thơ",
                DanhMucCha = "CAT001",
                SoLuongSach = 210,
                NgayTao = new DateTime(2023, 1, 5),
                CapNhatLanCuoi = new DateTime(2024, 3, 10),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT104",
                TenDanhMuc = "Truyện thiếu nhi",
                MoTa = "Sách dành cho thiếu nhi ",
                DanhMucCha = "CAT001",
                SoLuongSach = 210,
                NgayTao = new DateTime(2023, 1, 5),
                CapNhatLanCuoi = new DateTime(2024, 3, 10),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT201",
                TenDanhMuc = "Sách giáo khoa",
                MoTa = "Sách học tập các cấp",
                DanhMucCha = "CAT002",
                SoLuongSach = 850,
                NgayTao = new DateTime(2023, 1, 8),
                CapNhatLanCuoi = new DateTime(2024, 3, 15),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT202",
                TenDanhMuc = "Sách tham khảo",
                MoTa = "Sách bổ trợ kiến thức",
                DanhMucCha = "CAT002",
                SoLuongSach = 320,
                NgayTao = new DateTime(2023, 1, 8),
                CapNhatLanCuoi = new DateTime(2024, 3, 15),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT203",
                TenDanhMuc = "Từ điển & Bách khoa",
                MoTa = "Sách tra cứu",
                DanhMucCha = "CAT002",
                SoLuongSach = 80,
                NgayTao = new DateTime(2023, 1, 8),
                CapNhatLanCuoi = new DateTime(2024, 3, 15),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT301",
                TenDanhMuc = "Quản trị kinh doanh",
                MoTa = "Sách về quản lý và điều hành",
                DanhMucCha = "CAT003",
                SoLuongSach = 280,
                NgayTao = new DateTime(2023, 1, 10),
                CapNhatLanCuoi = new DateTime(2024, 3, 18),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT302",
                TenDanhMuc = "Marketing & Bán hàng",
                MoTa = "Sách về tiếp thị và bán hàng",
                DanhMucCha = "CAT003",
                SoLuongSach = 170,
                NgayTao = new DateTime(2023, 1, 10),
                CapNhatLanCuoi = new DateTime(2024, 3, 18),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT303",
                TenDanhMuc = "Tài chính & Đầu tư",
                MoTa = "Sách về tài chính cá nhân",
                DanhMucCha = "CAT003",
                SoLuongSach = 230,
                NgayTao = new DateTime(2023, 1, 10),
                CapNhatLanCuoi = new DateTime(2024, 3, 18),
                TrangThai = "Hoạt động"
            },
            new DanhMucSach {
                MaDanhMuc = "CAT401",
                TenDanhMuc = "Công nghệ thông tin",
                MoTa = "Sách về CNTT và lập trình",
                DanhMucCha = "CAT004",
                SoLuongSach = 310,
                NgayTao = new DateTime(2023, 1, 15),
                CapNhatLanCuoi = new DateTime(2024, 3, 20),
                TrangThai = "Hoạt động"
            }
        };
            context.DanhMucSachs.AddRange(danhMucList);

            // Khởi tạo dữ liệu mẫu cho Sach
            var sachList = new List<Sach>
            {
                new Sach {
                    MaSach = "B1001",
                    ISBN = "9780747532743",
                    TenSach = "Harry Potter và Hòn đá Phù thủy",
                    TacGia = "J.K. Rowling",
                    MaDanhMuc = "CAT101",
                    NamXuatBan = 1997,
                    NXB = "Nhà xuất bản Trẻ",
                    SoBan = 10,
                    KhaDung = 8,
                    ViTri = "A-12-3"
                },
                new Sach {
                    MaSach = "B1002",
                    ISBN = "9780747538486",
                    TenSach = "Harry Potter và Phòng chứa Bí mật",
                    TacGia = "J.K. Rowling",
                    MaDanhMuc = "CAT101",
                    NamXuatBan = 1998,
                    NXB = "Nhà xuất bản Trẻ",
                    SoBan = 8,
                    KhaDung = 6,
                    ViTri = "A-12-4"
                },
                new Sach {
                    MaSach = "B1003",
                    ISBN = "9780747542155",
                    TenSach = "Harry Potter và Tên tù nhân ngục Azkaban",
                    TacGia = "J.K. Rowling",
                    MaDanhMuc = "CAT101",
                    NamXuatBan = 1999,
                    NXB = "Nhà xuất bản Trẻ",
                    SoBan = 7,
                    KhaDung = 4,
                    ViTri = "A-12-5"
                },
                new Sach {
                    MaSach = "B1004",
                    ISBN = "9780439139595",
                    TenSach = "Harry Potter và Chiếc cốc lửa",
                    TacGia = "J.K. Rowling",
                    MaDanhMuc = "CAT101",
                    NamXuatBan = 2000,
                    NXB = "Nhà xuất bản Trẻ",
                    SoBan = 10,
                    KhaDung = 7,
                    ViTri = "A-12-6"
                },
                new Sach {
                    MaSach = "B1005",
                    ISBN = "9780439358064",
                    TenSach = "Harry Potter và Hội Phượng Hoàng",
                    TacGia = "J.K. Rowling",
                    MaDanhMuc = "CAT101",
                    NamXuatBan = 2003,
                    NXB = "Nhà xuất bản Trẻ",
                    SoBan = 12,
                    KhaDung = 9,
                    ViTri = "A-12-7"
                },
                new Sach {
                    MaSach = "B1006",
                    ISBN = "9780439785969",
                    TenSach = "Harry Potter và Hoàng tử lai",
                    TacGia = "J.K. Rowling",
                    MaDanhMuc = "CAT101",
                    NamXuatBan = 2005,
                    NXB = "Nhà xuất bản Trẻ",
                    SoBan = 15,
                    KhaDung = 11,
                    ViTri = "A-12-8"
                },
                new Sach {
                    MaSach = "B1007",
                    ISBN = "9780545139700",
                    TenSach = "Harry Potter và Bảo bối Tử thần",
                    TacGia = "J.K. Rowling",
                    MaDanhMuc = "CAT101",
                    NamXuatBan = 2007,
                    NXB = "Nhà xuất bản Trẻ",
                    SoBan = 20,
                    KhaDung = 15,
                    ViTri = "A-12-9"
                },
                new Sach {
                    MaSach = "B1008",
                    ISBN = "9780590353427",
                    TenSach = "Chú bé phù thủy",
                    TacGia = "Roald Dahl",
                    MaDanhMuc = "CAT104",
                    NamXuatBan = 1983,
                    NXB = "Nhà xuất bản Kim Đồng",
                    SoBan = 5,
                    KhaDung = 4,
                    ViTri = "B-03-2"
                },
                new Sach {
                    MaSach = "B1009",
                    ISBN = "9780747546290",
                    TenSach = "Matilda",
                    TacGia = "Roald Dahl",
                    MaDanhMuc = "CAT104",
                    NamXuatBan = 1988,
                    NXB = "Nhà xuất bản Kim Đồng",
                    SoBan = 7,
                    KhaDung = 5,
                    ViTri = "B-03-3"
                },
                new Sach {
                    MaSach = "B1010",
                    ISBN = "9780140328721",
                    TenSach = "Bí kíp làm giàu",
                    TacGia = "Napoleon Hill",
                    MaDanhMuc = "CAT303",
                    NamXuatBan = 1937,
                    NXB = "Nhà xuất bản Lao động",
                    SoBan = 3,
                    KhaDung = 2,
                    ViTri = "C-05-1"
                },
                new Sach {
                    MaSach = "B1011",
                    ISBN = "9780062457714",
                    TenSach = "Sức mạnh của thói quen",
                    TacGia = "Charles Duhigg",
                    MaDanhMuc = "CAT203",
                    NamXuatBan = 2012,
                    NXB = "Nhà xuất bản Lao động",
                    SoBan = 4,
                    KhaDung = 2,
                    ViTri = "C-07-2"
                },
                new Sach {
                    MaSach = "B1012",
                    ISBN = "9786048412234",
                    TenSach = "Đắc nhân tâm",
                    TacGia = "Dale Carnegie",
                    MaDanhMuc = "CAT005",
                    NamXuatBan = 1936,
                    NXB = "Nhà xuất bản Tổng hợp TPHCM",
                    SoBan = 10,
                    KhaDung = 8,
                    ViTri = "D-01-1"
                },
                new Sach {
                    MaSach = "B1013",
                    ISBN = "9786045512838",
                    TenSach = "Nhà giả kim",
                    TacGia = "Paulo Coelho",
                    MaDanhMuc = "CAT101",
                    NamXuatBan = 1988,
                    NXB = "Nhà xuất bản Văn học",
                    SoBan = 15,
                    KhaDung = 12,
                    ViTri = "A-05-2"
                },
                new Sach {
                    MaSach = "B1014",
                    ISBN = "9780671027032",
                    TenSach = "7 Thói quen của người thành đạt",
                    TacGia = "Stephen R. Covey",
                    MaDanhMuc = "CAT005",
                    NamXuatBan = 1989,
                    NXB = "Nhà xuất bản Trẻ",
                    SoBan = 6,
                    KhaDung = 4,
                    ViTri = "D-01-2"
                },
                new Sach {
                    MaSach = "B1015",
                    ISBN = "9780007442911",
                    TenSach = "Đi tìm lẽ sống",
                    TacGia = "Viktor E. Frankl",
                    MaDanhMuc = "CAT203",
                    NamXuatBan = 1946,
                    NXB = "Nhà xuất bản Trẻ",
                    SoBan = 5,
                    KhaDung = 4,
                    ViTri = "C-07-3"
                }
            };
            context.Sachs.AddRange(sachList);

            // Khởi tạo dữ liệu mẫu cho NhanVien

            var nhanVienList = new List<NhanVien>
            {
                new NhanVien {
                    ID = "NV001",
                    HoTen = "Nguyễn Văn Hòa",
                    GioiTinh = "Nam",
                    ChucVu = "Admin",
                    Email = "nguyenhoa@gmail.com",
                    SoDienThoai = "0901123456",
                    NgayVaoLam = new DateTime(2023, 1, 10),
                    TrangThai = "Đang làm"
                },
                new NhanVien {
                    ID = "NV002",
                    HoTen = "Trần Thị Mai",
                    GioiTinh = "Nữ",
                    ChucVu = "Quản Lý",
                    Email = "tranmaiqly@gmail.com",
                    SoDienThoai = "0912234567",
                    NgayVaoLam = new DateTime(2022, 3, 15),
                    TrangThai = "Đang làm"
                },
                new NhanVien {
                    ID = "NV003",
                    HoTen = "Lê Minh Tuấn",
                    GioiTinh = "Nam",
                    ChucVu = "Nhân Viên",
                    Email = "letuan_nv@gmail.com",
                    SoDienThoai = "0923345678",
                    NgayVaoLam = new DateTime(2021, 7, 20),
                    TrangThai = "Đang làm"
                },
                new NhanVien {
                    ID = "NV004",
                    HoTen = "Hoàng Đức Anh",
                    GioiTinh = "Nam",
                    ChucVu = "Nhân Viên",
                    Email = "hoangduca@gmail.com",
                    SoDienThoai = "0934456789",
                    NgayVaoLam = new DateTime(2020, 10, 5),
                    TrangThai = "Tạm nghỉ"
                },
                new NhanVien {
                    ID = "NV005",
                    HoTen = "Vũ Thị Hồng",
                    GioiTinh = "Nữ",
                    ChucVu = "Nhân Viên",
                    Email = "vuthihong@gmail.com",
                    SoDienThoai = "0945567890",
                    NgayVaoLam = new DateTime(2023, 5, 12),
                    TrangThai = "Đang làm"
                },
                new NhanVien {
                    ID = "NV006",
                    HoTen = "Phạm Quốc Bảo",
                    GioiTinh = "Nam",
                    ChucVu = "Nhân Viên",
                    Email = "phamquocbao@gmail.com",
                    SoDienThoai = "0956678901",
                    NgayVaoLam = new DateTime(2021, 8, 17),
                    TrangThai = "Tạm nghỉ"
                },
                new NhanVien {
                    ID = "NV007",
                    HoTen = "Đặng Thúy Hằng",
                    GioiTinh = "Nữ",
                    ChucVu = "Nhân Viên",
                    Email = "dangthuyhang@gmail.com",
                    SoDienThoai = "0967789012",
                    NgayVaoLam = new DateTime(2022, 2, 10),
                    TrangThai = "Đang làm"
                },
                new NhanVien {
                    ID = "NV008",
                    HoTen = "Bùi Văn Khánh",
                    GioiTinh = "Nam",
                    ChucVu = "Nhân Viên",
                    Email = "buivankhanh@gmail.com",
                    SoDienThoai = "0978890123",
                    NgayVaoLam = new DateTime(2020, 11, 25),
                    TrangThai = "Đang làm"
                },
                new NhanVien {
                    ID = "NV009",
                    HoTen = "Ngô Thị Hạnh",
                    GioiTinh = "Nữ",
                    ChucVu = "Nhân Viên",
                    Email = "ngothihanh@gmail.com",
                    SoDienThoai = "0989901234",
                    NgayVaoLam = new DateTime(2019, 6, 30),
                    TrangThai = "Tạm nghỉ"
                },
                new NhanVien {
                    ID = "NV010",
                    HoTen = "Đỗ Hoàng Sơn",
                    GioiTinh = "Nam",
                    ChucVu = "Nhân Viên",
                    Email = "dohoangson@gmail.com",
                    SoDienThoai = "0991012345",
                    NgayVaoLam = new DateTime(2023, 9, 5),
                    TrangThai = "Đang làm"
                }
            };
            context.NhanViens.AddRange(nhanVienList);

            // Khởi tạo dữ liệu mẫu cho ThanhVien
            var thanhVienList = new List<ThanhVien>
            {
                new ThanhVien {
                    MaThanhVien = "M0001",
                    HoTen = "Nguyễn Văn An",
                    GioiTinh = "Nam",
                    SoDienThoai = "0987654321",
                    Email = "nguyenvana@gmail.com",
                    LoaiThanhVien = "Sinh viên",
                    NgayDangKy = new DateTime(2023, 1, 1),
                    NgayHetHan = new DateTime(2025, 1, 1),
                    TrangThai = "Hết hạn"
                },
                new ThanhVien {
                    MaThanhVien = "M0002",
                    HoTen = "Trần Thị Bích Ngọc",
                    GioiTinh = "Nữ",
                    SoDienThoai = "0912345678",
                    Email = "bichngoc@gmail.com",
                    LoaiThanhVien = "Sinh viên",
                    NgayDangKy = new DateTime(2023, 1, 15),
                    NgayHetHan = new DateTime(2025, 1, 15),
                    TrangThai = "Hết hạn"
                },
                new ThanhVien {
                    MaThanhVien = "M0003",
                    HoTen = "Lê Hoàng Nam",
                    GioiTinh = "Nam",
                    SoDienThoai = "0905678123",
                    Email = "lehoangnam@gmail.com",
                    LoaiThanhVien = "Giảng viên",
                    NgayDangKy = new DateTime(2023, 2, 10),
                    NgayHetHan = new DateTime(2024, 2, 10),
                    TrangThai = "Hết hạn"
                },
                new ThanhVien {
                    MaThanhVien = "M0004",
                    HoTen = "Phạm Thu Hương",
                    GioiTinh = "Nữ",
                    SoDienThoai = "0977234567",
                    Email = "huongpham@gmail.com",
                    LoaiThanhVien = "Sinh viên",
                    NgayDangKy = new DateTime(2023, 3, 5),
                    NgayHetHan = new DateTime(2024, 3, 5),
                    TrangThai = "Hết hạn"
                },
                new ThanhVien {
                    MaThanhVien = "M0005",
                    HoTen = "Hoàng Thị Lan",
                    GioiTinh = "Nữ",
                    SoDienThoai = "0921456789",
                    Email = "hoanglan@gmail.com",
                    LoaiThanhVien = "Thường",
                    NgayDangKy = new DateTime(2023, 3, 20),
                    NgayHetHan = new DateTime(2025, 3, 20),
                    TrangThai = "Hết hạn"
                },
                new ThanhVien {
                    MaThanhVien = "M0006",
                    HoTen = "Vũ Đức Thành",
                    GioiTinh = "Nam",
                    SoDienThoai = "0968234890",
                    Email = "ducthanh123@gmail.com",
                    LoaiThanhVien = "Sinh viên",
                    NgayDangKy = new DateTime(2023, 4, 10),
                    NgayHetHan = new DateTime(2025, 4, 10),
                    TrangThai = "Hết hạn"
                },
                new ThanhVien {
                    MaThanhVien = "M0007",
                    HoTen = "Bùi Thanh Mai",
                    GioiTinh = "Nữ",
                    SoDienThoai = "0945678234",
                    Email = "thanhmai_bui@gmail.com",
                    LoaiThanhVien = "Giảng viên",
                    NgayDangKy = new DateTime(2023, 5, 15),
                    NgayHetHan = new DateTime(2025, 5, 15),
                    TrangThai = "Hoạt động"
                },
                new ThanhVien {
                    MaThanhVien = "M0008",
                    HoTen = "Đỗ Quang Huy",
                    GioiTinh = "Nam",
                    SoDienThoai = "0982345678",
                    Email = "huydo@gmail.com",
                    LoaiThanhVien = "Sinh viên",
                    NgayDangKy = new DateTime(2023, 6, 5),
                    NgayHetHan = new DateTime(2024, 6, 5),
                    TrangThai = "Hết hạn"
                },
                new ThanhVien {
                    MaThanhVien = "M0009",
                    HoTen = "Nguyễn Thị Kim Anh",
                    GioiTinh = "Nữ",
                    SoDienThoai = "0909123456",
                    Email = "kimanh99@gmail.com",
                    LoaiThanhVien = "Thường",
                    NgayDangKy = new DateTime(2023, 6, 20),
                    NgayHetHan = new DateTime(2025, 6, 20),
                    TrangThai = "Hết hạn"
                },
                new ThanhVien {
                    MaThanhVien = "M0010",
                    HoTen = "Lý Văn Duy",
                    GioiTinh = "Nam",
                    SoDienThoai = "0915678901",
                    Email = "lyvduy@gmail.com",
                    LoaiThanhVien = "Sinh viên",
                    NgayDangKy = new DateTime(2023, 7, 10),
                    NgayHetHan = new DateTime(2024, 7, 10),
                    TrangThai = "Hết hạn"
                },
                new ThanhVien {
                    MaThanhVien = "M0011",
                    HoTen = "Nguyễn Minh Tú",
                    GioiTinh = "Nam",
                    SoDienThoai = "0911123456",
                    Email = "minhtu@gmail.com",
                    LoaiThanhVien = "Sinh viên",
                    NgayDangKy = new DateTime(2023, 8, 10),
                    NgayHetHan = new DateTime(2024, 8, 10),
                    TrangThai = "Hết hạn"
                },
                new ThanhVien {
                    MaThanhVien = "M0012",
                    HoTen = "Phạm Hoàng Yến",
                    GioiTinh = "Nữ",
                    SoDienThoai = "0988112233",
                    Email = "hoangyen_pham@gmail.com",
                    LoaiThanhVien = "Sinh viên",
                    NgayDangKy = new DateTime(2023, 9, 5),
                    NgayHetHan = new DateTime(2025, 9, 5),
                    TrangThai = "Hoạt động"
                },
                new ThanhVien {
                    MaThanhVien = "M0013",
                    HoTen = "Bùi Hữu Nghĩa",
                    GioiTinh = "Nam",
                    SoDienThoai = "0977556677",
                    Email = "huunghia.bui@gmail.com",
                    LoaiThanhVien = "Giảng viên",
                    NgayDangKy = new DateTime(2023, 10, 15),
                    NgayHetHan = new DateTime(2025, 10, 15),
                    TrangThai = "Hoạt động"
                },
                new ThanhVien {
                    MaThanhVien = "M0014",
                    HoTen = "Lê Hải Đăng",
                    GioiTinh = "Nam",
                    SoDienThoai = "0933445566",
                    Email = "haidang_le@gmail.com",
                    LoaiThanhVien = "Thường",
                    NgayDangKy = new DateTime(2023, 11, 20),
                    NgayHetHan = new DateTime(2025, 11, 20),
                    TrangThai = "Hoạt động"
                },
                new ThanhVien {
                    MaThanhVien = "M0015",
                    HoTen = "Trần Thu Trang",
                    GioiTinh = "Nữ",
                    SoDienThoai = "0966778899",
                    Email = "trangtran@gmail.com",
                    LoaiThanhVien = "Sinh viên",
                    NgayDangKy = new DateTime(2023, 12, 1),
                    NgayHetHan = new DateTime(2024, 12, 1),
                    TrangThai = "Hết hạn"
                }
            };
            context.ThanhViens.AddRange(thanhVienList);

            context.SaveChanges();

            // Khởi tạo dữ liệu mẫu cho PhieuMuon (cần lưu trước các bảng có liên kết)
            var phieuMuonList = new List<PhieuMuon>
            {
                new PhieuMuon {
                    MaThanhVien = "M0001",
                    NgayMuon = new DateTime(2025, 3, 1),
                    HanTra = new DateTime(2025, 3, 15),
                    NgayTraThucTe = null,
                    TrangThai = "Quá hạn",
                    MaSach = "B1001",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0002",
                    NgayMuon = new DateTime(2025, 2, 20),
                    HanTra = new DateTime(2025, 3, 10),
                    NgayTraThucTe = new DateTime(2025, 3, 9),
                    TrangThai = "Đã trả",
                    MaSach = "B1003",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0003",
                    NgayMuon = new DateTime(2025, 3, 5),
                    HanTra = new DateTime(2025, 3, 19),
                    NgayTraThucTe = null,
                    TrangThai = "Quá hạn",
                    MaSach = "B1005",
                    SoLuong = 2
                },
                new PhieuMuon {
                    MaThanhVien = "M0004",
                    NgayMuon = new DateTime(2025, 3, 8),
                    HanTra = new DateTime(2025, 3, 22),
                    NgayTraThucTe = null,
                    TrangThai = "Quá hạn",
                    MaSach = "B1012",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0005",
                    NgayMuon = new DateTime(2025, 2, 28),
                    HanTra = new DateTime(2025, 3, 14),
                    NgayTraThucTe = null,
                    TrangThai = "Quá hạn",
                    MaSach = "B1010",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0006",
                    NgayMuon = new DateTime(2025, 2, 25),
                    HanTra = new DateTime(2025, 3, 11),
                    NgayTraThucTe = new DateTime(2025, 3, 10),
                    TrangThai = "Đã trả",
                    MaSach = "B1007",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0007",
                    NgayMuon = new DateTime(2025, 3, 10),
                    HanTra = new DateTime(2025, 3, 24),
                    NgayTraThucTe = null,
                    TrangThai = "Quá hạn",
                    MaSach = "B1009",
                    SoLuong = 2
                },
                new PhieuMuon {
                    MaThanhVien = "M0008",
                    NgayMuon = new DateTime(2025, 2, 15),
                    HanTra = new DateTime(2025, 3, 1),
                    NgayTraThucTe = null,
                    TrangThai = "Quá hạn",
                    MaSach = "B1011",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0009",
                    NgayMuon = new DateTime(2025, 3, 1),
                    HanTra = new DateTime(2025, 3, 15),
                    NgayTraThucTe = null,
                    TrangThai = "Quá hạn",
                    MaSach = "B1004",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0010",
                    NgayMuon = new DateTime(2025, 2, 27),
                    HanTra = new DateTime(2025, 3, 13),
                    NgayTraThucTe = new DateTime(2025, 3, 15),
                    TrangThai = "Đã trả",
                    MaSach = "B1006",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0011",
                    NgayMuon = new DateTime(2025, 3, 2),
                    HanTra = new DateTime(2025, 3, 16),
                    NgayTraThucTe = null,
                    TrangThai = "Quá hạn",
                    MaSach = "B1013",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0012",
                    NgayMuon = new DateTime(2025, 3, 6),
                    HanTra = new DateTime(2025, 3, 20),
                    NgayTraThucTe = new DateTime(2025, 3, 15),
                    TrangThai = "Đã trả",
                    MaSach = "B1002",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0013",
                    NgayMuon = new DateTime(2025, 3, 9),
                    HanTra = new DateTime(2025, 3, 23),
                    NgayTraThucTe = new DateTime(20),
                    TrangThai = "Đã trả",
                    MaSach = "B1008",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0014",
                    NgayMuon = new DateTime(2025, 2, 22),
                    HanTra = new DateTime(2025, 3, 8),
                    NgayTraThucTe = new DateTime(2025, 3, 12),
                    TrangThai = "Đã trả",
                    MaSach = "B1014",
                    SoLuong = 1
                },
                new PhieuMuon {
                    MaThanhVien = "M0015",
                    NgayMuon = new DateTime(2025, 3, 4),
                    HanTra = new DateTime(2025, 3, 18),
                    NgayTraThucTe = new DateTime(2025, 3, 15),
                    TrangThai = "Đã trả",
                    MaSach = "B1015",
                    SoLuong = 1
                }
            };
            context.PhieuMuons.AddRange(phieuMuonList);

            // Lưu thay đổi vào database
            context.SaveChanges();
        }
    }
}