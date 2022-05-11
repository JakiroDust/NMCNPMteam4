using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyKhachSan.DAO
{
   public class PhuThuDao
    {
        private static PhuThuDao instance;

        public static PhuThuDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhuThuDao();
                return instance;
            }
            private set => instance = value;
        }

        private PhuThuDao() { }
        public void ResetPhuThu()
        {
            DataProvider.Instance.ExecuteNonQuery("delete from PHUTHU; insert into PHUTHU(SoLuongKhach,PhuThu) VALUES(3, 1.25);");
        }
        public DataTable getPhuThu()
        {
            return DataProvider.Instance.ExecuteQuery("select MaPhuThu,SoLuongKhach as 'Mốc',PhuThu as 'Hệ số' from PHUTHU order by SoLuongKhach asc");
        }
        public void InsertPhuThu(string Moc,string Heso)
        {
            DataProvider.Instance.ExecuteNonQuery($"insert into PHUTHU(SoLuongKhach,PhuThu) values({Moc},{Heso})");
        }
        public void UpdatePhuThu(string MaPhuThu,string Moc,string Heso)
        {
            DataProvider.Instance.ExecuteNonQuery($"update PhuThu set SoLuongKhach={Moc},PhuThu={Heso.Replace(",",".")} where MaPhuThu={MaPhuThu}");
        }
        public void DeletePhuThu(string MaPhuThu)
        {
            DataProvider.Instance.ExecuteNonQuery($"Delete from PhuThu where MaPhuThu={MaPhuThu}");
        }
    }
}
