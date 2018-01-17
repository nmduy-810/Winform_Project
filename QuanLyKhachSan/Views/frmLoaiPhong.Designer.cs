namespace QuanLyKhachSan.Views
{
    partial class frmLoaiPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnPre = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTrangThietBi = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnXoaLoaiPhong = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatLoaiPhong = new DevExpress.XtraEditors.SimpleButton();
            this.cmbGiaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTenLoaiPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLoaiPhong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(1270, 476);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1270, 476);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Xử lý loại phòng";
            this.tabNavigationPage1.Controls.Add(this.groupControl3);
            this.tabNavigationPage1.Controls.Add(this.groupControl2);
            this.tabNavigationPage1.Controls.Add(this.groupControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1252, 431);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnLast);
            this.groupControl3.Controls.Add(this.btnFirst);
            this.groupControl3.Controls.Add(this.btnPre);
            this.groupControl3.Controls.Add(this.btnNext);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(370, 364);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(882, 67);
            this.groupControl3.TabIndex = 19;
            this.groupControl3.Text = "Điều hướng";
            // 
            // btnLast
            // 
            this.btnLast.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Appearance.Options.UseFont = true;
            this.btnLast.Location = new System.Drawing.Point(562, 33);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(79, 23);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = ">|";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Appearance.Options.UseFont = true;
            this.btnFirst.Location = new System.Drawing.Point(262, 33);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(77, 23);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "|<";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPre
            // 
            this.btnPre.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Appearance.Options.UseFont = true;
            this.btnPre.Location = new System.Drawing.Point(364, 33);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 12;
            this.btnPre.Text = "<";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Location = new System.Drawing.Point(457, 33);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(73, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvLoaiPhong);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(370, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(882, 431);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Thông tin về loại phòng";
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AllowUserToAddRows = false;
            this.dgvLoaiPhong.AllowUserToDeleteRows = false;
            this.dgvLoaiPhong.AllowUserToResizeColumns = false;
            this.dgvLoaiPhong.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvLoaiPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLoaiPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoaiPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiPhong.EnableHeadersVisualStyles = false;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(2, 20);
            this.dgvLoaiPhong.MultiSelect = false;
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.RowHeadersVisible = false;
            this.dgvLoaiPhong.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLoaiPhong.RowTemplate.Height = 25;
            this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(878, 409);
            this.dgvLoaiPhong.TabIndex = 1;
            this.dgvLoaiPhong.Click += new System.EventHandler(this.dgvLoaiPhong_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupControl1.Controls.Add(this.txtTrangThietBi);
            this.groupControl1.Controls.Add(this.txtMoTa);
            this.groupControl1.Controls.Add(this.btnXoaLoaiPhong);
            this.groupControl1.Controls.Add(this.btnCapNhatLoaiPhong);
            this.groupControl1.Controls.Add(this.cmbGiaLoaiPhong);
            this.groupControl1.Controls.Add(this.txtTenLoaiPhong);
            this.groupControl1.Controls.Add(this.txtMaLoaiPhong);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(370, 431);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Thông tin loại phòng";
            // 
            // txtTrangThietBi
            // 
            this.txtTrangThietBi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThietBi.Location = new System.Drawing.Point(118, 179);
            this.txtTrangThietBi.Multiline = true;
            this.txtTrangThietBi.Name = "txtTrangThietBi";
            this.txtTrangThietBi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTrangThietBi.Size = new System.Drawing.Size(225, 48);
            this.txtTrangThietBi.TabIndex = 14;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(119, 254);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMoTa.Size = new System.Drawing.Size(225, 58);
            this.txtMoTa.TabIndex = 14;
            // 
            // btnXoaLoaiPhong
            // 
            this.btnXoaLoaiPhong.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiPhong.Appearance.Options.UseFont = true;
            this.btnXoaLoaiPhong.Location = new System.Drawing.Point(190, 348);
            this.btnXoaLoaiPhong.Name = "btnXoaLoaiPhong";
            this.btnXoaLoaiPhong.Size = new System.Drawing.Size(127, 23);
            this.btnXoaLoaiPhong.TabIndex = 13;
            this.btnXoaLoaiPhong.Text = "Xóa loại phòng";
            this.btnXoaLoaiPhong.Click += new System.EventHandler(this.btnXoaLoaiPhong_Click);
            // 
            // btnCapNhatLoaiPhong
            // 
            this.btnCapNhatLoaiPhong.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiPhong.Appearance.Options.UseFont = true;
            this.btnCapNhatLoaiPhong.Location = new System.Drawing.Point(16, 348);
            this.btnCapNhatLoaiPhong.Name = "btnCapNhatLoaiPhong";
            this.btnCapNhatLoaiPhong.Size = new System.Drawing.Size(137, 23);
            this.btnCapNhatLoaiPhong.TabIndex = 13;
            this.btnCapNhatLoaiPhong.Text = "Cập nhật loại phòng";
            this.btnCapNhatLoaiPhong.Click += new System.EventHandler(this.btnCapNhatLoaiPhong_Click);
            // 
            // cmbGiaLoaiPhong
            // 
            this.cmbGiaLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGiaLoaiPhong.FormattingEnabled = true;
            this.cmbGiaLoaiPhong.Location = new System.Drawing.Point(118, 132);
            this.cmbGiaLoaiPhong.Name = "cmbGiaLoaiPhong";
            this.cmbGiaLoaiPhong.Size = new System.Drawing.Size(226, 25);
            this.cmbGiaLoaiPhong.TabIndex = 11;
            // 
            // txtTenLoaiPhong
            // 
            this.txtTenLoaiPhong.Location = new System.Drawing.Point(119, 87);
            this.txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            this.txtTenLoaiPhong.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiPhong.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoaiPhong.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTenLoaiPhong.Size = new System.Drawing.Size(225, 24);
            this.txtTenLoaiPhong.TabIndex = 10;
            // 
            // txtMaLoaiPhong
            // 
            this.txtMaLoaiPhong.Location = new System.Drawing.Point(119, 48);
            this.txtMaLoaiPhong.Name = "txtMaLoaiPhong";
            this.txtMaLoaiPhong.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiPhong.Properties.Appearance.Options.UseFont = true;
            this.txtMaLoaiPhong.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtMaLoaiPhong.Properties.ReadOnly = true;
            this.txtMaLoaiPhong.Size = new System.Drawing.Size(225, 24);
            this.txtMaLoaiPhong.TabIndex = 10;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(16, 55);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(97, 17);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Mã loại phòng : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(16, 259);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 17);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Mô tả : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 17);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Giá loại phòng : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(16, 198);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Trang thiết bị : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(14, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên loại phòng : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(319, -23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 20);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Mã khách hàng : ";
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 476);
            this.Controls.Add(this.tabPane1);
            this.Name = "frmLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ LOẠI PHÒNG";
            this.Load += new System.EventHandler(this.frmLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiPhong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaLoaiPhong;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatLoaiPhong;
        private System.Windows.Forms.ComboBox cmbGiaLoaiPhong;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiPhong;
        private DevExpress.XtraEditors.TextEdit txtMaLoaiPhong;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTrangThietBi;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnPre;
        private DevExpress.XtraEditors.SimpleButton btnNext;
    }
}