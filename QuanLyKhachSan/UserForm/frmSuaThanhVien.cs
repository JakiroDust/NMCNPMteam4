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
    public partial class frmSuaThanhVien : Form
    {
        public frmSuaThanhVien(object dataSource, string maPhong, string maPhieu)
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

            }
            else
                MessageBox.Show("Sua khach hang khong thanh cong!");
        }

        private void tbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
