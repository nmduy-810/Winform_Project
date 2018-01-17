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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        List<NhanVien_DTO> lstNhanVien;
        List<ChucVu_DTO> lstChucVu;
        int pos = 0;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachCacNhanVien(pos);
            HienThiTenChucVuLenComboBox();
        }
        private void HienThiDanhSachCacNhanVien(int index)
        {
            lstNhanVien = NhanVien_BLL.HienThiDanhSachCacNhanVien(index);
            dgvNhanVien.DataSource = lstNhanVien;
            dgvNhanVien.Columns[8].Visible = false;
        }
        private void HienThiLaiDuLieuTrenGridView()
        {
            dgvNhanVien.DataSource = typeof(List<NhanVien_DTO>);
            dgvNhanVien.DataSource = lstNhanVien;
        }
        private void HienThiTenChucVuLenComboBox()
        {
            lstChucVu = ChucVu_BLL.HienThiTenChucVuLenComboBox();
            cmbMaChucVu.DataSource = lstChucVu;
            cmbMaChucVu.DisplayMember = "TenChucVu";
            cmbMaChucVu.ValueMember = "MaChucVu";
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string errorS = "";
            try
            {
                NhanVien_DTO nvDTO = new NhanVien_DTO();
                if(txtMaNV.Text.Trim() != "" )
                {
                    if(NhanVien_BLL.KiemTraMa(txtMaNV.Text)==1)
                    {
                        errorS += "Mã nhân viên bị trùng!!\n";
                    }
                    else
                    {
                        nvDTO.MaNV = txtMaNV.Text;
                    }
          
                }
                else
                {
                    errorS += "Chưa nhập mã nhân viên!!\n";
                }
                if (txtTenNV.Text.Trim() != "")
                {
                    nvDTO.TenNhanVien = txtTenNV.Text;
                }
                else
                {
                    errorS += "Chưa nhập tên nhân viên!!\n";
                }
                if (dtpNgaySinh.Text.Trim() != "")
                {
                    nvDTO.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
                }
                else
                {
                    errorS += "Chưa nhập ngày sinh nhân viên!!\n";
                }
                if (txtDiaChi.Text.Trim() != "")
                {

                    nvDTO.DiaChi = txtDiaChi.Text;
                }
                else
                {
                    errorS += "Chưa nhập địa chỉ nhân viên!!\n";
                }
                if (txtCMND.Text.Trim() != "")
                {
                    if(IsNumber(txtCMND.Text)==true)
                    {
                        nvDTO.CMND = txtCMND.Text;
                    }
                    else
                    {
                        errorS += "CMND không hợp lệ!!\n";
                    }
                }
                else
                {
                    errorS += "Chưa nhập CMND nhân viên!!\n";
                }
                if (rdbNam.Checked)
                {
                    nvDTO.GioiTinh = "Nam";
                }
                else nvDTO.GioiTinh = "Nữ";
                if (txtSDT.Text.Trim() != "")
                {
                    if(IsNumber(txtSDT.Text)==true)
                    {
                        nvDTO.SDT = txtSDT.Text;
                    }
                    else
                    {
                        errorS += "Số điện thoại không hợp lệ!!\n";
                    }
                }
                else
                {
                    errorS += "Chưa nhập SDT nhân viên!!\n";
                }
                if(cmbMaChucVu.SelectedValue != null)
                {
                    nvDTO.MaChucVu = (string)cmbMaChucVu.SelectedValue;
                }
                else
                {
                    errorS += "Chưa chọn chức vụ nhân viên!!\n";
                }
                if(errorS!= "")
                {
                    MessageBox.Show(errorS,"Thông báo lỗi");
                    return;
                }

          
                int check = NhanVien_BLL.ThemNhanVien(nvDTO);

                if (check > 0)
                {
                    HienThiDanhSachCacNhanVien(pos);
                    XtraMessageBox.Show("Thêm 1 nhân viên thành công!", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Thêm 1 nhân viên thất bại!", "Thông báo");
                    return;
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            btnXoaNV.Enabled = false;
            string maNV = txtMaNV.Text;
            if(maNV == "")
            {
                XtraMessageBox.Show("Chưa chọn dữ liệu để xóa");

            }
            if(NhanVien_BLL.XoaNhanVien(maNV) == 1)
            {
                DialogResult _dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (_dr == DialogResult.Yes)
                {
                    NhanVien_DTO nvDTODelete = lstNhanVien.Single(n => n.MaNV == maNV);
                    lstNhanVien.Remove(nvDTODelete);
                    HienThiDanhSachCacNhanVien(pos);
                    XtraMessageBox.Show("Đã xóa 1 nhân viên thành công!", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Xóa 1 nhân viên thất bại!!! Kiểm tra lại dữ liệu!", "Thông báo");
                }
            }

           

        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if(dgvNhanVien.SelectedRows!=null)
            {
                btnXoaNV.Enabled = true;
                btmCapNhatNV.Enabled = true;
                DataGridViewRow _row = dgvNhanVien.SelectedRows[0];
                txtMaNV.Text = _row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = _row.Cells["TenNhanVien"].Value.ToString();
                dtpNgaySinh.Text = Convert.ToDateTime(_row.Cells["NgaySinh"].Value.ToString()).ToShortDateString();
                txtDiaChi.Text = _row.Cells["DiaChi"].Value.ToString();
                txtCMND.Text = _row.Cells["CMND"].Value.ToString();
                if (_row.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else rdbNu.Checked = true;
                txtSDT.Text = _row.Cells["SDT"].Value.ToString();
                cmbMaChucVu.SelectedValue = _row.Cells["MaChucVu"].Value.ToString();
            }
        }

        private void btmCapNhatNV_Click(object sender, EventArgs e)
        {
            btmCapNhatNV.Enabled = false;
            NhanVien_DTO nvDTO = new NhanVien_DTO();
            nvDTO.MaNV = txtMaNV.Text;
            nvDTO.TenNhanVien = txtTenNV.Text;
            nvDTO.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
            nvDTO.DiaChi = txtDiaChi.Text;
            nvDTO.CMND = txtCMND.Text;
            if (rdbNam.Checked)
            {
                nvDTO.GioiTinh = "Nam";
            }
            else nvDTO.GioiTinh = "Nữ";
            nvDTO.SDT = txtSDT.Text;
            nvDTO.MaChucVu = (string)cmbMaChucVu.SelectedValue;
            if(NhanVien_BLL.CapNhatNhanVien(nvDTO) == 1)
            {
                NhanVien_DTO nvDTOUpdate = lstNhanVien.Single(n => n.MaNV == nvDTO.MaNV);
                nvDTOUpdate.MaNV = nvDTO.MaNV;
                nvDTOUpdate.TenNhanVien = nvDTO.TenNhanVien;
                nvDTOUpdate.NgaySinh = nvDTO.NgaySinh;
                nvDTOUpdate.DiaChi = nvDTO.DiaChi;
                nvDTOUpdate.CMND = nvDTO.CMND;
                nvDTOUpdate.GioiTinh = nvDTO.GioiTinh;
                nvDTOUpdate.SDT = nvDTO.SDT;
                nvDTOUpdate.MaChucVu = nvDTO.MaChucVu;

                HienThiDanhSachCacNhanVien(pos);
                XtraMessageBox.Show("Cập nhật 1 nhân viên thành công!", "Thông báo");

            }
            else
            {
                XtraMessageBox.Show("Cập nhật 1 nhân viên thất bại. Xin xem lại dữ liệu cần cập nhật!", "Thông báo");
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            dgvNhanVien.Rows[pos].Selected = true;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if(pos >=0)
            {
                if(pos !=0)
                {
                    dgvNhanVien.Rows[pos].Selected = false;
                    dgvNhanVien.Rows[--pos].Selected = true;
                }
                else
                {
                    MessageBox.Show("END");
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(pos < dgvNhanVien.RowCount)
            {
                if(pos < dgvNhanVien.Rows.Count -1)
                {
                    dgvNhanVien.Rows[pos].Selected = false;
                    dgvNhanVien.Rows[++pos].Selected = true;                   
                }
                else
                {
                    MessageBox.Show("END");
                }

            }
           
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = dgvNhanVien.Rows.Count - 1;
            dgvNhanVien.Rows[pos].Selected = true;
        }
    }
}