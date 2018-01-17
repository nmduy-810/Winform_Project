using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;
using System.Data;

namespace BLL
{
    public class KhachHang_BLL
    {
        public static List<KhachHang_DTO> LoadKhachHang(int index)
        {
            return KhachHang_DAL.LoadKhachHang(index);
            
        }
        public static List<KhachHang_DTO>LoadKhachHang()
        {
            return KhachHang_DAL.LoadKhachHang();
        }
        public static int ThemKhachHang(KhachHang_DTO khDTO)
        {
            return KhachHang_DAL.ThemKhachHang(khDTO);
        }

        public static List<KhachHang_DTO> HienThiDanhSachCacKhachHangDaCoPhong_KH() => KhachHang_DAL.HienThiDanhSachCacKhachHangDaCoPhong_KH();

        public static int SuaKhachHang(KhachHang_DTO khDTO)
        {
            return KhachHang_DAL.SuaKhachHang(khDTO);
        }
        public static int XoaKhachHang(string maKH)
        {
            return KhachHang_DAL.XoaKhachHang(maKH);
        }
        public static KhachHang_DTO LoadDuLieuKhachHang(string MaKH)
        {
            return KhachHang_DAL.LoadDuLieuKhachHang(MaKH);
        }
        public static int KiemTraMa(string MaKH) => KhachHang_DAL.KiemTraMa(MaKH);

        public static DataTable TimMaKhachHang(string MaKH) => KhachHang_DAL.TimMaKhachHang(MaKH);

        public static DataTable TimTenKhachHang(string tenKH) => KhachHang_DAL.TimTenKhachHang(tenKH);

        public static DataTable LayMaKhachHang() => KhachHang_DAL.LayMaKhachHang();


    }
}
