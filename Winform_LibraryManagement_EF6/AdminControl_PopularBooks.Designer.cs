//using System.Windows.Forms;

//namespace Winform_LibraryManagement_EF6
//{
//    partial class AdminControl_PopularBooks
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.dgvPopularBooks = new System.Windows.Forms.DataGridView();
//            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.SoLanMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvPopularBooks)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // dgvPopularBooks
//            // 
//            this.dgvPopularBooks.AllowUserToAddRows = false;
//            this.dgvPopularBooks.AllowUserToDeleteRows = false;
//            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
//            this.dgvPopularBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
//            this.dgvPopularBooks.BackgroundColor = System.Drawing.Color.White;
//            this.dgvPopularBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.dgvPopularBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
//            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
//            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.dgvPopularBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
//            this.dgvPopularBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvPopularBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.STT,
//            this.MaSach,
//            this.TenSach,
//            this.SoLanMuon});
//            this.dgvPopularBooks.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.dgvPopularBooks.EnableHeadersVisualStyles = false;
//            this.dgvPopularBooks.Font = new System.Drawing.Font("Segoe UI", 10F);
//            this.dgvPopularBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
//            this.dgvPopularBooks.Location = new System.Drawing.Point(0, 0);
//            this.dgvPopularBooks.MultiSelect = false;
//            this.dgvPopularBooks.Name = "dgvPopularBooks";
//            this.dgvPopularBooks.ReadOnly = true;
//            this.dgvPopularBooks.RowHeadersVisible = false;
//            this.dgvPopularBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.dgvPopularBooks.Size = new System.Drawing.Size(514, 570);
//            this.dgvPopularBooks.TabIndex = 5;
//            this.dgvPopularBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopularBooks_CellContentClick);
//            // 
//            // STT
//            // 
//            this.STT.DataPropertyName = "STT";
//            this.STT.FillWeight = 101.5228F;
//            this.STT.HeaderText = "Số thứ tự";
//            this.STT.Name = "STT";
//            this.STT.ReadOnly = true;
//            this.STT.Width = 50;
//            // 
//            // MaSach
//            // 
//            this.MaSach.DataPropertyName = "MaSach";
//            this.MaSach.FillWeight = 99.49239F;
//            this.MaSach.HeaderText = "Mã sách";
//            this.MaSach.Name = "MaSach";
//            this.MaSach.ReadOnly = true;
//            this.MaSach.Width = 128;
//            // 
//            // TenSach
//            // 
//            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
//            this.TenSach.DataPropertyName = "TenSach";
//            this.TenSach.FillWeight = 99.49239F;
//            this.TenSach.HeaderText = "Tên sách";
//            this.TenSach.Name = "TenSach";
//            this.TenSach.ReadOnly = true;
//            // 
//            // SoLanMuon
//            // 
//            this.SoLanMuon.DataPropertyName = "SoLanMuon";
//            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
//            this.SoLanMuon.DefaultCellStyle = dataGridViewCellStyle3;
//            this.SoLanMuon.FillWeight = 99.49239F;
//            this.SoLanMuon.HeaderText = "Số lần mượn";
//            this.SoLanMuon.Name = "SoLanMuon";
//            this.SoLanMuon.ReadOnly = true;
//            this.SoLanMuon.Width = 128;
//            // 
//            // AdminControl_PopularBooks
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.dgvPopularBooks);
//            this.Name = "AdminControl_PopularBooks";
//            this.Size = new System.Drawing.Size(514, 570);
//            ((System.ComponentModel.ISupportInitialize)(this.dgvPopularBooks)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.DataGridView dgvPopularBooks;
//        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
//        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
//        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
//        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanMuon;
//    }
//}
