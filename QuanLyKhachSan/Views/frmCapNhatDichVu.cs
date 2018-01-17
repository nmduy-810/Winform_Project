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
    public partial class frmCapNhatDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatDichVu()
        {
            InitializeComponent();
        }
        List<LoaiDichVu_DTO> lstLoaiDichVu = new List<LoaiDichVu_DTO>();

        private void frmCapNhatDichVu_Load(object sender, EventArgs e)
        {
            HienThiTenLoaiDichVuLenComboBox();
            HienThiDanhSachCacDichVuCanCapNhat();
        }

        private void HienThiDanhSachCacDichVuCanCapNhat()
        {
            DataTable dt = DichVu_BLL.HienThiDanhSachCacDichVuCanCapNhat(frmDichVu.MaDichVu, frmDichVu.MaPhong);
            dgvChiTietDichVu.DataSource = dt;

        }
        private void HienThiTenLoaiDichVuLenComboBox()
        {
            lstLoaiDichVu = LoaiDichVu_BLL.HienThiTenLoaiDichVuLenComboBox();
            cmbLoaiDichVu.DataSource = lstLoaiDichVu;
            cmbLoaiDichVu.DisplayMember = "TenLoaiDichVu";
            cmbLoaiDichVu.ValueMember = "MaLoaiDichVu";
        }

        

        private void cmbLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiDichVu.SelectedItem == null)
            {
                return;
            }
            LoaiDichVu_DTO ldvDTO = (LoaiDichVu_DTO)cmbLoaiDichVu.SelectedItem;
            cmbTenDichVu.DataSource = DichVu_BLL.HienThiTenDichVuTheoMaDichVu(ldvDTO.MaLoaiDichVu);
            cmbTenDichVu.DisplayMember = "TenDichVu";
            cmbTenDichVu.ValueMember = "MaDichVu";
        }

        private void cmbGiaDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGiaDichVu.SelectedItem == null)
            {
                return;
            }
            DichVu_DTO dvDTO = (DichVu_DTO)cmbGiaDichVu.SelectedItem;
            cmbDonViTinh.DataSource = DichVu_BLL.HienThiDonViTinh(dvDTO.MaDichVu);
            cmbDonViTinh.DisplayMember = "TenDonVi";
            cmbDonViTinh.ValueMember = "MaDonVi";
        }

        private void cmbTenDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenDichVu.SelectedItem == null)
            {
                return;
            }
            DichVu_DTO dvDTO = (DichVu_DTO)cmbTenDichVu.SelectedItem;
            cmbGiaDichVu.DataSource = DichVu_BLL.HienThiGiaDichVuLenComboBox(dvDTO.MaDichVu);
            cmbGiaDichVu.DisplayMember = "DonGia";
            cmbGiaDichVu.ValueMember = "MaDichVu";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DichVu_DTO dvDTO = new DichVu_DTO();
            try
            {
                dvDTO.MaSuDungDichVu = txtMaSDDichVu.Text;
                dvDTO.MaDichVu = (string)cmbTenDichVu.SelectedValue;
                dvDTO.SoLuong = txtSoLuong.Text;
                dvDTO.ThanhTien = int.Parse(txtSoLuong.Text) * int.Parse(cmbGiaDichVu.Text);

                int check = DichVu_BLL.CapNhatDichVu(dvDTO);
                if (check > 0)
                {
                    
                    XtraMessageBox.Show("Cập nhật thành công!!");
                    HienThiDanhSachCacDichVuCanCapNhat();
                }
                else
                {
                    XtraMessageBox.Show("Cập nhật thất bại!!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

           
        }

        private void dgvChiTietDichVu_Click(object sender, EventArgs e)
        {
            if (dgvChiTietDichVu.SelectedRows != null)
            {
                DataGridViewRow row = dgvChiTietDichVu.SelectedRows[0];
                txtMaSDDichVu.Text = row.Cells["MaSuDungDichVu"].Value.ToString();
                cmbLoaiDichVu.Text = row.Cells["TenLoaiDichVu"].Value.ToString();
                cmbTenDichVu.Text = row.Cells["TenDichVu"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSDDV = txtMaSDDichVu.Text; 
            if(maSDDV == "")
            {
                XtraMessageBox.Show("Không có dữ liệu để xóa");
                
            }
            else
            {
                int check = DichVu_BLL.XoaDichVu(maSDDV);
                if(check>0)
                {
                    HienThiDanhSachCacDichVuCanCapNhat();
                    XtraMessageBox.Show("Đã xóa thành công 1 dịch vụ", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Xóa 1 dịch vụ thất bại", "Thông báo");
                }

            }
        }
    }
}