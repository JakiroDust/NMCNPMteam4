using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private List<string> listPTP = new List<string>();
        private bool flag = false;

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
                LoaiPhong loaiphong = LoaiPhongDAO.Instance.LayThongTinLoaiPhongTheoMaLoaiPhong(item.MaLoaiPhong);
                btn.Text = item.MaPhong + Environment.NewLine + "Tình trạng: " + item.TinhTrang + Environment.NewLine + "Đơn giá: " + loaiphong.DonGia.ToString();
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.TinhTrang)
                {
                    case true:
                        btn.BackColor = Color.Aqua;
                        break;
                    case false:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpRoom.Controls.Add(btn);
            }
        }

        

        void CTPhieuThuePhong(string maPhong)
        {
            lvCTPhieuThuePhong.Items.Clear();

            string maPhieu = tbMaPhieu.Text;

            List<CT_PhieuThuePhong> listKhachHang = CT_PhieuThuePhongDAO.Instance.LayDanhSachKhachHangTheoMaPhieu(maPhieu);
            /*tbThanhTien.Text = LoadTongTien().ToString("c");*/

            foreach (CT_PhieuThuePhong item in listKhachHang)
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
            CT_PhieuThuePhongDAO.Instance.XoaKhachHang(maPhieu);
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
            string maPhong = ((sender as Button).Tag as Phong).MaPhong.ToString();
            PhieuThuePhong ptp = PhieuThuePhongDAO.Instance.LayPhieuThuePhongConHanTheoMaPhong(maPhong);
            tbMaPhong.Text = maPhong;
            if (ptp != null)
            {
                tbMaPhieu.Text = ptp.MaPhieuThuePhong.ToString();
                tbSoLuongKhach.Text = ptp.SoLuongKhach.ToString();
                dtpStart.Value = ptp.NgayBDThue;
                dtpEnd.Value = ptp.NgayKTThue;
            }
            else
            {
                tbMaPhieu.Text = string.Empty;
                tbSoLuongKhach.Text = string.Empty;
                dtpStart.Value = DateTime.Now;
                dtpEnd.Value = DateTime.Now;
            }
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
                /*if (lvCTPhieuThuePhong.Items.Count < 3)
                {*/
                    frmThanhvien frm = new frmThanhvien(maphieu);
                    frm.ShowDialog();
                    CTPhieuThuePhong(tbMaPhong.Text);
                /*}
                else
                {
                    MessageBox.Show("Mỗi phòng chỉ tối đa 3 người!");
                }*/
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMaPhieu.Text == string.Empty && tbSoLuongKhach.Text != string.Empty)
                {
                    LoaiPhong loaiphong = LoaiPhongDAO.Instance.LayThongTinLoaiPhongTheoMaPhong(tbMaPhong.Text);
                    if (PhieuThuePhongDAO.Instance.LapPhieuThuePhong(tbMaPhong.Text, int.Parse(tbSoLuongKhach.Text), dtpStart.Text, dtpEnd.Text, loaiphong.DonGia))
                    {
                        MessageBox.Show("Lập phiếu thuê thành công!");
                        tbMaPhieu.Text = PhieuThuePhongDAO.Instance.LayMaPhieuTheoMaPhong(tbMaPhong.Text).ToString();
                        PhongDAO.Instance.CapNhatDanhSachPhong();
                        flpRoom.Controls.Clear();
                        LoadDanhSachPhong();

                        listPTP.Add(tbMaPhieu.Text);
                    }
                    else
                        MessageBox.Show("Lập phiếu thuê không thành công!");
                }
                else
                    MessageBox.Show("Lập phiếu thuê không thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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
                    PhongDAO.Instance.CapNhatDanhSachPhong();
                    tbMaPhieu.Text = "";
                    tbThanhTien.Text = "";
                    lvCTPhieuThuePhong.Items.Clear();
                    LoadDanhSachPhong();

                    listPTP.Remove(maPhieu);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Phong room = PhongDAO.Instance.LayThongTinPhongTheoMaPhong(tbMaPhong.Text);

            ListViewItem item = new ListViewItem((lvCTHoaDon.Items.Count + 1).ToString());

            LoaiPhong loaiphong = LoaiPhongDAO.Instance.LayThongTinLoaiPhongTheoMaLoaiPhong(room.MaLoaiPhong);

            item.SubItems.Add(tbMaPhong.Text);
            item.SubItems.Add(dtpEnd.Value.Subtract(dtpStart.Value).TotalDays.ToString());
            item.SubItems.Add(loaiphong.DonGia.ToString());
            item.SubItems.Add(tbThanhTien.Text);

            lvCTHoaDon.Items.Add(item);        
        }

        private void btLapHoaDon_Click(object sender, EventArgs e)
        {
            if (tbTen.Text != string.Empty && tbDiaChi.Text != string.Empty && tbSDT.Text != string.Empty)
            {
                if (flag == false)
                {
                    if (HoaDonDAO.Instance.LapHoaDon(tbDiaChi.Text, tbSDT.Text, tbTen.Text) == true)
                    {
                        HoaDon hoaDon = HoaDonDAO.Instance.LayMaHDVuaLap();
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
                            item.SubItems.Add(ptp.DonGiaSan.ToString());
                            item.SubItems.Add(ct.ThanhTien.ToString());

                            lvCTHoaDon.Items.Add(item);
                        }
                        tbTongTien.Text = hoaDon.TriGia.ToString("c");
                        flag = true;
                    }
                }            
            }
        }
        #endregion
    }
}
