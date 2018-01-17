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
    public class NhanVien_DAL
    {
        public static List<NhanVien_DTO> HienThiDanhSachCacNhanVien(int index)
        {
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM NhanVien");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    for (index = 0; index < _dt.Rows.Count; index++)
                    {
                        NhanVien_DTO nvDTO = new NhanVien_DTO();
                        nvDTO.MaNV = _dt.Rows[index]["MaNV"].ToString();
                        nvDTO.TenNhanVien = _dt.Rows[index]["TenNhanVien"].ToString();
                        nvDTO.NgaySinh = Convert.ToDateTime(_dt.Rows[index]["NgaySinh"].ToString());
                        nvDTO.DiaChi = _dt.Rows[index]["DiaChi"].ToString();
                        nvDTO.CMND = _dt.Rows[index]["CMND"].ToString();
                        if (nvDTO.GioiTinh == "Nam")
                        {
                            nvDTO.GioiTinh = _dt.Rows[index]["GioiTinh"].ToString();
                        }
                        else nvDTO.GioiTinh = _dt.Rows[index]["GioiTinh"].ToString();
                        nvDTO.SDT = _dt.Rows[index]["SDT"].ToString();
                        nvDTO.MaChucVu = _dt.Rows[index]["MaChucVu"].ToString();

                        lstNhanVien.Add(nvDTO);

                    }

                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }


            return lstNhanVien;

        }

        public static int KiemTraMa(string MaNV)
        {
            string strTruyVan = string.Format("SELECT * FROM NhanVien WHERE MaNV = '" + MaNV + "'");
            DataSet ds = new DataSet();
            ds = DataProvider.fillDataSet(strTruyVan);
            DataView dv = new DataView(ds.Tables[0]);
            if (dv.Count != 0)
            {
                return 1;
            }
            else return 0;

        }

        //Lấy thông tin nhân viên lễ tân load lên comboBox
        public static List<NhanVien_DTO> HienThiDanhSachNhanVienLeTan()
        {
            List<NhanVien_DTO> lstNhanVienLeTan = new List<NhanVien_DTO>();
            try
            {
                string strTruyVan = string.Format("select NV.MaNV,NV.TenNhanVien from NhanVien as NV, ChucVu as CV where NV.MaChucVu = CV.MaChucVu and TenChucVu like N'Nhân Viên Lễ Tân'");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        NhanVien_DTO nvDTO = new NhanVien_DTO();
                        nvDTO.MaNV = _dt.Rows[i]["MaNV"].ToString();
                        nvDTO.TenNhanVien = _dt.Rows[i]["TenNhanVien"].ToString();

                        lstNhanVienLeTan.Add(nvDTO);

                    }

                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }


            return lstNhanVienLeTan;

        }


        public static int ThemNhanVien(NhanVien_DTO nvDTO)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("INSERT INTO NhanVien(MaNV,TenNhanVien,NgaySinh,DiaChi,CMND,GioiTinh,SDT,MaChucVu) VALUES('{0}',N'{1}', '{2}',N'{3}',N'{4}',N'{5}','{6}',N'{7}')", nvDTO.MaNV, nvDTO.TenNhanVien, nvDTO.NgaySinh, nvDTO.DiaChi, nvDTO.CMND, nvDTO.GioiTinh, nvDTO.SDT, nvDTO.MaChucVu);
                count = DataProvider.ExecuteNonQuery(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            return count;
        }
        

        public static int CapNhatNhanVien(NhanVien_DTO nvDTO)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("UPDATE NhanVien SET TenNhanVien = N'{0}',NgaySinh = '{1}',DiaChi = N'{2}',CMND = '{3}',GioiTinh = N'{4}',SDT = {5}, MaChucVu = '{6}' WHERE MaNV = '{7}'",nvDTO.TenNhanVien,nvDTO.NgaySinh,nvDTO.DiaChi,nvDTO.CMND,nvDTO.GioiTinh,nvDTO.SDT,nvDTO.MaChucVu,nvDTO.MaNV);
                count = DataProvider.ExecuteNonQuery(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }
            return count;
        }
        public static int XoaNhanVien(string maNV)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("DELETE FROM NhanVien WHERE MaNV = '" + maNV + "'");
                count = DataProvider.ExecuteNonQuery(strTruyVan);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error : " + ex.Message);
            }
            return count;
        }

        public static DataTable LayMaNV(string maNV)
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM NhanVien WHERE MaNV like N'%" + maNV + "%'");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
                   
            }
            return dt;
        }

        public static DataTable LayTenNV(string tenNV)
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM NhanVien WHERE TenNhanVien LIKE  N'%" + tenNV + "%'");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);

            }
            return dt;
        }

        public static DataTable LayThuocTinhNV()
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT MaNV,TenNhanVien FROM NhanVien");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);

            }
            return dt;
        }


    }
    
}
