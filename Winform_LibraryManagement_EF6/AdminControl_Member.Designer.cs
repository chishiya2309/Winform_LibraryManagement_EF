using System.Drawing;

namespace Winform_LibraryManagement_EF6
{
    partial class AdminControl_Member
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.lblNoData = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
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
            this.gridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaHạnThẻToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchĐangMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inThẻThànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.MenuButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersGridView)).BeginInit();
            this.gridContextMenu.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.lblNoData);
            this.panel.Controls.Add(this.MenuButton);
            this.panel.Controls.Add(this.membersGridView);
            this.panel.Controls.Add(this.searchPanel);
            this.panel.Controls.Add(this.titleLabel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(854, 589);
            this.panel.TabIndex = 0;
            this.panel.Resize += new System.EventHandler(this.panel_Resize);
            // 
            // lblNoData
            // 
            this.lblNoData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.ForeColor = System.Drawing.Color.Red;
            this.lblNoData.Location = new System.Drawing.Point(170, 291);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(268, 31);
            this.lblNoData.TabIndex = 21;
            this.lblNoData.Text = "Không tìm thấy kết quả";
            this.lblNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoData.Visible = false;
            // 
            // MenuButton
            // 
            this.MenuButton.ColumnCount = 4;
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuButton.Controls.Add(this.btnAddMember, 0, 0);
            this.MenuButton.Controls.Add(this.btnReload, 3, 0);
            this.MenuButton.Controls.Add(this.btnDeleteMember, 2, 0);
            this.MenuButton.Controls.Add(this.btnEditMember, 1, 0);
            this.MenuButton.Location = new System.Drawing.Point(20, 64);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.RowCount = 1;
            this.MenuButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuButton.Size = new System.Drawing.Size(608, 60);
            this.MenuButton.TabIndex = 17;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Location = new System.Drawing.Point(3, 10);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(146, 40);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Thêm thành viên mới";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(459, 10);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(146, 40);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMember.FlatAppearance.BorderSize = 0;
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMember.Location = new System.Drawing.Point(307, 10);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(146, 40);
            this.btnDeleteMember.TabIndex = 7;
            this.btnDeleteMember.Text = "Xóa thành viên";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            // 
            // btnEditMember
            // 
            this.btnEditMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMember.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMember.FlatAppearance.BorderSize = 0;
            this.btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMember.ForeColor = System.Drawing.Color.White;
            this.btnEditMember.Location = new System.Drawing.Point(155, 10);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(146, 40);
            this.btnEditMember.TabIndex = 6;
            this.btnEditMember.Text = "Sửa thành viên";
            this.btnEditMember.UseVisualStyleBackColor = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
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
            this.membersGridView.ContextMenuStrip = this.gridContextMenu;
            this.membersGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.membersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.membersGridView.Location = new System.Drawing.Point(20, 210);
            this.membersGridView.MultiSelect = false;
            this.membersGridView.Name = "membersGridView";
            this.membersGridView.ReadOnly = true;
            this.membersGridView.RowHeadersVisible = false;
            this.membersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.membersGridView.Size = new System.Drawing.Size(608, 150);
            this.membersGridView.TabIndex = 4;
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
            // gridContextMenu
            // 
            this.gridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTiếtToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.giaHạnThẻToolStripMenuItem,
            this.sáchĐangMượnToolStripMenuItem,
            this.inThẻThànhViênToolStripMenuItem});
            this.gridContextMenu.Name = "contextMenuStrip1";
            this.gridContextMenu.Size = new System.Drawing.Size(165, 136);
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            this.xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            this.xemChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.xemChiTiếtToolStripMenuItem.Text = "Xem chi tiết";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // giaHạnThẻToolStripMenuItem
            // 
            this.giaHạnThẻToolStripMenuItem.Name = "giaHạnThẻToolStripMenuItem";
            this.giaHạnThẻToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.giaHạnThẻToolStripMenuItem.Text = "Gia hạn thẻ";
            // 
            // sáchĐangMượnToolStripMenuItem
            // 
            this.sáchĐangMượnToolStripMenuItem.Name = "sáchĐangMượnToolStripMenuItem";
            this.sáchĐangMượnToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sáchĐangMượnToolStripMenuItem.Text = "Sách đang mượn";
            // 
            // inThẻThànhViênToolStripMenuItem
            // 
            this.inThẻThànhViênToolStripMenuItem.Name = "inThẻThànhViênToolStripMenuItem";
            this.inThẻThànhViênToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.inThẻThànhViênToolStripMenuItem.Text = "In thẻ thành viên";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.btnSearch);
            this.searchPanel.Controls.Add(this.txtSearch);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPanel.Location = new System.Drawing.Point(20, 130);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(608, 60);
            this.searchPanel.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(438, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(100, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(15, 20);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(63, 17);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Tìm kiếm:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(229, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Quản lý thành viên";
            // 
            // AdminControl_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "AdminControl_Member";
            this.Size = new System.Drawing.Size(854, 589);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.MenuButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membersGridView)).EndInit();
            this.gridContextMenu.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView membersGridView;
        private System.Windows.Forms.ContextMenuStrip gridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaHạnThẻToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchĐangMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inThẻThànhViênToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel MenuButton;
        private System.Windows.Forms.Label lblNoData;
    }
}
