using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class LoaiPhong
    {
        private string maLoaiPhong;
        private string tenLoaiPhong;
        private decimal donGia;

        public string MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }

        public LoaiPhong(string maLoaiPhong, string tenLoaiPhong, decimal donGia)
        {
            this.MaLoaiPhong = maLoaiPhong;
            this.TenLoaiPhong = tenLoaiPhong;
            this.DonGia = donGia;
        }

        public LoaiPhong(DataRow row)
        {
            this.MaLoaiPhong = row["MaLoaiPhong"].ToString();
            this.TenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.DonGia = (decimal)row["DonGia"];
        }
    }
}
