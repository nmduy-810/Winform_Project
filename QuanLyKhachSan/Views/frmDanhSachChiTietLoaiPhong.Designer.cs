namespace QuanLyKhachSan.Views
{
    partial class frmDanhSachChiTietLoaiPhong
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvChiTietLoaiPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvChiTietLoaiPhong);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(861, 369);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách chi tiết về loại phòng";
            // 
            // dgvChiTietLoaiPhong
            // 
            this.dgvChiTietLoaiPhong.AllowUserToAddRows = false;
            this.dgvChiTietLoaiPhong.AllowUserToDeleteRows = false;
            this.dgvChiTietLoaiPhong.AllowUserToResizeColumns = false;
            this.dgvChiTietLoaiPhong.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvChiTietLoaiPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTietLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietLoaiPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChiTietLoaiPhong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChiTietLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChiTietLoaiPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTietLoaiPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChiTietLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietLoaiPhong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChiTietLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietLoaiPhong.EnableHeadersVisualStyles = false;
            this.dgvChiTietLoaiPhong.Location = new System.Drawing.Point(2, 20);
            this.dgvChiTietLoaiPhong.MultiSelect = false;
            this.dgvChiTietLoaiPhong.Name = "dgvChiTietLoaiPhong";
            this.dgvChiTietLoaiPhong.ReadOnly = true;
            this.dgvChiTietLoaiPhong.RowHeadersVisible = false;
            this.dgvChiTietLoaiPhong.RowTemplate.Height = 25;
            this.dgvChiTietLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietLoaiPhong.Size = new System.Drawing.Size(857, 347);
            this.dgvChiTietLoaiPhong.TabIndex = 1;
            // 
            // frmDanhSachChiTietLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 369);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDanhSachChiTietLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH CHI TIẾT LOẠI PHÒNG";
            this.Load += new System.EventHandler(this.frmDanhSachChiTietLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLoaiPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvChiTietLoaiPhong;
    }
}