using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Phong
    {
        public Phong(string maPhong, string status, double donGia)
        {
            this.MaPhong = maPhong;
            this.TinhTrang = status;
            this.DonGia = donGia;
        }

        public Phong(DataRow row)
        {
            this.MaPhong=row["MaPhong"].ToString();
            this.TinhTrang = row["TinhTrang"].ToString();
            this.DonGia = (double)row["DonGia"];
        }

        private string tinhTrang;
        private string maPhong;
        private double donGia;

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
