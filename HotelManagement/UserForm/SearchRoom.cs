using QuanLyKhachSan.DAO;
using System;
using System.Data;
using System.Windows.Forms;
namespace QuanLyKhachSan
{
    public partial class SearchRoom : Form
    {
       private static SearchRoom instance;
        public SearchRoom()
        {
            InitializeComponent();
            cbSearchRoomType_Load();
            RefreshSearchBar();
        }

        public static SearchRoom GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new SearchRoom();
                }
                return instance;
            }
        }
        private void RefreshSearchBar()
        {
            ///  cbSearchRoomType.Text = string.Empty;
            cbSearchRoomState.Text = string.Empty;
            cbSearchRoomType.Text = string.Empty;
            tbSearchRoomCode.Text = string.Empty;
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
        private void btFindRoom_Click(object sender, EventArgs e)
        {
            dgvRoomSearch.DataSource = getRoom();
            int count = Convert.ToInt32(tbSearchRoomCode.Text != "") + Convert.ToInt32(cbSearchRoomState.Text != "") + Convert.ToInt32(cbSearchRoomType.Text != "");
            string rowfilter = "";
            if (count == 0)
                return;
            if (tbSearchRoomCode.Text != "")
            {
                count--;
                rowfilter = "[Mã Phòng] like '" + tbSearchRoomCode.Text + "'";
                if (count != 0) rowfilter = rowfilter + " and ";
            }
            if (cbSearchRoomType.Text != "")
            {
                count--;
                rowfilter = rowfilter + " [Loại Phòng] ='" + cbSearchRoomType.Text + "'"; ;
                if (count != 0) rowfilter = rowfilter + " and ";
            }
            // 
            if (cbSearchRoomState.Text != "")
            {
                rowfilter = rowfilter + " [Tình Trạng] ='"+cbSearchRoomState.Text+"'";
            }
             (dgvRoomSearch.DataSource as DataTable).DefaultView.RowFilter = rowfilter;

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
            cbSearchRoomType.DataSource = target;
            cbSearchRoomType.DisplayMember = "TenLoaiPhong";
            cbSearchRoomType.SelectedIndex = -1;

        }
        private void cbSearchRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
         

        }

        private void cbSearchRoomState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
