using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class HoaDon
    {
        private int maHD;
        private string tenKH;
        private string diaChi;
        private string sDT;
        private DateTime ngayHD;
        private double triGia;

        public int MaHD { get => maHD; set => maHD = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public DateTime NgayHD { get => ngayHD; set => ngayHD = value; }
        public double TriGia { get => triGia; set => triGia = value; }

        public HoaDon(string tenKH, string diaChi, string sDT, DateTime ngayHD, double triGia)
        {
            this.TenKH = tenKH;
            this.DiaChi = diaChi;   
            this.SDT = sDT;
            this.NgayHD = ngayHD;
            this.TriGia = triGia;
        }

        public HoaDon(DataRow row)
        {
            this.MaHD = (int)row["MaHD"];
            this.TenKH = row["TenKH"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.NgayHD = (DateTime)row["NgayHD"];
            this.TriGia = (double)row["TriGia"];
        }
    }
}
