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
        private int maHoaDon;
        private string tenKH;
        private string diaChi;
        private string sDT;
        private DateTime ngayHD;
        private decimal triGia;

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public DateTime NgayHD { get => ngayHD; set => ngayHD = value; }
        public decimal TriGia { get => triGia; set => triGia = value; }

        public HoaDon(string tenKH, string diaChi, string sDT, DateTime ngayHD, decimal triGia)
        {
            this.TenKH = tenKH;
            this.DiaChi = diaChi;
            this.SDT = sDT;
            this.NgayHD = ngayHD;
            this.TriGia = triGia;
        }

        public HoaDon(DataRow row)
        {
            this.MaHoaDon = (int)row["MaHoaDon"];
            this.TenKH = row["TenKH"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.NgayHD = (DateTime)row["NgayHD"];
            this.TriGia = (decimal)row["TriGia"];
        }
    }
}
