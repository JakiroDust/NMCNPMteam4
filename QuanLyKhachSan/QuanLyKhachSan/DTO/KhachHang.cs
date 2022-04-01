using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class KhachHang
    {
        public KhachHang(string MaPhieu, string TenKH, string LoaiKhach, string CMND, string DiaChi) 
        {
            this.MaPhieu = MaPhieu;
            this.TenKH = TenKH;
            this.LoaiKhach = LoaiKhach;
            this.CMND = CMND;
            this.DiaChi = DiaChi;
        }

        public KhachHang(DataRow row) 
        {
            this.MaPhieu = row["MaPhieu"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.LoaiKhach = row["LoaiKhach"].ToString();
            this.CMND = row["CMND"].ToString();
            this.DiaChi = row["DiaChi"].ToString();

        }

        private string maPhieu;
        private string tenKH;
        private string loaiKhach;
        private string cMND;
        private string diaChi;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string LoaiKhach { get => loaiKhach; set => loaiKhach = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
