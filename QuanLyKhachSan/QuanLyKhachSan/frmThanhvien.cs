using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan
{
    public partial class frmThanhvien : Form
    {
        public frmThanhvien(string maphieu)
        {
            InitializeComponent();
            tbMaPhieu.Text = maphieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaPhieu = tbMaPhieu.Text;
            string TenKH = tbTen.Text;
            string LoaiKhach = cbLoaiKhach.Text;
            string CMND = tbCMND.Text;
            string DiaChi = tbDiaChi.Text;

            if (KhachHangDAO.Instance.ThemKhachHang(MaPhieu, TenKH, LoaiKhach, CMND, DiaChi))
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng không thành công!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
