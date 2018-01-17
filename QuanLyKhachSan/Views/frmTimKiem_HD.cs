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
    public partial class frmTimKiem_HD : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiem_HD()
        {
            InitializeComponent();
        }

        private void frmTimKiem_HD_Load(object sender, EventArgs e)
        {
            HienThiMaHoaDon();
        }
        private void HienThiMaHoaDon()
        {
            cmbTimTheo.Text = "Mã Hóa Đơn";
        }

        private void cmbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            DataTable dt = new DataTable();
            dt = HoaDon_BLL.LayMaHoaDon();

            foreach (DataRow dr in dt.Rows)
            {
                if (cmbTimTheo.SelectedIndex == 0)
                {
                    auto.Add(dr[0].ToString());
                }
            }
            txtTuKhoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTuKhoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTuKhoa.AutoCompleteCustomSource = auto;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimTheo.SelectedIndex == 0)
            {
                dgvXuLyHD.DataSource = HoaDon_BLL.TimMaHoaDon(txtTuKhoa.Text);
            }

           
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"SERVER = DESKTOP-5HGTV4A; uid = sa; pwd = 12112014; DATABASE = QuanLyKhachSan");
            conn.Open();
            string sql = "select HD.MaHoaDon,HD.NgayThanhToan,CTHD.TienPhong,CTHD.TienDichVu,CTHD.PhuThu,CTHD.ThanhTien,HD.SoTienDaDatTruoc,HD.TongTienHoaDon,HD.MaNV from HoaDon as HD inner join ChiTietHoaDon as CTHD on HD.MaChiTietHoaDon = CTHD.MaChiTietHoaDon where HD.MaHoaDon = '" + txtTuKhoa.Text + "'";
            SqlCommand command = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet("tbHoaDon");
            adapter.Fill(ds, "tbHoaDon");
            conn.Close();



            rpHoaDon rp = new rpHoaDon();
            rp.DataSource = ds;
            rp.DataMember = ds.Tables["tbHoaDon"].TableName;
            rp.ShowPreview();

        }
    }
}