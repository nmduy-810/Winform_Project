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
    public partial class frmTimKiem_NV : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiem_NV()
        {
            InitializeComponent();
        }

        private void frmTimKiem_NV_Load(object sender, EventArgs e)
        {
            HienThiMaNVLenComboBox();
            //LayCacThuocTinhNVDoLenTextBox();
        }
        private void HienThiMaNVLenComboBox()
        {
            cmbTimTheo.Text = "Mã Nhân Viên";
        }
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            
            
            if (cmbTimTheo.SelectedIndex == 0)
            {
                dgvNhanVien.DataSource = NhanVien_BLL.LayMaNV(txtTuKhoa.Text);
                dgvNhanVien.Columns[8].Visible = false;
                dgvNhanVien.Columns[9].Visible = false;
                dgvNhanVien.Columns[10].Visible = false;
                dgvNhanVien.Columns[11].Visible = false;
            }
            else if (cmbTimTheo.SelectedIndex == 1)
            {
                dgvNhanVien.DataSource = NhanVien_BLL.LayTenNV(txtTuKhoa.Text);
                dgvNhanVien.Columns[8].Visible = false;
                dgvNhanVien.Columns[9].Visible = false;
                dgvNhanVien.Columns[10].Visible = false;
                dgvNhanVien.Columns[11].Visible = false;
            }

        }

        private void cmbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            DataTable dt = new DataTable();
            dt = NhanVien_BLL.LayThuocTinhNV();

            foreach (DataRow item in dt.Rows)
            {
                if (cmbTimTheo.SelectedIndex == 0)
                {
                    auto.Add(item[0].ToString());
                }
                else if (cmbTimTheo.SelectedIndex == 1)
                {
                    string[] LocTheoTen = item[1].ToString().Split(' ');
                    auto.Add(item[1].ToString().Split(' ')[LocTheoTen.Length - 1]);
                }


            }
            txtTuKhoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTuKhoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTuKhoa.AutoCompleteCustomSource = auto;
        }
    }
}