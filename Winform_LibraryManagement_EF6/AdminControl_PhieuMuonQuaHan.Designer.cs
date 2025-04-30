namespace Winform_LibraryManagement_EF6
{
    partial class AdminControl_PhieuMuonQuaHan
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
            this.lblNoData = new System.Windows.Forms.Label();
            this.larGridView = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThanhVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.larGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.ForeColor = System.Drawing.Color.Green;
            this.lblNoData.Location = new System.Drawing.Point(41, 292);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(254, 21);
            this.lblNoData.TabIndex = 8;
            this.lblNoData.Text = "Không có phiếu mượn nào quá hạn";
            // 
            // larGridView
            // 
            this.larGridView.AllowUserToAddRows = false;
            this.larGridView.AllowUserToDeleteRows = false;
            this.larGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.larGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.larGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.larGridView.BackgroundColor = System.Drawing.Color.White;
            this.larGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.larGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.larGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaThanhVien,
            this.NgayMuon,
            this.HanTra,
            this.TrangThai,
            this.MaSach,
            this.SoLuong,
            this.NgayTraThucTe});
            this.larGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.larGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.larGridView.Location = new System.Drawing.Point(0, 0);
            this.larGridView.MultiSelect = false;
            this.larGridView.Name = "larGridView";
            this.larGridView.ReadOnly = true;
            this.larGridView.RowHeadersVisible = false;
            this.larGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.larGridView.Size = new System.Drawing.Size(523, 604);
            this.larGridView.TabIndex = 3;
            this.larGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.larGridView_CellContentClick);
            this.larGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.larGridView_CellFormatting);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            // 
            // MaThanhVien
            // 
            this.MaThanhVien.DataPropertyName = "MaThanhVien";
            this.MaThanhVien.FillWeight = 81.21828F;
            this.MaThanhVien.HeaderText = "Thành viên";
            this.MaThanhVien.Name = "MaThanhVien";
            this.MaThanhVien.ReadOnly = true;
            this.MaThanhVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaThanhVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.FillWeight = 118.7817F;
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // HanTra
            // 
            this.HanTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HanTra.DataPropertyName = "HanTra";
            this.HanTra.HeaderText = "Hạn trả";
            this.HanTra.Name = "HanTra";
            this.HanTra.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // NgayTraThucTe
            // 
            this.NgayTraThucTe.DataPropertyName = "NgayTraThucTe";
            this.NgayTraThucTe.HeaderText = "Ngày trả thực tế";
            this.NgayTraThucTe.Name = "NgayTraThucTe";
            this.NgayTraThucTe.ReadOnly = true;
            this.NgayTraThucTe.Visible = false;
            // 
            // AdminControl_PhieuMuonQuaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.larGridView);
            this.Name = "AdminControl_PhieuMuonQuaHan";
            this.Size = new System.Drawing.Size(523, 604);
            ((System.ComponentModel.ISupportInitialize)(this.larGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.DataGridView larGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraThucTe;
    }
}
