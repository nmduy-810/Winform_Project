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
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace QuanLyKhachSan.Views
{
    public partial class frmTimKiem_KH : DevExpress.XtraEditors.XtraForm
    {
       
        public frmTimKiem_KH()
        {
            InitializeComponent();
           
        }

        private void frmTimKiem_KH_Load(object sender, EventArgs e)
        {
            HienThiMaKH_TenKHLenComboBox();
            LayMaKhachHangDoLenTextBox();
        }

        KhachHang_DTO khDTO = new KhachHang_DTO();
        private void HienThiMaKH_TenKHLenComboBox()
        {
            cmbTimTheo.Text = "Mã Khách Hàng";
        }
        private void LayMaKhachHangDoLenTextBox()
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            DataTable dt = KhachHang_BLL.LayMaKhachHang();
            foreach (DataRow item in dt.Rows)
            {
                auto.Add(item[0].ToString());
                auto.Add(item[1].ToString());
            }
            txtTuKhoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTuKhoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTuKhoa.AutoCompleteCustomSource = auto;


        }

        

        private void cmbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {            
            
            if(cmbTimTheo.Text == "Mã Khách Hàng")
            {
                dgvKhachHang.DataSource = KhachHang_BLL.TimMaKhachHang(txtTuKhoa.Text);
                dgvKhachHang.Columns[8].Visible = false;
            }        

            if (cmbTimTheo.Text == "Tên Khách Hàng")
            {
                dgvKhachHang.DataSource = KhachHang_BLL.TimTenKhachHang(txtTuKhoa.Text);
                dgvKhachHang.Columns[8].Visible = false;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"SERVER = DESKTOP-5HGTV4A; uid = sa; pwd = 12112014; DATABASE = QuanLyKhachSan");
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM KhachHang WHERE MaKH = '"+txtTuKhoa.Text+"'", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet("tbKhachHang");
            adapter.Fill(ds, "tbKhachHang");
            conn.Close();

            rpKhachHang rp = new rpKhachHang();
            rp.DataSource = ds;
            rp.DataMember = ds.Tables["tbKhachHang"].TableName;
            rp.ShowPreview();
        }
    }
}