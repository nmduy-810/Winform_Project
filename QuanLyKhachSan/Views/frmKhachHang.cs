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
using System.Globalization;
using System.Data.SqlClient;
using DTO;
using BLL;
using QuanLyKhachSan.Views;
using DevExpress.XtraReports.UI;
namespace QuanLyKhachSan
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        List<KhachHang_DTO> lstKhachHangDTO = new List<KhachHang_DTO>();
        DataTable table = new DataTable();
        int pos = 0;
        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {           
            var lstCountries = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(p => new RegionInfo(p.Name).EnglishName).Distinct().OrderBy(s => s).ToList();

            cmbQuocTich.DataSource = lstCountries;

            HienThiDuLieuKhachHang(pos);


        }

        private void HienThiDuLieuKhachHang(int pos)
        {
            lstKhachHangDTO = KhachHang_BLL.LoadKhachHang(pos);
            dgvKhachHang.DataSource = lstKhachHangDTO;
            dgvKhachHang.Columns[8].Visible = false;
            dgvKhachHang.Columns[9].Visible = false;
            dgvKhachHang.Columns[10].Visible = false;

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


        private void btnLuuKH_Click(object sender, EventArgs e)
        {          
            string errorS = "" ;
            try
            {
                KhachHang_DTO khDTO = new KhachHang_DTO();
                if (txtMaKH.Text.Trim() != "")
                {
                    if (KhachHang_BLL.KiemTraMa(txtMaKH.Text) == 1)
                    {
                        errorS += "Mã khách hàng đã bị trùng. Xin kiểm tra lại mã khách hàng!!\n";
                    }
                    else
                    {
                        khDTO.MaKhachHang = txtMaKH.Text;
                    }

                }
                else
                {
                    errorS += "Chưa nhập thông tin cho khách hàng. Hãy nhập thông tin để tiếp tục!!\n";

                }
                if (txtTenKH.Text.Trim() != "")
                {
                    khDTO.TenKhachHang = txtTenKH.Text;
                }
                else
                {
                    errorS += "Chưa nhập tên khách hàng. Hãy nhập thông tin để tiếp tục!!\n";
                }

                
                if(dtpNgaySinh.Text.Trim() !="")
                {
                    khDTO.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text.ToString());
                }
                else
                {
                    errorS += "Chưa nhập ngày sinh của khách hàng. Hãy nhập thông tin để tiếp tục!!\n";
                }
               


                if (rdbNam.Checked)
                {
                    khDTO.GioiTinh = "Nam";
                }
                else khDTO.GioiTinh = "Nữ";

                if (txtCMND.Text.Trim() != "")
                {

                    if (IsNumber(txtCMND.Text) == true)
                    {
                        khDTO.CMND = txtCMND.Text;
                    }
                    else
                    {

                        errorS += "'"+txtCMND.Text +"' không hợp lệ. Dữ liệu phải là số!!!\n";

                    }
                }
                else
                {

                    errorS += "Chưa nhập CMND của khách hàng. Hãy nhập CMND để tiếp tục!!\n";

                }

                if(txtDiaChi.Text.Trim() != "")
                {
                    khDTO.DiaChi = txtDiaChi.Text;
                }
                else
                {
                    errorS += "Chưa nhập địa chỉ của khách hàng. Hãy nhập địa chỉ để tiếp tục!!\n";
                }

                if (txtDienThoai.Text.Trim() != "")
                {

                    if (IsNumber(txtCMND.Text) == true)
                    {
                        khDTO.SDT = txtDienThoai.Text;
                    }
                    else
                    {

                        errorS += "'"+txtDienThoai.Text+"' không hợp lệ. Dữ liệu phải là số!!!\n";

                    }
                }
                else
                {

                    errorS += "Chưa nhập số điện thoại của khách hàng. Hãy nhập số điện thoại để tiếp tục!!\n";

                }

                if (errorS != "")
                {
                    MessageBox.Show(errorS, "Thông báo lỗi");
                    return;
                }


                khDTO.QuocTich = cmbQuocTich.Text;

                int check = KhachHang_BLL.ThemKhachHang(khDTO);

                if (check > 0)
                {
                    btnLuuKH.Enabled = true;
                    HienThiDuLieuKhachHang(pos);
                    XtraMessageBox.Show("Lưu thành công!", "Thông báo");



                }
                else
                {
                    XtraMessageBox.Show("Lưu thất bại!", "Thông báo");
                    return;
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            

        }

        private void btnHuyKH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            btnSuaKH.Enabled = false;
            KhachHang_DTO khDTO = new KhachHang_DTO();
            try
            {
                
                khDTO.MaKhachHang = txtMaKH.Text;
                khDTO.TenKhachHang = txtTenKH.Text;
                khDTO.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
                if (rdbNam.Checked)
                {
                    khDTO.GioiTinh = "Nam";
                }
                else khDTO.GioiTinh = "Nữ";

                khDTO.CMND = txtCMND.Text;
                khDTO.DiaChi = txtDiaChi.Text;
                khDTO.SDT = txtDienThoai.Text;
                khDTO.QuocTich = cmbQuocTich.Text;
                
                try
                {
                    int check = KhachHang_BLL.SuaKhachHang(khDTO);
                    
                                
                    if (check > 0)
                    {
                        KhachHang_DTO khDTOUpdate = lstKhachHangDTO.Single(n => n.MaKhachHang == khDTO.MaKhachHang);
                        khDTOUpdate.TenKhachHang = khDTO.TenKhachHang;
                        khDTOUpdate.NgaySinh = khDTO.NgaySinh;
                        khDTOUpdate.GioiTinh = khDTO.GioiTinh;
                        khDTOUpdate.CMND = khDTO.CMND;
                        khDTOUpdate.DiaChi = khDTO.DiaChi;
                        khDTOUpdate.SDT = khDTO.CMND;
                        khDTOUpdate.QuocTich = khDTO.QuocTich;
                        HienThiDuLieuKhachHang(pos);
                        XtraMessageBox.Show("Sửa thành công", "Thông báo");

                    }
                    else
                    {
                        XtraMessageBox.Show("Sửa thất bại", "Thông báo");
                        return;
                    }
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Error : " + ex.Message);
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            
            

        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {

            btnXoaKH.Enabled = false;
            string maKH = txtMaKH.Text;
            if(maKH == "")
            {
                XtraMessageBox.Show("Chưa chọn dữ liệu để xóa", "Thông báo");
            }
            if(KhachHang_BLL.XoaKhachHang(maKH) == 1)
            {


                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(dr == DialogResult.Yes)
                {
                    KhachHang_DTO khDTODelete = lstKhachHangDTO.Single(n => n.MaKhachHang == maKH);
                    lstKhachHangDTO.Remove(khDTODelete);
                    HienThiDuLieuKhachHang(pos);
                    XtraMessageBox.Show("Xóa thành công", "Thông báo");
                }              
   
            }
            else
            {
                XtraMessageBox.Show("Xóa thất bại", "Thông báo");
            }   

        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhachHang.SelectedRows != null)
                {
                    btnSuaKH.Enabled = true;
                    btnXoaKH.Enabled = true;
                    DataGridViewRow _row = dgvKhachHang.SelectedRows[0];
                    txtMaKH.Text = _row.Cells["MaKH"].Value.ToString();
                    txtTenKH.Text = _row.Cells["TenKH"].Value.ToString();
                    dtpNgaySinh.Text = Convert.ToDateTime(_row.Cells["NgaySinh"].Value.ToString()).ToShortDateString();
                    if (_row.Cells["GioiTinh"].Value.ToString() == "Nam")
                    {
                        rdbNam.Checked = true;
                    }
                    else rdbNu.Checked = true;


                    txtCMND.Text = _row.Cells["CMND"].Value.ToString();
                    txtDiaChi.Text = _row.Cells["DiaChi"].Value.ToString();
                    txtDienThoai.Text = _row.Cells["SDT"].Value.ToString();
                    cmbQuocTich.Text = _row.Cells["QuocTich"].Value.ToString();
                }
            }
            catch (Exception)
            {

                return;
            }
            

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(pos < dgvKhachHang.RowCount)
            {
                if(pos!=dgvKhachHang.RowCount-1)
                {
                    dgvKhachHang.Rows[pos].Selected = false;
                    dgvKhachHang.Rows[++pos].Selected = true;
                }
                else
                {
                    MessageBox.Show("End");
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(pos>=0)
            {
                if(pos!=0)
                {
                    dgvKhachHang.Rows[pos].Selected = false;
                    dgvKhachHang.Rows[--pos].Selected = true;
                }
                else
                {
                    MessageBox.Show("End");
                }
            }
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            dgvKhachHang.Rows[pos].Selected = true;
           
        }

        private void btnLast_Click(object sender, EventArgs e)
        {

            pos = dgvKhachHang.Rows.Count - 1;
            dgvKhachHang.Rows[pos].Selected = true;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Text = "";
            txtDienThoai.Text = "";
            cmbQuocTich.Text = "";
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            


        }
    }
}