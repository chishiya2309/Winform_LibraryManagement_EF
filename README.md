# Hệ Thống Quản Lý Thư Viện

Hệ thống quản lý thư viện hiện đại được phát triển bằng C# Windows Forms và Entity Framework 6. Dự án này là quá trình chuyển đổi từ phương pháp truy cập dữ liệu truyền thống (ADO.NET) sang Entity Framework 6, mang lại hiệu suất và khả năng bảo trì tốt hơn.

![Library Management System](https://img.shields.io/badge/C%23-Library%20Management-blue)
![EF6](https://img.shields.io/badge/ORM-Entity%20Framework%206-orange)
![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-green)

## 📋 Tính Năng

### 👥 Quản Lý Thành Viên
- Thêm, sửa, xóa thông tin thành viên
- Kiểm tra và cảnh báo thành viên sắp hết hạn
- Thống kê thành viên theo loại

### 📚 Quản Lý Sách
- Quản lý danh mục sách
- Thêm, sửa, xóa thông tin sách
- Theo dõi số lượng sách còn lại
- Cảnh báo sách sắp hết

### 📝 Quản Lý Mượn Trả
- Đăng ký mượn sách với các kiểm tra tự động:
  - Kiểm tra tình trạng thành viên
  - Kiểm tra số lượng sách khả dụng
  - Kiểm tra giới hạn mượn (tối đa 5 cuốn)
  - Kiểm tra phiếu mượn quá hạn
  - Đảm bảo hạn trả lớn hơn ngày mượn ít nhất 1 ngày
- Xử lý trả sách
- Thống kê phiếu mượn quá hạn

### 📊 Báo Cáo Thống Kê
- Thống kê sách mượn nhiều nhất
- Thống kê tỷ lệ trả sách
- Top người mượn thường xuyên
- Thống kê số lượng sách theo danh mục
- Biểu đồ thống kê thành viên

### 👩‍💼 Quản Lý Nhân Viên
- Thêm, sửa, xóa thông tin nhân viên
- Phân quyền quản lý

## 🏗️ Kiến Trúc Dự Án

Dự án được tổ chức theo mô hình kiến trúc 3 lớp:

### 1. Data Access Layer (DAL)
- Chứa các model Entity Framework
- Xử lý kết nối và truy cập cơ sở dữ liệu

### 2. Business Access Layer (BAL)
- Chứa các service và interface
- Triển khai logic nghiệp vụ
- DTO (Data Transfer Objects) cho việc truyền dữ liệu

### 3. Presentation Layer (Winform)
- Giao diện người dùng Windows Forms
- Xử lý tương tác người dùng

## 💻 Công Nghệ Sử Dụng

- **C# .NET Framework**: Ngôn ngữ và framework chính
- **Entity Framework 6**: ORM (Object-Relational Mapping)
- **Windows Forms**: UI framework
- **SQL Server**: Hệ quản trị cơ sở dữ liệu

## 🚀 Hướng Dẫn Cài Đặt

### Yêu Cầu Hệ Thống
- Windows 7/8/10/11
- .NET Framework 4.7.2 hoặc cao hơn
- SQL Server 2012 hoặc cao hơn
- Visual Studio 2019 hoặc cao hơn (để phát triển)

### Các Bước Cài Đặt
1. Clone repository về máy:
```
git clone https://github.com/chishiya2309/Winform_LibraryManagement_EF.git
```

2. Mở solution trong Visual Studio

3. Cấu hình connection string trong file `App.config` của các tầng UI:
```xml
<connectionStrings>
  <add name="LibraryDbContext" connectionString="Data Source=YOUR_SERVER;Initial Catalog=LibraryDb;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```

4. Xây dựng và chạy ứng dụng

## 📝 Lưu Ý Khi Sử Dụng

- Đăng nhập với tài khoản admin mặc định:
  - Username: admin
  - Password: admin
- Sao lưu cơ sở dữ liệu định kỳ

## 🔄 Quá Trình Chuyển Đổi Sang Entity Framework 6

Dự án này được chuyển đổi từ phương pháp truy cập dữ liệu truyền thống sang Entity Framework 6. Các bước chuyển đổi chính:

1. Tạo các model Entity Framework từ cơ sở dữ liệu hiện có
2. Thiết kế lớp service với các interface tương ứng
3. Cập nhật các form và control để sử dụng dịch vụ mới
4. Triển khai logic nghiệp vụ trong các service
5. Kiểm thử và đảm bảo tính tương thích

## 📜 Giấy Phép

Phân phối theo Giấy phép MIT. Xem `LICENSE` để biết thêm thông tin.

## 📞 Liên Hệ

- Email: lequanghung.work@gmail.com
- GitHub: [chishiya2309](https://github.com/chishiya2309)

---

⭐️ Từ [chishiya2309](https://github.com/chishiya2309)
