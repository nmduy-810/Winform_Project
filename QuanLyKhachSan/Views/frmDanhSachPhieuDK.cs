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
    public partial class frmDanhSachPhieuDK : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachPhieuDK()
        {
            InitializeComponent();
        }
        List<PhieuDangKy_DTO> lstPDK = new List<PhieuDangKy_DTO>();
        private void frmDanhSachPhieuDK_Load(object sender, EventArgs e)
        {
            HienThiDanhSachCacPhieuDK();
        }
        private void HienThiDanhSachCacPhieuDK()
        {
            lstPDK = PhieuDangKy_BLL.HienThiDanhSachCacPhieuDK();
            dgvDanhSachCacPhieuDK.DataSource = lstPDK;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"SERVER = DESKTOP-5HGTV4A; uid = sa; pwd = 12112014; DATABASE = QuanLyKhachSan");
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM PhieuDangKy", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet("tbPhieuDangKy");
            adapter.Fill(ds, "tbPhieuDangKy");
            conn.Close();

            rpPhieuDangKy rp = new rpPhieuDangKy();
            rp.DataSource = ds;
            rp.DataMember = ds.Tables["tbPhieuDangKy"].TableName;
            rp.ShowPreview();
        }
    }
}