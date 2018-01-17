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
    public class Phong_BLL
    {
       

        public static List<Phong_DTO> HienThiTenPhongTheoMaPhong() => Phong_DAL.HienThiTenPhongTheoMaPhong();

        public static List<Phong_DTO> HienThiTenPhongTheoMaLoaiPhong_Trong(string maLoaiPhong) => Phong_DAL.HienThiTenPhongTheoMaLoaiPhong_Trong(maLoaiPhong);

        public static int XacNhanDatPhong(PhieuDangKy_DTO pdkDTO,Phong_DTO phgDTO) => Phong_DAL.XacNhanDatPhong(pdkDTO,phgDTO);

        public static List<Phong_DTO> HienThiTenPhongTheoMaLoaiPhong_CoNguoi(string maLoaiPhong) => Phong_DAL.HienThiTenPhongTheoMaLoaiPhong_CoNguoi(maLoaiPhong);

        public static List<Phong_DTO> HienThiDSKhachHangDaCoPhong() => Phong_DAL.HienThiDSKhachHangDaCoPhong();

        public static int ThayDoiPhongChoKhach(PhieuDangKy_DTO pdkDTO, Phong_DTO phgDTO) => Phong_DAL.ThayDoiPhongChoKhach(pdkDTO,phgDTO);

        public static List<Phong_DTO> HienThiDanhSachCacPhong() => Phong_DAL.HienThiDanhSachCacPhong();

        public static int CapNhatLaiTrangThaiPhong(PhieuDangKy_DTO pdkDTO, Phong_DTO phgDTO) => Phong_DAL.CapNhatLaiTrangThaiPhong(pdkDTO, phgDTO);

        public static DataTable LayThuocTinhPhong() => Phong_DAL.LayThuocTinhPhong();

        public static DataTable TimMaPhong(string maPhong) => Phong_DAL.TimMaPhong(maPhong);

        public static DataTable TimTenPhong(string tenPhong) => Phong_DAL.TimTenPhong(tenPhong);


    }
}
