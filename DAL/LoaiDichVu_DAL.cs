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
    public class LoaiDichVu_DAL
    {

        public static List<LoaiDichVu_DTO>HienThiTenLoaiDichVuLenComboBox()
        {
            List<LoaiDichVu_DTO> lstTenLoaiDichVu = new List<LoaiDichVu_DTO>();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM LoaiDichVu");
                DataTable _dt = new DataTable();
                _dt = DataProvider.fillDataTable(strTruyVan);
                if (_dt != null)
                {
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        LoaiDichVu_DTO ldvDTO = new LoaiDichVu_DTO();
                        ldvDTO.MaLoaiDichVu = _dt.Rows[i]["MaLoaiDichVu"].ToString();
                        ldvDTO.TenLoaiDichVu = _dt.Rows[i]["TenLoaiDichVu"].ToString();

                        lstTenLoaiDichVu.Add(ldvDTO);
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error : " + ex.Message);
            }

            return lstTenLoaiDichVu;
        }
    }
}
