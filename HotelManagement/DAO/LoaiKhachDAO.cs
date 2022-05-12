using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class LoaiKhachDAO
    {
        private static LoaiKhachDAO instance;

        public static LoaiKhachDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiKhachDAO();
                return instance;
            }
            private set => instance = value;
        }

        private LoaiKhachDAO() { }

        public List<LoaiKhach> LoadDanhSachLoaiKhach()
        {
            List<LoaiKhach> list = new List<LoaiKhach>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM LOAIKHACH");

            foreach (DataRow row in data.Rows)
            {
                LoaiKhach loaiKhach = new LoaiKhach(row);
                list.Add(loaiKhach);
            }
            return list;
        }
        public DataTable LoadDanhSachLoaiKhachv2()
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaLoaiKhach as 'ID',LoaiKhach as 'Loại khách', HeSo as'Hệ số'  FROM LOAIKHACH order by LoaiKhach");

            return data;
        }
        public void ResetLoaiKhach()
        {
            DataProvider.Instance.ExecuteNonQuery("delete from LOAIKHACH;Insert into LOAIKHACH(LoaiKhach,HeSo) values (N'Nội địa',1);Insert into LOAIKHACH(LoaiKhach,HeSo) values (N'Nước ngoài',1.5); ");
        }
        public void InsertLoaiKhach(string LoaiKhach,string HeSo)
        {
            HeSo = float.Parse(HeSo).ToString().Replace(",", ".");
            DataProvider.Instance.ExecuteNonQuery($"Insert into LOAIKHACH(LoaiKhach,HeSo) values (N'{LoaiKhach}',{HeSo})");
        }
        public void UpdateLoaiKhach(string MaLoaiKhach,string LoaiKhach,string HeSo)
        {
            HeSo = float.Parse(HeSo).ToString().Replace(",", ".");
            DataProvider.Instance.ExecuteNonQuery($"update LOAIKHACH set LoaiKhach=N'{LoaiKhach}',HeSo={HeSo} where MaLoaiKhach={MaLoaiKhach}");
        }
        public void DeleteLoaiKhach(string MaLoaiKhach)
        {
            DataProvider.Instance.ExecuteNonQuery($"delete from LOAIKHACH where MaLoaiKhach={MaLoaiKhach}");
        }
    }
}
