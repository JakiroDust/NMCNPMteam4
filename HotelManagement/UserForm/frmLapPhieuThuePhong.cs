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
            cbLoaiPhong_Load();
            cbTinhTrang.SelectedIndex = 0;
            LoadDanhSachPhong();
        }


        #region Method
        void LoadDanhSachPhong()
        {
            flpRoom.Controls.Clear();
            PhongDAO.Instance.CapNhatDanhSachPhong();
            List<Phong> roomList = PhongDAO.Instance.LoadDanhSachPhong();

            foreach (Phong item in roomList)
            {
                Button btn = new Button() { Width = PhongDAO.RoomWidth, Height = PhongDAO.RoomHeight};
                LoaiPhong loaiphong = LoaiPhongDAO.Instance.LayThongTinLoaiPhongTheoMaLoaiPhong(item.MaLoaiPhong);
                btn.Text = "Tên phòng: " + item.TenPhong + Environment.NewLine + "Đơn giá: " + loaiphong.DonGia.ToString()+ Environment.NewLine +"Loại phòng: "+loaiphong.TenLoaiPhong;
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

        void FiltflpRoom(string type, string state)
        {
            foreach(Control c in flpRoom.Controls)
            {
                c.Visible = true;
            }
            if(type!="Tất cả")
            foreach (Control c in flpRoom.Controls)
            {
                    if(!c.Text.Contains($"Loại phòng: {type}"))
                    c.Visible = false;
            }
    switch(state)
            {
                case "Trống":
                    foreach (Control c in flpRoom.Controls)
                    {
                        if (c.BackColor!=Color.Aqua)
                            c.Visible = false;
                    }
                    break;
                case "Đầy":
                    foreach (Control c in flpRoom.Controls)
                    {
                        if (c.BackColor != Color.LightPink)
                            c.Visible = false;
                    }
                    break;
                default:
                    break;

            }    

        }

        private void cbLoaiPhong_Load()
        {
            DataTable target = DataProvider.Instance.ExecuteQuery("select TenLoaiPhong from LOAIPHONG order by TenLoaiPhong asc");
            DataRow a = target.NewRow();
            a[0] = "Tất cả";
            target.Rows.InsertAt(a, 0);/// ADD a blank row
            cbLoaiPhong.DataSource = target;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.SelectedIndex = 0;

        }

        private void loadbtnSelectedRoom(string Text,Color clr)
        {
            btnPhongDangChon.Text = Text;
            btnPhongDangChon.BackColor = clr;
        }
        #endregion

        #region Event
        void btn_Click(object sender, EventArgs e)
        {
            string maPhong = ((sender as Button).Tag as Phong).MaPhong.ToString();
            string tenPhong= ((sender as Button).Tag as Phong).TenPhong.ToString();
            PhieuThuePhong ptp = PhieuThuePhongDAO.Instance.LayPhieuThuePhongConHanTheoMaPhong(maPhong);
            tbMaPhong.Text = maPhong;
            tbTenPhong.Text = tenPhong;
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
            loadbtnSelectedRoom((sender as Button).Text, Color.AliceBlue);
            CTPhieuThuePhong();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if(tbMaPhong.Text=="")
            {
                MessageBox.Show("Chưa chọn phòng");
                return;
            }    
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
            { DataTable check = DataProvider.Instance.ExecuteQuery("select * from LOAIKHACH");
                if(check.Rows.Count==0)
                {
                    MessageBox.Show("Vui lòng tạo loại khách trước.\n Cài đặt -> Loại khách");
                }    
            else
                {
                    frmCT_PhieuThuePhong frm = new frmCT_PhieuThuePhong(tbMaPhong.Text,tbTenPhong.Text, tbMaPhieu.Text);
                    frm.ShowDialog();
                    CTPhieuThuePhong();
                }
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

        private void tbMaPhieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSoLuongKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSearchRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = (sender as ComboBox).Text;
            FiltflpRoom(str, cbTinhTrang.Text);
        }

        private void cbSearchRoomState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = (sender as ComboBox).Text;
            FiltflpRoom(cbLoaiPhong.Text,str);

        }

        private void maLoaiPhongLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbMaPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void flpRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCTPhieuThuePhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
