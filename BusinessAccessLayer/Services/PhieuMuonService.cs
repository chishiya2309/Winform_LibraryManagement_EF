using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.DAL;
using DataAccessLayer.Models;
using BusinessAccessLayer.DTOs;

namespace BusinessAccessLayer.Services
{
    public class PhieuMuonService : IPhieuMuonService
    {
        private readonly UnitOfWork _unitOfWork;

        public PhieuMuonService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<PhieuMuonDTO> GetAllPhieuMuonDTO()
        {
            return _unitOfWork.PhieuMuonRepository.GetAll()
                .Select(p => new PhieuMuonDTO
                {
                    MaPhieu = p.MaPhieu,
                    MaThanhVien = p.MaThanhVien,
                    NgayMuon = p.NgayMuon,
                    HanTra = p.HanTra,
                    NgayTraThucTe = p.NgayTraThucTe,
                    TrangThai = p.TrangThai,
                    MaSach = p.MaSach,
                    SoLuong = p.SoLuong
                });
        }

        public PhieuMuon GetPhieuMuonById(int maPhieu)
        {
            return _unitOfWork.PhieuMuonRepository.GetById(maPhieu);
        }

        public IEnumerable<PhieuMuon> GetPhieuMuonByStatus(string trangThai)
        {
            return _unitOfWork.PhieuMuonRepository.Find(p => p.TrangThai == trangThai);
        }

        public IEnumerable<PhieuMuon> GetPhieuMuonByDate(DateTime fromDate, DateTime toDate)
        {
            return _unitOfWork.PhieuMuonRepository.Find(p =>
                p.NgayMuon >= fromDate && p.NgayMuon <= toDate);
        }

        public IEnumerable<PhieuMuon> SearchPhieuMuon(string keyword)
        {
            keyword = keyword.ToLower();
            return _unitOfWork.PhieuMuonRepository.Find(pm =>
                pm.MaPhieu.ToString().Contains(keyword) ||
                pm.MaThanhVien.ToLower().Contains(keyword) ||
                pm.MaSach.ToLower().Contains(keyword));
        }

        public void AddPhieuMuon(PhieuMuon phieuMuon)
        {
            if (phieuMuon == null)
                throw new ArgumentNullException("phieuMuon");

            // Thiết lập giá trị mặc định
            if (phieuMuon.NgayMuon == DateTime.MinValue)
                phieuMuon.NgayMuon = DateTime.Now;

            if (phieuMuon.HanTra == DateTime.MinValue)
                phieuMuon.HanTra = phieuMuon.NgayMuon.AddDays(14); // Mặc định 14 ngày

            if (string.IsNullOrEmpty(phieuMuon.TrangThai))
                phieuMuon.TrangThai = "Đang mượn";

            // Kiểm tra hạn trả phải lớn hơn ngày mượn ít nhất 1 ngày
            if (phieuMuon.HanTra <= phieuMuon.NgayMuon)
                throw new Exception("Hạn trả phải lớn hơn ngày mượn ít nhất 1 ngày.");

            // Kiểm tra thành viên có tồn tại không
            var thanhVien = _unitOfWork.ThanhVienRepository.GetById(phieuMuon.MaThanhVien);
            if (thanhVien == null)
                throw new Exception("Mã thành viên không tồn tại!");

            // Kiểm tra thành viên có bị khóa hoặc hết hạn không
            if (thanhVien.TrangThai == "Khóa" || thanhVien.TrangThai == "Hết hạn")
                throw new Exception("Thành viên đã bị khóa hoặc tài khoản đã hết hạn!");

            // Kiểm tra sách có tồn tại không
            var sach = _unitOfWork.SachRepository.GetById(phieuMuon.MaSach);
            if (sach == null)
                throw new Exception("Mã sách không tồn tại!");

            // Kiểm tra số lượng sách còn đủ không
            if (sach.KhaDung < phieuMuon.SoLuong)
                throw new Exception($"Số lượng sách không đủ để mượn! Hiện có {sach.KhaDung} cuốn khả dụng.");

            // Kiểm tra số lượng sách thành viên đã mượn (giới hạn mỗi thành viên mượn tối đa 5 sách)
            int soSachDangMuon = CountSachByThanhVien(phieuMuon.MaThanhVien);
            if ((soSachDangMuon + phieuMuon.SoLuong) > 5)
                throw new Exception($"Thành viên đã mượn {soSachDangMuon} cuốn, không thể mượn thêm {phieuMuon.SoLuong} cuốn nữa! Tối đa là 5 cuốn.");

            // Kiểm tra thành viên có phiếu mượn quá hạn không
            bool coPhieuMuonQuaHan = _unitOfWork.PhieuMuonRepository.Find(p =>
                p.MaThanhVien == phieuMuon.MaThanhVien && p.TrangThai == "Quá hạn").Any();

            if (coPhieuMuonQuaHan)
                throw new Exception("Thành viên có sách mượn quá hạn chưa trả, không thể mượn thêm!");

            // Thêm phiếu mượn
            _unitOfWork.PhieuMuonRepository.Add(phieuMuon);

            // Cập nhật số lượng sách khả dụng
            sach.KhaDung -= phieuMuon.SoLuong;
            _unitOfWork.SachRepository.Update(sach);

            _unitOfWork.Save();
        }

        public void UpdatePhieuMuon(PhieuMuon phieuMuon)
        {
            if (phieuMuon == null)
                throw new ArgumentNullException(nameof(phieuMuon));

            var phieuMuonHienTai = _unitOfWork.PhieuMuonRepository.GetById(phieuMuon.MaPhieu);
            if (phieuMuonHienTai == null)
                throw new Exception("Không tìm thấy phiếu mượn cần cập nhật.");

            // Lưu thông tin cũ để so sánh
            string trangThaiCu = phieuMuonHienTai.TrangThai;
            int soLuongCu = phieuMuonHienTai.SoLuong;

            // Kiểm tra giới hạn số lượng sách mượn
            if (phieuMuon.TrangThai == "Đang mượn" || phieuMuon.TrangThai == "Quá hạn")
            {
                // Tính tổng số sách đang mượn (không tính phiếu hiện tại)
                int tongSachDangMuon = _unitOfWork.PhieuMuonRepository
                    .Find(p => p.MaThanhVien == phieuMuon.MaThanhVien &&
                             p.MaPhieu != phieuMuon.MaPhieu &&
                             (p.TrangThai == "Đang mượn" || p.TrangThai == "Quá hạn"))
                    .Sum(p => p.SoLuong);

                // Nếu tổng số sách đang mượn + số lượng mới > 5
                if (tongSachDangMuon + phieuMuon.SoLuong > 5)
                    throw new Exception($"Thành viên đã mượn {tongSachDangMuon} cuốn, không thể mượn thêm {phieuMuon.SoLuong} cuốn nữa! Tối đa là 5 cuốn.");
            }


            // Cập nhật thông tin phiếu mượn
            phieuMuonHienTai.MaThanhVien = phieuMuon.MaThanhVien;
            phieuMuonHienTai.NgayMuon = phieuMuon.NgayMuon;
            phieuMuonHienTai.HanTra = phieuMuon.HanTra;
            phieuMuonHienTai.NgayTraThucTe = phieuMuon.NgayTraThucTe;
            phieuMuonHienTai.TrangThai = phieuMuon.TrangThai;
            phieuMuonHienTai.SoLuong = phieuMuon.SoLuong;

            // Kiểm tra ngày trả thực tế
            if (phieuMuonHienTai.NgayTraThucTe.HasValue && phieuMuonHienTai.NgayTraThucTe.Value < phieuMuonHienTai.NgayMuon)
                throw new Exception("Ngày trả thực tế phải lớn hơn hoặc bằng ngày mượn!");

            // Kiểm tra hạn trả
            if (phieuMuonHienTai.HanTra < phieuMuonHienTai.NgayMuon)
                throw new Exception("Hạn trả phải lớn hơn hoặc bằng ngày mượn!");

            // Cập nhật số lượng sách khả dụng nếu có thay đổi trạng thái hoặc số lượng
            if (trangThaiCu != phieuMuon.TrangThai || soLuongCu != phieuMuon.SoLuong)
            {
                var sach = _unitOfWork.SachRepository.GetById(phieuMuon.MaSach);
                if (sach != null)
                {
                    // Nếu trạng thái từ "Đang mượn" hoặc "Quá hạn" sang "Đã trả"
                    if ((trangThaiCu == "Đang mượn" || trangThaiCu == "Quá hạn") && phieuMuon.TrangThai == "Đã trả")
                    {
                        sach.KhaDung += soLuongCu;
                    }
                    // Nếu trạng thái từ "Đã trả" sang "Đang mượn" hoặc "Quá hạn"
                    else if (trangThaiCu == "Đã trả" && (phieuMuon.TrangThai == "Đang mượn" || phieuMuon.TrangThai == "Quá hạn"))
                    {
                        if (sach.KhaDung < phieuMuon.SoLuong)
                            throw new Exception("Số lượng sách không đủ để cho mượn!");
                        sach.KhaDung -= phieuMuon.SoLuong;
                    }
                    // Nếu chỉ thay đổi số lượng trong cùng trạng thái "Đang mượn" hoặc "Quá hạn"
                    else if ((trangThaiCu == "Đang mượn" || trangThaiCu == "Quá hạn") &&
                            (phieuMuon.TrangThai == "Đang mượn" || phieuMuon.TrangThai == "Quá hạn") &&
                            soLuongCu != phieuMuon.SoLuong)
                    {
                        int chenhLech = soLuongCu - phieuMuon.SoLuong;
                        sach.KhaDung += chenhLech;
                        if (sach.KhaDung < 0)
                            throw new Exception("Số lượng sách không đủ để cho mượn thêm!");
                    }

                    _unitOfWork.SachRepository.Update(sach);
                }
            }

            // Cập nhật trạng thái dựa vào hạn trả
            if (phieuMuon.HanTra < DateTime.Now && phieuMuon.TrangThai == "Đang mượn")
                phieuMuonHienTai.TrangThai = "Quá hạn";

            _unitOfWork.PhieuMuonRepository.Update(phieuMuonHienTai);
            _unitOfWork.Save();
        }

        public void DeletePhieuMuon(int maPhieu)
        {
            var phieuMuon = _unitOfWork.PhieuMuonRepository.GetById(maPhieu);
            if (phieuMuon != null)
            {
                // Nếu phiếu mượn đang trong trạng thái "Đang mượn" hoặc "Quá hạn", cập nhật lại số lượng sách
                if (phieuMuon.TrangThai == "Đang mượn" || phieuMuon.TrangThai == "Quá hạn")
                {
                    var sach = _unitOfWork.SachRepository.GetById(phieuMuon.MaSach);
                    if (sach != null)
                    {
                        sach.KhaDung += phieuMuon.SoLuong;
                        _unitOfWork.SachRepository.Update(sach);
                    }
                }

                _unitOfWork.PhieuMuonRepository.Remove(phieuMuon);
                _unitOfWork.Save();
            }
        }

        public void TraSach(PhieuMuon phieuMuon)
        {
            if (phieuMuon == null)
                throw new ArgumentNullException(nameof(phieuMuon));

            // Lấy thông tin phiếu mượn hiện tại
            var phieuMuonHienTai = _unitOfWork.PhieuMuonRepository.GetById(phieuMuon.MaPhieu);
            if (phieuMuonHienTai == null)
                throw new Exception("Phiếu mượn không tồn tại!");

            // Kiểm tra trạng thái phiếu mượn
            if (phieuMuonHienTai.TrangThai != "Đang mượn" && phieuMuonHienTai.TrangThai != "Quá hạn")
                throw new Exception("Phiếu mượn không ở trạng thái cho phép trả sách!");

            // Kiểm tra ngày trả phải lớn hơn ngày mượn
            if (phieuMuon.NgayTraThucTe < phieuMuonHienTai.NgayMuon)
                throw new Exception("Ngày trả thực tế phải lớn hơn hoặc bằng ngày mượn!");

            // Cập nhật thông tin trả sách
            phieuMuonHienTai.NgayTraThucTe = phieuMuon.NgayTraThucTe;
            phieuMuonHienTai.TrangThai = "Đã trả";

            // Cập nhật số lượng sách khả dụng
            var sach = _unitOfWork.SachRepository.GetById(phieuMuonHienTai.MaSach);
            if (sach != null)
            {
                sach.KhaDung += phieuMuonHienTai.SoLuong;
                _unitOfWork.SachRepository.Update(sach);
            }

            // Cập nhật phiếu mượn và lưu thay đổi
            _unitOfWork.PhieuMuonRepository.Update(phieuMuonHienTai);
            _unitOfWork.Save();
        }

        public IEnumerable<PhieuMuonDTO> GetPhieuMuonQuaHanDTO()
        {
            return _unitOfWork.PhieuMuonRepository
                .Find(p => p.HanTra < DateTime.Now &&
                          (p.TrangThai == "Đang mượn" || p.TrangThai == "Quá hạn"))
                .Select(p => new PhieuMuonDTO
                {
                    MaPhieu = p.MaPhieu,
                    MaThanhVien = p.MaThanhVien,
                    MaSach = p.MaSach,
                    NgayMuon = p.NgayMuon,
                    HanTra = p.HanTra,
                    TrangThai = p.TrangThai,
                    SoLuong = p.SoLuong
                });
        }

        public int CountSachByThanhVien(string maThanhVien)
        {
            return _unitOfWork.PhieuMuonRepository.Find(p =>
                p.MaThanhVien == maThanhVien && p.TrangThai == "Đang mượn")
                .Sum(p => p.SoLuong);
        }

        public IEnumerable<PhieuMuonDTO> GetLichSuMuonTheoThanhVien(string maThanhVien)
        {
            return _unitOfWork.PhieuMuonRepository
                .Find(p => p.MaThanhVien == maThanhVien)
                .OrderByDescending(p => p.NgayMuon)
                .Select(p => new PhieuMuonDTO
                {
                    MaPhieu = p.MaPhieu,
                    MaThanhVien = p.MaThanhVien,
                    MaSach = p.MaSach,
                    NgayMuon = p.NgayMuon,
                    HanTra = p.HanTra,
                    NgayTraThucTe = p.NgayTraThucTe,
                    TrangThai = p.TrangThai,
                    SoLuong = p.SoLuong
                });
        }

        public IEnumerable<TopThanhVienMuonDTO> GetTop5ThanhVienMuonNhieuNhat()
        {
            var phieuMuonList = _unitOfWork.PhieuMuonRepository
                .Find(p => p.TrangThai == "Đang mượn" || p.TrangThai == "Quá hạn");

            var topBorrowers = phieuMuonList
                .GroupBy(p => p.MaThanhVien)
                .Select(g => new
                {
                    MaThanhVien = g.Key,
                    TongSoSach = g.Sum(p => p.SoLuong)
                })
                .OrderByDescending(x => x.TongSoSach)
                .Take(5)
                .ToList();

            int stt = 1;
            var result = new List<TopThanhVienMuonDTO>();

            foreach (var item in topBorrowers)
            {
                var thanhVien = _unitOfWork.ThanhVienRepository.GetById(item.MaThanhVien);
                string hoTen = thanhVien != null ? thanhVien.HoTen : "Không xác định";

                result.Add(new TopThanhVienMuonDTO
                {
                    STT = stt++,
                    MaThanhVien = item.MaThanhVien,
                    HoTen = hoTen,
                    TongSoSach = item.TongSoSach
                });
            }
            return result;
        }

        public IEnumerable<TopSachPhoBienDTO> GetTop10SachPhoBien()
        {
            var phieuMuonList = _unitOfWork.PhieuMuonRepository.GetAll();

            var popularBooks = phieuMuonList
                .GroupBy(p => p.MaSach)
                .Select(g => new
                {
                    MaSach = g.Key,
                    SoLanMuon = g.Count()
                })
                .OrderByDescending(x => x.SoLanMuon)
                .Take(10)
                .ToList();

            int stt = 1;
            var result = new List<TopSachPhoBienDTO>();

            foreach (var item in popularBooks)
            {
                var sach = _unitOfWork.SachRepository.GetById(item.MaSach);
                string tenSach = sach != null ? sach.TenSach : "Không xác định";

                result.Add(new TopSachPhoBienDTO
                {
                    STT = stt++,
                    MaSach = item.MaSach,
                    TenSach = tenSach,
                    SoLanMuon = item.SoLanMuon
                });
            }

            return result;
        }

        public IEnumerable<ThongKeSachMuonTheoThangDTO> GetThongKeSachMuonTheoThang(int? selectedYear = null)
        {
            var phieuMuonList = _unitOfWork.PhieuMuonRepository.GetAll();

            var loansByMonth = phieuMuonList
                .GroupBy(p => new
                {
                    Thang = p.NgayMuon.Month,
                    Nam = p.NgayMuon.Year
                })
                .Select(g => new ThongKeSachMuonTheoThangDTO
                {
                    Thang = g.Key.Thang,
                    Nam = g.Key.Nam,
                    ThangNam = $"{g.Key.Thang}/{g.Key.Nam}",
                    SoLuongMuon = g.Sum(p => p.SoLuong)
                })
                .OrderBy(x => x.Nam)
                .ThenBy(x => x.Thang)
                .ToList();

            if (selectedYear.HasValue)
            {
                loansByMonth = loansByMonth.Where(x => x.Nam == selectedYear.Value).ToList();
            }

            return loansByMonth;
        }

        public IEnumerable<int> GetDanhSachNam()
        {
            return _unitOfWork.PhieuMuonRepository.GetAll()
                .Select(p => p.NgayMuon.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToList();
        }

        public ThongKeTraSachDTO GetThongKeTraSach()
        {
            var phieuMuonList = _unitOfWork.PhieuMuonRepository.GetAll().ToList();

            if (phieuMuonList == null || !phieuMuonList.Any())
            {
                return new ThongKeTraSachDTO
                {
                    TongSoPhieu = 0,
                    SoPhieuDungHan = 0,
                    SoPhieuQuaHan = 0
                };
            }

            int tongSoPhieu = phieuMuonList
                .Count(p => p.TrangThai != "Đang mượn");

            int soPhieuDungHan = phieuMuonList
                .Count(p => p.TrangThai == "Đã trả"
                    && p.NgayTraThucTe.HasValue
                    && p.NgayTraThucTe.Value <= p.HanTra);

            int soPhieuQuaHan = phieuMuonList
                .Count(p => p.TrangThai == "Quá hạn"
                    || (p.TrangThai == "Đã trả"
                    && p.NgayTraThucTe.HasValue
                    && p.NgayTraThucTe.Value > p.HanTra));

            return new ThongKeTraSachDTO
            {
                TongSoPhieu = tongSoPhieu,
                SoPhieuDungHan = soPhieuDungHan,
                SoPhieuQuaHan = soPhieuQuaHan
            };
        }
    }
}