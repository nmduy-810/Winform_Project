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
using BLL;
using DTO;
namespace QuanLyKhachSan.Views
{
    public partial class frmSuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaKhachHang()
        {
            InitializeComponent();
        }

        private void frmSuaKhachHang_Load(object sender, EventArgs e)
        {
            LoadDuLieuKhachHang();
        }
        private void LoadDuLieuKhachHang()
        {
            //frmPhieuDangKy frmPDK = new frmPhieuDangKy();
            

            KhachHang_DTO khDTO = KhachHang_BLL.LoadDuLieuKhachHang(frmPhieuDangKy.MaKH);
            
            txtMaKH.Text = khDTO.MaKhachHang;
            txtTenKH.Text = khDTO.TenKhachHang;
            txtDiaChi.Text = khDTO.DiaChi;
            txtDienThoai.Text = khDTO.SDT;
            dtpNgaySinh.Text = Convert.ToDateTime(khDTO.NgaySinh).ToString();
            txtCMND.Text = khDTO.CMND;
            cmbQuocTich.Text = khDTO.QuocTich;
      
        }



        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            KhachHang_DTO khDTO = new KhachHang_DTO();
            khDTO.MaKhachHang = txtMaKH.Text;
            khDTO.TenKhachHang = txtTenKH.Text;
            khDTO.DiaChi = txtDiaChi.Text;
            khDTO.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
            khDTO.SDT = txtDienThoai.Text;
            khDTO.CMND = txtCMND.Text;
            if (rdbNam.Checked)
            {
                khDTO.GioiTinh = "Nam";
            }
            else khDTO.GioiTinh = "Nữ";
            khDTO.QuocTich = cmbQuocTich.Text;

            if(KhachHang_BLL.SuaKhachHang(khDTO) > 0)
            {
                XtraMessageBox.Show("Sửa thành công","Thông báo");
                LoadDuLieuKhachHang();
            }
            else
            {
                XtraMessageBox.Show("Sửa thất bại","Thông báo");
            }

        } 
    }
}