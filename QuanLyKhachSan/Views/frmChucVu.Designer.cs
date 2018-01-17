namespace QuanLyKhachSan.Views
{
    partial class frmChucVu
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
            this.txtMaChucVu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenChucVu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoaChucVu = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatChucVu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemChucVu = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(237, 32);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChucVu.Properties.Appearance.Options.UseFont = true;
            this.txtMaChucVu.Size = new System.Drawing.Size(228, 24);
            this.txtMaChucVu.TabIndex = 0;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(237, 74);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChucVu.Properties.Appearance.Options.UseFont = true;
            this.txtTenChucVu.Size = new System.Drawing.Size(228, 24);
            this.txtTenChucVu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(123, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên chức vụ : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(123, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã chức vụ : ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTenChucVu);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMaChucVu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(614, 111);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin chức vụ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnXoaChucVu);
            this.groupControl2.Controls.Add(this.btnCapNhatChucVu);
            this.groupControl2.Controls.Add(this.btnThemChucVu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 111);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(139, 266);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Xử lý";
            // 
            // btnXoaChucVu
            // 
            this.btnXoaChucVu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChucVu.Appearance.Options.UseFont = true;
            this.btnXoaChucVu.Enabled = false;
            this.btnXoaChucVu.Location = new System.Drawing.Point(12, 185);
            this.btnXoaChucVu.Name = "btnXoaChucVu";
            this.btnXoaChucVu.Size = new System.Drawing.Size(112, 53);
            this.btnXoaChucVu.TabIndex = 0;
            this.btnXoaChucVu.Text = "Xóa chức vụ";
            this.btnXoaChucVu.Click += new System.EventHandler(this.btnXoaChucVu_Click);
            // 
            // btnCapNhatChucVu
            // 
            this.btnCapNhatChucVu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatChucVu.Appearance.Options.UseFont = true;
            this.btnCapNhatChucVu.Enabled = false;
            this.btnCapNhatChucVu.Location = new System.Drawing.Point(12, 39);
            this.btnCapNhatChucVu.Name = "btnCapNhatChucVu";
            this.btnCapNhatChucVu.Size = new System.Drawing.Size(112, 53);
            this.btnCapNhatChucVu.TabIndex = 0;
            this.btnCapNhatChucVu.Text = "Cập nhật chức vụ";
            this.btnCapNhatChucVu.Click += new System.EventHandler(this.btnCapNhatChucVu_Click);
            // 
            // btnThemChucVu
            // 
            this.btnThemChucVu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChucVu.Appearance.Options.UseFont = true;
            this.btnThemChucVu.Location = new System.Drawing.Point(12, 109);
            this.btnThemChucVu.Name = "btnThemChucVu";
            this.btnThemChucVu.Size = new System.Drawing.Size(112, 53);
            this.btnThemChucVu.TabIndex = 0;
            this.btnThemChucVu.Text = "Thêm chức vụ ";
            this.btnThemChucVu.Click += new System.EventHandler(this.btnThemChucVu_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgvChucVu);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(139, 111);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(475, 266);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Danh sách các chức vụ ";
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            this.dgvChucVu.AllowUserToDeleteRows = false;
            this.dgvChucVu.AllowUserToResizeColumns = false;
            this.dgvChucVu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvChucVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChucVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChucVu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChucVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChucVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChucVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChucVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChucVu.EnableHeadersVisualStyles = false;
            this.dgvChucVu.Location = new System.Drawing.Point(2, 20);
            this.dgvChucVu.MultiSelect = false;
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ReadOnly = true;
            this.dgvChucVu.RowHeadersVisible = false;
            this.dgvChucVu.RowTemplate.Height = 25;
            this.dgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChucVu.Size = new System.Drawing.Size(471, 244);
            this.dgvChucVu.TabIndex = 1;
            this.dgvChucVu.Click += new System.EventHandler(this.dgvChucVu_Click);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 377);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CHỨC VỤ";
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMaChucVu;
        private DevExpress.XtraEditors.TextEdit txtTenChucVu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoaChucVu;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatChucVu;
        private DevExpress.XtraEditors.SimpleButton btnThemChucVu;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgvChucVu;
    }
}