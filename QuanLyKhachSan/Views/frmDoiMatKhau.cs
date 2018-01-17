using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BLL;
namespace QuanLyKhachSan.Views
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();

        }

        NhanVien_DTO nvDTO = new NhanVien_DTO();
        private void btnDongY_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap();


            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            if (tenDangNhap == "")
            {
                XtraMessageBox.Show("Xin nhập user cần thay đổi mật khẩu!!!!");
                txtTenDangNhap.Select();
            }
            else if (matKhauCu == "")
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu cũ!!");
                txtMatKhauCu.Select();
            }
            else if (matKhauMoi == "")
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu mới");
                txtMatKhauMoi.Select();
            }
            else
            {
                string check = DangNhap_BLL.DoiMatKhau(nvDTO.MaNV, tenDangNhap, matKhauMoi);
                if (check.Length > 0)
                {
                    XtraMessageBox.Show("Đổi mật khẩu thành công!!", "Thông báo");
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Đổi mật khẩu thất bại!!", "Thông báo");
                    return;

                }
            }
        }
    }
}