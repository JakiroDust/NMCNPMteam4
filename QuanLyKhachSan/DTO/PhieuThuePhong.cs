using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class PhieuThuePhong
    {
        private int maPhieuThuePhong;
        private int maPhong;
        private int soLuongKhach;
        private DateTime ngayBDThue;
        private DateTime ngayKTThue;
        private decimal donGiaSan;

        public int MaPhieuThuePhong { get => maPhieuThuePhong; set => maPhieuThuePhong = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
        public int SoLuongKhach { get => soLuongKhach; set => soLuongKhach = value; }
        public DateTime NgayBDThue { get => ngayBDThue; set => ngayBDThue = value; }
        public DateTime NgayKTThue { get => ngayKTThue; set => ngayKTThue = value; }
        public decimal DonGiaSan { get => donGiaSan; set => donGiaSan = value; }

        public PhieuThuePhong(int maphong, int soluongkhach, DateTime startdate, DateTime enddate, decimal dongiasan)
        {
            this.MaPhong = maphong;
            this.SoLuongKhach = soluongkhach;
            this.NgayBDThue = startdate;
            this.NgayKTThue = enddate;
            this.DonGiaSan = dongiasan;
        }

        public PhieuThuePhong(DataRow row)
        {
            this.MaPhieuThuePhong = (int)row["MaPhieuThuePhong"];
            this.MaPhong = (int)row["MaPhong"];
            this.SoLuongKhach = (int)row["SoLuongKhach"];
            this.NgayBDThue = (DateTime)row["NgayBDThue"];
            this.NgayKTThue = (DateTime)row["NgayKTThue"];
            this.DonGiaSan = (decimal)row["DonGiaSan"];
        }
    }
}
