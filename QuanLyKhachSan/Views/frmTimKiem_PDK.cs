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
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace QuanLyKhachSan.Views
{
    public partial class frmTimKiem_PDK : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiem_PDK()
        {
            InitializeComponent();
        }

        private void frmTimKiem_PDK_Load(object sender, EventArgs e)
        {
            HienThiMaPhieuDK_TenPhieuDKLenComboBox();
            LayMaPhieuDKDoLenTextBox();
        }
        private void HienThiMaPhieuDK_TenPhieuDKLenComboBox()
        {
            cmbTimTheo.Text = "Mã Phiếu Đăng Ký";
        }
        
        private void LayMaPhieuDKDoLenTextBox()
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            DataTable dt = PhieuDangKy_BLL.LayMaPhieuDK();
            foreach (DataRow item in dt.Rows)
            {
                auto.Add(item[0].ToString());
            }
            txtTuKhoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTuKhoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTuKhoa.AutoCompleteCustomSource = auto;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimTheo.Text == "Mã Phiếu Đăng Ký")
            {
                dgvPhieuDangKy.DataSource = PhieuDangKy_BLL.TimMaPhieuDK(txtTuKhoa.Text);
                dgvPhieuDangKy.Columns[10].Visible = false;
                dgvPhieuDangKy.Columns[11].Visible = false;
            } 
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"SERVER = DESKTOP-5HGTV4A; uid = sa; pwd = 12112014; DATABASE = QuanLyKhachSan");
            conn.Open();
            string sql = "select * from PhieuDangKy where MaPhieuDK = '"+txtTuKhoa.Text+"'";
            SqlCommand command = new SqlCommand(sql, conn);

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