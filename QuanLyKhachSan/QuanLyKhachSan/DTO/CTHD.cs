using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class CTHD
    {
        private int iD;
        private string maHD;
        private int maPhieu;
        private int soNgayThue;
        private double thanhTien;

        public int ID { get => iD; set => iD = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public int MaPhieu { get => maPhieu; set => maPhieu = value; }
        public int SoNgayThue { get => soNgayThue; set => soNgayThue = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }

        public CTHD(string maHD, int maPhieu, int soNgayThue, double thanhTien)
        {
            this.MaHD = maHD;
            this.MaPhieu = maPhieu;
            this.SoNgayThue= soNgayThue;
            this.ThanhTien= thanhTien;
        }

        public CTHD(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.MaHD = row["MaHD"].ToString();
            this.MaPhieu = (int)row["MaPhieu"];
            this.SoNgayThue = (int)row["SoNgayThue"];
            this.ThanhTien = (double)row["ThanhTien"];
        }
    }
}
