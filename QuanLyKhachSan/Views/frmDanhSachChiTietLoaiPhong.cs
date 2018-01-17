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
    public partial class frmDanhSachChiTietLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachChiTietLoaiPhong()
        {
            InitializeComponent();
        }
        List<LoaiPhong_DTO> lstLoaiPhong = new List<LoaiPhong_DTO>();
        int pos = 0;
        private void frmDanhSachChiTietLoaiPhong_Load(object sender, EventArgs e)
        {
            HienThiDanhSachChiTietLoaiPhong();
        }
        private void HienThiDanhSachChiTietLoaiPhong()
        {
            lstLoaiPhong = LoaiPhong_BLL.HienThiThongTinLoaiPhong(pos);
            dgvChiTietLoaiPhong.DataSource = lstLoaiPhong;
        }
    }
}