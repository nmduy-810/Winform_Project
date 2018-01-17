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
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Views
{
    public partial class frmDanhSachKH : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachKH()
        {
            InitializeComponent();
        }
        List<KhachHang_DTO> lstKH = new List<KhachHang_DTO>();

        private void frmDanhSachKH_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
        }

        private void HienThiDanhSachKhachHang()
        {
            lstKH = KhachHang_BLL.LoadKhachHang();
            dgvDanhSachKH.DataSource = lstKH;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"SERVER = DESKTOP-5HGTV4A; uid = sa; pwd = 12112014; DATABASE = QuanLyKhachSan");
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM KhachHang", conn);

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