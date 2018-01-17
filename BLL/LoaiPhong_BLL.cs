using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class LoaiPhong_BLL
    {
        public static List<LoaiPhong_DTO> HienThiThongTinLoaiPhong(int index) => LoaiPhong_DAL.HienThiThongTinLoaiPhong(index);
        public static List<LoaiPhong_DTO> HienThiGiaLoaiPhongLenComboBox() => LoaiPhong_DAL.HienThiGiaLoaiPhongLenComboBox();
        public static int ThemLoaiPhong(LoaiPhong_DTO lphgDTO) => LoaiPhong_DAL.ThemLoaiPhong(lphgDTO);
        public static int XoaLoaiPhong(string maLoaiPhong) => LoaiPhong_DAL.XoaLoaiPhong(maLoaiPhong);

        public static int CapNhatLoaiPhong(LoaiPhong_DTO lphgDTO) => LoaiPhong_DAL.CapNhatLoaiPhong(lphgDTO);

        public static List<LoaiPhong_DTO> HienThiTenLoaiPhong() => LoaiPhong_DAL.HienThiTenLoaiPhong();

        public static List<LoaiPhong_DTO> HienThiTenLoaiPhongTheoMaLoaiPhong() => LoaiPhong_DAL.HienThiTenLoaiPhongTheoMaLoaiPhong();

    }
}
