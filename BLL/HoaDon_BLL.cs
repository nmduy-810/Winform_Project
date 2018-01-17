using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class HoaDon_BLL
    {
        public static DataTable HienThiDanhSachMaSuDungDichVu(string maPhong) => HoaDon_DAL.HienThiDanhSachMaSuDungDichVu(maPhong);

        public static DataTable HienThiMaPhong(string maPhong) => HoaDon_DAL.HienThiMaPhong(maPhong);

        public static int LayTienLoaiPhong(string maPhong) => HoaDon_DAL.LayTienLoaiPhong(maPhong);

        public static int LayTienDichVu(string maPhong) => HoaDon_DAL.LayTienDichVu(maPhong);

        public static int ThemChiTietHoaDon(HoaDon_DTO hdDTO) => HoaDon_DAL.ThemChiTietHoaDon(hdDTO);

        public static DataTable HienThiDanhSachChiTietHoaDon() => HoaDon_DAL.HienThiDanhSachChiTietHoaDon();

        public static DataTable LayMaChiTietHoaDon() => HoaDon_DAL.LayMaChiTietHoaDon();

        public static int LayTienDatCoc(string maPhong) => HoaDon_DAL.LayTienDatCoc(maPhong);

        public static int XacNhanHoaDon(HoaDon_DTO hdDTO) => HoaDon_DAL.XacNhanHoaDon(hdDTO);

        public static DataTable HienThiDanhSachHoaDon() => HoaDon_DAL.HienThiDanhSachHoaDon();

        public static DataTable LayMaHoaDon() => HoaDon_DAL.LayMaHoaDon();

        public static DataTable TimMaHoaDon(string maHoaDon) => HoaDon_DAL.TimMaHoaDon(maHoaDon);

    }
}
