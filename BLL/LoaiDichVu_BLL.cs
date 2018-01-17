using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class LoaiDichVu_BLL
    {
        public static List<LoaiDichVu_DTO> HienThiTenLoaiDichVuLenComboBox() => LoaiDichVu_DAL.HienThiTenLoaiDichVuLenComboBox();
    }
}
