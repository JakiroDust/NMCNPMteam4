using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class CTHDDAO
    {
        private static CTHDDAO instance;

        public static CTHDDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTHDDAO();
                return instance;
            }
            private set => instance = value;
        }

        private CTHDDAO() { }

        public List<CT_HoaDon> LayDanhSachCTHDTheoMaHD(string maHD)
        {
            List<CT_HoaDon> list = new List<CT_HoaDon>();

            DataTable date = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CTHD WHERE MaHD = N'" + maHD + "'");
            foreach (DataRow item in date.Rows)
            {
                CT_HoaDon info = new CT_HoaDon(item);
                list.Add(info);
            }
            return list;
        }

        public bool ThemCTHD(int maHD, int maPhieu, int soNgayThue, double thanhTien)
        {
            string query = "INSERT INTO dbo.CTHD(MaHD,MaPhieu,SoNgayThue,ThanhTien)VALUES(" + maHD + "," + maPhieu + "," + soNgayThue + "," + thanhTien + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaCTHD(int maHD)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.CTHD WHERE MaHD = " + maHD);

            return result > 0;
        }
    }
}
