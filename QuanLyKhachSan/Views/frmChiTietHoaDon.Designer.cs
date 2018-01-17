namespace QuanLyKhachSan.Views
{
    partial class frmChiTietHoaDon
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhuThu = new DevExpress.XtraEditors.TextEdit();
            this.txtTienLoaiPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtTienDichVu = new DevExpress.XtraEditors.TextEdit();
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.cmbMaSDDV = new System.Windows.Forms.ComboBox();
            this.txtMaChiTietHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhuThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienLoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienDichVu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaChiTietHD);
            this.groupControl1.Controls.Add(this.btnXacNhan);
            this.groupControl1.Controls.Add(this.cmbMaSDDV);
            this.groupControl1.Controls.Add(this.cmbMaPhong);
            this.groupControl1.Controls.Add(this.txtTienDichVu);
            this.groupControl1.Controls.Add(this.txtTienLoaiPhong);
            this.groupControl1.Controls.Add(this.txtPhuThu);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(910, 290);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin hóa đơn";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Appearance.Options.UseFont = true;
            this.btnXacNhan.Location = new System.Drawing.Point(379, 183);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(138, 40);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(35, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(125, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã chi tiết hóa đơn : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(35, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã sử dụng dịch vụ : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(35, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mã phòng : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(474, 48);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Phụ thu : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(471, 90);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 17);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tiền loại phòng : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(471, 130);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 17);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Tiền dịch vụ : ";
            // 
            // txtPhuThu
            // 
            this.txtPhuThu.Location = new System.Drawing.Point(579, 48);
            this.txtPhuThu.Name = "txtPhuThu";
            this.txtPhuThu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuThu.Properties.Appearance.Options.UseFont = true;
            this.txtPhuThu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPhuThu.Size = new System.Drawing.Size(273, 24);
            this.txtPhuThu.TabIndex = 1;
            // 
            // txtTienLoaiPhong
            // 
            this.txtTienLoaiPhong.Location = new System.Drawing.Point(579, 87);
            this.txtTienLoaiPhong.Name = "txtTienLoaiPhong";
            this.txtTienLoaiPhong.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienLoaiPhong.Properties.Appearance.Options.UseFont = true;
            this.txtTienLoaiPhong.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTienLoaiPhong.Size = new System.Drawing.Size(273, 24);
            this.txtTienLoaiPhong.TabIndex = 1;
            // 
            // txtTienDichVu
            // 
            this.txtTienDichVu.Location = new System.Drawing.Point(579, 127);
            this.txtTienDichVu.Name = "txtTienDichVu";
            this.txtTienDichVu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDichVu.Properties.Appearance.Options.UseFont = true;
            this.txtTienDichVu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTienDichVu.Size = new System.Drawing.Size(273, 24);
            this.txtTienDichVu.TabIndex = 1;
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(168, 130);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(252, 25);
            this.cmbMaPhong.TabIndex = 2;
            // 
            // cmbMaSDDV
            // 
            this.cmbMaSDDV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSDDV.FormattingEnabled = true;
            this.cmbMaSDDV.Location = new System.Drawing.Point(168, 86);
            this.cmbMaSDDV.Name = "cmbMaSDDV";
            this.cmbMaSDDV.Size = new System.Drawing.Size(252, 25);
            this.cmbMaSDDV.TabIndex = 2;
            // 
            // txtMaChiTietHD
            // 
            this.txtMaChiTietHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChiTietHD.Location = new System.Drawing.Point(168, 48);
            this.txtMaChiTietHD.Name = "txtMaChiTietHD";
            this.txtMaChiTietHD.Size = new System.Drawing.Size(252, 25);
            this.txtMaChiTietHD.TabIndex = 5;
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 290);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhuThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienLoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienDichVu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private System.Windows.Forms.TextBox txtMaChiTietHD;
        private System.Windows.Forms.ComboBox cmbMaSDDV;
        private System.Windows.Forms.ComboBox cmbMaPhong;
        private DevExpress.XtraEditors.TextEdit txtTienDichVu;
        private DevExpress.XtraEditors.TextEdit txtTienLoaiPhong;
        private DevExpress.XtraEditors.TextEdit txtPhuThu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}