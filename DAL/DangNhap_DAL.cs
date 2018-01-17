using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DAL
{
    public class DangNhap_DAL
    {
        public static string LayTenDangNhap_MatKhau(string tendangnhap,string matkhau)
        {
            string id = "";
            try
            {
                string strTruyVan = string.Format("SELECT * from NhanVien where TenDangNhap = '" + tendangnhap + "' and MatKhau = '" + matkhau + "'");
                DataTable dt = new DataTable();
                dt = DataProvider.fillDataTable(strTruyVan);
                if(dt!=null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        id = dt.Rows[i]["MaNV"].ToString();
                    }
                }
               
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại :" + ex.Message);
            }
            
            return id;

        }

        public static string DoiMatKhau(string maNV,string tendangnhap, string matkhau)
        {
            string id = "";
            try
            {
                string strTruyVan = string.Format("update NhanVien set TenDangNhap = '"+tendangnhap+"', MatKhau = '"+matkhau+"' where MaNV = '"+maNV+"'");
                DataTable dt = new DataTable();
                dt = DataProvider.fillDataTable(strTruyVan);
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        id = dt.Rows[i]["MaNV"].ToString();
                        id = dt.Rows[i]["TenDangNhap"].ToString();
                        id = dt.Rows[i]["MatKhau"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại :" + ex.Message);
            }

            return id;

        }



        public static string LayMaQuyenHan(string maCanLay)
        {
            string id = "";
            try
            {
                string strTruyVan = string.Format("select * from NhanVien where MaNV = '"+maCanLay+"'");
                DataTable dt = new DataTable();
                dt = DataProvider.fillDataTable(strTruyVan);
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //Nếu tài khoản còn được sử dụng thì mới có mã quyền hạn
                        if(dt.Rows[i]["DinhChi"].ToString() == "False")
                        {
                            id = dt.Rows[i]["MaQuyenHan"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại :" + ex.Message);
            }

            return id;
        }

       
  
    }
}
