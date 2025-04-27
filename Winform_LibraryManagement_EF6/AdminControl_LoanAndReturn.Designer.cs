namespace Winform_LibraryManagement_EF6
{
    partial class AdminControl_LoanAndReturn
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
            this.MenuButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnDeleteLAR = new System.Windows.Forms.Button();
            this.btnEditLAR = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.larGridView = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThanhVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.lblNoData = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.MenuButton.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.larGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.lblNoData);
            this.panel.Controls.Add(this.MenuButton);
            this.panel.Controls.Add(this.searchPanel);
            this.panel.Controls.Add(this.actionPanel);
            this.panel.Controls.Add(this.larGridView);
            this.panel.Controls.Add(this.titleLabel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(819, 602);
            this.panel.TabIndex = 1;
           // this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.staffPanel_Paint);
            // 
            // MenuButton
            // 
            this.MenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuButton.ColumnCount = 5;
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MenuButton.Controls.Add(this.btnLoan, 0, 0);
            this.MenuButton.Controls.Add(this.btnDeleteLAR, 3, 0);
            this.MenuButton.Controls.Add(this.btnEditLAR, 2, 0);
            this.MenuButton.Controls.Add(this.btnReload, 4, 0);
            this.MenuButton.Controls.Add(this.btnReturn, 1, 0);
            this.MenuButton.Location = new System.Drawing.Point(20, 64);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.RowCount = 1;
            this.MenuButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuButton.Size = new System.Drawing.Size(594, 60);
            this.MenuButton.TabIndex = 19;
            // 
            // btnLoan
            // 
            this.btnLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoan.FlatAppearance.BorderSize = 0;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.Color.White;
            this.btnLoan.Location = new System.Drawing.Point(3, 10);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(112, 40);
            this.btnLoan.TabIndex = 8;
            this.btnLoan.Text = "Mượn sách";
            this.btnLoan.UseVisualStyleBackColor = false;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnDeleteLAR
            // 
            this.btnDeleteLAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteLAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteLAR.FlatAppearance.BorderSize = 0;
            this.btnDeleteLAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLAR.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLAR.Location = new System.Drawing.Point(357, 10);
            this.btnDeleteLAR.Name = "btnDeleteLAR";
            this.btnDeleteLAR.Size = new System.Drawing.Size(112, 40);
            this.btnDeleteLAR.TabIndex = 12;
            this.btnDeleteLAR.Text = "Xóa phiếu mượn";
            this.btnDeleteLAR.UseVisualStyleBackColor = false;
            this.btnDeleteLAR.Click += new System.EventHandler(this.btnDeleteLAR_Click);
            // 
            // btnEditLAR
            // 
            this.btnEditLAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditLAR.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditLAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditLAR.FlatAppearance.BorderSize = 0;
            this.btnEditLAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLAR.ForeColor = System.Drawing.Color.White;
            this.btnEditLAR.Location = new System.Drawing.Point(239, 10);
            this.btnEditLAR.Name = "btnEditLAR";
            this.btnEditLAR.Size = new System.Drawing.Size(112, 40);
            this.btnEditLAR.TabIndex = 11;
            this.btnEditLAR.Text = "Sửa phiếu mượn";
            this.btnEditLAR.UseVisualStyleBackColor = false;
            this.btnEditLAR.Click += new System.EventHandler(this.btnEditLAR_Click);
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
            this.btnReload.Location = new System.Drawing.Point(475, 10);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(116, 40);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.Green;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(121, 10);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 40);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Trả sách";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.btnSearch);
            this.searchPanel.Controls.Add(this.txtSearch);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPanel.Location = new System.Drawing.Point(20, 130);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(594, 60);
            this.searchPanel.TabIndex = 9;
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
            this.btnSearch.Location = new System.Drawing.Point(430, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // actionPanel
            // 
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 542);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(819, 60);
            this.actionPanel.TabIndex = 3;
            // 
            // larGridView
            // 
            this.larGridView.AllowUserToAddRows = false;
            this.larGridView.AllowUserToDeleteRows = false;
            this.larGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.larGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.larGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.larGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.larGridView.BackgroundColor = System.Drawing.Color.White;
            this.larGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.larGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.larGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaThanhVien,
            this.NgayMuon,
            this.HanTra,
            this.NgayTraThucTe,
            this.TrangThai,
            this.MaSach,
            this.SoLuong});
            this.larGridView.ContextMenuStrip = this.contextMenu;
            this.larGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.larGridView.Location = new System.Drawing.Point(20, 210);
            this.larGridView.MultiSelect = false;
            this.larGridView.Name = "larGridView";
            this.larGridView.ReadOnly = true;
            this.larGridView.RowHeadersVisible = false;
            this.larGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.larGridView.Size = new System.Drawing.Size(820, 265);
            this.larGridView.TabIndex = 2;
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
            // NgayTraThucTe
            // 
            this.NgayTraThucTe.DataPropertyName = "NgayTraThucTe";
            this.NgayTraThucTe.HeaderText = "Ngày trả thực tế";
            this.NgayTraThucTe.Name = "NgayTraThucTe";
            this.NgayTraThucTe.ReadOnly = true;
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
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItem,
            this.editItem,
            this.deleteItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(128, 70);
            // 
            // addItem
            // 
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(127, 22);
            this.addItem.Text = "Thêm";
            // 
            // editItem
            // 
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(127, 22);
            this.editItem.Text = "Chỉnh sửa";
            // 
            // deleteItem
            // 
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(127, 22);
            this.deleteItem.Text = "Xóa";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(291, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Quản lý mượn / trả sách";
            // 
            // lblNoData
            // 
            this.lblNoData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.ForeColor = System.Drawing.Color.Red;
            this.lblNoData.Location = new System.Drawing.Point(178, 321);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(268, 31);
            this.lblNoData.TabIndex = 20;
            this.lblNoData.Text = "Không tìm thấy kết quả";
            this.lblNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoData.Visible = false;
            // 
            // AdminControl_LoanAndReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "AdminControl_LoanAndReturn";
            this.Size = new System.Drawing.Size(819, 602);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.MenuButton.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.larGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnDeleteLAR;
        private System.Windows.Forms.Button btnEditLAR;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.DataGridView larGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addItem;
        private System.Windows.Forms.ToolStripMenuItem editItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItem;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraThucTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.TableLayoutPanel MenuButton;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblNoData;
    }
}
