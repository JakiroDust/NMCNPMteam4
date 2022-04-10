using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool LapHoaDon(string tenKH, string diaChi, string sDT, decimal triGia, DateTime ngayHD)
        {
            string query = $"INSERT INTO dbo.HOADON(TenKH,DiaChi,SDT,TriGia,NgayHD)VALUES(N'{tenKH}',N'{diaChi}',N'{sDT}','{triGia}','{ngayHD}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
