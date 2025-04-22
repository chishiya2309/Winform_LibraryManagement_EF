using System.Drawing;

namespace Winform_LibraryManagement_EF6
{
    partial class AdminControl_Staff
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
            this.staffPanel = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.staffGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.lblNoData = new System.Windows.Forms.Label();
            this.staffPanel.SuspendLayout();
            this.MenuButton.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffPanel
            // 
            this.staffPanel.BackColor = System.Drawing.Color.White;
            this.staffPanel.Controls.Add(this.lblNoData);
            this.staffPanel.Controls.Add(this.MenuButton);
            this.staffPanel.Controls.Add(this.searchPanel);
            this.staffPanel.Controls.Add(this.actionPanel);
            this.staffPanel.Controls.Add(this.staffGridView);
            this.staffPanel.Controls.Add(this.titleLabel);
            this.staffPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffPanel.Location = new System.Drawing.Point(0, 0);
            this.staffPanel.Name = "staffPanel";
            this.staffPanel.Size = new System.Drawing.Size(819, 602);
            this.staffPanel.TabIndex = 0;
         //   this.staffPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.staffPanel_Paint);
            this.staffPanel.Resize += new System.EventHandler(this.staffPanel_Resize);
            // 
            // MenuButton
            // 
            this.MenuButton.ColumnCount = 4;
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuButton.Controls.Add(this.btnAddStaff, 0, 0);
            this.MenuButton.Controls.Add(this.btnReload, 3, 0);
            this.MenuButton.Controls.Add(this.btnDeleteStaff, 2, 0);
            this.MenuButton.Controls.Add(this.btnEditStaff, 1, 0);
            this.MenuButton.Location = new System.Drawing.Point(20, 64);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.RowCount = 1;
            this.MenuButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuButton.Size = new System.Drawing.Size(594, 60);
            this.MenuButton.TabIndex = 18;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(3, 10);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(142, 40);
            this.btnAddStaff.TabIndex = 8;
            this.btnAddStaff.Text = "Thêm nhân viên mới";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
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
            this.btnReload.Location = new System.Drawing.Point(447, 10);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(144, 40);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStaff.FlatAppearance.BorderSize = 0;
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Location = new System.Drawing.Point(299, 10);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(142, 40);
            this.btnDeleteStaff.TabIndex = 11;
            this.btnDeleteStaff.Text = "Xóa nhân viên";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditStaff.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStaff.FlatAppearance.BorderSize = 0;
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.ForeColor = System.Drawing.Color.White;
            this.btnEditStaff.Location = new System.Drawing.Point(151, 10);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(142, 40);
            this.btnEditStaff.TabIndex = 10;
            this.btnEditStaff.Text = "Sửa nhân viên";
            this.btnEditStaff.UseVisualStyleBackColor = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // searchPanel
            // 
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
            // staffGridView
            // 
            this.staffGridView.AllowUserToAddRows = false;
            this.staffGridView.AllowUserToDeleteRows = false;
            this.staffGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.staffGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffGridView.BackgroundColor = System.Drawing.Color.White;
            this.staffGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HoTen,
            this.GioiTinh,
            this.ChucVu,
            this.Email,
            this.SoDienThoai,
            this.NgayVaoLam,
            this.TrangThai});
            this.staffGridView.ContextMenuStrip = this.contextMenu;
            this.staffGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.staffGridView.Location = new System.Drawing.Point(20, 210);
            this.staffGridView.MultiSelect = false;
            this.staffGridView.Name = "staffGridView";
            this.staffGridView.ReadOnly = true;
            this.staffGridView.RowHeadersVisible = false;
            this.staffGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffGridView.Size = new System.Drawing.Size(820, 265);
            this.staffGridView.TabIndex = 2;
            this.staffGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.staffGridView_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 81.21828F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 118.7817F;
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
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.DataPropertyName = "NgayVaoLam";
            this.NgayVaoLam.HeaderText = "Ngày vào làm";
            this.NgayVaoLam.Name = "NgayVaoLam";
            this.NgayVaoLam.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
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
            this.titleLabel.Size = new System.Drawing.Size(221, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Quản lý nhân viên";
            // 
            // lblNoData
            // 
            this.lblNoData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.ForeColor = System.Drawing.Color.Red;
            this.lblNoData.Location = new System.Drawing.Point(176, 294);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(268, 31);
            this.lblNoData.TabIndex = 22;
            this.lblNoData.Text = "Không tìm thấy kết quả";
            this.lblNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoData.Visible = false;
            // 
            // AdminControl_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.staffPanel);
            this.Name = "AdminControl_Staff";
            this.Size = new System.Drawing.Size(819, 602);
            this.staffPanel.ResumeLayout(false);
            this.staffPanel.PerformLayout();
            this.MenuButton.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel staffPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView staffGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addItem;
        private System.Windows.Forms.ToolStripMenuItem editItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItem;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.TableLayoutPanel MenuButton;
        private System.Windows.Forms.Label lblNoData;
    }
}
