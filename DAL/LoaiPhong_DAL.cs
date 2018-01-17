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
    public class LoaiPhong_DAL
    {
        public static List<LoaiPhong_DTO>HienThiThongTinLoaiPhong(int index)
        {
            List<LoaiPhong_DTO> lstLoaiPhong = null;
            try
            {
                string strTruyVan = string.Format("SELECT * FROM LoaiPhong");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);

                if (_dt != null)
                {
                    lstLoaiPhong = new List<LoaiPhong_DTO>();
                    for (index = 0; index < _dt.Rows.Count; index++)
                    {
                        LoaiPhong_DTO lphgDTO = new LoaiPhong_DTO();
                        lphgDTO.MaLoaiPhong = _dt.Rows[index]["MaLoaiPhong"].ToString();
                        lphgDTO.TenLoaiPhong = _dt.Rows[index]["TenLoaiPhong"].ToString();
                        lphgDTO.TrangThietBi = _dt.Rows[index]["TrangThietBi"].ToString();
                        lphgDTO.GiaLoaiPhong = Convert.ToInt32(_dt.Rows[index]["GiaLoaiPhong"]);
                        lphgDTO.MoTa = _dt.Rows[index]["MoTa"].ToString();

                        lstLoaiPhong.Add(lphgDTO);
                    }
                }
                return lstLoaiPhong;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;
            }
        }

        //Hiển thị tên loại phòng lên comboBox trong form Chi Tiết Loại Phòng
        public static List<LoaiPhong_DTO> HienThiTenLoaiPhong()
        {
            List<LoaiPhong_DTO> lstTenLoaiPhong = null;
            try
            {
                string strTruyVan = string.Format("SELECT MaLoaiPhong, TenLoaiPhong FROM LoaiPhong");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);

                if (_dt != null)
                {
                    lstTenLoaiPhong = new List<LoaiPhong_DTO>();
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        LoaiPhong_DTO lphgDTO = new LoaiPhong_DTO();
                        lphgDTO.MaLoaiPhong = _dt.Rows[i]["MaLoaiPhong"].ToString();
                        lphgDTO.TenLoaiPhong = _dt.Rows[i]["TenLoaiPhong"].ToString();
                       

                        lstTenLoaiPhong.Add(lphgDTO);
                    }
                }
                return lstTenLoaiPhong;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                return null;
            }
        }



        public static List<LoaiPhong_DTO> HienThiGiaLoaiPhongLenComboBox()
        {
            List<LoaiPhong_DTO> lstGiaLoaiPhong = new List<LoaiPhong_DTO>();
            
            try
            {
                string strTruyVan = string.Format("SELECT distinct GiaLoaiPhong from LoaiPhong");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        LoaiPhong_DTO lphgDTO = new LoaiPhong_DTO();
                        
                        
                        lphgDTO.GiaLoaiPhong = Convert.ToInt32(_dt.Rows[i]["GiaLoaiPhong"]);
                         
                        lstGiaLoaiPhong.Add(lphgDTO);

                    }
                }
            }
           
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }

            return lstGiaLoaiPhong;
            
            
            
        }
        public static int ThemLoaiPhong(LoaiPhong_DTO lphgDTO)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("INSERT INTO LoaiPhong(MaLoaiPhong,TenLoaiPhong,TrangThietBi,GiaLoaiPhong,MoTa) VALUES('{0}','{1}',N'{2}', {3},N'{4}')", lphgDTO.MaLoaiPhong, lphgDTO.TenLoaiPhong, lphgDTO.TrangThietBi, lphgDTO.GiaLoaiPhong, lphgDTO.MoTa);
                count = DataProvider.ExecuteNonQuery(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
           
            
            return count;
        }

        public static int CapNhatLoaiPhong(LoaiPhong_DTO lphgDTO)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("UPDATE LoaiPhong SET TenLoaiPhong = N'{0}',TrangThietBi = N'{1}',GiaLoaiPhong = {2}, MoTa = N'{3}' WHERE MaLoaiPhong = '{4}'",lphgDTO.TenLoaiPhong, lphgDTO.TrangThietBi, lphgDTO.GiaLoaiPhong, lphgDTO.MoTa,lphgDTO.MaLoaiPhong);
                count = DataProvider.ExecuteNonQuery(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }


            return count;
        }
        public static int XoaLoaiPhong(string maLoaiPhong)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("DELETE FROM LoaiPhong WHERE MaLoaiPhong = '"+maLoaiPhong+"' ");
                count = DataProvider.ExecuteNonQuery(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }


            return count;
        }

        //Hiển thị tên loại phòng 
        public static List<LoaiPhong_DTO> HienThiTenLoaiPhongTheoMaLoaiPhong()
        {
            List<LoaiPhong_DTO> lstTenPhong = null;
            try
            {
                string strTruyVan = string.Format("select MaLoaiPhong, TenLoaiPhong from LoaiPhong");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);

                if (_dt != null)
                {
                    lstTenPhong = new List<LoaiPhong_DTO>();
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        LoaiPhong_DTO phgDTO = new LoaiPhong_DTO();
                        phgDTO.MaLoaiPhong = _dt.Rows[i]["MaLoaiPhong"].ToString();
                        phgDTO.TenLoaiPhong = _dt.Rows[i]["TenLoaiPhong"].ToString();
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

    }
}
