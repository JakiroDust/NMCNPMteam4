using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class LoaiKhach
    {
        private string maLoaiKhach;
        private string tenLoaiKhach;
        private double phuThu;

        public string MaLoaiKhach { get => maLoaiKhach; set => maLoaiKhach = value; }
        public string TenLoaiKhach { get => tenLoaiKhach; set => tenLoaiKhach = value; }
        public double PhuThu { get => phuThu; set => phuThu = value; }

        public LoaiKhach(string maLoaiKhach, string tenloaikhach, double phuThu)
        {
            this.MaLoaiKhach = maLoaiKhach;
            this.TenLoaiKhach= tenloaikhach;
            this.PhuThu = phuThu;
        }

        public LoaiKhach (DataRow rows)
        {
            this.MaLoaiKhach = rows["MaLoaiKhach"].ToString();
            this.TenLoaiKhach = rows["LoaiKhach"].ToString();
            this.PhuThu = (double)rows["PhuThu"];
        }
    }
}
