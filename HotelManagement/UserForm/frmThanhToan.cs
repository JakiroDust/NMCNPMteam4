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
        public frmThanhToan()
        {
            InitializeComponent();

            //Setting để hiện tổng tiền format vi-VN
            CultureInfo culture = new CultureInfo("vi-VN");

            Thread.CurrentThread.CurrentCulture = culture;
            LapHoaDon();
        }
            private static frmThanhToan instance;
            public static frmThanhToan GetInstance
            {
                get
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new frmThanhToan();
                    }
                    return instance;
                }
            }

            private void LapHoaDon()
        {
            if (HoaDonDAO.Instance.LapHoaDon())
            {
                HoaDon hoaDon = HoaDonDAO.Instance.LayHoaDonVuaLap();
                List<string> listPTP = PhieuThuePhongDAO.Instance.LayDanhSachPhieuChuaThanhToan();

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
            }
        }

        private void btLapHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = HoaDonDAO.Instance.LayHoaDonVuaLap();
            if (tbTen.Text != string.Empty && tbDiaChi.Text != string.Empty && tbSDT.Text != string.Empty)
            {
                if (HoaDonDAO.Instance.CapNhatThongTinHoaDon(tbDiaChi.Text, tbSDT.Text, tbTen.Text, hoaDon.MaHoaDon))
                    flag = true;
                else
                    MessageBox.Show("Co loi xay ra");
            }
        }
        

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!flag)
                MessageBox.Show("Vui long nhap thong tin thanh toan");
            else
            {
                Close();
            }    

        }

        public bool ClosedByXButtonOrAltF4 { get; private set; }
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
                ClosedByXButtonOrAltF4 = true;
            base.WndProc(ref msg);
        }
        protected override void OnShown(EventArgs e)
        {
            ClosedByXButtonOrAltF4 = false;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (ClosedByXButtonOrAltF4)
            {
                HoaDon hoaDon = HoaDonDAO.Instance.LayHoaDonVuaLap();
                if (!HoaDonDAO.Instance.XoaHoaDonTheoMaHD(hoaDon.MaHoaDon))
                    MessageBox.Show("Co loi xay ra");   
            }
        }

        private void lvCTHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
