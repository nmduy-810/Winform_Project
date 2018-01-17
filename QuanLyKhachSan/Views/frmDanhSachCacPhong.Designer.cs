namespace QuanLyKhachSan.Views
{
    partial class frmDanhSachCacPhong
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
            this.dgvDanhSachCacPhong = new System.Windows.Forms.DataGridView();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCacPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvDanhSachCacPhong);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(839, 332);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách các phòng";
            // 
            // dgvDanhSachCacPhong
            // 
            this.dgvDanhSachCacPhong.AllowUserToAddRows = false;
            this.dgvDanhSachCacPhong.AllowUserToDeleteRows = false;
            this.dgvDanhSachCacPhong.AllowUserToResizeColumns = false;
            this.dgvDanhSachCacPhong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvDanhSachCacPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachCacPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachCacPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachCacPhong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDanhSachCacPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachCacPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachCacPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachCacPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachCacPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachCacPhong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachCacPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachCacPhong.EnableHeadersVisualStyles = false;
            this.dgvDanhSachCacPhong.Location = new System.Drawing.Point(2, 20);
            this.dgvDanhSachCacPhong.MultiSelect = false;
            this.dgvDanhSachCacPhong.Name = "dgvDanhSachCacPhong";
            this.dgvDanhSachCacPhong.ReadOnly = true;
            this.dgvDanhSachCacPhong.RowHeadersVisible = false;
            this.dgvDanhSachCacPhong.RowTemplate.Height = 25;
            this.dgvDanhSachCacPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachCacPhong.Size = new System.Drawing.Size(835, 310);
            this.dgvDanhSachCacPhong.TabIndex = 1;
            this.dgvDanhSachCacPhong.Click += new System.EventHandler(this.dgvDanhSachCacPhong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Location = new System.Drawing.Point(290, 350);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(199, 37);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmDanhSachCacPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 408);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDanhSachCacPhong";
            this.Text = "DANH SÁCH CÁC PHÒNG";
            this.Load += new System.EventHandler(this.frmDanhSachCacPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCacPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvDanhSachCacPhong;
        private DevExpress.XtraEditors.SimpleButton btnIn;
    }
}