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
    public partial class frmTimKiem_Phong : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiem_Phong()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Phong_Load(object sender, EventArgs e)
        {
            HienThiMaPhongLenComboBox();
        }
        private void HienThiMaPhongLenComboBox()
        {
            cmbTimTheo.Text = "Mã Phòng";
        }

        private void cmbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            DataTable dt = new DataTable();
            dt = Phong_BLL.LayThuocTinhPhong();
            foreach (DataRow item in dt.Rows)
            {
                if (cmbTimTheo.SelectedIndex == 0)
                {
                    auto.Add(item[0].ToString());
                }
                else if(cmbTimTheo.SelectedIndex == 1)
                {
                    auto.Add(item[1].ToString());
                }

            }
            txtTuKhoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTuKhoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTuKhoa.AutoCompleteCustomSource = auto;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimTheo.SelectedIndex == 0)
            {
                dgvPhong.DataSource = Phong_BLL.TimMaPhong(txtTuKhoa.Text);
            }
            else if (cmbTimTheo.SelectedIndex == 1)
            {
                dgvPhong.DataSource = Phong_BLL.TimTenPhong(txtTuKhoa.Text);
            }
        }
    }
}