namespace QuanLyKhachSan.Views
{
    partial class frmDangKy
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
            this.btnReCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtReName = new DevExpress.XtraEditors.TextEdit();
            this.txtRePassAgain = new DevExpress.XtraEditors.TextEdit();
            this.txtRePass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassAgain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReCancel
            // 
            this.btnReCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReCancel.Appearance.Options.UseFont = true;
            this.btnReCancel.Location = new System.Drawing.Point(376, 238);
            this.btnReCancel.Name = "btnReCancel";
            this.btnReCancel.Size = new System.Drawing.Size(87, 29);
            this.btnReCancel.TabIndex = 4;
            this.btnReCancel.Text = "Hủy";
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Location = new System.Drawing.Point(196, 238);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 29);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Đăng ký";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtReName);
            this.groupControl1.Controls.Add(this.txtRePassAgain);
            this.groupControl1.Controls.Add(this.txtRePass);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(72, 40);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(544, 179);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông Tin Tài Khoản";
            // 
            // txtReName
            // 
            this.txtReName.Location = new System.Drawing.Point(238, 44);
            this.txtReName.Name = "txtReName";
            this.txtReName.Size = new System.Drawing.Size(220, 20);
            this.txtReName.TabIndex = 1;
            // 
            // txtRePassAgain
            // 
            this.txtRePassAgain.Location = new System.Drawing.Point(238, 111);
            this.txtRePassAgain.Name = "txtRePassAgain";
            this.txtRePassAgain.Size = new System.Drawing.Size(220, 20);
            this.txtRePassAgain.TabIndex = 1;
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(238, 79);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(220, 20);
            this.txtRePass.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(94, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Nhập lại mật khẩu :  ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(94, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(94, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(198, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "*";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(214, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(6, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Location = new System.Drawing.Point(165, 79);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(6, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "*";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 307);
            this.Controls.Add(this.btnReCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmRegister";
            this.Text = "ĐĂNG KÝ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassAgain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnReCancel;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtReName;
        private DevExpress.XtraEditors.TextEdit txtRePass;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRePassAgain;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}