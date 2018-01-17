namespace QuanLyKhachSan.Views
{
    partial class frmCapNhatDichVu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaSDDichVu = new DevExpress.XtraEditors.TextEdit();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTenDichVu = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDonViTinh = new System.Windows.Forms.ComboBox();
            this.cmbLoaiDichVu = new System.Windows.Forms.ComboBox();
            this.cmbGiaDichVu = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvChiTietDichVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSDDichVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaSDDichVu);
            this.groupControl1.Controls.Add(this.btnCapNhat);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.cmbTenDichVu);
            this.groupControl1.Controls.Add(this.txtSoLuong);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.cmbDonViTinh);
            this.groupControl1.Controls.Add(this.cmbLoaiDichVu);
            this.groupControl1.Controls.Add(this.cmbGiaDichVu);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(359, 505);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin dịch vụ";
            // 
            // txtMaSDDichVu
            // 
            this.txtMaSDDichVu.Location = new System.Drawing.Point(121, 58);
            this.txtMaSDDichVu.Name = "txtMaSDDichVu";
            this.txtMaSDDichVu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSDDichVu.Properties.Appearance.Options.UseFont = true;
            this.txtMaSDDichVu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtMaSDDichVu.Size = new System.Drawing.Size(217, 24);
            this.txtMaSDDichVu.TabIndex = 38;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(18, 341);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(320, 64);
            this.btnCapNhat.TabIndex = 37;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(20, 427);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(320, 64);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cmbTenDichVu
            // 
            this.cmbTenDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenDichVu.FormattingEnabled = true;
            this.cmbTenDichVu.Location = new System.Drawing.Point(122, 150);
            this.cmbTenDichVu.Name = "cmbTenDichVu";
            this.cmbTenDichVu.Size = new System.Drawing.Size(218, 25);
            this.cmbTenDichVu.TabIndex = 34;
            this.cmbTenDichVu.SelectedIndexChanged += new System.EventHandler(this.cmbTenDichVu_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(121, 287);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSoLuong.Size = new System.Drawing.Size(219, 24);
            this.txtSoLuong.TabIndex = 29;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(20, 294);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(89, 17);
            this.labelControl10.TabIndex = 28;
            this.labelControl10.Text = "Số lượng tính : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(18, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 17);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Mã sd dịch vụ : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(18, 102);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 17);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Loại dịch vụ : ";
            // 
            // cmbDonViTinh
            // 
            this.cmbDonViTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDonViTinh.FormattingEnabled = true;
            this.cmbDonViTinh.Location = new System.Drawing.Point(121, 238);
            this.cmbDonViTinh.Name = "cmbDonViTinh";
            this.cmbDonViTinh.Size = new System.Drawing.Size(219, 25);
            this.cmbDonViTinh.TabIndex = 24;
            // 
            // cmbLoaiDichVu
            // 
            this.cmbLoaiDichVu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLoaiDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiDichVu.FormattingEnabled = true;
            this.cmbLoaiDichVu.Location = new System.Drawing.Point(121, 102);
            this.cmbLoaiDichVu.Name = "cmbLoaiDichVu";
            this.cmbLoaiDichVu.Size = new System.Drawing.Size(219, 25);
            this.cmbLoaiDichVu.TabIndex = 25;
            this.cmbLoaiDichVu.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiDichVu_SelectedIndexChanged);
            // 
            // cmbGiaDichVu
            // 
            this.cmbGiaDichVu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbGiaDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGiaDichVu.FormattingEnabled = true;
            this.cmbGiaDichVu.Location = new System.Drawing.Point(121, 192);
            this.cmbGiaDichVu.Name = "cmbGiaDichVu";
            this.cmbGiaDichVu.Size = new System.Drawing.Size(219, 25);
            this.cmbGiaDichVu.TabIndex = 26;
            this.cmbGiaDichVu.SelectedIndexChanged += new System.EventHandler(this.cmbGiaDichVu_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(20, 246);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 17);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Đơn vị tính : ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(18, 200);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(75, 17);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "Giá dịch vụ : ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(18, 150);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(72, 17);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Tên dịch vụ :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvChiTietDichVu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(359, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(848, 505);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chi tiết dịch vụ";
            // 
            // dgvChiTietDichVu
            // 
            this.dgvChiTietDichVu.AllowUserToAddRows = false;
            this.dgvChiTietDichVu.AllowUserToDeleteRows = false;
            this.dgvChiTietDichVu.AllowUserToResizeColumns = false;
            this.dgvChiTietDichVu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvChiTietDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChiTietDichVu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChiTietDichVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChiTietDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTietDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietDichVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietDichVu.EnableHeadersVisualStyles = false;
            this.dgvChiTietDichVu.Location = new System.Drawing.Point(2, 20);
            this.dgvChiTietDichVu.MultiSelect = false;
            this.dgvChiTietDichVu.Name = "dgvChiTietDichVu";
            this.dgvChiTietDichVu.ReadOnly = true;
            this.dgvChiTietDichVu.RowHeadersVisible = false;
            this.dgvChiTietDichVu.RowTemplate.Height = 25;
            this.dgvChiTietDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDichVu.Size = new System.Drawing.Size(844, 483);
            this.dgvChiTietDichVu.TabIndex = 3;
            this.dgvChiTietDichVu.Click += new System.EventHandler(this.dgvChiTietDichVu_Click);
            // 
            // frmCapNhatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 505);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmCapNhatDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT DỊCH VỤ";
            this.Load += new System.EventHandler(this.frmCapNhatDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSDDichVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbTenDichVu;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cmbDonViTinh;
        private System.Windows.Forms.ComboBox cmbLoaiDichVu;
        private System.Windows.Forms.ComboBox cmbGiaDichVu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvChiTietDichVu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.TextEdit txtMaSDDichVu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}