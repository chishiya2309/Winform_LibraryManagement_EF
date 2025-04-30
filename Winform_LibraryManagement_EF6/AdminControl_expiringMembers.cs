using BusinessAccessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_expiringMembers : UserControl
    {
        private DBMembers dbtv;

        public AdminControl_expiringMembers()
        {
            InitializeComponent();
            dbtv = new DBMembers();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dtThanhVien = dbtv.LayThanhVienSapHetHan(30);

            if (dtThanhVien != null)
            {
                membersGridView.DataSource = dtThanhVien;
            }
            else
            {
                membersGridView.DataSource = new DataTable(); // Nếu không có dữ liệu, gán bảng rỗng
            }
        }

        private void membersGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (membersGridView.Columns[e.ColumnIndex].Name == "NgayHetHan")
            {
                e.CellStyle.ForeColor = Color.Orange;
            }
        }

        private void membersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
