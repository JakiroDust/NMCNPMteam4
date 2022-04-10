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
        private float heSo;

        public string TenLoaiKhach { get => tenLoaiKhach; set => tenLoaiKhach = value; }
        public float HeSo { get => heSo; set => heSo = value; }

        public LoaiKhach(string tenloaikhach, float heso)
        {
            this.TenLoaiKhach= tenloaikhach;
            this.HeSo= heso;
        }

        public LoaiKhach (DataRow rows)
        {
            this.TenLoaiKhach = rows["TenLoaiKhach"].ToString();
            this.HeSo = (float)rows["HeSo"];
        }
    }
}
