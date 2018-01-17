using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class HoaDon_DAL
    {
        public static DataTable HienThiDanhSachMaSuDungDichVu(string maPhong)
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("select * from DanhSachSDDichVu as DS inner join Phong as PHG on DS.MaPhong = PHG.MaPhong where PHG.MaPhong = '" + maPhong + "' and TinhTrangPhong = 1");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public static DataTable LayMaChiTietHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM ChiTietHoaDon");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }
            

        public static DataTable HienThiMaPhong(string maPhong)
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("select * from Phong where TinhTrangPhong = 1 and MaPhong = '" + maPhong + "'");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }
        public static int LayTienLoaiPhong(string maPhong)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("SELECT distinct GiaLoaiPhong FROM Phong as PHG inner join LoaiPhong as LPG on PHG.MaLoaiPhong = LPG.MaLoaiPhong where PHG.MaPhong = '" + maPhong + "' and TinhTrangPhong = 1");
                string tam = DataProvider.ExecuteScalar(strTruyVan).ToString().Split('.')[0];
                count = int.Parse(tam);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return count;
        }
        public static int LayTienDichVu(string maPhong)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("create view Tam as select  distinct p.MaPhong, p.TenPhong, k.TenKH,ldv.MaLoaiDichVu,ldv.TenLoaiDichVu,dv.MaDichVu,TenDichVu,count(TenDichVu) as [SoLuong],sum(ThanhTien)as [Tong Tien] from DanhSachSDDichVu d  join Phong p on p.MaPhong = d.MaPhong join ChiTietLoaiPhong c on p.MaPhong  = c.MaPhong join PhieuDangKy ph on ph.MaPhieuDK = c.MaPhieuDK  join KhachHang k on k.MaKH = ph.MaKH  join DichVu dv on dv.MaDichVu = d.MaDichVu  join LoaiDichVu ldv on dv.MaLoaiDichVu = ldv.MaLoaiDichVu where p.MaPhong = '" + maPhong + "' group by TenDichVu, k.TenKH, p.TenPhong, p.MaPhong, dv.MaDichVu, ldv.MaLoaiDichVu, ldv.TenLoaiDichVu");
                DataProvider.fillDataSet(strTruyVan);

                string strTruyVan2 = string.Format("select sum([Tong Tien]) from Tam");
                string tmp = DataProvider.ExecuteScalar(strTruyVan2).ToString().Split('.')[0];
                count = int.Parse(tmp);

                string strTruyVan3 = string.Format("drop view Tam");
                DataProvider.ExecuteNonQuery(strTruyVan3);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return count;
        }
        public static int ThemChiTietHoaDon(HoaDon_DTO hdDTO)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("INSERT INTO ChiTietHoaDon(MaChiTietHoaDon,PhuThu,TienPhong,TienDichVu,ThanhTien,MaPhong) VALUES('{0}', {1}, {2}, {3}, {4},'{5}')", hdDTO.MaChiTietHoaDon, hdDTO.PhuThu, hdDTO.TienPhong, hdDTO.TienDichVu, hdDTO.ThanhTien, hdDTO.MaPhong);

                count = DataProvider.ExecuteNonQuery(strTruyVan);

                string strTruyVan4 = string.Format("UPDATE ChiTietHoaDon SET DaThanhToan = 0 WHERE MaChiTietHoaDon = '"+hdDTO.MaChiTietHoaDon+"'");

                count = DataProvider.ExecuteNonQuery(strTruyVan4);

                string strTruyVan2 = string.Format("UPDATE Phong SET TinhTrangPhong = 0 WHERE MaPhong = '" + hdDTO.MaPhong + "'");
                count = DataProvider.ExecuteNonQuery(strTruyVan2);

                //string strTruyVan3 = string.Format("UPDATE PhieuDangKy SET DaXoa = 1 WHERE MaPhieuDK = '" +  + "'");
                //count = DataProvider.ExecuteNonQuery(strTruyVan3);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return count;
        }
        public static int XacNhanHoaDon(HoaDon_DTO hdDTO)
        {
            int count = 0;
            try
            {
                //Tự sửa lại mã nhân viên
                string strTruyVan = string.Format("INSERT INTO HoaDon(MaHoaDon,NgayThanhToan,SoTienDaDatTruoc,TongTienHoaDon,MaNV,MaChiTietHoaDon) VALUES ('{0}','{1}',{2},{3},'{4}','{5}')",hdDTO.MaHoaDon,hdDTO.NgayThanhToan,hdDTO.SoTienDaDatTruoc,hdDTO.TongTienHoaDon,hdDTO.MaNV,hdDTO.MaChiTietHoaDon);
                
                count = DataProvider.ExecuteNonQuery(strTruyVan);

                string strTruyVan2 = string.Format("UPDATE ChiTietHoaDon SET DaThanhToan = 1 WHERE MaChiTietHoaDon = '" + hdDTO.MaChiTietHoaDon + "'");

                

                count = DataProvider.ExecuteNonQuery(strTruyVan2);
                
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return count;
             
        }

        public static int LayTienDatCoc(string maPhong)
        {
            int count = 0;
            try
            {
                string strTruyVan = string.Format("select PDK.TienDatCoc,PDK.MaPhieuDK from PhieuDangKy as PDK inner join ChiTietLoaiPhong as CTLP on PDK.MaPhieuDK = CTLP.MaPhieuDK inner join ChiTietHoaDon as CTHD on CTHD.MaPhong = CTLP.MaPhong where CTLP.MaPhong = '"+ maPhong+"'");
                string tmp = DataProvider.ExecuteScalar(strTruyVan).ToString().Split('.')[0];
                count = int.Parse(tmp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return count;
        }

        public static DataTable HienThiDanhSachChiTietHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM ChiTietHoaDon where DaThanhToan = 0");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public static DataTable HienThiDanhSachHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("select HD.MaHoaDon,HD.NgayThanhToan,CTHD.TienDichVu,CTHD.TienPhong,CTHD.PhuThu,HD.SoTienDaDatTruoc,HD.TongTienHoaDon from HoaDon as HD inner join ChiTietHoaDon as CTHD on HD.MaChiTietHoaDon = CTHD.MaChiTietHoaDon where CTHD.DaThanhToan = 1");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }
        public static DataTable LayMaHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT MaHoaDon FROM HoaDon");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }


        public static DataTable TimMaHoaDon(string maHoaDon)
        {
            DataTable dt = new DataTable();
            try
            {
                string strTruyVan = string.Format("SELECT * FROM HoaDon WHERE MaHoaDon = '"+ maHoaDon+ "'");
                dt = DataProvider.fillDataTable(strTruyVan);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }



    }
}
