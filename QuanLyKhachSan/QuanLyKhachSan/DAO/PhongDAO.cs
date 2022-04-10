using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongDAO();
                return instance;
            }
            private set => instance = value;
        }

        public static int RoomWidth = 100;
        public static int RoomHeight = 100;

        private PhongDAO() { }

        public List<Phong> LoadDanhSachPhong()
        {
            List<Phong> roomList = new List<Phong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PHONG");

            foreach (DataRow row in data.Rows)
            {
                Phong room = new Phong(row);
                roomList.Add(room);
            }

            return roomList;
        }

        public Phong LayThongTinPhongTheoMaPhong(string maPhong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PHONG WHERE MaPhong = N'" + maPhong + "'");
            Phong room = new Phong(data.Rows[0]);
            return room;
        }

        public void CapNhatPhongTheoMaPhong(string maPhong)
        {
            bool TinhTrang = true;
            if ((int)DataProvider.Instance.ExecuteScalar($"select count(*) from PHIEUTHUEPHONG where NgayKTThue >= GETDATE() and MaPhong = '{maPhong}'") > 0)
            {
                TinhTrang = false;
            }
            DataProvider.Instance.ExecuteNonQuery($"UPDATE dbo.PHONG SET TinhTrang = '{TinhTrang}' WHERE MaPhong = N'{maPhong}'");
        }     
    }
}
