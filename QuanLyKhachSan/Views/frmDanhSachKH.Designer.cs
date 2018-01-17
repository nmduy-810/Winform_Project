namespace QuanLyKhachSan.Views
{
    partial class frmDanhSachKH
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
            this.dgvDanhSachKH = new System.Windows.Forms.DataGridView();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvDanhSachKH);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1281, 372);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Danh sách các khách hàng";
            // 
            // dgvDanhSachKH
            // 
            this.dgvDanhSachKH.AllowUserToAddRows = false;
            this.dgvDanhSachKH.AllowUserToDeleteRows = false;
            this.dgvDanhSachKH.AllowUserToResizeColumns = false;
            this.dgvDanhSachKH.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvDanhSachKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachKH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDanhSachKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachKH.EnableHeadersVisualStyles = false;
            this.dgvDanhSachKH.Location = new System.Drawing.Point(2, 20);
            this.dgvDanhSachKH.MultiSelect = false;
            this.dgvDanhSachKH.Name = "dgvDanhSachKH";
            this.dgvDanhSachKH.ReadOnly = true;
            this.dgvDanhSachKH.RowHeadersVisible = false;
            this.dgvDanhSachKH.RowTemplate.Height = 25;
            this.dgvDanhSachKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachKH.Size = new System.Drawing.Size(1277, 350);
            this.dgvDanhSachKH.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIn.Location = new System.Drawing.Point(580, 393);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(116, 40);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmDanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 445);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDanhSachKH";
            this.Text = "DANH SÁCH KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmDanhSachKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvDanhSachKH;
        private DevExpress.XtraEditors.SimpleButton btnIn;
    }
}