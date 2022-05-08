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
        readonly BindingSource CTPTP = new BindingSource();

        public frmCT_PhieuThuePhong(string maPhong, string maPhieu)
        {

            InitializeComponent();

            dgvDanhSachKhachHang.DataSource = CTPTP;

            LoadCTPhieuThuePhong();
            tbMaPhong.Text = maPhong;
            tbMaPhieu.Text = maPhieu;
            LoadCTPhieuThuePhong();
            LoadDanhSachLoaiKhachVaoComboBox(cbLoaiKhach);
            ThemBindingVaoDanhSach();
        }     

        void ThemBindingVaoDanhSach()
        {
            tbID.DataBindings.Add(new Binding("Text", dgvDanhSachKhachHang.DataSource, "ID", true, DataSourceUpdateMode.Never));
            tbTenKH.DataBindings.Add(new Binding("Text", dgvDanhSachKhachHang.DataSource, "Tên khách hàng", true, DataSourceUpdateMode.Never));
            cbLoaiKhach.DataBindings.Add(new Binding("Text", dgvDanhSachKhachHang.DataSource, "Loại khách", true, DataSourceUpdateMode.Never));
            tbCMND.DataBindings.Add(new Binding("Text", dgvDanhSachKhachHang.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            tbDiaChi.DataBindings.Add(new Binding("Text", dgvDanhSachKhachHang.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
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
                        LoadCTPhieuThuePhong();
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
                LoadCTPhieuThuePhong();
            }
            else
                MessageBox.Show("Sua khach hang khong thanh cong!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CT_PhieuThuePhongDAO.Instance.XoaKhachHangTheoID(tbID.Text))
            {
                MessageBox.Show("Xoa khach hang thanh cong!");
                LoadCTPhieuThuePhong();
            }
        }

        private void tbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadCTPhieuThuePhong()
        {
            CTPTP.DataSource = CT_PhieuThuePhongDAO.Instance.LayDanhSachKhachHangTheoMaPhieu(tbMaPhieu.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
