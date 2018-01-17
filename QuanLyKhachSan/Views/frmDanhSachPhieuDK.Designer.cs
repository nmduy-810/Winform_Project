namespace QuanLyKhachSan.Views
{
    partial class frmDanhSachPhieuDK
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
            this.dgvDanhSachCacPhieuDK = new System.Windows.Forms.DataGridView();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCacPhieuDK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvDanhSachCacPhieuDK);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(925, 322);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh sách các phiếu đăng ký";
            // 
            // dgvDanhSachCacPhieuDK
            // 
            this.dgvDanhSachCacPhieuDK.AllowUserToAddRows = false;
            this.dgvDanhSachCacPhieuDK.AllowUserToDeleteRows = false;
            this.dgvDanhSachCacPhieuDK.AllowUserToResizeColumns = false;
            this.dgvDanhSachCacPhieuDK.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvDanhSachCacPhieuDK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachCacPhieuDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachCacPhieuDK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachCacPhieuDK.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDanhSachCacPhieuDK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachCacPhieuDK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachCacPhieuDK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachCacPhieuDK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachCacPhieuDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachCacPhieuDK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachCacPhieuDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachCacPhieuDK.EnableHeadersVisualStyles = false;
            this.dgvDanhSachCacPhieuDK.Location = new System.Drawing.Point(2, 20);
            this.dgvDanhSachCacPhieuDK.MultiSelect = false;
            this.dgvDanhSachCacPhieuDK.Name = "dgvDanhSachCacPhieuDK";
            this.dgvDanhSachCacPhieuDK.ReadOnly = true;
            this.dgvDanhSachCacPhieuDK.RowHeadersVisible = false;
            this.dgvDanhSachCacPhieuDK.RowTemplate.Height = 25;
            this.dgvDanhSachCacPhieuDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachCacPhieuDK.Size = new System.Drawing.Size(921, 300);
            this.dgvDanhSachCacPhieuDK.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Location = new System.Drawing.Point(387, 328);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(146, 34);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmDanhSachPhieuDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 374);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDanhSachPhieuDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH CÁC PHIẾU ĐĂNG KÝ";
            this.Load += new System.EventHandler(this.frmDanhSachPhieuDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCacPhieuDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvDanhSachCacPhieuDK;
        private DevExpress.XtraEditors.SimpleButton btnIn;
    }
}