using QuanLyKhachSan.DAO;
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;
namespace QuanLyKhachSan
{
    public partial class frmTimPhong : Form
    {
       private static frmTimPhong instance;
        public frmTimPhong()
        {
            InitializeComponent();
            cbSearchRoomType_Load();
            RefreshSearchBar();
            findRoom();
        }

        public static frmTimPhong GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmTimPhong();
                }
                return instance;
            }
        }
        private void RefreshSearchBar()
        {
            ///  cbSearchRoomType.Text = string.Empty;
            cbTinhTrang.Text = string.Empty;
            cbLoaiPhong.Text = string.Empty;
            tbPhong.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RefreshSearchBar();
        }
        public DataTable getRoom()
        {
            DataTable target = DataProvider.Instance.ExecuteQuery("select PHONG.TenPhong as 'Phòng',LOAIPHONG.TenLoaiPhong as 'Loại Phòng',LOAIPHONG.DonGia as 'Đơn Giá',PHONG.TinhTrang as 'boolTinhTrang' from PHONG,LOAIPHONG where PHONG.MaLoaiPhong=LoaiPhong.MaLoaiPhong");
            target.Columns.Add("Tình Trạng");
            foreach (DataRow row in target.Rows)
            {
                if ((bool)row["boolTinhTrang"] == true)
                {
                    row["Tình Trạng"] = "Trống";

                }
                else
                    row["Tình Trạng"] = "Đầy";
            }
            target.Columns.Remove("boolTinhTrang");
            return target;
        }
        private void findRoom()
        {
            dgvPhong.DataSource = getRoom();
            int count = Convert.ToInt32(tbPhong.Text != "") + Convert.ToInt32(cbTinhTrang.Text != "") + Convert.ToInt32(cbLoaiPhong.Text != "");
            string rowfilter = "";
            if (count == 0)
                return;
            if (tbPhong.Text != "")
            {
                count--;
                rowfilter = "[Phòng] like '" + tbPhong.Text + "'";
                if (count != 0) rowfilter = rowfilter + " and ";
            }
            if (cbLoaiPhong.Text != "")
            {
                count--;
                rowfilter = rowfilter + " [Loại Phòng] ='" + cbLoaiPhong.Text + "'"; ;
                if (count != 0) rowfilter = rowfilter + " and ";
            }
            // 
            if (cbTinhTrang.Text != "")
            {
                rowfilter = rowfilter + " [Tình Trạng] ='" + cbTinhTrang.Text + "'";
            }
             (dgvPhong.DataSource as DataTable).DefaultView.RowFilter = rowfilter;
        }
        private void btFindRoom_Click(object sender, EventArgs e)
        {
            PhongDAO.Instance.CapNhatDanhSachPhong();
            findRoom();
        }

        private void cbSearchCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvRoomSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void cbSearchRoomType_Load()
        {
            DataTable target = DataProvider.Instance.ExecuteQuery("select TenLoaiPhong from LOAIPHONG order by TenLoaiPhong asc");

            target.Rows.InsertAt(target.NewRow(), 0);/// ADD a blank row
            cbLoaiPhong.DataSource = target;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.SelectedIndex = -1;

        }
        private void cbSearchRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
         

        }

        private void cbSearchRoomState_SelectedIndexChanged(object sender, EventArgs e)
        {
           //// MessageBox.Show(cbSearchRoomState.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSearchRoomState_Validated(object sender, EventArgs e)
        {
            ///MessageBox.Show(cbSearchRoomState.Text);
        }

        private void lbPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
