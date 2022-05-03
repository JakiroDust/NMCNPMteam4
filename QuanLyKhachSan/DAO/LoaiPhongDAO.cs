using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class LoaiPhongDAO
    {
        private static LoaiPhongDAO instance;

        public static LoaiPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiPhongDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private LoaiPhongDAO() { }

        public List<LoaiPhong> LoadDanhSachLoaiPhong()
        {
            List<LoaiPhong> danhSachLoaiPhong = new List<LoaiPhong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM LOAIPHONG");

            foreach (DataRow row in data.Rows)
            {
                LoaiPhong loaiPhong = new LoaiPhong(row);
                danhSachLoaiPhong.Add(loaiPhong);
            }
            return danhSachLoaiPhong;
        }

        public LoaiPhong LayThongTinLoaiPhongTheoMaLoaiPhong(string maLoaiPhong)
        { 
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM LOAIPHONG WHERE MaLoaiPhong = '" + maLoaiPhong + "'");
            LoaiPhong loaiPhong = new LoaiPhong(data.Rows[0]);
            return loaiPhong;           
        }

        public LoaiPhong LayThongTinLoaiPhongTheoMaPhong(string maphong)
        {
            Phong room = PhongDAO.Instance.LayThongTinPhongTheoMaPhong(maphong);
            LoaiPhong loaiphong = LayThongTinLoaiPhongTheoMaLoaiPhong(room.MaLoaiPhong);
            return loaiphong;
        }
    }
}
