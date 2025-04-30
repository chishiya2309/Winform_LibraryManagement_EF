using BusinessAccessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_PhieuMuonQuaHan : UserControl
    {
        private DBMembers dBMembers;
        private DBBooks dBBooks;
        private DBLoanAndReturn dBLAR;

        public AdminControl_PhieuMuonQuaHan()
        {
            InitializeComponent();
            dBMembers = new DBMembers();
            dBBooks = new DBBooks();
            dBLAR = new DBLoanAndReturn();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dtThanhVien = dBMembers.LayThanhVien().Tables[0];

            if (dtThanhVien != null)
            {
                var col = larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn;
                if (col != null)
                {
                    col.DataSource = dtThanhVien;
                    col.DisplayMember = "HoTen";
                    col.ValueMember = "MaThanhVien";
                }
            }

            DataTable dtSach = dBBooks.LaySach().Tables[0];

            if (dtSach != null)
            {
                var col = larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn;
                if (col != null)
                {
                    col.DataSource = dtSach;
                    col.DisplayMember = "TenSach";
                    col.ValueMember = "MaSach";
                }
            }

            DataTable dtPhieuMuonQuaHan = dBLAR.LayPhieuMuonQuaHan();

            if (dtPhieuMuonQuaHan != null)
            {
                larGridView.DataSource = dtPhieuMuonQuaHan;
            }
            else
            {
                larGridView.DataSource = new DataTable(); // Nếu không có dữ liệu, gán bảng rỗng
            }
        }

        private void larGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (larGridView.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value is string trangThai)
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void larGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
