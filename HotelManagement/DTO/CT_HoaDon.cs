using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class CT_HoaDon
    {
        private int maCTHD;
        private string maHoaDon;
        private int maPhieuThuePhong;
        private int soNgayThue;
        private decimal thanhTien;

        public int MaCTHD { get => maCTHD; set => maCTHD = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaPhieuThuePhong { get => maPhieuThuePhong; set => maPhieuThuePhong = value; }
        public int SoNgayThue { get => soNgayThue; set => soNgayThue = value; }
        public decimal ThanhTien { get => thanhTien; set => thanhTien = value; }

        public CT_HoaDon(string maHD, int maPhieu, int soNgayThue, decimal thanhTien)
        {
            this.MaHoaDon = maHD;
            this.MaPhieuThuePhong = maPhieu;
            this.SoNgayThue = soNgayThue;
            this.ThanhTien = thanhTien;
        }

        public CT_HoaDon(DataRow row)
        {
            this.maCTHD = (int)row["maCTHD"];
            this.MaHoaDon = row["MaHoaDon"].ToString();
            this.MaPhieuThuePhong = (int)row["MaPhieuThuePhong"];
            this.SoNgayThue = (int)row["SoNgayThue"];
            this.ThanhTien = (decimal)row["ThanhTien"];
        }
    }
}
