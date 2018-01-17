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
    public class ChucVu_DAL
    {
        public static List<ChucVu_DTO> HienThiTenChucVuLenComboBox()
        {
            List<ChucVu_DTO> lstTenChucVu = new List<ChucVu_DTO>();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM ChucVu");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        ChucVu_DTO cvDTO = new ChucVu_DTO();
                        cvDTO.MaChucVu = _dt.Rows[i]["MaChucVu"].ToString();
                        cvDTO.TenChucVu = _dt.Rows[i]["TenChucVu"].ToString();

                        lstTenChucVu.Add(cvDTO);
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }

            return lstTenChucVu;


        }

        public static int KiemTraMa(string MaChucVu)
        {
            string strTruyVan = string.Format("SELECT * FROM ChucVu WHERE MaChucVu = '" + MaChucVu + "'");
            DataSet ds = new DataSet();
            ds = DataProvider.fillDataSet(strTruyVan);
            DataView dv = new DataView(ds.Tables[0]);
            if (dv.Count != 0)
            {
                return 1;
            }
            else return 0;

        }
        public static List<ChucVu_DTO> HienThiDanhSachChucVu(int index)
        {
            List<ChucVu_DTO> lstChucVu = new List<ChucVu_DTO>();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM ChucVu");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    for (index = 0; index < _dt.Rows.Count; index++)
                    {
                        ChucVu_DTO cvDTO = new ChucVu_DTO();
                        cvDTO.MaChucVu = _dt.Rows[index]["MaChucVu"].ToString();
                        cvDTO.TenChucVu = _dt.Rows[index]["TenChucVu"].ToString();

                        lstChucVu.Add(cvDTO);
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }

            return lstChucVu;


        }
        public static int ThemChucVu(ChucVu_DTO cvDTO)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("INSERT INTO ChucVu(MaChucVu,TenChucVu) VALUES('{0}',N'{1}')", cvDTO.MaChucVu, cvDTO.TenChucVu);
                count = DataProvider.ExecuteNonQuery(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }

            return count;
            

        }

        public static int CapNhatChucVu(ChucVu_DTO cvDTO)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("UPDATE ChucVu SET TenChucVu = N'{0}' WHERE MaChucVu = '{1}'",cvDTO.TenChucVu,cvDTO.MaChucVu);
                count = DataProvider.ExecuteNonQuery(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }

            return count;


        }

        public static int XoaChucVu(string maChucVu)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("DELETE FROM ChucVu WHERE MaChucVu = '"+maChucVu+"'");
                count = DataProvider.ExecuteNonQuery(strTruyVan);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }

            return count;


        }
    }
}
