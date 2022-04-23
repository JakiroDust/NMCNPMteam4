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
    }
}
