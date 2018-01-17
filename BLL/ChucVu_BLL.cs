using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ChucVu_BLL
    {
        public static List<ChucVu_DTO> HienThiTenChucVuLenComboBox() => ChucVu_DAL.HienThiTenChucVuLenComboBox();
        public static List<ChucVu_DTO> HienThiDanhSachChucVu(int index) => ChucVu_DAL.HienThiDanhSachChucVu(index);
        public static int ThemChucVu(ChucVu_DTO cvDTO) => ChucVu_DAL.ThemChucVu(cvDTO);
        public static int CapNhatChucVu(ChucVu_DTO cvDTO) => ChucVu_DAL.CapNhatChucVu(cvDTO);
        public static int XoaChucVu(string maChucVu) => ChucVu_DAL.XoaChucVu(maChucVu);

        public static int KiemTraMa(string MaChucVu) => ChucVu_DAL.KiemTraMa(MaChucVu);

    }
}
