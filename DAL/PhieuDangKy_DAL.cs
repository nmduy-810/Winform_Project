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
    public class PhieuDangKy_DAL
    {

        public static List<PhieuDangKy_DTO> HienThiDanhSachKhachHangTrongPDK(int index)
        {
            List<PhieuDangKy_DTO> lstPhieuDangKy = null;
            try
            {
                string strTruyVan = @"SELECT DISTINCT KH.MaKH ,KH.TenKH,PDK.MaPhieuDK,PDK.NgayDen,PDK.GioDen,PDK.NgayDi,PDK.GioDi,PDK.SoLuongNguoiLon,PDK.SoLuongTreEm,PDK.TienDatCoc,PDK.MaNV,PDK.MaKH,KH.NgaySinh,KH.GioiTinh,KH.CMND,KH.QuocTich,KH.DiaChi,KH.SDT
              FROM PhieuDangKy as PDK, KhachHang as KH
            WHERE PDK.MaKH = KH.MaKH AND KH.DaXacNhan = 1";
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    if (lstPhieuDangKy == null)
                    {
                        lstPhieuDangKy = new List<PhieuDangKy_DTO>();
                    }
                    PhieuDangKy_DTO pdkDTO = null;
                    for (index = 0; index < _dt.Rows.Count; index++)
                    {
                        pdkDTO = new PhieuDangKy_DTO();
                        pdkDTO.TenKH = _dt.Rows[index]["TenKH"].ToString();
                        pdkDTO.MaPhieuDK = _dt.Rows[index]["MaPhieuDK"].ToString();
                        pdkDTO.NgayDen = Convert.ToDateTime(_dt.Rows[index]["NgayDen"].ToString());
                        DateTime dtGioDen = Convert.ToDateTime(_dt.Rows[index]["GioDen"].ToString());
                        string strGioDen = String.Format("{0:00}:{1:00}:{2:00}", dtGioDen.Hour, dtGioDen.Minute, dtGioDen.Second);
                        DateTime dtGioDi = Convert.ToDateTime(_dt.Rows[index]["GioDi"].ToString());
                        string strGioDi = String.Format("{0:00}:{1:00}:{2:00}", dtGioDi.Hour, dtGioDi.Minute, dtGioDi.Second);

                        pdkDTO.GioDen = strGioDen;
                        pdkDTO.GioDi = strGioDi;

                        pdkDTO.NgayDi = Convert.ToDateTime(_dt.Rows[index]["NgayDi"].ToString());
                        pdkDTO.SoLuongNguoiLon = int.Parse(_dt.Rows[index]["SoLuongNguoiLon"].ToString());
                        pdkDTO.SoLuongTreEm = int.Parse(_dt.Rows[index]["SoLuongTreEm"].ToString());
                        pdkDTO.TienDatCoc = double.Parse(_dt.Rows[index]["TienDatCoc"].ToString());
                        pdkDTO.MaNV = _dt.Rows[index]["MaNV"].ToString();
                        pdkDTO.MaKH = _dt.Rows[index]["MaKH"].ToString();

                        lstPhieuDangKy.Add(pdkDTO);
                    }
                   
                }
                return lstPhieuDangKy;

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;
            }
            

            

        }

        //Hiển thị mã phiếu đăng ký mà chưa có xác nhận đặt phòng ở
        public static List<PhieuDangKy_DTO> HienThiMaPhieuDangKyChuaDuocDatPhong()
        {
            List<PhieuDangKy_DTO> lstMaPhieuDKChuaDuocDP = new List<PhieuDangKy_DTO>();
            try
            {
                string strTruyVan = string.Format("select * from PhieuDangKy where DaXacNhan = 0");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    if (lstMaPhieuDKChuaDuocDP == null)
                    {
                        lstMaPhieuDKChuaDuocDP = new List<PhieuDangKy_DTO>();
                    }
                    PhieuDangKy_DTO pdkDTO = null;
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {

                        pdkDTO = new PhieuDangKy_DTO();
                        pdkDTO.MaPhieuDK = _dt.Rows[i]["MaPhieuDK"].ToString();

                        lstMaPhieuDKChuaDuocDP.Add(pdkDTO);
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;
            }
            return lstMaPhieuDKChuaDuocDP;
        }

        public static int KiemTraMa(string MaPhieuDK)
        {
            string strTruyVan = string.Format("SELECT * FROM PhieuDangKy WHERE MaPhieuDK = '"+MaPhieuDK+"'");
            DataSet ds = new DataSet();
            ds = DataProvider.fillDataSet(strTruyVan);
            DataView dv = new DataView(ds.Tables[0]);
            if (dv.Count != 0)
            {
                return 1;
            }
            else return 0;

        }



        public static List<PhieuDangKy_DTO> HienThiDanhSachCacPhieuDK()
        {
            List<PhieuDangKy_DTO> lstPDK = new List<PhieuDangKy_DTO>();
            try
            {
                string strTruyVan = string.Format(@"SELECT * FROM PhieuDangKy");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    for (int index = 0; index < _dt.Rows.Count; index++)
                    {
                        PhieuDangKy_DTO pdkDTO = new PhieuDangKy_DTO();
                        pdkDTO.MaPhieuDK = _dt.Rows[index]["MaPhieuDK"].ToString();
                        pdkDTO.NgayDen = Convert.ToDateTime(_dt.Rows[index]["NgayDen"].ToString());
                        DateTime dtGioDen = Convert.ToDateTime(_dt.Rows[index]["GioDen"].ToString());
                        string strGioDen = String.Format("{0:00}:{1:00}:{2:00}", dtGioDen.Hour, dtGioDen.Minute, dtGioDen.Second);
                        DateTime dtGioDi = Convert.ToDateTime(_dt.Rows[index]["GioDi"].ToString());
                        string strGioDi = String.Format("{0:00}:{1:00}:{2:00}", dtGioDi.Hour, dtGioDi.Minute, dtGioDi.Second);

                        pdkDTO.GioDen = strGioDen;
                        pdkDTO.GioDi = strGioDi;

                        pdkDTO.NgayDi = Convert.ToDateTime(_dt.Rows[index]["NgayDi"].ToString());
                        pdkDTO.SoLuongNguoiLon = int.Parse(_dt.Rows[index]["SoLuongNguoiLon"].ToString());
                        pdkDTO.SoLuongTreEm = int.Parse(_dt.Rows[index]["SoLuongTreEm"].ToString());
                        pdkDTO.TienDatCoc = double.Parse(_dt.Rows[index]["TienDatCoc"].ToString());
                        pdkDTO.MaNV = _dt.Rows[index]["MaNV"].ToString();
                        pdkDTO.MaKH = _dt.Rows[index]["MaKH"].ToString();
                       

                        lstPDK.Add(pdkDTO);

                    }

                }
                return lstPDK;

            }


            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;

            }

        }


        public static PhieuDangKy_DTO HienThiDuLieuPhieuDangKy(string MaPhieuDK)
        {
            PhieuDangKy_DTO pdkDTO = new PhieuDangKy_DTO();
            try
            {
                string strTruyVan = string.Format(@"SELECT DISTINCT KH.MaKH, KH.TenKH, PDK.MaPhieuDK, PDK.NgayDen, PDK.GioDen, PDK.NgayDi, PDK.GioDi, PDK.SoLuongNguoiLon, PDK.SoLuongTreEm, PDK.TienDatCoc, PDK.MaNV, PDK.MaKH, KH.NgaySinh, KH.GioiTinh, KH.CMND, KH.QuocTich, KH.DiaChi, KH.SDT
              FROM PhieuDangKy as PDK, KhachHang as KH
            WHERE PDK.MaKH = KH.MaKH AND KH.DaXacNhan = 1 AND  MaPhieuDK = '" + MaPhieuDK + "'");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    for (int index = 0; index < _dt.Rows.Count; index++)
                    {

                        pdkDTO.MaPhieuDK = _dt.Rows[index]["MaPhieuDK"].ToString();
                        pdkDTO.NgayDen = Convert.ToDateTime(_dt.Rows[index]["NgayDen"].ToString());
                        DateTime dtGioDen = Convert.ToDateTime(_dt.Rows[index]["GioDen"].ToString());
                        string strGioDen = String.Format("{0:00}:{1:00}:{2:00}", dtGioDen.Hour, dtGioDen.Minute, dtGioDen.Second);
                        DateTime dtGioDi = Convert.ToDateTime(_dt.Rows[index]["GioDi"].ToString());
                        string strGioDi = String.Format("{0:00}:{1:00}:{2:00}", dtGioDi.Hour, dtGioDi.Minute, dtGioDi.Second);

                        pdkDTO.GioDen = strGioDen;
                        pdkDTO.GioDi = strGioDi;

                        pdkDTO.NgayDi = Convert.ToDateTime(_dt.Rows[index]["NgayDi"].ToString());
                        pdkDTO.SoLuongNguoiLon = int.Parse(_dt.Rows[index]["SoLuongNguoiLon"].ToString());
                        pdkDTO.SoLuongTreEm = int.Parse(_dt.Rows[index]["SoLuongTreEm"].ToString());
                        pdkDTO.TienDatCoc = double.Parse(_dt.Rows[index]["TienDatCoc"].ToString());

                    }
                    
                }
                return pdkDTO;

            }
          

            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;

            }

        }

        public static List<PhieuDangKy_DTO> HienThiDuLieuPDKDangCho()
        {
            List<PhieuDangKy_DTO> listPDKDTO = new List<PhieuDangKy_DTO>();
            try
            {
                string strTruyVan = string.Format(@"SELECT DISTINCT KH.MaKH, KH.TenKH, PDK.MaPhieuDK, PDK.TienDatCoc, PDK.MaNV, PDK.MaKH, KH.NgaySinh, KH.GioiTinh, KH.CMND, KH.QuocTich, KH.DiaChi, KH.SDT FROM PhieuDangKy as PDK, KhachHang as KH WHERE PDK.MaKH = KH.MaKH AND KH.DaXacNhan = 1 AND ISNULL(PDK.DaVaoPhong,'false') not in (1)");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    for (int index = 0; index < _dt.Rows.Count; index++)
                    {
                        PhieuDangKy_DTO pdkDTO = new PhieuDangKy_DTO();
                        pdkDTO.TenKH = _dt.Rows[index]["TenKH"].ToString();
                        pdkDTO.MaPhieuDK = _dt.Rows[index]["MaPhieuDK"].ToString();                      
                        pdkDTO.TienDatCoc = double.Parse(_dt.Rows[index]["TienDatCoc"].ToString());
                        pdkDTO.MaNV = _dt.Rows[index]["MaNV"].ToString();
                        pdkDTO.MaKH = _dt.Rows[index]["MaKH"].ToString();
                        listPDKDTO.Add(pdkDTO);

                    }

                }
                return listPDKDTO;

            }


            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;

            }

        }
        public static int ThemPhieuDangKy(PhieuDangKy_DTO pdkDTO)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format(@"INSERT INTO PhieuDangKy(MaPhieuDK,NgayDen,NgayDi,GioDen, GioDi,SoLuongNguoiLon,SoLuongTreEm,TienDatCoc, MaNV,MaKH) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}, '{8}', '{9}')", pdkDTO.MaPhieuDK, pdkDTO.NgayDen, pdkDTO.NgayDi, pdkDTO.GioDen, pdkDTO.GioDi, pdkDTO.SoLuongNguoiLon, pdkDTO.SoLuongTreEm, pdkDTO.TienDatCoc, pdkDTO.MaNV,pdkDTO.MaKH);

                count = DataProvider.ExecuteNonQuery(strTruyVan);

                //Cập nhật phiếu đăng ký đã có khách hàng
                string strTruyVanUpdateKH = " UPDATE KhachHang SET DaXacNhan = 1 WHERE MaKH =  '" + pdkDTO.MaKH + "'";

                count = DataProvider.ExecuteNonQuery(strTruyVanUpdateKH);

                
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }

            return count;

        }

        public static int SuaPhieuDangKy(PhieuDangKy_DTO pdkDTO)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("UPDATE PhieuDangKy SET NgayDen = '{0}',NgayDi = '{1}', GioDen = '{2}', GioDi = '{3}', SoLuongNguoiLon = {4}, SoLuongTreEm = {5},TienDatCoc = {6} WHERE MaPhieuDK = '{7}'", pdkDTO.NgayDen, pdkDTO.NgayDi, pdkDTO.GioDen, pdkDTO.GioDi, pdkDTO.SoLuongNguoiLon, pdkDTO.SoLuongTreEm, pdkDTO.TienDatCoc, pdkDTO.MaPhieuDK);

                count = DataProvider.ExecuteNonQuery(strTruyVan);

                
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            return count;

        }

        public static int XoaPhieuDangKy(string maPhieuDK)
        {

            int count = 0;
            try
            {
                string strTruyVan = string.Format("DELETE FROM PhieuDangKy WHERE MaPhieuDK = '" + maPhieuDK + "'");

                count = DataProvider.ExecuteNonQuery(strTruyVan);

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            return count;



        }
        public static DataTable TimMaPhieuDK(string maPhieuDK)
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM PhieuDangKy WHERE MaPhieuDK = '" + maPhieuDK + "'");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            return dt;
        }
      
        public static DataTable LayMaPhieuDK()
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT MaPhieuDK from PhieuDangKy");
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
