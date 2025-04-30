namespace Winform_LibraryManagement_EF6
{
    partial class AdminControl_expiringMembers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.membersGridView = new System.Windows.Forms.DataGridView();
            this.MaThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.membersGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 425);
            this.panel1.TabIndex = 0;
            // 
            // membersGridView
            // 
            this.membersGridView.AllowUserToAddRows = false;
            this.membersGridView.AllowUserToDeleteRows = false;
            this.membersGridView.AllowUserToResizeColumns = false;
            this.membersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.membersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.membersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.membersGridView.BackgroundColor = System.Drawing.Color.White;
            this.membersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.membersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.membersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThanhVien,
            this.HoTen,
            this.GioiTinh,
            this.SoDienThoai,
            this.Email,
            this.LoaiThanhVien,
            this.NgayDangKy,
            this.NgayHetHan,
            this.TrangThai});
            this.membersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.membersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.membersGridView.Location = new System.Drawing.Point(0, 0);
            this.membersGridView.MultiSelect = false;
            this.membersGridView.Name = "membersGridView";
            this.membersGridView.ReadOnly = true;
            this.membersGridView.RowHeadersVisible = false;
            this.membersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.membersGridView.Size = new System.Drawing.Size(545, 425);
            this.membersGridView.TabIndex = 5;
            this.membersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membersGridView_CellContentClick);
            this.membersGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.membersGridView_CellFormatting);
            // 
            // MaThanhVien
            // 
            this.MaThanhVien.DataPropertyName = "MaThanhVien";
            this.MaThanhVien.HeaderText = "Mã thành viên";
            this.MaThanhVien.Name = "MaThanhVien";
            this.MaThanhVien.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // LoaiThanhVien
            // 
            this.LoaiThanhVien.DataPropertyName = "LoaiThanhVien";
            this.LoaiThanhVien.HeaderText = "Loại thành viên";
            this.LoaiThanhVien.Name = "LoaiThanhVien";
            this.LoaiThanhVien.ReadOnly = true;
            // 
            // NgayDangKy
            // 
            this.NgayDangKy.DataPropertyName = "NgayDangKy";
            this.NgayDangKy.HeaderText = "Ngày đăng ký";
            this.NgayDangKy.Name = "NgayDangKy";
            this.NgayDangKy.ReadOnly = true;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // AdminControl_expiringMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdminControl_expiringMembers";
            this.Size = new System.Drawing.Size(545, 425);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView membersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}
