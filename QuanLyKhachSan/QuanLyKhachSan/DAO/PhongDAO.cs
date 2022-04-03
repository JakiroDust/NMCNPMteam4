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

            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetRoomList");

            foreach (DataRow row in data.Rows)
            {
                Phong room = new Phong(row);
                roomList.Add(room);
            }

            return roomList;
        }

        public Phong LayThongTinPhongTheoMaPhong(string maPhong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DanhSachPhong WHERE MaPhong = N'"+ maPhong + "'");
            Phong room = new Phong(data.Rows[0]);
            return room;
        }

        public void CapNhatPhongTheoMaPhong(string maPhong)
        {
            string TinhTrang = "";
            Phong room = LayThongTinPhongTheoMaPhong(maPhong);
            switch (room.TinhTrang)
            {
                case "Occupied":
                    TinhTrang = "Free";
                    break;
                case "Free":
                    TinhTrang = "Occupied";
                    break;
            }
            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DanhSachPhong SET TinhTrang = N'"+ TinhTrang + "' WHERE MaPhong = N'"+ maPhong + "'");
        }
    }
}
