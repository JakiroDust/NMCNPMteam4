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

        public bool LapPhieuThuePhong(string maPhong, int soluongkhach, string ngayBDThue, string ngayKTThue, decimal dongiasan)
        {
            string query = $"INSERT INTO dbo.PHIEUTHUEPHONG(MaPhong, SoLuongKhach, NgayBDThue, NgayKTThue, DonGiaSan) VALUES (N'{maPhong}', {soluongkhach}, N'{ngayBDThue}', N'{ngayKTThue}', {(int)dongiasan})";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public string LayMaPhieuTheoMaPhong(string maPhong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PHIEUTHUEPHONG WHERE MaPhong = N'" + maPhong + "'");

            if (data.Rows.Count > 0)
            {
                PhieuThuePhong maphieu = new PhieuThuePhong(data.Rows[0]);
                return maphieu.MaPhieuThuePhong.ToString();
            }
            return null;
        }

        public PhieuThuePhong LayPhieuThuePhongTheoMaPhieu(string maPhieu)
        {
            int count = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM dbo.PHIEUTHUEPHONG WHERE MaPhieuThuePhong = N'" + maPhieu + "'");
            if (count <= 0)
                return null;

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PHIEUTHUEPHONG WHERE MaPhieuThuePhong = N'" + maPhieu + "'");
            PhieuThuePhong ptp = new PhieuThuePhong(data.Rows[0]);
            return ptp;
        }

        public bool XoaPhieuThuePhong(string maPhieu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.PHIEUTHUEPHONG WHERE MaPhieuThuePhong = " + maPhieu);
            return result > 0;
        }

        public PhieuThuePhong LayPhieuThuePhongConHanTheoMaPhong(string maphong)
        {
            int count = (int)DataProvider.Instance.ExecuteScalar($"select count(*) from PHIEUTHUEPHONG where NgayKTThue >= GETDATE() and MaPhong = '{maphong}'");
            if (count <= 0)
                return null;

            DataTable data = DataProvider.Instance.ExecuteQuery($"select * from PHIEUTHUEPHONG where NgayKTThue >= GETDATE() and MaPhong = '{maphong}'");
            PhieuThuePhong ptp = new PhieuThuePhong(data.Rows[0]);
            return ptp;
        }

        public List<string> LayDanhSachPhieuChuaThanhToan()
        {
            List<string> list = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaPhieuThuePhong FROM PHIEUTHUEPHONG WHERE MaPhieuThuePhong not in (SELECT MaPhieuThuePhong FROM CT_HOADON)");

            foreach (DataRow row in data.Rows)
            {
                list.Add(row["MaPhieuThuePhong"].ToString());
            }
            return list;
        }
    }
}
