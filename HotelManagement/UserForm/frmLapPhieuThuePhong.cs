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
        public frmLapPhieuThuePhong()
        {
            InitializeComponent();
            LoadDanhSachPhong();
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
                btn.Text = item.MaPhong + Environment.NewLine + "Loại phòng: " + loaiphong.TenLoaiPhong + Environment.NewLine + "Đơn giá: " + loaiphong.DonGia.ToString();
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

        void CTPhieuThuePhong()
        {
            string maPhieu = tbMaPhieu.Text;
            
            dgvCTPhieuThuePhong.DataSource = CT_PhieuThuePhongDAO.Instance.LayDanhSachKhachHangTheoMaPhieu(maPhieu);
        }     

        bool XoaPhieuThuePhongTheoMaPhieu(string maPhieu)
        { 
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
            CTPhieuThuePhong();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maphieu = tbMaPhieu.Text;
            if (maphieu == string.Empty)
            {
                MessageBox.Show("Vui lòng lập phiếu trước tiên!");
            }
            else
            {
                frmCT_PhieuThuePhong frm = new frmCT_PhieuThuePhong(tbMaPhong.Text, tbMaPhieu.Text);
                frm.ShowDialog();
                CTPhieuThuePhong();
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            string maPhieu = tbMaPhieu.Text;

            if (maPhieu != string.Empty)
            {
                if (XoaPhieuThuePhongTheoMaPhieu(maPhieu))
                {
                    PhongDAO.Instance.CapNhatDanhSachPhong();
                    tbMaPhieu.Text = "";
                    LoadDanhSachPhong();
                }
            }
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan frm = new frmThanhToan();
            frm.ShowDialog();
            CTPhieuThuePhong();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.MinDate = dtpStart.Value;
        }
        #endregion
    }
}
