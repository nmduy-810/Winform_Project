using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DevExpress.XtraEditors;

namespace DAL
{
    public class Phong_DAL
    {
        

        //Hiển thị tên phòng còn trống để khách đặt
        public static List<Phong_DTO>HienThiTenPhongTheoMaLoaiPhong_Trong(string maLoaiPhong)
        {
            List<Phong_DTO> lstTenPhong = null;
            try
            {
                string strTruyVan = string.Format("select MaPhong,TenPhong from Phong where MaLoaiPhong = '"+ maLoaiPhong+ "' and ISNULL(TinhTrangPhong,'false') not in(1) ");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);

                if (_dt != null)
                {
                    lstTenPhong = new List<Phong_DTO>();
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        Phong_DTO phgDTO = new Phong_DTO();
                        phgDTO.TenPhong = _dt.Rows[i]["TenPhong"].ToString();
                        phgDTO.MaPhong = _dt.Rows[i]["MaPhong"].ToString();
                       // phgDTO.MaLoaiPhong = _dt.Rows[i]["MaLoaiPhong"].ToString();
                        lstTenPhong.Add(phgDTO);
                    }
                }
                return lstTenPhong;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;
            }
        }

        //Hiển thị tên phòng đã có khách đặt
        public static List<Phong_DTO> HienThiTenPhongTheoMaLoaiPhong_CoNguoi(string maLoaiPhong)
        {
            List<Phong_DTO> lstTenPhong = null;
            try
            {
                string strTruyVan = string.Format("select MaPhong,TenPhong from Phong where MaLoaiPhong = '" + maLoaiPhong + "' and ISNULL(TinhTrangPhong,'false') not in(0) ");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);

                if (_dt != null)
                {
                    lstTenPhong = new List<Phong_DTO>();
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        Phong_DTO phgDTO = new Phong_DTO();
                        phgDTO.TenPhong = _dt.Rows[i]["TenPhong"].ToString();
                        phgDTO.MaPhong = _dt.Rows[i]["MaPhong"].ToString();
                        // phgDTO.MaLoaiPhong = _dt.Rows[i]["MaLoaiPhong"].ToString();
                        lstTenPhong.Add(phgDTO);
                    }
                }
                return lstTenPhong;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;
            }
        }



        //HIển thị danh sách thông tin phòng đã ở
        public static List<Phong_DTO>HienThiDSKhachHangDaCoPhong()
        {
            List<Phong_DTO> lstKhachHangDaCoPhong = null;
            try
            {
                string strTruyVan = string.Format("select PDK.MaPhieuDK,KH.TenKH,PHG.TenPhong from PhieuDangKy as PDK,ChiTietLoaiPhong as CTLP, KhachHang as KH,Phong as PHG where PDK.MaPhieuDK = CTLP.MaPhieuDK and PDK.MaKH = KH.MaKH and CTLP.MaPhong = PHG.MaPhong and DaVaoPhong = 1");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);

                if (_dt != null)
                {
                    lstKhachHangDaCoPhong = new List<Phong_DTO>();
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        Phong_DTO phgDTO = new Phong_DTO();
                        phgDTO.MaPhieuDK = _dt.Rows[i]["MaPhieuDK"].ToString();
                        phgDTO.TenKH = _dt.Rows[i]["TenKH"].ToString();
                        phgDTO.TenPhong = _dt.Rows[i]["TenPhong"].ToString(); ;

                        lstKhachHangDaCoPhong.Add(phgDTO);
                    }
                }
                return lstKhachHangDaCoPhong;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;
            }
        }

        public static List<Phong_DTO> HienThiDanhSachCacPhong()
        {
            List<Phong_DTO> lstTenPhong = null;
            try
            {
                string strTruyVan = string.Format("select MaPhong,TenPhong, (CASE WHEN TinhTrangPhong='1' THEN N'Phòng có khách' ELSE N'Phòng trống' END) AS TinhTrangPhong,MaLoaiPhong from Phong");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);

                if (_dt != null)
                {
                    lstTenPhong = new List<Phong_DTO>();
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        Phong_DTO phgDTO = new Phong_DTO();
                        phgDTO.TenPhong = _dt.Rows[i]["TenPhong"].ToString();
                        phgDTO.MaPhong = _dt.Rows[i]["MaPhong"].ToString();
                        phgDTO.TinhTrangPhong = _dt.Rows[i]["TinhTrangPhong"].ToString();                       
                        phgDTO.MaLoaiPhong = _dt.Rows[i]["MaLoaiPhong"].ToString();
                        lstTenPhong.Add(phgDTO);
                    }
                }
                return lstTenPhong;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;
            }
        }

        public static List<Phong_DTO> HienThiTenPhongTheoMaPhong()
        {
            List<Phong_DTO> lstTenPhong = null;
            try
            {
                string strTruyVan = string.Format("select MaPhong,TenPhong from Phong");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);

                if (_dt != null)
                {
                    lstTenPhong = new List<Phong_DTO>();
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        Phong_DTO phgDTO = new Phong_DTO();
                        phgDTO.TenPhong = _dt.Rows[i]["TenPhong"].ToString();
                        phgDTO.MaPhong = _dt.Rows[i]["MaPhong"].ToString();
                        lstTenPhong.Add(phgDTO);
                    }
                }
                return lstTenPhong;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;
            }
        }
        public static int XacNhanDatPhong(PhieuDangKy_DTO pdkDTO,Phong_DTO phgDTO)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("INSERT INTO ChiTietLoaiPhong(MaPhieuDK,MaPhong) VALUES('{0}','{1}')", pdkDTO.MaPhieuDK, phgDTO.MaPhong);
               count = DataProvider.ExecuteNonQuery(strTruyVan);

                string strTruyVanUpdate = string.Format("UPDATE PhieuDangKy SET DaVaoPhong = 1 WHERE MaPhieuDK = '" + pdkDTO.MaPhieuDK + "'");

                count = DataProvider.ExecuteNonQuery(strTruyVanUpdate);

                string strTruyVanUpdateTTP = string.Format("UPDATE Phong SET TinhTrangPhong = 1 WHERE MaPhong = '" + phgDTO.MaPhong + "'");

                count = DataProvider.ExecuteNonQuery(strTruyVanUpdateTTP);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            

            return count;
        }

        public static int ThayDoiPhongChoKhach(PhieuDangKy_DTO pdkDTO,Phong_DTO phgDTO)
        {
            int count = 0;
            string maPhongCu = "";
            try
            {
                string strTruyVan_LayMaPhongCu = string.Format("SELECT MaPhong from ChiTietLoaiPhong where MaPhieuDK = '" + pdkDTO.MaPhieuDK +"'");
                maPhongCu = DataProvider.ExecuteScalar(strTruyVan_LayMaPhongCu);
        

                string strTruyVan_ThayDoiTTPhong = string.Format("Update Phong SET TinhTrangPhong = 0 WHERE MaPhong = '"+ maPhongCu + "'");

                count = DataProvider.ExecuteNonQuery(strTruyVan_ThayDoiTTPhong);

                string strTruyVan_Update = string.Format("UPDATE ChiTietLoaiPhong SET MaPhong = '" + phgDTO.MaPhong + "' WHERE MaPhieuDK = '" + pdkDTO.MaPhieuDK + "'");
                count = DataProvider.ExecuteNonQuery(strTruyVan_Update);

                string strTruyVan_ThayDoiTTPhong_2 = string.Format("Update Phong SET TinhTrangPhong = 1 WHERE MaPhong = '" + phgDTO.MaPhong + "'");

                count = DataProvider.ExecuteNonQuery(strTruyVan_ThayDoiTTPhong_2);

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            return count;
          
        }
        public static int CapNhatLaiTrangThaiPhong(PhieuDangKy_DTO pdkDTO,Phong_DTO phgDTO)
        {
            int count = 0;
            string MaPhong = "";
            try
            {

                string strTruyVan_LayMaPhongHienTai = string.Format("SELECT MaPhong from ChiTietLoaiPhong WHERE MaPhieuDK = '"+pdkDTO.MaPhieuDK+"'");
                MaPhong = DataProvider.ExecuteScalar(strTruyVan_LayMaPhongHienTai);

                string strTruyVan_UpdateTTP = string.Format("UPDATE Phong SET TinhTrangPhong = 0 WHERE MaPhong = '"+ MaPhong + "'");

                count = DataProvider.ExecuteNonQuery(strTruyVan_UpdateTTP);

                return count;

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            return count;
        }
        public static DataTable LayThuocTinhPhong()
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("select MaPhong,TenPhong from Phong where TinhTrangPhong = 1");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public static DataTable TimMaPhong(string maPhong)
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("select PDK.MaPhieuDK,KH.MaKH,KH.TenKH,KH.GioiTinh,KH.NgaySinh,KH.DiaChi,KH.CMND,SDT,KH.QuocTich,PHG.MaPhong,PHG.TenPhong from PhieuDangKy as PDK,ChiTietLoaiPhong as CTLP, KhachHang as KH,Phong as PHG where PDK.MaPhieuDK = CTLP.MaPhieuDK and PDK.MaKH = KH.MaKH and CTLP.MaPhong = PHG.MaPhong and DaVaoPhong = 1 and PHG.TinhTrangPhong = 1 and PHG.MaPhong like '%"+maPhong+"%'");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public static DataTable TimTenPhong(string tenPhong)
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("select PDK.MaPhieuDK,KH.MaKH,KH.TenKH,KH.GioiTinh,KH.NgaySinh,KH.DiaChi,KH.CMND,SDT,KH.QuocTich,PHG.MaPhong,PHG.TenPhong from PhieuDangKy as PDK,ChiTietLoaiPhong as CTLP, KhachHang as KH,Phong as PHG where PDK.MaPhieuDK = CTLP.MaPhieuDK and PDK.MaKH = KH.MaKH and CTLP.MaPhong = PHG.MaPhong and DaVaoPhong = 1 and PHG.TinhTrangPhong = 1 and PHG.TenPhong like '%" + tenPhong + "%'");
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
