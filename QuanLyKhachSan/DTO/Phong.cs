using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Phong
    {
        public Phong(int maPhong, string maLoaiPhong, string ghiChu, bool tinhTrang)
        {
            this.MaPhong = maPhong;
            this.MaLoaiPhong = maLoaiPhong;
            this.GhiChu = ghiChu;
            this.TinhTrang = tinhTrang;
        }

        public Phong(DataRow row)
        {
            this.MaPhong = (int)row["MaPhong"];
            this.MaLoaiPhong = row["MaLoaiPhong"].ToString();
            this.GhiChu = row["GhiChu"].ToString();
            this.TinhTrang = (bool)row["TinhTrang"];
        }

        private int maPhong;
        private string maLoaiPhong;
        private string ghiChu;
        private bool tinhTrang;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
