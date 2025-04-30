using BusinessAccessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class AdminControl_MemberLoanHistory : UserControl
    {
        private string memberId;
        private DBMembers dBMembers;
        private DBBooks dBBooks;
        private DBLoanAndReturn dBLAR;

        public AdminControl_MemberLoanHistory()
        {
            InitializeComponent();
            dBMembers = new DBMembers();
            dBBooks = new DBBooks();
            dBLAR = new DBLoanAndReturn();
            LoadMembers(); // Chỉ load thành viên trước
        }

        private void LoadMembers()
        {
            DataSet dsThanhVien = dBMembers.LayThanhVien();
            if (dsThanhVien == null || dsThanhVien.Tables.Count == 0 || dsThanhVien.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtThanhVien = dsThanhVien.Tables[0];
            cmbThanhVien.DataSource = dtThanhVien;
            cmbThanhVien.DisplayMember = "HoTen";
            cmbThanhVien.ValueMember = "MaThanhVien";

            if (cmbThanhVien.Items.Count > 0)
            {
                cmbThanhVien.SelectedIndex = 0;
                memberId = cmbThanhVien.SelectedValue.ToString();
                LoadData(memberId);
            }
        }

        private void LoadData(string memberId)
        {
            if (string.IsNullOrEmpty(memberId)) return;

            try
            {
                // Lấy danh sách phiếu mượn theo thành viên
                DataTable dtLichSuMuon = dBLAR.LayLichSuMuonTheoThanhVien(memberId);

                // Gán dữ liệu vào DataGridView
                larGridView.DataSource = dtLichSuMuon;

                // Đảm bảo DataGridView có cột "MaSach" và "MaThanhVien" trước khi gán dữ liệu
                if (larGridView.Columns.Contains("MaSach") && larGridView.Columns["MaSach"] is DataGridViewComboBoxColumn)
                {
                    DataSet dsSach = dBBooks.LaySach();
                    if (dsSach != null && dsSach.Tables.Count > 0)
                    {
                        DataTable dtSach = dsSach.Tables[0];

                        var comboBoxColumn = larGridView.Columns["MaSach"] as DataGridViewComboBoxColumn;
                        comboBoxColumn.DataSource = dtSach;
                        comboBoxColumn.DisplayMember = "TenSach";
                        comboBoxColumn.ValueMember = "MaSach";
                    }
                }

                if (larGridView.Columns.Contains("MaThanhVien") && larGridView.Columns["MaThanhVien"] is DataGridViewComboBoxColumn)
                {
                    DataSet dsThanhVien = dBMembers.LayThanhVien();
                    if (dsThanhVien != null && dsThanhVien.Tables.Count > 0)
                    {
                        DataTable dtThanhVien = dsThanhVien.Tables[0];

                        var comboBoxColumn = larGridView.Columns["MaThanhVien"] as DataGridViewComboBoxColumn;
                        comboBoxColumn.DataSource = dtThanhVien;
                        comboBoxColumn.DisplayMember = "HoTen";
                        comboBoxColumn.ValueMember = "MaThanhVien";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbThanhVien_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbThanhVien.SelectedValue != null)
            {
                memberId = cmbThanhVien.SelectedValue.ToString();
                LoadData(memberId);
            }
        }

        private void larGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
