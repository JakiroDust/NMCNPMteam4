using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;
using System.Data.SqlClient;

namespace QuanLyKhachSan.DAO
{
    public class PhieuThuePhongDAO
    {
        private static PhieuThuePhongDAO instance;

        public static PhieuThuePhongDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new PhieuThuePhongDAO();
                return instance;
            }
            private set => instance = value; 
        }

        private PhieuThuePhongDAO() { }

        public bool LapPhieuThuePhong(string maPhong, string ngayBDThue, string ngayKTThue)
        {
            string query = "INSERT INTO dbo.PhieuThuePhong (MaPhong, NgayBDThue, NgayKTThue) VALUES (N'"+ maPhong + "', '"+ ngayBDThue + "', '"+ ngayKTThue + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public string LayMaPhieuTheoMaPhong(string maPhong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PhieuThuePhong WHERE MaPhong = N'" + maPhong + "'");

            if (data.Rows.Count > 0)
            {
                PhieuThuePhong maphieu = new PhieuThuePhong(data.Rows[0]);
                return maphieu.MaPhieu;
            }
            return null;
        }

        public PhieuThuePhong LayCTPhieuThuePhongTheoMaPhieu(string maPhieu)
        {
            int count = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM dbo.PhieuThuePhong WHERE MaPhieu = N'" + maPhieu + "'");
            if (count <= 0)
                return null;

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PhieuThuePhong WHERE MaPhieu = N'" + maPhieu + "'");
            PhieuThuePhong ptp = new PhieuThuePhong(data.Rows[0]);            
            return ptp;
        }

        public bool XoaPhieuThuePhong(string maPhieu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.PhieuThuePhong WHERE MaPhieu = " + maPhieu);
            return result > 0;
        }
    }
}
