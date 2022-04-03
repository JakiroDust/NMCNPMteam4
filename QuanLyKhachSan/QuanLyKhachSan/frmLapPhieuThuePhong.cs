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
    public partial class frmLapPhieuThuePhong : Form
    {
        public double TongTien = 0;

        public frmLapPhieuThuePhong()
        {
            InitializeComponent();
            LoadDanhSachPhong();

            //Setting để hiện tổng tiền format vi-VN
            CultureInfo culture = new CultureInfo("vi-VN");

            Thread.CurrentThread.CurrentCulture = culture;
        }


        #region Method
        void LoadDanhSachPhong()
        {
            flpRoom.Controls.Clear();
            List<Phong> roomList = PhongDAO.Instance.LoadDanhSachPhong();

            foreach (Phong item in roomList)
            {
                Button btn = new Button() { Width = PhongDAO.RoomWidth, Height = PhongDAO.RoomHeight};
                btn.Text = item.MaPhong + Environment.NewLine + "Tình trạng: " + item.TinhTrang + Environment.NewLine + "Đơn giá: " + item.DonGia.ToString();
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.TinhTrang)
                {
                    case "Free":
                        btn.BackColor = Color.Aqua;
                        break;
                    case "Occupied":
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpRoom.Controls.Add(btn);
            }
        }

        double LoadTongTien()
        {
            int timeSpan = 0;
            double tongTien = 0;
            string maPhong = tbMaPhong.Text;
            string maPhieu = tbMaPhieu.Text;
            Phong room = PhongDAO.Instance.LayThongTinPhongTheoMaPhong(maPhong);
            PhieuThuePhong ptp = PhieuThuePhongDAO.Instance.LayCTPhieuThuePhongTheoMaPhieu(maPhieu);
            List<KhachHang> listKhachHang = KhachHangDAO.Instance.LayDanhSachKhachHangTheoMaPhieu(maPhieu);

            if (ptp != null)
            {
                timeSpan = (int)ptp.NgayKTThue.Subtract(ptp.NgayBDThue).TotalDays;
                dtpStart.Value = ptp.NgayBDThue;
                dtpEnd.Value = ptp.NgayKTThue;
                tongTien += room.DonGia * timeSpan;
            }
            if (listKhachHang.Count() >= 3)
                tongTien *= 1.25;
            foreach (KhachHang khachHang in listKhachHang)
            {
                if (khachHang.LoaiKhach == "Nuoc ngoai")
                {
                    tongTien *= 1.5;
                    break;
                }
            }
            return tongTien;          
        }

        void CTPhieuThuePhong(string maPhong)
        {
            lvCTPhieuThuePhong.Items.Clear();
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;

            string maPhieu = tbMaPhieu.Text;

            List<KhachHang> listKhachHang = KhachHangDAO.Instance.LayDanhSachKhachHangTheoMaPhieu(maPhieu);
            tbThanhTien.Text = LoadTongTien().ToString("c");

            foreach (KhachHang item in listKhachHang)
            {
                ListViewItem lvKhachHang = new ListViewItem(item.TenKH.ToString());
                lvKhachHang.SubItems.Add(item.LoaiKhach.ToString());
                lvKhachHang.SubItems.Add(item.CMND.ToString());
                lvKhachHang.SubItems.Add(item.DiaChi.ToString());

                lvCTPhieuThuePhong.Items.Add(lvKhachHang);
            }
        }     

        bool XoaPhieuThuePhongTheoMaPhieu(string maPhieu)
        {
            KhachHangDAO.Instance.XoaKhachHang(maPhieu);
            if (PhieuThuePhongDAO.Instance.XoaPhieuThuePhong(maPhieu))
            {
                MessageBox.Show("Xóa phiếu thành công!");
                return true;
            }
            else
                MessageBox.Show("Xóa phiếu không thành công!");
            return false;
        }
        #endregion

        #region Event
        void btn_Click(object sender, EventArgs e)
        {
            string maPhong = ((sender as Button).Tag as Phong).MaPhong;
            string maPhieu = PhieuThuePhongDAO.Instance.LayMaPhieuTheoMaPhong(maPhong);
            tbMaPhong.Text = maPhong;
            if (maPhieu != null)
                tbMaPhieu.Text = maPhieu;
            else
                tbMaPhieu.Text = string.Empty;
            CTPhieuThuePhong(maPhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maphieu = tbMaPhieu.Text;
            if (maphieu == string.Empty)
            {
                MessageBox.Show("Vui lòng lập phiếu trước tiên!");
            }
            else
            {
                if (lvCTPhieuThuePhong.Items.Count < 3)
                {
                    frmThanhvien frm = new frmThanhvien(maphieu);
                    frm.ShowDialog();
                    CTPhieuThuePhong(tbMaPhong.Text);
                }
                else
                {
                    MessageBox.Show("Mỗi phòng chỉ tối đa 3 người!");
                }
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (tbMaPhieu.Text == string.Empty)
            { 
                if (PhieuThuePhongDAO.Instance.LapPhieuThuePhong(tbMaPhong.Text, dtpStart.Text, dtpEnd.Text))
                {
                    MessageBox.Show("Lập phiếu thuê thành công!");
                    tbMaPhieu.Text = PhieuThuePhongDAO.Instance.LayMaPhieuTheoMaPhong(tbMaPhong.Text).ToString();
                    PhongDAO.Instance.CapNhatPhongTheoMaPhong(tbMaPhong.Text);
                    flpRoom.Controls.Clear();
                    LoadDanhSachPhong();                                      

                    tbThanhTien.Text = LoadTongTien().ToString("c");
                }
                else
                    MessageBox.Show("Lập phiếu thuê không thành công!");
            }

        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            string maPhong = tbMaPhong.Text;
            string maPhieu = tbMaPhieu.Text;

            if (maPhieu != string.Empty)
            {
                for (int i = 0; i < lvCTHoaDon.Items.Count; i++)
                {
                    if (lvCTHoaDon.Items[i].SubItems[1].Text == maPhong)
                    {
                        TongTien -= LoadTongTien();
                        tbTongTien.Text = TongTien.ToString("c");

                        lvCTHoaDon.Items.RemoveAt(i);

                        for (int j = 0; j < lvCTHoaDon.Items.Count; j++)
                        {
                            lvCTHoaDon.Items[j].Text = (j + 1).ToString();
                        }

                        break;
                    }
                }

                if (XoaPhieuThuePhongTheoMaPhieu(maPhieu))
                {
                    PhongDAO.Instance.CapNhatPhongTheoMaPhong(maPhong);
                    tbMaPhieu.Text = "";
                    tbThanhTien.Text = "";
                    lvCTPhieuThuePhong.Items.Clear();
                    LoadDanhSachPhong();
                    tbThanhTien.Text = LoadTongTien().ToString("c");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Phong room = PhongDAO.Instance.LayThongTinPhongTheoMaPhong(tbMaPhong.Text);

            ListViewItem item = new ListViewItem((lvCTHoaDon.Items.Count + 1).ToString());

            item.SubItems.Add(tbMaPhong.Text);
            item.SubItems.Add(dtpEnd.Value.Subtract(dtpStart.Value).TotalDays.ToString());
            item.SubItems.Add(room.DonGia.ToString());
            item.SubItems.Add(tbThanhTien.Text);

            lvCTHoaDon.Items.Add(item);

            TongTien += LoadTongTien();
            tbTongTien.Text = TongTien.ToString("c");
        }
        #endregion
    }
}
