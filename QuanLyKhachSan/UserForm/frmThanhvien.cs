using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            LoadDanhSachLoaiKhachVaoComboBox(cbLoaiKhach);
            tbMaPhieu.Text = maphieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbTen.Text != string.Empty && tbCMND.Text != string.Empty && tbDiaChi.Text != string.Empty)
            {
                try
                {
                    string MaPhieu = tbMaPhieu.Text;
                    string TenKH = tbTen.Text;
                    string LoaiKhach = cbLoaiKhach.Text;
                    string CMND = tbCMND.Text;
                    string DiaChi = tbDiaChi.Text;

                    if (CT_PhieuThuePhongDAO.Instance.ThemKhachHang(MaPhieu, TenKH, LoaiKhach, CMND, DiaChi))
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công!");
                    }
                }
                catch (SqlException ex)
                {
MessageBox.Show(ex.Message);
                }
            }            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadDanhSachLoaiKhachVaoComboBox(ComboBox cb)
        {
            cb.DataSource = LoaiKhachDAO.Instance.LoadDanhSachLoaiKhach();
            cb.DisplayMember = "TenLoaiKhach";
        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
