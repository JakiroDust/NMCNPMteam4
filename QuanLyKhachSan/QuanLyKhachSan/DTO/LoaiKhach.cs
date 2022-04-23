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
        private string tenLoaiKhach;
        private double heSo;

        public string TenLoaiKhach { get => tenLoaiKhach; set => tenLoaiKhach = value; }
        public double HeSo { get => heSo; set => heSo = value; }

        public LoaiKhach(string tenloaikhach, double heso)
        {
            this.TenLoaiKhach= tenloaikhach;
            this.HeSo= heso;
        }

        public LoaiKhach (DataRow rows)
        {
            this.TenLoaiKhach = rows["LoaiKhach"].ToString();
            this.HeSo = (double)rows["HeSo"];
        }
    }
}
