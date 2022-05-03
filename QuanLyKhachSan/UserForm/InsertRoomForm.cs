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
    public partial class InsertRoomForm : Form
    {
        int temp;
        private static InsertRoomForm instance;
        public InsertRoomForm()
        {
            InitializeComponent();
            loadRoom();
        }
        public static InsertRoomForm GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new InsertRoomForm();
                }
                return instance;
            }
        }
        public void insertPhong()
        {
            string query = "insert into PHONG(TenPhong,MaLoaiPhong,GhiChu) values ('" + tbPhong.Text + "','" + cbLoaiPhong.Text + "', '" + tbGhiChu.Text + "')";
            DataProvider provide = new DataProvider();
            dgv.DataSource = provide.ExecuteQuery(query);
        }
        public void updatePhong()
        {

            string query = "update PHONG set TenPhong = '" + tbPhong.Text + "',MaLoaiPhong = '" + cbLoaiPhong.Text + "' ,GhiChu = '" + tbGhiChu.Text + "' where MaPhong = '" + temp + "'";
            DataProvider provide = new DataProvider();
            dgv.DataSource = provide.ExecuteQuery(query);
        }
        public void deletePhong()
        {
            string query = "delete from PHONG where TenPhong = '" + tbPhong.Text + "'";
            DataProvider provide = new DataProvider();
            dgv.DataSource = provide.ExecuteQuery(query);
        }
        public void loadRoom()
        {
            string query = "select MaPhong as 'ID', TenPhong as 'Phòng' ,PHONG.MaLoaiPhong as 'Loại Phòng',DonGia as 'Đơn Giá',GhiChu as 'Ghi Chú' from PHONG join LOAIPHONG on PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong";
            DataProvider provide = new DataProvider();
            dgv.DataSource = provide.ExecuteQuery(query);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            for(int item = 0; item < dgv.Rows.Count; item++)
            {
                if(tbPhong.Text == dgv.Rows[item].Cells[1].Value.ToString())
                {
                    MessageBox.Show("ID duplicate");
                    return;
                }
            }
            insertPhong();
            loadRoom();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            deletePhong();
            loadRoom();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updatePhong();
            loadRoom();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            temp = int.Parse(dgv.Rows[i].Cells[0].Value.ToString());
            tbPhong.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbLoaiPhong.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cbDonGia.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tbGhiChu.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void InsertRoomForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.LOAIPHONG' table. You can move, or remove it, as needed.
/// this.lOAIPHONGTableAdapter.Fill(this.quanLyKhachSanDataSet.LOAIPHONG);

        }
    }
}
