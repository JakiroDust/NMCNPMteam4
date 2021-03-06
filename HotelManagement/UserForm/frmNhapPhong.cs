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
    public partial class frmNhapPhong : Form
    {
        int temp;
        public frmNhapPhong()
        {
            InitializeComponent();
            loadRoom();
            bindDataComboBox();
            txtDonGia.ReadOnly = true;
            
        }
        
        public void bindDataComboBox()
        {
            String query = "Select * from LOAIPHONG order by TenLoaiPhong asc";
            DataTable a = new DataTable();
            
            a = DataProvider.Instance.ExecuteQuery(query);
            for (int i=0;i<a.Rows.Count;i++)
            {
                cbLoaiPhong.Items.Add(a.Rows[i]["TenLoaiPhong"]);
            }
            if (a.Rows.Count == 0)
                throw new IndexOutOfRangeException();
            else
            cbLoaiPhong.SelectedIndex = 0;
        }
        public bool insertPhong()
        {
            try
            {
                //string query = "insert into PHONG(TenPhong,TenLoaiPhong,GhiChu) values ('" + tbPhong.Text + "','" + cbLoaiPhong.Text + "', '" + tbGhiChu.Text + "')";
                string query = "declare @temp int; select @temp=MaLoaiPhong from LOAIPHONG where TenLoaiPhong=N'" + cbLoaiPhong.Text + "'; insert into PHONG(TenPhong, MaLoaiPhong, GhiChu) values(N'" + tbPhong.Text + "', @temp , N'" + tbGhiChu.Text + "') ";
                dgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
                return true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Vượt quá số kí tự cho phép, vui lòng nhập ít hơn 10 kí tự cho tên và 200 kí tự cho ghi chú.");
                return false;
            }
        }
        public void updatePhong()
        {

            string query = "declare @temp1 int; select @temp1 = MaLoaiPhong from LOAIPHONG where TenLoaiPhong = '"+ cbLoaiPhong.Text + "' ; update PHONG set TenPhong = '" + tbPhong.Text + "',MaLoaiPhong=  @temp1, GhiChu = '" + tbGhiChu.Text + "' where MaPhong = '" + temp + "'";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public void deletePhong()
        {
            string query = "delete from PHONG where TenPhong = '" + tbPhong.Text + "'";
            DataProvider.Instance.ExecuteNonQuery($"exec FUNC_DELETE_CT_BAOCAODOANHTHUTHEOLOAIPHONG_PHONG @TenPhong=N'{tbPhong.Text}'");
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public void loadRoom()
        {
            string query = "select MaPhong, TenPhong as 'Phòng' ,TenLoaiPhong as 'Loại Phòng',DonGia as 'Đơn Giá',GhiChu as 'Ghi Chú' from PHONG join LOAIPHONG on PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong";
           
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dgv.Columns[0].Visible = false;
        }
        private Boolean checkDuplicate(int specialcase=0)
        {
            String query = "Select * from PHONG";
            DataTable a = new DataTable();
            a = DataProvider.Instance.ExecuteQuery(query);
            if(specialcase==0)
            for (int i = 0; i < a.Rows.Count; i++)
            {
                if (tbPhong.Text.Equals(a.Rows[i]["TenPhong"])) return false;
            }
            if(specialcase==1)
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    if (tbPhong.Text.Equals(a.Rows[i]["TenPhong"]))
                    {
                        if (temp!=int.Parse(a.Rows[i]["MaPhong"].ToString())) return false;
                    }
                }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbPhong.Text == "")
            {
                MessageBox.Show("Thêm Thất Bại!!. Phòng không được để trống");
            }
            else if (!checkDuplicate())
            {
                MessageBox.Show("Thêm Thất Bại!!. Tên phòng bị trùng");
            }
            else
            {
                if(insertPhong())
                MessageBox.Show("Thêm Thành công");

                loadRoom();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbPhong.Text == "")
            {
                MessageBox.Show("Xoá Thất Bại!!. Phòng không được để trống");
            }
            else
            {
                deletePhong();
                MessageBox.Show("Xoá Thành công");
                loadRoom();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbPhong.Text == "")
            {
                MessageBox.Show("Sửa Thất Bại!!. Phòng không được để trống");
            }
            else if (!checkDuplicate(1))
            {
                MessageBox.Show("Sửa Thất Bại!!. Tên phòng bị trùng");
            }
            else
            {
                updatePhong();
                MessageBox.Show("Sửa Thành công");
                loadRoom();
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow == null)
                return;

            int i;
            i = dgv.CurrentRow.Index;
            temp = int.Parse(dgv.Rows[i].Cells[0].Value.ToString());
            tbPhong.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbLoaiPhong.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtDonGia.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tbGhiChu.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.LOAIPHONG' table. You can move, or remove it, as needed.
            this.lOAIPHONGTableAdapter.Fill(this.quanLyKhachSanDataSet.LOAIPHONG);

        }
        */
        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select DonGia from LOAIPHONG where  TenLoaiPhong = '" + cbLoaiPhong.Text + "'";
            Object a = DataProvider.Instance.ExecuteScalar(query);
            txtDonGia.Text = a.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbPhong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
