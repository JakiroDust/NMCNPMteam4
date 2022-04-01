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
        private string maPhieu;
        private string maPhong;
        private DateTime ngayBDThue;
        private DateTime ngayKTThue;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public DateTime NgayBDThue { get => ngayBDThue; set => ngayBDThue = value; }
        public DateTime NgayKTThue { get => ngayKTThue; set => ngayKTThue = value; }

        public PhieuThuePhong(string maphong, DateTime startdate, DateTime enddate) 
        {
            this.MaPhong = maphong;
            this.NgayBDThue = startdate;
            this.NgayKTThue = enddate;
        }

        public PhieuThuePhong(DataRow row)
        {
            this.MaPhieu = row["MaPhieu"].ToString();
            this.MaPhong = row["MaPhong"].ToString();
            this.NgayBDThue = (DateTime)row["NgayBDThue"];
           
            DateTime ngayKTThueTemp = (DateTime)row["NgayKTThue"];
            if (ngayKTThueTemp.ToString() != "")
                this.NgayKTThue = (DateTime)row["NgayKTThue"];
        }
    }
}
