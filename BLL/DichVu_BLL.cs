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
    public class DichVu_BLL
    {
        public static List<DichVu_DTO> HienThiDanhSachCacDichVu(int index) => DichVu_DAL.HienThiDanhSachCacDichVu(index);
        public static List<DichVu_DTO> HienThiGiaDichVuLenComboBox(string maDichVu) => DichVu_DAL.HienThiGiaDichVuLenComboBox(maDichVu);

        public static List<DichVu_DTO> HienThiTenDichVuTheoMaDichVu(string maLoaiDichVu) => DichVu_DAL.HienThiTenDichVuTheoMaDichVu(maLoaiDichVu);

        public static List<DichVu_DTO> HienThiDonViTinh(string maDichVu) => DichVu_DAL.HienThiDonViTinh(maDichVu);

        public static int XacNhanDichVu(DichVu_DTO dvDTO, Phong_DTO phgDTO) => DichVu_DAL.XacNhanDichVu(dvDTO, phgDTO);

        public static DataTable HienThiThongTinPhongDaDangKyDichVu(Phong_DTO phgDTO) => DichVu_DAL.HienThiThongTinPhongDaDangKyDichVu(phgDTO);

        public static int CapNhatDichVu(DichVu_DTO dvDTO) => DichVu_DAL.CapNhatDichVu(dvDTO);

        public static DataTable HienThiDanhSachCacDichVuCanCapNhat(string maDichVu, string maPhong)=>DichVu_DAL.HienThiDanhSachCacDichVuCanCapNhat(maDichVu,maPhong);

        public static int XoaDichVu(string maSuDungDichVu) => DichVu_DAL.XoaDichVu(maSuDungDichVu);

        public static string TongTien(string maPhong) => DichVu_DAL.TongTien(maPhong);



    }
}
