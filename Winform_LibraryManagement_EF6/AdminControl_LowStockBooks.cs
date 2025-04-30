using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessAccessLayer;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_LowStockBooks : UserControl
    {
        DBCategory dbdm;
        DataTable dtDanhMuc;

        DBBooks dbs;
        DataTable dtSach;
        public AdminControl_LowStockBooks()
        {
            InitializeComponent();
            dbdm = new DBCategory();
            dbs = new DBBooks();
            LoadData();
            lblNoData.Location = new Point(
       booksGridView.Location.X + (booksGridView.Width - lblNoData.Width) / 2,
       booksGridView.Location.Y + (booksGridView.Height - lblNoData.Height) / 2
   );
        }

        private void LoadData()
        {
            dtDanhMuc = new DataTable();
            dtDanhMuc.Clear();
            dtDanhMuc = dbdm.LayDanhMuc().Tables[0];

            (booksGridView.Columns["MaDanhMuc"] as DataGridViewComboBoxColumn).DataSource = dtDanhMuc;
            (booksGridView.Columns["MaDanhMuc"] as DataGridViewComboBoxColumn).DisplayMember = "TenDanhMuc";
            (booksGridView.Columns["MaDanhMuc"] as DataGridViewComboBoxColumn).ValueMember = "MaDanhMuc";

            dtSach = new DataTable();
            dtSach.Clear();
            dtSach = dbs.LaySach().Tables[0];

            var lowStockBooks = dtSach.AsEnumerable()
            .Where(row => row.Field<int>("KhaDung") < 3); // Lọc sách có KhaDung < 3

            DataTable filteredTable = lowStockBooks.Any() ? lowStockBooks.CopyToDataTable() : dtSach.Clone();
            // Kiểm tra nếu không có dữ liệu thì ẩn DataGridView, hiển thị Label
            if (filteredTable.Rows.Count == 0)
            {
                lblNoData.Visible = true;
                booksGridView.Visible = false;
            }
            else
            {
                lblNoData.Visible = false;
                booksGridView.Visible = true;
            }

            booksGridView.DataSource = filteredTable;
        }

        private void AdminControl_LowStockBooks_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
