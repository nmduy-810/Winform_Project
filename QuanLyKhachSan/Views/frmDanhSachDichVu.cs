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
    public partial class frmDanhSachDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachDichVu()
        {
            InitializeComponent();
        }
        int pos = 0;

        private void frmDanhSachDichVu_Load(object sender, EventArgs e)
        {
            HienThiDanhSachDichVu();
        }
        private void HienThiDanhSachDichVu()
        {
            dgvDichVu.DataSource = DichVu_BLL.HienThiDanhSachCacDichVu(pos);
            dgvDichVu.Columns[6].Visible = false;
            dgvDichVu.Columns[7].Visible = false;
            dgvDichVu.Columns[8].Visible = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"SERVER = DESKTOP-5HGTV4A; uid = sa; pwd = 12112014; DATABASE = QuanLyKhachSan");
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM DichVu", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet("tbDichVu");
            adapter.Fill(ds, "tbDichVu");
            conn.Close();

            rpDichVu rp = new rpDichVu();
            rp.DataSource = ds;
            rp.DataMember = ds.Tables["tbDichVu"].TableName;
            rp.ShowPreview();
        }
    }
}