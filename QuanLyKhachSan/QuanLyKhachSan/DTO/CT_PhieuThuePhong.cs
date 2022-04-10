using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class CT_PhieuThuePhong
    {
        public CT_PhieuThuePhong(string TenKH, string LoaiKhach, string CMND, string DiaChi)
        {
            this.TenKH = TenKH;
            this.LoaiKhach = LoaiKhach;
            this.CMND = CMND;
            this.DiaChi = DiaChi;
        }

        public CT_PhieuThuePhong(DataRow row)
        {
            this.MaPhieuThuePhong = (int)row["MaPhieuThuePhong"];
            this.TenKH = row["TenKH"].ToString();
            this.LoaiKhach = row["LoaiKhach"].ToString();
            this.CMND = row["CMND"].ToString();
            this.DiaChi = row["DiaChi"].ToString();

        }

        private int maPhieuThuePhong;
        private string tenKH;
        private string loaiKhach;
        private string cMND;
        private string diaChi;

        public int MaPhieuThuePhong { get => maPhieuThuePhong; set => maPhieuThuePhong = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string LoaiKhach { get => loaiKhach; set => loaiKhach = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
