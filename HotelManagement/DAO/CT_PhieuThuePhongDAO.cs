using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class CT_PhieuThuePhongDAO
    {
        private static CT_PhieuThuePhongDAO instance;

        public static CT_PhieuThuePhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CT_PhieuThuePhongDAO();
                return instance;
            }
            private set => instance = value;
        }

        private CT_PhieuThuePhongDAO() { }

        public DataTable LayDanhSachKhachHangTheoMaPhieu(string maPhieu)
        {
            if (maPhieu == string.Empty)
                maPhieu = "null";

            string query = $"EXEC USP_GET_CT_PHIEUTHUEPHONG_BY_MAPHIEUTHUEPHONG @MaPhieuThuePhong = {maPhieu}";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool ThemKhachHang(string maPhieuThuePhong, string tenKH, string loaiKhach, string CMND, string diaChi)
        {
            string query = $"INSERT INTO dbo.CT_PHIEUTHUEPHONG (MaPhieuThuePhong, TenKH, LoaiKhach, CMND, DiaChi) VALUES ('{maPhieuThuePhong}', '{tenKH}', '{loaiKhach}', '{CMND}', '{diaChi}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaKhachHangTheoPhieuThuePhong(string maPhieu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.CT_PHIEUTHUEPHONG WHERE MaPhieuThuePhong = " + maPhieu);

            return result > 0;
        }
        public bool SuaKhachHang(string maCTPTP, string tenKH, string loaiKhach, string CMND, string diaChi)
        {
            string query = $"update CT_PHIEUTHUEPHONG set TenKH = N'{tenKH}', LoaiKhach = N'{loaiKhach}', CMND = N'{CMND}', DiaChi = N'{diaChi}' Where MaCTPTP = N'{maCTPTP}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaKhachHangTheoID(string iD)
        {
            int result = DataProvider.Instance.ExecuteNonQuery($"DELETE FROM CT_PHIEUTHUEPHONG WHERE MaCTPTP = {iD}");

            return result > 0;
        }
    }
}
