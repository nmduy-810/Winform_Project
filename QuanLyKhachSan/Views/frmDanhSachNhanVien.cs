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
    public partial class frmDanhSachNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }
        int pos = 0;
        private void HienThiDanhSachNhanVien()

        {
            dgvNhanVien.DataSource = NhanVien_BLL.HienThiDanhSachCacNhanVien(pos);
            dgvNhanVien.Columns[8].Visible = false;
        }

        private void frmDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
        }
    }
}