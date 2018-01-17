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
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        int pos = 0;
        List<ChucVu_DTO> lstChucVu;

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            HienThiDanhSachChucVu(pos);
        }
        private void HienThiDanhSachChucVu(int index)
        {
            lstChucVu = ChucVu_BLL.HienThiDanhSachChucVu(index);
            dgvChucVu.DataSource = lstChucVu;
            
        }
        private void HienThiLaiDuLieuTrenGridView()
        {
            dgvChucVu.DataSource = typeof(List<ChucVu_DTO>);
            dgvChucVu.DataSource = lstChucVu;
        }

        private void btnThemChucVu_Click(object sender, EventArgs e)
        {
            ChucVu_DTO cvDTO = new ChucVu_DTO();
            string errorS = "";
            if(txtMaChucVu.Text.Trim()!= "")
            {
                if (ChucVu_BLL.KiemTraMa(txtMaChucVu.Text) == 1)
                {
                    errorS += "Mã chức vụ bị trùng!!!\n";
                }
                else
                {
                    cvDTO.MaChucVu = txtMaChucVu.Text;
                }
   
            }
            else
            {
                errorS += "Chưa nhập mã chức vụ!!\n";
            }
            if(txtTenChucVu.Text.Trim() != "")
            {
                cvDTO.TenChucVu = txtTenChucVu.Text;
            }
            else
            {
                errorS += "Chưa nhập tên chức vụ!!\n";
            }
            if(errorS!= "")
            {
                XtraMessageBox.Show(errorS, "Thông báo lỗi");
                return;
            }
           
            
            if (ChucVu_BLL.ThemChucVu(cvDTO) == 1)
            {
                lstChucVu.Add(cvDTO);
                HienThiLaiDuLieuTrenGridView();
                XtraMessageBox.Show("Thêm 1 chức vụ thành công", "Thông báo");

            }
            else
            {
                XtraMessageBox.Show("Thêm 1 chức vụ thất bại", "Thông báo");
                return;
            }

        }

        private void btnCapNhatChucVu_Click(object sender, EventArgs e)
        {
            btnCapNhatChucVu.Enabled = false;
            ChucVu_DTO cvDTO = new ChucVu_DTO();
            cvDTO.MaChucVu = txtMaChucVu.Text;
            cvDTO.TenChucVu = txtTenChucVu.Text;
            if(ChucVu_BLL.CapNhatChucVu(cvDTO) == 1)
            {
                //ChucVu_DTO cvDTOUpdate = lstChucVu.Single(n => n.MaChucVu == cvDTO.MaChucVu);
                //cvDTOUpdate.MaChucVu = cvDTO.MaChucVu;
                //cvDTOUpdate.TenChucVu = cvDTO.TenChucVu;
                //HienThiLaiDuLieuTrenGridView();
                HienThiDanhSachChucVu(pos);
                XtraMessageBox.Show("Cập nhật chức vụ thành công", "Thông báo");
            }
            else
            {
                XtraMessageBox.Show("Cập nhật chức vụ thất bại", "Thông báo");
                return;
            }
        }

        private void btnXoaChucVu_Click(object sender, EventArgs e)
        {
            btnXoaChucVu.Enabled = false;
            string maChucVu = txtMaChucVu.Text;
            if(maChucVu == "")
            {
                XtraMessageBox.Show("Chưa chọn dữ liệu để xóa!!!");
            }
            if(ChucVu_BLL.XoaChucVu(maChucVu)==1)
            {
                DialogResult _dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(_dr == DialogResult.Yes)
                {
                    //ChucVu_DTO cvDTODelete = lstChucVu.Single(n => n.MaChucVu == maChucVu);
                    //lstChucVu.Remove(cvDTODelete);
                    //HienThiLaiDuLieuTrenGridView();
                    HienThiDanhSachChucVu(pos);
                    XtraMessageBox.Show("Đã xóa 1 chức vụ thành công", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Xóa chức vụ thất bại!! Kiểm tra lại dữ liệu cần xóa", "Thông báo");
                    return;
                }
            }

        }

        private void dgvChucVu_Click(object sender, EventArgs e)
        {
            if(dgvChucVu.SelectedRows!=null)
            {
                btnCapNhatChucVu.Enabled = true;
                btnXoaChucVu.Enabled = true;
                DataGridViewRow _row = dgvChucVu.SelectedRows[0];
                txtMaChucVu.Text = _row.Cells["MaChucVu"].Value.ToString();
                txtTenChucVu.Text = _row.Cells["TenChucVu"].Value.ToString();
            }
        }

    }
}