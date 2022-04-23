using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan
{
    public partial class frmThanhToan : Form
    {
        private bool flag = false;
        private List<string> listPTP = new List<string>();

        public frmThanhToan(List<string> list)
        {
            InitializeComponent();
            listPTP = list;

            //Setting để hiện tổng tiền format vi-VN
            CultureInfo culture = new CultureInfo("vi-VN");

            Thread.CurrentThread.CurrentCulture = culture;
        }

        private void btLapHoaDon_Click(object sender, EventArgs e)
        {
            if (tbTen.Text != string.Empty && tbDiaChi.Text != string.Empty && tbSDT.Text != string.Empty)
            {
                if (flag == false)
                {
                    if (HoaDonDAO.Instance.LapHoaDon(tbDiaChi.Text, tbSDT.Text, tbTen.Text) == true)
                    {
                        HoaDon hoaDon = HoaDonDAO.Instance.LayHoaDonVuaLap();
                        foreach (string maPTP in listPTP)
                        {
                            CTHDDAO.Instance.ThemCTHD(hoaDon.MaHoaDon, int.Parse(maPTP));
                        }
                        List<CT_HoaDon> cthd = CTHDDAO.Instance.LayDanhSachCTHDTheoMaHD(hoaDon.MaHoaDon.ToString());
                        foreach (CT_HoaDon ct in cthd)
                        {
                            PhieuThuePhong ptp = PhieuThuePhongDAO.Instance.LayPhieuThuePhongTheoMaPhieu(ct.MaPhieuThuePhong.ToString());
                            ListViewItem item = new ListViewItem((lvCTHoaDon.Items.Count + 1).ToString());

                            item.SubItems.Add(ptp.MaPhong.ToString());
                            item.SubItems.Add(ct.SoNgayThue.ToString());
                            item.SubItems.Add(ptp.DonGiaSan.ToString("c"));
                            item.SubItems.Add(ct.ThanhTien.ToString("c"));

                            lvCTHoaDon.Items.Add(item);
                        }
                        hoaDon = HoaDonDAO.Instance.LayHoaDonVuaLap();
                        tbTongTien.Text = hoaDon.TriGia.ToString("c");
                        flag = true;
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
