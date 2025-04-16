using System;
using DataAccessLayer.Models;

namespace DataAccessLayer.DAL
{
    public class UnitOfWork : IDisposable
    {
        private readonly QuanLyThuVienContext _context;
        private bool _disposed = false;

        // Repositories
        private GenericRepository<DanhMucSach> _danhMucSachRepository;
        private GenericRepository<Sach> _sachRepository;
        private GenericRepository<NhanVien> _nhanVienRepository;
        private GenericRepository<ThanhVien> _thanhVienRepository;
        private GenericRepository<PhieuMuon> _phieuMuonRepository;

        public UnitOfWork()
        {
            _context = new QuanLyThuVienContext();
        }

        // Properties to access repositories
        public GenericRepository<DanhMucSach> DanhMucSachRepository
        {
            get
            {
                if (_danhMucSachRepository == null)
                {
                    _danhMucSachRepository = new GenericRepository<DanhMucSach>(_context);
                }
                return _danhMucSachRepository;
            }
        }

        public GenericRepository<Sach> SachRepository
        {
            get
            {
                if (_sachRepository == null)
                {
                    _sachRepository = new GenericRepository<Sach>(_context);
                }
                return _sachRepository;
            }
        }

        public GenericRepository<NhanVien> NhanVienRepository
        {
            get
            {
                if (_nhanVienRepository == null)
                {
                    _nhanVienRepository = new GenericRepository<NhanVien>(_context);
                }
                return _nhanVienRepository;
            }
        }

        public GenericRepository<ThanhVien> ThanhVienRepository
        {
            get
            {
                if (_thanhVienRepository == null)
                {
                    _thanhVienRepository = new GenericRepository<ThanhVien>(_context);
                }
                return _thanhVienRepository;
            }
        }

        public GenericRepository<PhieuMuon> PhieuMuonRepository
        {
            get
            {
                if (_phieuMuonRepository == null)
                {
                    _phieuMuonRepository = new GenericRepository<PhieuMuon>(_context);
                }
                return _phieuMuonRepository;
            }
        }

        // Save changes to database
        public void Save()
        {
            _context.SaveChanges();
        }

        // Dispose pattern implementation
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}