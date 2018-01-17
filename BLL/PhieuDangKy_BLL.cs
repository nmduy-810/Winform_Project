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
    public class PhieuDangKy_BLL
    {
        
        public static List<PhieuDangKy_DTO> HienThiDanhSachKhachHangTrongPDK(int index) => PhieuDangKy_DAL.HienThiDanhSachKhachHangTrongPDK(index);
        public static PhieuDangKy_DTO HienThiDuLieuPhieuDangKy(string MaPhieuDK) => PhieuDangKy_DAL.HienThiDuLieuPhieuDangKy(MaPhieuDK);
        public static List<PhieuDangKy_DTO> HienThiDuLieuPDKDangCho() => PhieuDangKy_DAL.HienThiDuLieuPDKDangCho();
        public static int ThemPhieuDangKy(PhieuDangKy_DTO pdkDTO) => PhieuDangKy_DAL.ThemPhieuDangKy(pdkDTO);

        public static int SuaPhieuDangKy(PhieuDangKy_DTO pdkDTO) => PhieuDangKy_DAL.SuaPhieuDangKy(pdkDTO);

        public static List<PhieuDangKy_DTO> HienThiDanhSachCacPhieuDK() => PhieuDangKy_DAL.HienThiDanhSachCacPhieuDK();

        public static int XoaPhieuDangKy(string maPhieuDK) => PhieuDangKy_DAL.XoaPhieuDangKy(maPhieuDK);
        public static int KiemTraMa(string MaPhieuDK) => PhieuDangKy_DAL.KiemTraMa(MaPhieuDK);

        public static List<PhieuDangKy_DTO> HienThiMaPhieuDangKyChuaDuocDatPhong() => PhieuDangKy_DAL.HienThiMaPhieuDangKyChuaDuocDatPhong();

        public static DataTable TimMaPhieuDK(string maPhieuDK) => PhieuDangKy_DAL.TimMaPhieuDK(maPhieuDK);


        public static DataTable LayMaPhieuDK() => PhieuDangKy_DAL.LayMaPhieuDK();
    }
}
