namespace QuanLyKhachSan.Views
{
    partial class frmDanhSachDichVu
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
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.MaDichVuu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvDichVu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1073, 198);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách các dịch vụ";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.AllowUserToResizeColumns = false;
            this.dgvDichVu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDichVu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDichVuu,
            this.TenDichVu,
            this.DonGia,
            this.TenDonVi,
            this.MaLoaiDichVu,
            this.MaDonVi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDichVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.EnableHeadersVisualStyles = false;
            this.dgvDichVu.Location = new System.Drawing.Point(2, 20);
            this.dgvDichVu.MultiSelect = false;
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.RowTemplate.Height = 25;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(1069, 176);
            this.dgvDichVu.TabIndex = 3;
            // 
            // MaDichVuu
            // 
            this.MaDichVuu.DataPropertyName = "MaDichVu";
            this.MaDichVuu.HeaderText = "Mã Dịch Vụ";
            this.MaDichVuu.Name = "MaDichVuu";
            this.MaDichVuu.ReadOnly = true;
            // 
            // TenDichVu
            // 
            this.TenDichVu.DataPropertyName = "TenDichVu";
            this.TenDichVu.HeaderText = "Tên Dịch Vụ";
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // TenDonVi
            // 
            this.TenDonVi.DataPropertyName = "TenDonVi";
            this.TenDonVi.HeaderText = "Tên Đơn Vị";
            this.TenDonVi.Name = "TenDonVi";
            this.TenDonVi.ReadOnly = true;
            // 
            // MaLoaiDichVu
            // 
            this.MaLoaiDichVu.DataPropertyName = "MaLoaiDichVu";
            this.MaLoaiDichVu.HeaderText = "Mã Loại DV";
            this.MaLoaiDichVu.Name = "MaLoaiDichVu";
            this.MaLoaiDichVu.ReadOnly = true;
            // 
            // MaDonVi
            // 
            this.MaDonVi.DataPropertyName = "MaDonVi";
            this.MaDonVi.HeaderText = "Mã Đơn Vị";
            this.MaDonVi.Name = "MaDonVi";
            this.MaDonVi.ReadOnly = true;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Location = new System.Drawing.Point(463, 224);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(143, 36);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmDanhSachDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 303);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDanhSachDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH CÁC DỊCH VỤ";
            this.Load += new System.EventHandler(this.frmDanhSachDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonVi;
    }
}