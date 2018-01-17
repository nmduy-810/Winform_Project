using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data; 

namespace BLL
{
    public class NhanVien_BLL
    {
        public static List<NhanVien_DTO> HienThiDanhSachCacNhanVien(int index) => NhanVien_DAL.HienThiDanhSachCacNhanVien(index);


        public static int ThemNhanVien(NhanVien_DTO nvDTO) => NhanVien_DAL.ThemNhanVien(nvDTO);
        public static int XoaNhanVien(string maNV) => NhanVien_DAL.XoaNhanVien(maNV);

        public static int CapNhatNhanVien(NhanVien_DTO nvDTO) => NhanVien_DAL.CapNhatNhanVien(nvDTO);

        public static List<NhanVien_DTO> HienThiDanhSachNhanVienLeTan() => NhanVien_DAL.HienThiDanhSachNhanVienLeTan();

        public static int KiemTraMa(string MaNV) => NhanVien_DAL.KiemTraMa(MaNV);

        public static DataTable LayTenNV(string tenNV) => NhanVien_DAL.LayTenNV(tenNV);

        public static DataTable LayMaNV(string maNV) => NhanVien_DAL.LayMaNV(maNV);


        public static DataTable LayThuocTinhNV() => NhanVien_DAL.LayThuocTinhNV();
    }
}
