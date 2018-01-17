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
using QuanLyKhachSan.Views;
namespace QuanLyKhachSan.Views
{
    public partial class frmPhieuDangKy : DevExpress.XtraEditors.XtraForm
    {
        public static string MaKH;
        public static string maPhieuDK;
        KhachHang_BLL khBLL = new KhachHang_BLL();
        List<KhachHang_DTO> lstKhachHangDTO = new List<KhachHang_DTO>();
        List<PhieuDangKy_DTO> lstPhieuDangKyDTO = new List<PhieuDangKy_DTO>();
        List<NhanVien_DTO> lstNVLT = new List<NhanVien_DTO>();
        List<Phong_DTO> lstTenPhong = new List<Phong_DTO>();
        List<DichVu_DTO> lstTenDichVu = new List<DichVu_DTO>();
        int pos = 0;

        public frmPhieuDangKy()
        {
            InitializeComponent();
        }

        private void frmPhieuDangKy_Load(object sender, EventArgs e)
        {
            HienThiDuLieuKhachHang(pos);
            HienThiDanhSachKhachHangTrongPDK();
            txtMaNVV.Text = frmMain.MaNV;
        }
        private void HienThiDuLieuKhachHang(int pos)
        {
            lstKhachHangDTO = KhachHang_BLL.LoadKhachHang(pos);
            dgvLoadKhachHang.DataSource = lstKhachHangDTO;
            dgvLoadKhachHang.Columns[8].Visible = false;
            dgvLoadKhachHang.Columns[9].Visible = false;
            dgvLoadKhachHang.Columns[10].Visible = false;


        }

       

        private void HienThiDanhSachKhachHangTrongPDK()
        {
            lstPhieuDangKyDTO = PhieuDangKy_BLL.HienThiDanhSachKhachHangTrongPDK(pos);
            dgvPhieuDK.DataSource = lstPhieuDangKyDTO;

        }

        private void HienThiLaiDuLieuTrenDataGridView()
        {
            dgvPhieuDK.DataSource = typeof(List<PhieuDangKy_DTO>);
            dgvPhieuDK.DataSource = lstPhieuDangKyDTO;
        }


        private void btnThemPDK_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
            HienThiDuLieuKhachHang(pos);

        }

        //Kiểm tra có phải là số hay không ?
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        //Duyệt danh sách các khách hàng chưa xác nhận. 

        private void btnXacNhanDangKy_Click(object sender, EventArgs e)
        {
            //Lấy mã khách hàng để load dữ liệu tên khách hàng lên txtBox
            string maKH = "";
            string tenKH = "";           
            if (dgvLoadKhachHang.SelectedRows != null)
            {
                DataGridViewRow _row = dgvLoadKhachHang.SelectedRows[0];

                maKH = _row.Cells["MaKhachHang"].Value.ToString();
                tenKH = _row.Cells["TenKhachHang"].Value.ToString();                
            }
            string errorS = "";
           
           
            PhieuDangKy_DTO pdkDTO = new PhieuDangKy_DTO();

            //Kiểm tra hợp lệ của dữ liệu
            if (txtMaPhieuDK.Text.Trim() != "")
            {

                if (PhieuDangKy_BLL.KiemTraMa(txtMaPhieuDK.Text) == 1)
                {
                    errorS += "Mã phiếu đăng ký đã bị trùng. Xin kiểm tra lại mã phiếu!!\n";
                    
                }
                else
                {
                    pdkDTO.MaPhieuDK = txtMaPhieuDK.Text;
                }
                                         
            }
            else
            {
                errorS += "Chưa nhập thông tin trên phiếu đăng ký. Hãy nhập thông tin để tiếp tục!!\n";
            }

            if (txtSoLuongNL.Text.Trim() != "")
            {

                if (IsNumber(txtSoLuongNL.Text) == true)
                {
                    pdkDTO.SoLuongNguoiLon = Convert.ToInt32(txtSoLuongNL.Text.ToString());
                }
                else
                {

                    errorS += "Kiểu dữ liệu không hợp lệ. Dữ liệu phải là số...\n";

                }
            }
            else
            {
                
                errorS+= "Chưa nhập số lượng người lớn. Hãy nhập số lượng người lớn để tiếp tục!!\n";
              
            }
            if (txtSoLuongTE.Text.Trim() != "")
            {
                if(IsNumber(txtSoLuongTE.Text) == true)
                {
                    pdkDTO.SoLuongTreEm = Convert.ToInt32(txtSoLuongTE.Text.ToString());

                }
                else
                {

                    errorS += "Kiểu dữ liệu không hợp lệ. Dữ liệu phải là số...\n";

                }
            }
            else
            {
                pdkDTO.SoLuongTreEm = 0;

            }

            if (txtTienDatCoc.Text.Trim() != "")
            {
                if (IsNumber(txtTienDatCoc.Text) == true)
                {
                    pdkDTO.TienDatCoc = Convert.ToDouble(txtTienDatCoc.Text.ToString());
                }
                else
                {
                    errorS += "Kiểu dữ liệu không hợp lệ. Dữ liệu phải là số...\n";
                }
            }
            else
            {
                pdkDTO.TienDatCoc = 0;
            }
           
            if (errorS != "")
            {
                MessageBox.Show(errorS,"Thông báo lỗi");
                return;
            }          
            pdkDTO.NgayDen = Convert.ToDateTime(dtpNgayDen.Text);
            pdkDTO.NgayDi = Convert.ToDateTime(dtpNgayDi.Text);
            pdkDTO.GioDen = Convert.ToString(dtpGioDen.Text);
            pdkDTO.GioDi = Convert.ToString(dtpGioDi.Text);                                         
            pdkDTO.MaKH = maKH;
            pdkDTO.TenKH = tenKH;
            pdkDTO.MaNV = txtMaNVV.Text;
            int check = PhieuDangKy_BLL.ThemPhieuDangKy(pdkDTO);

            if (check > 0)
            {
                XtraMessageBox.Show("Thêm 1 phiếu đăng ký thành công", "Thông báo");
                HienThiDuLieuKhachHang(pos);
                HienThiDanhSachKhachHangTrongPDK();
            }
            else
            {
                XtraMessageBox.Show("Thêm 1 phiếu đăng ký thất bại!!", "Thông báo");
            }
        }

        private void dgvLoadKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLoadKhachHang.SelectedRows != null)
                {
                    DataGridViewRow _row = dgvLoadKhachHang.SelectedRows[0];

                    txtTenKH.Text = _row.Cells["TenKhachHang"].Value.ToString();
                    btnXacNhanDangKy.Text = _row.Cells["MaKhachHang"].Value.ToString();

                }
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void btnThongTinKH_Click(object sender, EventArgs e)
        {

            frmSuaKhachHang frmSKH = new frmSuaKhachHang();
            frmSKH.ShowDialog();

        }

        //Bắt sự kiện click vào DataGridView Phiếu Đăng Ký
   
        private void dgvPhieuDK_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieuDK.SelectedRows != null)
                {

                    DataGridViewRow _row = dgvPhieuDK.SelectedRows[0];
                    string MaPhieuDK = _row.Cells["MaPhieuDK"].Value.ToString();
                    PhieuDangKy_DTO pdkDTO = PhieuDangKy_BLL.HienThiDuLieuPhieuDangKy(MaPhieuDK);
                    txtMaPDK_TTPDK.Text = pdkDTO.MaPhieuDK;
                    dtpGioDen_TTPDK.EditValue = pdkDTO.GioDen;
                    dtpGioDi_TTPDK.EditValue = pdkDTO.GioDi;
                    dtpNgayDen_TTPDK.Text = Convert.ToDateTime(pdkDTO.NgayDen).ToShortDateString();
                    dtpNgayDi_TTPDK.Text = Convert.ToDateTime(pdkDTO.NgayDi).ToShortDateString();
                    txtSoLuongNL_TTPDK.Text = pdkDTO.SoLuongNguoiLon + "";
                    txtSoLuongTE_TTPDK.Text = pdkDTO.SoLuongTreEm + "";
                    txtTienDatCoc_TTPDK.Text = pdkDTO.TienDatCoc + "";

                    //Truyền thuộc tính MaKH để truyền sang form khác
                    MaKH = _row.Cells["MaKHH"].Value.ToString();

                    txtMaNV_TTPDK.Text = _row.Cells["MaNV"].Value.ToString();

                    maPhieuDK = _row.Cells["MaPhieuDK"].Value.ToString();

                }
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void btnSuaPhieuDK_Click(object sender, EventArgs e)
        {
            //Lấy tất cả giá trị từ các control giao điện đổ vào đối tượng
            PhieuDangKy_DTO pdkDTO = new PhieuDangKy_DTO();
            pdkDTO.MaPhieuDK = txtMaPDK_TTPDK.Text;
            pdkDTO.GioDen = dtpGioDen_TTPDK.Text;
            pdkDTO.GioDi = dtpGioDi_TTPDK.Text;
            pdkDTO.NgayDen = Convert.ToDateTime(dtpNgayDen_TTPDK.Text);
            pdkDTO.NgayDi = Convert.ToDateTime(dtpNgayDi_TTPDK.Text);
            pdkDTO.SoLuongNguoiLon = int.Parse(txtSoLuongNL_TTPDK.Text);
            pdkDTO.SoLuongTreEm = int.Parse(txtSoLuongTE_TTPDK.Text);
            pdkDTO.TienDatCoc = int.Parse(txtTienDatCoc_TTPDK.Text);
            int check = PhieuDangKy_BLL.SuaPhieuDangKy(pdkDTO);
            if(check >0)
            {
                PhieuDangKy_DTO pdkDTOUpDate = lstPhieuDangKyDTO.Single(n => n.MaPhieuDK == pdkDTO.MaPhieuDK);
                pdkDTOUpDate.NgayDen = pdkDTO.NgayDen;
                pdkDTOUpDate.NgayDi = pdkDTO.NgayDi;
                pdkDTOUpDate.GioDen = pdkDTO.GioDen;
                pdkDTOUpDate.GioDi = pdkDTO.GioDi;
                pdkDTOUpDate.SoLuongNguoiLon = pdkDTO.SoLuongNguoiLon;
                pdkDTOUpDate.SoLuongTreEm = pdkDTO.SoLuongTreEm;
                pdkDTOUpDate.TienDatCoc = pdkDTO.TienDatCoc;
                HienThiLaiDuLieuTrenDataGridView();
                XtraMessageBox.Show("Cập nhật lại phiếu đăng ký thành công", "Thông báo");


            }
            else
            {
                XtraMessageBox.Show("Cập nhật phiếu đăng ký thất bại", "Thông báo");
            }


        }

        private void btnXoaPhieuDK_Click(object sender, EventArgs e)
        {
            if(DangNhap_BLL.LayMaQuyenHan(txtMaNV_TTPDK.Text)== "2")
            {
                string MaPhieuDK = txtMaPDK_TTPDK.Text;
                if (PhieuDangKy_BLL.XoaPhieuDangKy(MaPhieuDK) == 1)
                {
                    PhieuDangKy_DTO pdkDTODelete = lstPhieuDangKyDTO.Single(n => n.MaPhieuDK == MaPhieuDK);
                    lstPhieuDangKyDTO.Remove(pdkDTODelete);
                    HienThiLaiDuLieuTrenDataGridView();
                    XtraMessageBox.Show("Xóa phiếu đăng ký thành công!", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Xóa phiếu đăng ký thất bại!", "Thông báo");
                }
            }
            

        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            frmPhong frmPhong = new frmPhong();
            frmPhong.ShowDialog();
        }
    }
}