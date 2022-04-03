using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
            private set => instance = value; 
        }

        private KhachHangDAO() { }

        public List<KhachHang> LayDanhSachKhachHangTheoMaPhieu(string maPhieu)
        {
            List<KhachHang> listCT = new List<KhachHang>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.KhachHang WHERE MaPhieu = N'"+ maPhieu + "'");

            foreach (DataRow item in data.Rows)
            {
                KhachHang info = new KhachHang(item);
                listCT.Add(info);
            }

            return listCT;
        }

        public bool ThemKhachHang(string maPhieu, string tenKH, string loaiKhach, string CMND, string diaChi)
        {
            string query = "INSERT INTO dbo.KhachHang (MaPhieu, TenKH, LoaiKhach, CMND, DiaChi) VALUES (N'"+ maPhieu + "',N'"+ tenKH + "',N'"+ loaiKhach + "',N'"+ CMND + "', N'"+ diaChi + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaKhachHang(string maPhieu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.KhachHang WHERE MaPhieu = " + maPhieu);

            return result > 0;
        }
    }
}
