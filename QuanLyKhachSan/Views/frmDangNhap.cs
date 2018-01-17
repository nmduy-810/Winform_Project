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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        NhanVien_DTO nvDTO = new NhanVien_DTO();
        
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtMatKhau.Properties.PasswordChar = '*';
        }

        public static string MaNV = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}