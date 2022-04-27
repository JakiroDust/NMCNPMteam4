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
    public partial class frmCT_PhieuThuePhong : Form
    {
        public frmCT_PhieuThuePhong(object dataSource, string maPhong, string maPhieu)
        {
            InitializeComponent();
            dgvDanhSachKhachHang.DataSource = dataSource;
            tbMaPhong.Text = maPhong;
            tbMaPhieu.Text = maPhieu;
            LoadDanhSachLoaiKhachVaoComboBox(cbLoaiKhach);
            ThemBindingVaoDanhSach();
        }

        void ThemBindingVaoDanhSach()
        {
            tbID.DataBindings.Add(new Binding("Text", dgvDanhSachKhachHang.DataSource, "ID", true));
            tbTenKH.DataBindings.Add(new Binding("Text", dgvDanhSachKhachHang.DataSource, "Tên khách hàng", true));
            cbLoaiKhach.DataBindings.Add(new Binding("Text", dgvDanhSachKhachHang.DataSource, "Loại khách", true));
            tbCMND.DataBindings.Add(new Binding("Text", dgvDanhSachKhachHang.DataSource, "CMND", true));
            tbDiaChi.DataBindings.Add(new Binding("Text", dgvDanhSachKhachHang.DataSource, "Địa chỉ", true));
        }

        void LoadDanhSachLoaiKhachVaoComboBox(ComboBox cb)
        {
            cb.DataSource = LoaiKhachDAO.Instance.LoadDanhSachLoaiKhach();
            cb.DisplayMember = "TenLoaiKhach";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbTenKH.Text != string.Empty && tbCMND.Text != string.Empty && tbDiaChi.Text != string.Empty)
            {
                try
                {
                    string MaPhieu = tbMaPhieu.Text;
                    string TenKH = tbTenKH.Text;
                    string LoaiKhach = cbLoaiKhach.Text;
                    string CMND = tbCMND.Text;
                    string DiaChi = tbDiaChi.Text;

                    if (CT_PhieuThuePhongDAO.Instance.ThemKhachHang(MaPhieu, TenKH, LoaiKhach, CMND, DiaChi))
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                        CTPhieuThuePhong();
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

        private void tbSua_Click(object sender, EventArgs e)
        {
            string name = tbTenKH.Text;
            string loaiKhach = cbLoaiKhach.Text;
            string cMND = tbCMND.Text;
            string diaChi = tbDiaChi.Text;
            string id = tbID.Text;

            if (CT_PhieuThuePhongDAO.Instance.SuaKhachHang(id, name, loaiKhach, cMND, diaChi))
            {
                MessageBox.Show("Sua khach hang thanh cong!");
                CTPhieuThuePhong();

            }
            else
                MessageBox.Show("Sua khach hang khong thanh cong!");
        }

        private void tbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void CTPhieuThuePhong()
        {
            string maPhieu = tbMaPhieu.Text;

            dgvDanhSachKhachHang.DataSource = CT_PhieuThuePhongDAO.Instance.LayDanhSachKhachHangTheoMaPhieu(maPhieu);
        }
    }
}
