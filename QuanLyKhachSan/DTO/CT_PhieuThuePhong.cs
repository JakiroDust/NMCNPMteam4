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
        public CT_PhieuThuePhong(int maPhieuThuePhong, string TenKH, string LoaiKhach, string CMND, string DiaChi)
        {
            this.MaPhieuThuePhong = maPhieuThuePhong;
            this.TenKH = TenKH;
            this.LoaiKhach = LoaiKhach;
            this.CMND = CMND;
            this.DiaChi = DiaChi;
        }

        public CT_PhieuThuePhong(DataRow row)
        {
            this.MaCTPTP = (int)row["MaCTPTP"];
            this.MaPhieuThuePhong = (int)row["MaPhieuThuePhong"];
            this.TenKH = row["TenKH"].ToString();
            this.LoaiKhach = row["LoaiKhach"].ToString();
            this.CMND = row["CMND"].ToString();
            this.DiaChi = row["DiaChi"].ToString();

        }

        private int maCTPTP;
        private int maPhieuThuePhong;
        private string tenKH;
        private string loaiKhach;
        private string cMND;
        private string diaChi;

        public int MaCTPTP { get => maCTPTP; set => maCTPTP = value; }
        public int MaPhieuThuePhong { get => maPhieuThuePhong; set => maPhieuThuePhong = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string LoaiKhach { get => loaiKhach; set => loaiKhach = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
