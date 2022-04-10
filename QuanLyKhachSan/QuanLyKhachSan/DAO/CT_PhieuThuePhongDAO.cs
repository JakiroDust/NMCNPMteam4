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

        public List<CT_PhieuThuePhong> LayDanhSachKhachHangTheoMaPhieu(string maPhieu)
        {
            List<CT_PhieuThuePhong> listCT = new List<CT_PhieuThuePhong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CT_PHIEUTHUEPHONG WHERE MaPhieuThuePhong = N'" + maPhieu + "'");

            foreach (DataRow item in data.Rows)
            {
                CT_PhieuThuePhong info = new CT_PhieuThuePhong(item);
                listCT.Add(info);
            }

            return listCT;
        }

        public bool ThemKhachHang(string maPhieuThuePhong, string tenKH, string loaiKhach, string CMND, string diaChi)
        {
            string query = $"INSERT INTO dbo.CT_PHIEUTHUEPHONG (MaPhieuThuePhong, TenKH, LoaiKhach, CMND, DiaChi) VALUES ('{maPhieuThuePhong}', '{tenKH}', '{loaiKhach}', '{CMND}', '{diaChi}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaKhachHang(string maPhieu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.CT_PHIEUTHUEPHONG WHERE MaPhieuThuePhong = " + maPhieu);

            return result > 0;
        }
    }
}
