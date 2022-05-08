using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
            private set => instance = value;
        }

        private HoaDonDAO() { }

        public bool LapHoaDon(string diaChi = "null", string sDT = "null", string tenKH = "null")
        {
            string query = $"INSERT INTO dbo.HOADON(TenKH,DiaChi,SDT,TriGia,NgayHD)VALUES(N'{tenKH}',N'{diaChi}',N'{sDT}',0,GETDATE())";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool CapNhatThongTinHoaDon(string diaChi, string sDT, string tenKH, int maHD)
        {
            string query = $"update HOADON set TenKH = '{tenKH}', DiaChi = '{diaChi}', SDT = '{sDT}' where MaHoaDon = {maHD}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public HoaDon LayHoaDonVuaLap()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TOP 1 * FROM HOADON ORDER BY MaHoaDon DESC");
            DataRow row = data.Rows[0];

            HoaDon hd = new HoaDon(row);
            return hd;
        }

        public bool XoaHoaDonTheoMaHD(int maHD)
        {
            int result = DataProvider.Instance.ExecuteNonQuery($"DELETE FROM HOADON WHERE MaHoaDon = {maHD}");

            return result > 0;
        }
    }
}
