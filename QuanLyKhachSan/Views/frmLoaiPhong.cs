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
using System.Globalization;

namespace QuanLyKhachSan.Views
{
    public partial class frmLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }
        int pos = 0;
        List<LoaiPhong_DTO> lstThongTinLoaiPhong;
        List<LoaiPhong_DTO> lstGiaLoaiPhong = new List<LoaiPhong_DTO>();

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            HienThiThongTinLoaiPhong(pos);
            HienThiGiaLoaiPhongLenComboBox();

        }
        private void HienThiThongTinLoaiPhong(int index)
        {
            lstThongTinLoaiPhong = LoaiPhong_BLL.HienThiThongTinLoaiPhong(index);
            dgvLoaiPhong.DataSource = lstThongTinLoaiPhong;
            dgvLoaiPhong.Columns[3].DefaultCellStyle.Format = "#,## VND";
        }

        private void HienThiGiaLoaiPhongLenComboBox()
        {
            lstGiaLoaiPhong = LoaiPhong_BLL.HienThiGiaLoaiPhongLenComboBox();
            cmbGiaLoaiPhong.DataSource = lstGiaLoaiPhong;
            cmbGiaLoaiPhong.DisplayMember = "GiaLoaiPhong";
            cmbGiaLoaiPhong.ValueMember = "MaLoaiPhong";
            cmbGiaLoaiPhong.FormatString = "#,## VND";

        }

        private void HienThiDonViTinhLenComboBox()
        {
            lstGiaLoaiPhong = LoaiPhong_BLL.HienThiGiaLoaiPhongLenComboBox();
            cmbGiaLoaiPhong.DataSource = lstGiaLoaiPhong;
            cmbGiaLoaiPhong.DisplayMember = "GiaLoaiPhong";
            cmbGiaLoaiPhong.ValueMember = "MaLoaiPhong";
            cmbGiaLoaiPhong.FormatString = "#,## VND";

        }
        private void HienThiLaiDuLieuTrenGridView()
        {
            dgvLoaiPhong.DataSource = typeof(List<LoaiPhong_DTO>);
            dgvLoaiPhong.DataSource = lstThongTinLoaiPhong;
            dgvLoaiPhong.Columns[3].DefaultCellStyle.Format = "#,## VND";
        }

        private void btnCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {
            LoaiPhong_DTO lphgDTO = new LoaiPhong_DTO();
            lphgDTO.MaLoaiPhong = txtMaLoaiPhong.Text;
            lphgDTO.TenLoaiPhong = txtTenLoaiPhong.Text;
            lphgDTO.TrangThietBi = txtTrangThietBi.Text;
            string tmp = cmbGiaLoaiPhong.Text;
            string[] formatGia = tmp.Split(' ');
            string[] ghepChuoi = formatGia[0].Split(',');
            string saveChuoi = "";
            foreach (string item in ghepChuoi)
            {
                saveChuoi += item;
            }

            double GiaLoaiPhong = double.Parse(saveChuoi);
            lphgDTO.GiaLoaiPhong = Convert.ToInt32(GiaLoaiPhong);
            lphgDTO.MoTa = txtMoTa.Text;
            if(LoaiPhong_BLL.CapNhatLoaiPhong(lphgDTO)==1)
            {
                LoaiPhong_DTO lphgDTOUpdate = lstThongTinLoaiPhong.Single(n => n.MaLoaiPhong == lphgDTO.MaLoaiPhong);
                lphgDTOUpdate.MaLoaiPhong = lphgDTO.MaLoaiPhong;
                lphgDTOUpdate.TenLoaiPhong = lphgDTO.TenLoaiPhong;
                lphgDTOUpdate.TrangThietBi = lphgDTO.TrangThietBi;
                lphgDTOUpdate.GiaLoaiPhong = lphgDTO.GiaLoaiPhong;
                lphgDTOUpdate.MoTa = lphgDTO.MoTa;
                HienThiLaiDuLieuTrenGridView();
                XtraMessageBox.Show("Cập nhật loại phòng thành công", "Thông báo");
            }
            else
            {
                XtraMessageBox.Show("Cập nhật loại phòng thất bại", "Thông báo");
            }

           
        }

        //Thêm loại phòng
        //private void btnThemPhong_Click(object sender, EventArgs e)
        //{
        //    LoaiPhong_DTO lphgDTO = new LoaiPhong_DTO();
        //    lphgDTO.MaLoaiPhong = txtMaLoaiPhong.Text;
        //    lphgDTO.TenLoaiPhong = txtTenLoaiPhong.Text;
        //    lphgDTO.TrangThietBi = txtTrangThietBi.Text;
        //    //Xử lý chuyển kiểu int sang kiểu chuỗi
        //    string tmp = cmbGiaLoaiPhong.Text;
        //    string[] formatGia = tmp.Split(' ');
        //    string[] ghepChuoi = formatGia[0].Split(',');
        //    string saveChuoi = "";
        //    foreach (string item in ghepChuoi)
        //    {
        //        saveChuoi += item;
        //    }

        //    double GiaLoaiPhong = double.Parse(saveChuoi);          
        //    lphgDTO.GiaLoaiPhong = Convert.ToInt32(GiaLoaiPhong);
        //    lphgDTO.MoTa = txtMoTa.Text;
        //    if(LoaiPhong_BLL.ThemLoaiPhong(lphgDTO) == 1)
        //    {
        //        lstThongTinLoaiPhong.Add(lphgDTO);
        //        HienThiLaiDuLieuTrenGridView();
        //        XtraMessageBox.Show("Thêm 1 loại phòng thành công", "Thông báo");

        //    }
        //    else
        //    {
        //        XtraMessageBox.Show("Thêm 1 loại phòng thất bại. Xin kiểm tra lại!!!", "Thông báo");
        //    }

            
        //}

        private void dgvLoaiPhong_Click(object sender, EventArgs e)
        {
            if(dgvLoaiPhong.SelectedRows!=null)
            {
                DataGridViewRow _row = dgvLoaiPhong.SelectedRows[0];
                txtMaLoaiPhong.Text = _row.Cells["MaLoaiPhong"].Value.ToString();
                txtTenLoaiPhong.Text = _row.Cells["TenLoaiPhong"].Value.ToString();
                txtTrangThietBi.Text = _row.Cells["TrangThietBi"].Value.ToString();

                //Xử lý chuyển kiểu int sang kiểu chuỗi
                string tmp = _row.Cells["GiaLoaiPhong"].Value.ToString();
                string[] formatGia = tmp.Split(' ');
                string[] ghepChuoi = formatGia[0].Split(',');
                string saveChuoi = "";
                foreach (string item in ghepChuoi)
                {
                    saveChuoi += item;
                }
                double GiaLoaiPhong = double.Parse(saveChuoi);
                saveChuoi = String.Format("{0:#,### VND}", GiaLoaiPhong);

                cmbGiaLoaiPhong.Text = saveChuoi;
                txtMoTa.Text = _row.Cells["MoTa"].Value.ToString();
            }
        }

        private void btnXoaLoaiPhong_Click(object sender, EventArgs e)
        {
            string maLoaiPhong = txtMaLoaiPhong.Text;
            if(maLoaiPhong == "")
            {
                XtraMessageBox.Show("Chưa chọn dữ liệu để xóa", "Thông báo");
            }
            if(LoaiPhong_BLL.XoaLoaiPhong(maLoaiPhong) == 1)
            {
                DialogResult _dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(_dr == DialogResult.Yes)
                {
                    LoaiPhong_DTO lphgDTODelete = lstThongTinLoaiPhong.Single(n => n.MaLoaiPhong == maLoaiPhong);
                    lstThongTinLoaiPhong.Remove(lphgDTODelete);
                    HienThiLaiDuLieuTrenGridView();
                    XtraMessageBox.Show("Đã xóa 1 loại phòng thành công", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Xóa 1 loại phòng thất bai!! Xin kiểm tra lại dữ liệu cần xóa", "Thông báo");
                }


            }
        }
       

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            dgvLoaiPhong.Rows[0].Selected = true;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                if (pos != 0)
                {
                    dgvLoaiPhong.Rows[pos].Selected = false;
                    dgvLoaiPhong.Rows[--pos].Selected = true;
                }
                else
                {
                    XtraMessageBox.Show("End");
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pos < dgvLoaiPhong.RowCount)
            {
                if (pos != dgvLoaiPhong.Rows.Count - 1)
                {
                    dgvLoaiPhong.Rows[pos].Selected = false;
                    dgvLoaiPhong.Rows[++pos].Selected = true;
                }
                else
                {
                    XtraMessageBox.Show("End");
                }
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = dgvLoaiPhong.Rows.Count - 1;
            dgvLoaiPhong.Rows[pos].Selected = true;
        }
    }
}