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
    public partial class frmDanhSachCacDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachCacDichVu()
        {
            InitializeComponent();
        }
        int pos = 0;
        List<DichVu_DTO> lstCacDichVu;

        private void frmDanhSachCacDichVu_Load(object sender, EventArgs e)
        {
            HienThiDanhSachCacDichVu(pos);
        }
        private void HienThiDanhSachCacDichVu(int index)
        {
            lstCacDichVu = DichVu_BLL.HienThiDanhSachCacDichVu(index);
            dgvCacDichVu.DataSource = lstCacDichVu;

        }
    }
}