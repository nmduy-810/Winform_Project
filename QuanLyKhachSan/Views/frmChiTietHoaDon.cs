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
    public partial class frmChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        Phong_DTO phgDTO = new Phong_DTO();
        public static int ThanhTien;
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSDDichVu();
            HienThiMaPhongLenComboBox();
            HienThiGiaLoaiPhongLenTextBox();
            HienThiTongTienDichVuLenTextBox();
        }
        private void HienThiDanhSachSDDichVu()
        {
            cmbMaSDDV.DataSource = HoaDon_BLL.HienThiDanhSachMaSuDungDichVu(frmHoaDon.MaPhong);
            cmbMaSDDV.DisplayMember = "MaSuDungDichVu";
            cmbMaSDDV.ValueMember = "MaSuDungDichVu";
        }
        private void HienThiMaPhongLenComboBox()
        {
            cmbMaPhong.DataSource = HoaDon_BLL.HienThiMaPhong(frmHoaDon.MaPhong);
            cmbMaPhong.DisplayMember = "MaPhong";
            cmbMaPhong.ValueMember = "MaPhong";
        }

        private void HienThiGiaLoaiPhongLenTextBox()
        {            

            txtTienLoaiPhong.Text = HoaDon_BLL.LayTienLoaiPhong(frmHoaDon.MaPhong).ToString();
            

        }
        private void HienThiTongTienDichVuLenTextBox()
        {
            txtTienDichVu.Text = HoaDon_BLL.LayTienDichVu(frmHoaDon.MaPhong).ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            HoaDon_DTO hdDTO = new HoaDon_DTO();
            hdDTO.MaChiTietHoaDon = txtMaChiTietHD.Text;
            if (txtPhuThu.Text.Trim() != "")
            {
                hdDTO.PhuThu = Convert.ToInt32(txtPhuThu.Text);
            }
            else
            {
                hdDTO.PhuThu = 0;
            }
            hdDTO.TienPhong = int.Parse(txtTienLoaiPhong.Text.ToString());
            hdDTO.TienDichVu =int.Parse(txtTienDichVu.Text.ToString());
            hdDTO.ThanhTien = int.Parse(txtTienLoaiPhong.Text) + int.Parse(txtTienDichVu.Text) + hdDTO.PhuThu;

            hdDTO.MaPhong = cmbMaPhong.Text;
            int check = HoaDon_BLL.ThemChiTietHoaDon(hdDTO);
            if(check >0 )
            {
                XtraMessageBox.Show("Thêm chi tiết hóa đơn thành công!!", "Thông báo");
                
            }
            else
            {
                XtraMessageBox.Show("Thêm chi tiết hóa đơn thất bại!!", "Thông báo");
            }

            


        }

        
    }
}