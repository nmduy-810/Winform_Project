using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;

namespace DAL
{
    public class KhachHang_DAL
    {
        public static List<KhachHang_DTO> LoadKhachHang(int index)
        {
            List<KhachHang_DTO> lstKhachHang = null;
            string strTruyVan = @" SELECT * FROM KhachHang where ISNULL(DaXacNhan,'false')  not in (1)";
            DataTable _dt = new DataTable();
            _dt = DataProvider.fillDataTable(strTruyVan);
            //Nếu database hợp lệ và có giá trị
            if (_dt != null && _dt.Rows.Count > 0)
            {

                if (lstKhachHang == null)
                {
                    lstKhachHang = new List<KhachHang_DTO>();

                }

                KhachHang_DTO khDTO;

                for (index = 0; index < _dt.Rows.Count; index++)
                {
                    khDTO = new KhachHang_DTO();
                    khDTO.MaKhachHang = _dt.Rows[index]["MaKH"].ToString();
                    khDTO.TenKhachHang = _dt.Rows[index]["TenKH"].ToString();
                    khDTO.NgaySinh = Convert.ToDateTime(_dt.Rows[index]["NgaySinh"].ToString());
                    if (khDTO.GioiTinh == "Nam")
                    {
                        khDTO.GioiTinh = _dt.Rows[index]["GioiTinh"].ToString();
                    }
                    else khDTO.GioiTinh = _dt.Rows[index]["GioiTinh"].ToString();

                    khDTO.CMND = _dt.Rows[index]["CMND"].ToString();
                    khDTO.DiaChi = _dt.Rows[index]["DiaChi"].ToString();
                    khDTO.SDT = _dt.Rows[index]["SDT"].ToString();
                    khDTO.QuocTich = _dt.Rows[index]["QuocTich"].ToString();

                    //Add customer 
                    lstKhachHang.Add(khDTO);
                }
                return lstKhachHang;

            }
            return null;


        }

        //Hiển thị danh sách các khách hàng đã xác nhận và có phòng
        public static List<KhachHang_DTO> HienThiDanhSachCacKhachHangDaCoPhong_KH()
        {
            List<KhachHang_DTO> lstKhachHang = new List<KhachHang_DTO>();
            try
            {
                string strTruyVan = string.Format("select PDK.MaPhieuDK,KH.MaKH,KH.TenKH,KH.GioiTinh,KH.NgaySinh,KH.DiaChi,KH.CMND,SDT,KH.QuocTich,PHG.MaPhong,PHG.TenPhong from PhieuDangKy as PDK,ChiTietLoaiPhong as CTLP, KhachHang as KH,Phong as PHG where PDK.MaPhieuDK = CTLP.MaPhieuDK and PDK.MaKH = KH.MaKH and CTLP.MaPhong = PHG.MaPhong and DaVaoPhong = 1 and PHG.TinhTrangPhong = 1");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    KhachHang_DTO khDTO = new KhachHang_DTO();
                    khDTO.MaKhachHang = _dt.Rows[i]["MaKH"].ToString();
                    khDTO.MaPhieuDK = _dt.Rows[i]["MaPhieuDK"].ToString();
                    khDTO.MaPhong = _dt.Rows[i]["MaPhong"].ToString();
                    khDTO.TenKhachHang = _dt.Rows[i]["TenKH"].ToString();
                    if (khDTO.GioiTinh == "Nam")
                    {
                        khDTO.GioiTinh = _dt.Rows[i]["GioiTinh"].ToString();
                    }
                    else khDTO.GioiTinh = _dt.Rows[i]["GioiTinh"].ToString();

                    khDTO.CMND = _dt.Rows[i]["CMND"].ToString();
                    khDTO.NgaySinh = Convert.ToDateTime(_dt.Rows[i]["NgaySinh"].ToString());
                    khDTO.DiaChi = _dt.Rows[i]["DiaChi"].ToString();
                    khDTO.SDT = _dt.Rows[i]["SDT"].ToString();
                    khDTO.QuocTich = _dt.Rows[i]["QuocTich"].ToString();
                    khDTO.TenPhong = _dt.Rows[i]["TenPhong"].ToString();

                    lstKhachHang.Add(khDTO);

                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            return lstKhachHang;
        }


        public static List<KhachHang_DTO> LoadKhachHang()
        {
            List<KhachHang_DTO> lstMaKhachHang = new List<KhachHang_DTO>();
            string strTruyVan = @"select distinct KH.MaKH, KH.TenKH,Kh.NgaySinh,KH.GioiTinh,KH.CMND,KH.QuocTich,KH.DiaChi,KH.SDT
            from PhieuDangKy as PDK, KhachHang as KH
             where PDK.MaKH = KH.MaKH";
            DataTable _dt = new DataTable();
            _dt = DataProvider.fillDataTable(strTruyVan);
            if (_dt != null && _dt.Rows.Count > 0)
            {

                if (lstMaKhachHang == null)
                {
                    lstMaKhachHang = new List<KhachHang_DTO>();

                }

                KhachHang_DTO khDTO;
                for (int index = 0; index < _dt.Rows.Count; index++)
                {
                    khDTO = new KhachHang_DTO();
                    khDTO.MaKhachHang = _dt.Rows[index]["MaKH"].ToString();
                    khDTO.TenKhachHang = _dt.Rows[index]["TenKH"].ToString();
                    khDTO.NgaySinh = Convert.ToDateTime(_dt.Rows[index]["NgaySinh"].ToString());
                    if (khDTO.GioiTinh == "Nam")
                    {
                        khDTO.GioiTinh = _dt.Rows[index]["GioiTinh"].ToString();
                    }
                    else khDTO.GioiTinh = _dt.Rows[index]["GioiTinh"].ToString();

                    khDTO.CMND = _dt.Rows[index]["CMND"].ToString();
                    khDTO.DiaChi = _dt.Rows[index]["DiaChi"].ToString();
                    khDTO.SDT = _dt.Rows[index]["SDT"].ToString();
                    khDTO.QuocTich = _dt.Rows[index]["QuocTich"].ToString();
                    lstMaKhachHang.Add(khDTO);
                }
                return lstMaKhachHang;
            }
            return null;
        }

        public static int KiemTraMa(string MaKH)
        {
            string strTruyVan = string.Format("SELECT * FROM KhachHang WHERE MaKH = '" + MaKH + "'");
            DataSet ds = new DataSet();
            ds = DataProvider.fillDataSet(strTruyVan);
            DataView dv = new DataView(ds.Tables[0]);
            if (dv.Count != 0)
            {
                return 1;
            }
            else return 0;

        }

        public static KhachHang_DTO LoadDuLieuKhachHang(string MaKH)
        {
            try
            {
                string strTruyVan = string.Format(@"SELECT * FROM KhachHang as KH
             WHERE Kh.MaKH = '" + MaKH + "'");

                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                KhachHang_DTO khDTO = new KhachHang_DTO();
                if (_dt != null)
                {
                    for (int index = 0; index < _dt.Rows.Count; index++)
                    {

                        khDTO.MaKhachHang = _dt.Rows[index]["MaKH"].ToString();
                        khDTO.TenKhachHang = _dt.Rows[index]["TenKH"].ToString();
                        khDTO.NgaySinh = Convert.ToDateTime(_dt.Rows[index]["NgaySinh"].ToString());
                        if (khDTO.GioiTinh == "Nam")
                        {
                            khDTO.GioiTinh = _dt.Rows[index]["GioiTinh"].ToString();
                        }
                        else khDTO.GioiTinh = _dt.Rows[index]["GioiTinh"].ToString();

                        khDTO.CMND = _dt.Rows[index]["CMND"].ToString();
                        khDTO.DiaChi = _dt.Rows[index]["DiaChi"].ToString();
                        khDTO.SDT = _dt.Rows[index]["SDT"].ToString();
                        khDTO.QuocTich = _dt.Rows[index]["QuocTich"].ToString();


                    }
                    return khDTO;

                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        public static int ThemKhachHang(KhachHang_DTO khDTO)
        {
            string strTruyVan = string.Format("INSERT INTO KhachHang(MaKH,TenKH,NgaySinh,GioiTinh,CMND,DiaChi,SDT,QuocTich) VALUES('{0}',N'{1}','{2}',N'{3}','{4}',N'{5}','{6}','{7}')", khDTO.MaKhachHang, khDTO.TenKhachHang, khDTO.NgaySinh, khDTO.GioiTinh, khDTO.CMND, khDTO.DiaChi, khDTO.SDT, khDTO.QuocTich);
            int count = DataProvider.ExecuteNonQuery(strTruyVan);

            return count;

        }

        public static int SuaKhachHang(KhachHang_DTO khDTO)
        {
            string strTruyVan = string.Format("UPDATE KhachHang SET TenKH = N'{0}',NgaySinh = '{1}',GioiTinh= N'{2}',CMND='{3}',DiaChi=N'{4}',SDT='{5}',QuocTich='{6}' WHERE MaKH='{7}' ", khDTO.TenKhachHang, khDTO.NgaySinh, khDTO.GioiTinh, khDTO.CMND, khDTO.DiaChi, khDTO.SDT, khDTO.QuocTich, khDTO.MaKhachHang);

            int count = DataProvider.ExecuteNonQuery(strTruyVan);

            return count;
        }
        public static int XoaKhachHang(string maKH)
        {
            string strTruyVan = "DELETE FROM KhachHang WHERE MaKH = '" + maKH + "'  ";
            int count = DataProvider.ExecuteNonQuery(strTruyVan);

            return count;
        }

        public static DataTable TimMaKhachHang(string MaKH)
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM KhachHang WHERE MaKH = '" + MaKH + "'");
                dt = DataProvider.fillDataTable(strTruyVan);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public static DataTable TimTenKhachHang(string tenKH)
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM KhachHang WHERE TenKH = N'" + tenKH + "'");
                dt = DataProvider.fillDataTable(strTruyVan);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public static DataTable LayMaKhachHang()
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT MaKH,TenKH from KhachHang");
                dt = DataProvider.fillDataTable(strTruyVan);
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

    }
}
