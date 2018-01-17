namespace QuanLyKhachSan.Views
{
    partial class frmTimKiem_PDK
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvPhieuDangKy = new System.Windows.Forms.DataGridView();
            this.MaPhieuDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNguoiLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTreEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTimTheo = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvPhieuDangKy);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 100);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1133, 193);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Danh sách khách hàng";
            // 
            // dgvPhieuDangKy
            // 
            this.dgvPhieuDangKy.AllowUserToAddRows = false;
            this.dgvPhieuDangKy.AllowUserToDeleteRows = false;
            this.dgvPhieuDangKy.AllowUserToResizeColumns = false;
            this.dgvPhieuDangKy.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvPhieuDangKy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDangKy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhieuDangKy.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPhieuDangKy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPhieuDangKy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhieuDangKy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuDangKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuDK,
            this.NgayDen,
            this.NgayDi,
            this.GioDen,
            this.GioDi,
            this.SoLuongNguoiLon,
            this.SoLuongTreEm,
            this.TienDatCoc,
            this.MaNV,
            this.MaKH});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuDangKy.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieuDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuDangKy.EnableHeadersVisualStyles = false;
            this.dgvPhieuDangKy.Location = new System.Drawing.Point(2, 20);
            this.dgvPhieuDangKy.MultiSelect = false;
            this.dgvPhieuDangKy.Name = "dgvPhieuDangKy";
            this.dgvPhieuDangKy.ReadOnly = true;
            this.dgvPhieuDangKy.RowHeadersVisible = false;
            this.dgvPhieuDangKy.RowTemplate.Height = 25;
            this.dgvPhieuDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDangKy.Size = new System.Drawing.Size(1129, 171);
            this.dgvPhieuDangKy.TabIndex = 4;
            // 
            // MaPhieuDK
            // 
            this.MaPhieuDK.DataPropertyName = "MaPhieuDK";
            this.MaPhieuDK.HeaderText = "Mã Phiếu ĐK";
            this.MaPhieuDK.Name = "MaPhieuDK";
            this.MaPhieuDK.ReadOnly = true;
            // 
            // NgayDen
            // 
            this.NgayDen.DataPropertyName = "NgayDen";
            this.NgayDen.HeaderText = "Ngày Đến";
            this.NgayDen.Name = "NgayDen";
            this.NgayDen.ReadOnly = true;
            // 
            // NgayDi
            // 
            this.NgayDi.DataPropertyName = "NgayDi";
            this.NgayDi.HeaderText = "NgayDi";
            this.NgayDi.Name = "NgayDi";
            this.NgayDi.ReadOnly = true;
            // 
            // GioDen
            // 
            this.GioDen.DataPropertyName = "GioDen";
            this.GioDen.HeaderText = "Giờ Đến";
            this.GioDen.Name = "GioDen";
            this.GioDen.ReadOnly = true;
            // 
            // GioDi
            // 
            this.GioDi.DataPropertyName = "GioDi";
            this.GioDi.HeaderText = "Giờ Đi";
            this.GioDi.Name = "GioDi";
            this.GioDi.ReadOnly = true;
            // 
            // SoLuongNguoiLon
            // 
            this.SoLuongNguoiLon.DataPropertyName = "SoLuongNguoiLon";
            this.SoLuongNguoiLon.HeaderText = "SL Người Lớn";
            this.SoLuongNguoiLon.Name = "SoLuongNguoiLon";
            this.SoLuongNguoiLon.ReadOnly = true;
            // 
            // SoLuongTreEm
            // 
            this.SoLuongTreEm.DataPropertyName = "SoLuongTreEm";
            this.SoLuongTreEm.HeaderText = "SL Trẻ Em";
            this.SoLuongTreEm.Name = "SoLuongTreEm";
            this.SoLuongTreEm.ReadOnly = true;
            // 
            // TienDatCoc
            // 
            this.TienDatCoc.DataPropertyName = "TienDatCoc";
            this.TienDatCoc.HeaderText = "Tiền Đặt Cọc";
            this.TienDatCoc.Name = "TienDatCoc";
            this.TienDatCoc.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnIn);
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.txtTuKhoa);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cmbTimTheo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1133, 100);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Location = new System.Drawing.Point(745, 45);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 25);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(401, 46);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(309, 25);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(32, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 17);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tìm theo : ";
            // 
            // cmbTimTheo
            // 
            this.cmbTimTheo.CausesValidation = false;
            this.cmbTimTheo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimTheo.FormattingEnabled = true;
            this.cmbTimTheo.Items.AddRange(new object[] {
            "Mã Phiếu Đăng Ký"});
            this.cmbTimTheo.Location = new System.Drawing.Point(109, 45);
            this.cmbTimTheo.Name = "cmbTimTheo";
            this.cmbTimTheo.Size = new System.Drawing.Size(173, 25);
            this.cmbTimTheo.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(326, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 17);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Từ khóa : ";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(868, 46);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(102, 25);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmTimKiem_PDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 293);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTimKiem_PDK";
            this.Text = "frmTimKiem_PDK";
            this.Load += new System.EventHandler(this.frmTimKiem_PDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbTimTheo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridView dgvPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNguoiLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTreEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDatCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private DevExpress.XtraEditors.SimpleButton btnIn;
    }
}