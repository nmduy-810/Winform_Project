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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public static string idLogin;
        frmDangNhap login;
        public frmMain()
        {
            InitializeComponent();
            Skins();
            DisEndMenuLogin(true, idLogin);            

        }



        public void DisEndMenuLogin(bool e, string _idLogin)
        {
           
            btnDangNhap.Enabled = e;
            btnDoiMatKhau.Enabled = !e;
            btnDangXuat.Enabled = !e;
            btnPhanQuyenNguoiDung.Enabled = !e;
            btnSaoLuu.Enabled = !e;
            btnKhoiPhuc.Enabled = !e;
            rbQuanLy.Visible = !e;
            rbDanhMuc.Visible = !e;
            rbTraCuu.Visible = !e;
            rbTroGiup.Visible = !e;
            rbQuanTri.Visible = !e;
            

        }

        private void Skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel _themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            _themes.LookAndFeel.SkinName = "Office 2016 Colorful"; // Default design name when start program.
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult _dialogRes;
            _dialogRes = XtraMessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_dialogRes == DialogResult.No)
            {
                e.Cancel = true;
            }
           
        }

        //Kiểm tra xem form đã được mở hay chưa? 
        private Form CheckForms(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if(f.GetType()== ftype)
                {
                    return f;
                }
                
            }
            return null;
        }
        

        private void ViewForms(Form _frm)
        {
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void btnQuanLyDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForms(typeof(frmPhong));
            if (frm == null)
            {
                frmPhong frmPHG = new frmPhong();
                ViewForms(frmPHG);
            }
            else
            {
                frm.Activate();
            }

           

        }

        private void btnQuanLyPDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForms(typeof(frmPhieuDangKy));
            if(frm ==null)
            {
                frmPhieuDangKy frmPDK = new frmPhieuDangKy();
                ViewForms(frmPDK);
            }
            else
            {
                frm.Activate();
            }
           
        }

        private void btnQuanLyKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForms(typeof(frmKhachHang));
            if (frm == null)
            {
                frmKhachHang frmKH = new frmKhachHang();
                ViewForms(frmKH);
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDanhSachLoaiPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForms(typeof(frmDanhSachChiTietLoaiPhong));
            if (frm == null)
            {
                frmDanhSachChiTietLoaiPhong frmDSCTLP = new frmDanhSachChiTietLoaiPhong();
                ViewForms(frmDSCTLP);
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDanhSachCacPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForms(typeof(frmDanhSachCacPhong));
            if (frm == null)
            {
                frmDanhSachCacPhong frmDSCP = new frmDanhSachCacPhong();
                ViewForms(frmDSCP);
            }
            else
            {
                frm.Activate();
            }
        }

  

        private void btnDanhSachPhieuDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForms(typeof(frmDanhSachPhieuDK));
            if (frm == null)
            {
                frmDanhSachPhieuDK frmDSPDK = new frmDanhSachPhieuDK();
                ViewForms(frmDSPDK);
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDanhSachKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
                Form frm = CheckForms(typeof(frmDanhSachKH));
                if (frm == null)
                {
                    frmDanhSachKH frmDSKH = new frmDanhSachKH();
                    ViewForms(frmDSKH);
                }
                else
                {
                    frm.Activate();
                }
           
        }
        public static string MaNV = "";
        NhanVien_DTO nvDTO = new NhanVien_DTO();
        
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

        }

        private void btnPhanQuyenNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(DangNhap_BLL.LayMaQuyenHan(MaNV) == "1")
            {
                
            }
        }

        private void btnQuanLyDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForms(typeof(frmDichVu));
            if (frm == null)
            {
                frmDichVu frmDV = new frmDichVu();
                ViewForms(frmDV);
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnQLNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DangNhap_BLL.LayMaQuyenHan(MaNV) == "2")
            {
                Form frm = CheckForms(typeof(frmNhanVien));
                if (frm == null)
                {
                    frmNhanVien frmNV = new frmNhanVien();
                    ViewForms(frmNV);
                }
                else
                {
                    frm.Activate();
                }
            }
        }

        private void btnQLCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DangNhap_BLL.LayMaQuyenHan(MaNV) == "2")
            {
                Form frm = CheckForms(typeof(frmChucVu));
                if (frm == null)
                {
                    frmChucVu frmCV = new frmChucVu();
                    ViewForms(frmCV);
                }
                else
                {
                    frm.Activate();
                }
            }
           
        }

        private void btnTraCuuKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {          
            
                Form frm = CheckForms(typeof(frmTimKiem_KH));
                if (frm == null)
                {
                    frmTimKiem_KH frmTimKiemKH = new frmTimKiem_KH();
                    ViewForms(frmTimKiemKH);
                }
                else
                {
                    frm.Activate();
                }

        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn đăng xuất?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisEndMenuLogin(true, idLogin);
                
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau frmDMK = new frmDoiMatKhau();
            frmDMK.ShowDialog();
        }

        private void btnTraCuuPhieuDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
                Form frm = CheckForms(typeof(frmTimKiem_PDK));
                if (frm == null)
                {
                    frmTimKiem_PDK frmTimKiemPhieuDK = new frmTimKiem_PDK();
                    ViewForms(frmTimKiemPhieuDK);
                }
                else
                {
                    frm.Activate();
                }
            
        }

        private void btnQLHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForms(typeof(frmHoaDon));
            if (frm == null)
            {
                frmHoaDon frmHD = new frmHoaDon();
                ViewForms(frmHD);
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDanhSachNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForms(typeof(frmDanhSachNhanVien));
            if (frm == null)
            {
                frmDanhSachNhanVien frmDSNV = new frmDanhSachNhanVien();
                ViewForms(frmDSNV);
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDanhSachDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForms(typeof(frmDanhSachDichVu));
            if (frm == null)
            {
                frmDanhSachDichVu frmDSDV = new frmDanhSachDichVu();
                ViewForms(frmDSDV);
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnTraCuuNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(DangNhap_BLL.LayMaQuyenHan(MaNV) == "2")
            {
                Form frm = CheckForms(typeof(frmTimKiem_NV));
                if (frm == null)
                {
                    frmTimKiem_NV frmTimKiem_NV = new frmTimKiem_NV();
                    ViewForms(frmTimKiem_NV);
                }
                else
                {
                    frm.Activate();
                }
            }
            
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaNV = nvDTO.MaNV;
            if (login == null)
            {
                login = new frmDangNhap();
            }
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.txtTaiKhoan.Text.Trim() == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập tài khoản. Xin thử lại");
                    return;
                }
                if (login.txtMatKhau.Text.Trim() == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập mật khẩu. Xin thử lại");
                    return;
                }
            }
            MaNV = DangNhap_BLL.LayTenDangNhap_MatKhau(login.txtTaiKhoan.Text, login.txtMatKhau.Text);


            if (MaNV.Trim() != "")
            {

                XtraMessageBox.Show("Đăng nhập thành công!!!", "Thông báo");

                XtraMessageBox.Show("Xin chào User có ID là : " + MaNV, "Thông báo");
            }
            if (MaNV.Trim() == "")
            {
                XtraMessageBox.Show("Tài khoản và mật khẩu không đúng !", "Lỗi đăng nhập");
                return;
            }
            else
            {
                DisEndMenuLogin(false, idLogin);
            }

        }

        private void btnTraCuuHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DangNhap_BLL.LayMaQuyenHan(MaNV) == "2")
            {
                Form frm = CheckForms(typeof(frmTimKiem_NV));
                if (frm == null)
                {
                    frmTimKiem_HD frmTimKiemHD = new frmTimKiem_HD();
                    ViewForms(frmTimKiemHD);
                }
                else
                {
                    frm.Activate();
                }
            }
        }
    }
}