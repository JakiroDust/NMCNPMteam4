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
namespace QuanLyKhachSan.UserForm
{
    public partial class frmChinhThamSo : Form
    {
        public frmChinhThamSo()
        {
            InitializeComponent();
            getThamSo();
            getLoaiPhong();
            getPhuThu();
            getLoaiKhach();
        }
        private void getThamSo()
        {
            ///
            DataTable target=DataProvider.Instance.ExecuteQuery("select TenThamSo as 'TenThamSo',TenThamSo as 'Tên Tham Số',GiaTriThamSo as 'Hệ Số' from ThamSo");

              foreach (DataRow row in target.Rows)
              {
                  if ((string)row["Tên Tham Số"] == "SoKhachToiDa")
                  {
                      row["Tên Tham Số"] = "Số khách tối đa";

                  }
            }
            dgvThamSo.DataSource = target;
            dgvThamSo.Columns["TenThamSo"].Visible = false;


        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void getThamSoforDGV()
        {
            if (dgvThamSo.CurrentRow == null)
                return;
            int i;
            i = dgvThamSo.CurrentRow.Index;
            tbTenThamSo.Text = dgvThamSo.Rows[i].Cells[1].Value.ToString();
            tbHeSo.Text = dgvThamSo.Rows[i].Cells[2].Value.ToString();
        }    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getThamSoforDGV();
            ///  cbLoaiPhong.Text = dgv.Rows[i].Cells[2].Value.ToString();
            //txtDonGia.Text = dgv.Rows[i].Cells[3].Value.ToString();
            ///tbGhiChu.Text = dgv.Rows[i].Cells[4].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btEditThamSo_Click(object sender, EventArgs e)
        {
            if(tbTenThamSo.Text=="Chưa chọn tham số")
            {
                MessageBox.Show("Vui lòng chọn Tham Số");
            }
            else
            if(tbHeSo.Text=="")
            {
                MessageBox.Show("Vui lòng nhập hệ số");
            }
            else
            if(float.Parse(tbHeSo.Text)<=0)
            {
                MessageBox.Show("Hệ số phải lớn hơn không");
            }    
            else
            {
                int i;
                i = dgvThamSo.CurrentRow.Index;
                if(dgvThamSo.Rows[i].Cells[0].Value.ToString()=="SoKhachToiDa")
                {
                    if(!int.TryParse(tbHeSo.Text,out int outputt))
                        {
                        MessageBox.Show("Số lượng khách phải là số nguyên không âm");
                        return;
                    }
                }    
                DataProvider.Instance.ExecuteNonQuery($"update THAMSO set GiaTriThamSo={float.Parse(tbHeSo.Text)} where TenThamSo='{dgvThamSo.Rows[i].Cells[0].Value.ToString()}'");
                getThamSo();
                MessageBox.Show("Sửa thành công");
            }    
        }
        private void getLoaiPhong()
        {
            ///
            DataTable target = DataProvider.Instance.ExecuteQuery("select MaLoaiPhong as 'MaLoaiPhong',TenLoaiPhong as 'Loại phòng',DonGia as 'Đơn giá' from LOAIPHONG order by TenLoaiPhong asc");
            dgvLoaiPhong.DataSource = target;
            dgvLoaiPhong.Columns["MaLoaiPHong"].Visible = false;


        }
        private void getLoaiPhongfromDGV()
        {

        }
        private void dgvLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoaiPhong.CurrentRow == null)
                return;
            int i;
            i = dgvLoaiPhong.CurrentRow.Index;
            tbTenLoaiPhong.Text = dgvLoaiPhong.Rows[i].Cells[1].Value.ToString();
            tbDonGiaLoaiPhong.Text = dgvLoaiPhong.Rows[i].Cells[2].Value.ToString();
            tbMaLoaiPhong.Text = dgvLoaiPhong.Rows[i].Cells[0].Value.ToString();
        }

        private void tbTenLoaiPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDonGiaLoaiPhong_TextChanged(object sender, EventArgs e)
        {

        }
        private Boolean checkDuplicateforLOAIPHONG(int specialcase)
        {
            String query = "Select MaLoaiPhong,TenLoaiPhong from LOAIPHONG";
            DataTable a = new DataTable();
            a = DataProvider.Instance.ExecuteQuery(query);
            switch (specialcase)
            {
                case 1:
                    {
                        for (int i = 0; i < a.Rows.Count; i++)
                            if (tbTenLoaiPhong.Text.Equals(a.Rows[i]["TenLoaiPhong"]))
                            if(a.Rows[i][0]==tbMaLoaiPhong.Text)
                                return false;
                        return true;
                    }
                default:
            for (int i = 0; i < a.Rows.Count; i++)
            {
                if (tbTenLoaiPhong.Text.Equals(a.Rows[i]["TenLoaiPhong"])) return false;
            }
            return true;
        }
        }
        bool CheckDieuKienLoaiPhong(int specialcase=0)
        {
            string temp = "";
            string ErrorRealValue = "Đơn giá phải là số thực và lớn hơn 0\n";
            if(tbTenLoaiPhong.Text.Length>=20)
            {
                MessageBox.Show("Tên loại phòng phải bé hơn 19 kí tự.");
                return false;
            }    
            if (!float.TryParse(tbDonGiaLoaiPhong.Text, out float outputt))

                temp += ErrorRealValue;
            else
            {
                if (outputt <= 0)
                {
                    temp += ErrorRealValue;
                }
            }
            if (!checkDuplicateforLOAIPHONG(specialcase))
                temp += $"Bị trùng loại phòng: {tbTenLoaiPhong.Text}";
            if (temp != "")
            {
                MessageBox.Show(temp);
                return false;
            }
            return true;
        }
        void insertLoaiPhong()
        {
            if (CheckDieuKienLoaiPhong()) 
            {
                DataProvider.Instance.ExecuteNonQuery($"INSERT INTO LOAIPHONG(TenLoaiPhong,DonGia) values('{tbTenLoaiPhong.Text}',{float.Parse(tbDonGiaLoaiPhong.Text).ToString().Replace(",",".")})");
                MessageBox.Show("Thêm Thành công");
                getLoaiPhong();
            }    
        }
        private void btnThemLoaiPhong_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (tbTenLoaiPhong.Text == "")
            {
                temp+="Tên loại phòng không được để trống.\n";
            }
            if(tbDonGiaLoaiPhong.Text=="")
            {
                temp += "Đơn giá loại phòng không được để trống.\n";
            }
            if(temp!="")
            {
                MessageBox.Show(temp);
            }    
            else
            {
                insertLoaiPhong();

            }
        }

        private void btnSuaLoaiPhong_Click(object sender, EventArgs e)
        {
            if (tbMaLoaiPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Loại phòng trước");
                return;
            }
            if (CheckDieuKienLoaiPhong(1))
            {
                DataProvider.Instance.ExecuteNonQuery($"update LOAIPHONG set TenLoaiPhong='{tbTenLoaiPhong.Text}', DonGia={(float.Parse(tbDonGiaLoaiPhong.Text)).ToString().Replace(",", ".")} where TenLoaiPhong='{dgvLoaiPhong.CurrentRow.Cells["Loại phòng"].Value.ToString()}'");
                MessageBox.Show("Sửa loại phòng thành công");
                getLoaiPhong();
            }    
        }
        private bool CheckIfExistsLoaiPhong()
        {
            DataTable LoaiPhong = DataProvider.Instance.ExecuteQuery("Select TenLoaiPhong from LOAIPHONG");
            for(int i=0;i<LoaiPhong.Rows.Count;i++)
            {
                if (tbTenLoaiPhong.Text.Equals(LoaiPhong.Rows[i]["TenLoaiPhong"])) return true ;
            }    
            return false;
        }
        private void btnXoaLoaiPhong_Click(object sender, EventArgs e)
        {
            if (tbMaLoaiPhong.Text=="")
            {
                MessageBox.Show("Vui lòng chọn Loại phòng trước");
                return;
            }
            if (CheckIfExistsLoaiPhong())
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa loại phòng đang được chọn?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    return;
                DataProvider.Instance.ExecuteNonQuery($"exec FUNC_DELETE_CT_BAOCAODOANHTHUTHEOLOAIPHONG @MaLoaiPhong={dgvLoaiPhong.CurrentRow.Cells[0].Value.ToString()}");
                DataProvider.Instance.ExecuteNonQuery($"Delete from LOAIPHONG where MaLoaiPhong='{dgvLoaiPhong.CurrentRow.Cells[0].Value.ToString()}'");
                getLoaiPhong();
                BoChonLoaiPhong();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Loại phòng không tồn tại!");
            }    

        }

        private void tbMaLoaiPhong_TextChanged(object sender, EventArgs e)
        {

        }
        void BoChonLoaiPhong()
        {
            tbTenLoaiPhong.Text = "";
            tbDonGiaLoaiPhong.Text = "";
            tbMaLoaiPhong.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            BoChonLoaiPhong();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn reset loại phòng về ban đầu?\nWarn: Việc này sẽ làm bạn mất hết dữ liệu", "Reset về mặc định", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LoaiPhongDAO.Instance.ResetLoaiPhong();
                getLoaiPhong();
                BoChonLoaiPhong();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void getPhuThu()
        {
            ///
            DataTable target = PhuThuDao.Instance.getPhuThu();
            dgvPhuThu.DataSource = target;
            dgvPhuThu.Columns["MaPhuThu"].Visible = false;


        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn reset phụ thu về ban đầu?\nWarn: Việc này sẽ không ảnh hưởng gì hết", "Reset về mặc định", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PhuThuDao.Instance.ResetPhuThu();
                getPhuThu();
                BoChonPhuThu();
            }
        }
        private void BoChonPhuThu()
        {
            tbMocPhuThu.Text = "";
            tbHeSoPhuThu.Text = "";
            tbMaPhuThu.Text = "";
        }
        private void btnBoChonPhuThu_Click(object sender, EventArgs e)
        {
            BoChonPhuThu();

        }

        private void dgvPhuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPhuThu.CurrentRow!=null)
            {
                int i;
                i = dgvPhuThu.CurrentRow.Index;
                tbMocPhuThu.Text = dgvPhuThu.Rows[i].Cells[1].Value.ToString();
                tbHeSoPhuThu.Text = dgvPhuThu.Rows[i].Cells[2].Value.ToString();
                tbMaPhuThu.Text = dgvPhuThu.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (CheckDieuKienChoPhuThu())
            {
                PhuThuDao.Instance.InsertPhuThu(tbMocPhuThu.Text, tbHeSoPhuThu.Text);
                getPhuThu();
                MessageBox.Show("Thêm thành công.");
            }
        }
        bool CheckDieuKienChoPhuThu(int specialcase=0)
        {
            string temp = "";
            if (tbMocPhuThu.Text == "")
                temp += "Mốc phụ thu không được để trống.\n";

            if (tbHeSoPhuThu.Text == "")
                temp += "Hệ số phụ thu không được để trống.\n";
            else
            {
                if (!float.TryParse(tbHeSoPhuThu.Text, out float outputt))
                    temp += "Hệ số phụ thu phải là số nguyên và lớn hơn 0.\n";
                else
                if (outputt <= 0)
                    temp += "Hệ số phụ thu phải là số nguyên và lớn hơn 0.\n";
            }
            if (!int.TryParse(tbMocPhuThu.Text, out int tbmocphuthu))
            {
                temp += "Mốc phụ thu phải là 1 số nguyên dương.\n";
            }
            else
            if(tbmocphuthu<0)
            {
                temp += "Mốc phụ thu phải là 1 số nguyên dương.\n";
            }    

            if (temp != "")
            {
                MessageBox.Show(temp);
                return false;
            }
            switch(specialcase)
            {
                case 1:
                    {
                        for (int i = 0; i < dgvPhuThu.Rows.Count; i++)
                            if (tbMocPhuThu.Text.Equals(dgvPhuThu.Rows[i].Cells["Mốc"].Value.ToString()))
                                if (dgvPhuThu.Rows[i].Cells["MaPhuThu"].Value.ToString() != tbMaPhuThu.Text)
                                {
                                    MessageBox.Show($"Đã có mốc {tbMocPhuThu.Text}");
                                    return false;
                                }
                        break;
                    }
                default:
                    for (int i = 0; i < dgvPhuThu.Rows.Count; i++)
                    {
                        if (tbMocPhuThu.Text.Equals(dgvPhuThu.Rows[i].Cells["Mốc"].Value.ToString()))
                        {
                            MessageBox.Show($"Đã có mốc {tbMocPhuThu.Text}");
                            return false;
                        }
                    }
                    break;

            }
            return true;
        }

        private void dgvPhuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhuThu.CurrentRow == null)
                return;
            int i;
            i = dgvPhuThu.CurrentRow.Index;
            tbMocPhuThu.Text = dgvPhuThu.Rows[i].Cells["Mốc"].Value.ToString();
            tbHeSoPhuThu.Text = dgvPhuThu.Rows[i].Cells["Hệ số"].Value.ToString();
            tbMaPhuThu.Text = dgvPhuThu.Rows[i].Cells["MaPhuThu"].Value.ToString();
           /// tb
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tbMaPhuThu.Text=="")
            {
                MessageBox.Show("Chưa chọn mục tiêu chỉnh sửa.");
                return;
            }    
            if(CheckDieuKienChoPhuThu(1))
            {
                PhuThuDao.Instance.UpdatePhuThu(tbMaPhuThu.Text,tbMocPhuThu.Text,tbHeSoPhuThu.Text);
                    getPhuThu();
                BoChonPhuThu();
                    MessageBox.Show("Cập nhật phụ thu thành công.");
            }    
        }

        private void tbHeSoPhuThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbMaPhuThu.Text == "")
            {
                MessageBox.Show("Chưa chọn mục tiêu để xóa.");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa mốc phụ thu này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    return;
                PhuThuDao.Instance.DeletePhuThu(tbMaPhuThu.Text);
                getPhuThu();
                BoChonPhuThu();
                MessageBox.Show("Đã xóa thành công.");
               

            }    
        }

        private void tbMaPhuThu_TextChanged(object sender, EventArgs e)
        {

        }
        private void getLoaiKhachfromdgv()
        {
            if (dgvLoaiKhach.CurrentRow == null)
                return;
            int i;
            i = dgvLoaiKhach.CurrentRow.Index;
            tbLoaiKhach.Text = dgvLoaiKhach.Rows[i].Cells["Loại khách"].Value.ToString();
            tbHeSoLoaiKhach.Text = dgvLoaiKhach.Rows[i].Cells["Hệ số"].Value.ToString();
            tbMaLoaiKhach.Text = dgvLoaiKhach.Rows[i].Cells["ID"].Value.ToString();
        }
        private void dgvLoaiKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getLoaiKhachfromdgv();
        }
        private void getLoaiKhach()
        {
            dgvLoaiKhach.DataSource = LoaiKhachDAO.Instance.LoadDanhSachLoaiKhachv2();
            dgvLoaiKhach.Columns["ID"].Visible = false;
            BoChonLoaiKhach();
        }
        private bool checkDieuKienLoaiKhach(int specialcase=0)
        {
            string temp = "";
            if (tbLoaiKhach.Text == "")
                temp += "Mục loại khách không được để trống.\n";
            if (tbHeSoLoaiKhach.Text == "")
                temp += "Mục hệ số không được để trống.\n";
            if (!float.TryParse(tbHeSoLoaiKhach.Text, out float outputt))
                temp += "Hệ số phải là số nguyên dương.\n";
            else
            if (outputt <= 0)
                temp += "Hệ số phải là số nguyên dương.\n";
            if (tbLoaiKhach.Text.Length > 20)
                temp += "Tên loại khách phải bé hơn hoặc bằng 19 kí tự.\n";
            if (temp != "")
            {
                MessageBox.Show(temp);
                return false;
            }
            String query = "Select MaLoaiKhach,LoaiKhach from LOAIKHACH";
            DataTable a = DataProvider.Instance.ExecuteQuery(query);
            switch (specialcase)
            {
                case 1:
                    {
                        for (int i = 0; i < a.Rows.Count; i++)
                            if (tbLoaiKhach.Text.Equals(a.Rows[i]["LoaiKhach"]))
                                if (a.Rows[i][0] == tbMaLoaiKhach.Text)
                                {
                                    MessageBox.Show("Đã có loại khách :" + tbLoaiKhach.Text);
                                    return false;
                                }
                        return true;
                    }
                default:
                    for (int i = 0; i < a.Rows.Count; i++)
                    {
                        if (tbLoaiKhach.Text.Equals(a.Rows[i]["LoaiKhach"]))
                        {
                            MessageBox.Show("Đã có loại khách :" + tbLoaiKhach.Text);
                            return false;
                        }
                    }
                    return true;
            }
    
        }    
        void InsertLoaiKhach()
        {
            LoaiKhachDAO.Instance.InsertLoaiKhach(tbLoaiKhach.Text, tbHeSoLoaiKhach.Text);
        }    
        private void btnThemLoaiKhach_Click(object sender, EventArgs e)
        {
            if(checkDieuKienLoaiKhach())
            {
                InsertLoaiKhach();
                getLoaiKhach();
                MessageBox.Show("Thêm thành công");
            }    
        }
        void BoChonLoaiKhach()
        {
            tbMaLoaiKhach.Text = "";
            tbLoaiKhach.Text = "";
            tbHeSoLoaiKhach.Text = "";
        }
        private void tbBoChonLoaiKhach_Click(object sender, EventArgs e)
        {
            BoChonLoaiKhach();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn reset phụ thu về ban đầu?\nWarn: Việc này sẽ không ảnh hưởng gì hết", "Reset về mặc định", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LoaiKhachDAO.Instance.ResetLoaiKhach();
                getLoaiKhach();
            }

        }

        private void dgvLoaiKhach_Validated(object sender, EventArgs e)
        {
            getLoaiKhachfromdgv();
        }
        void UpdateLoaiKhach()
        {
            LoaiKhachDAO.Instance.UpdateLoaiKhach(tbMaLoaiKhach.Text, tbLoaiKhach.Text, tbHeSoLoaiKhach.Text);
        }
        private void btnSuaLoaiKhach_Click(object sender, EventArgs e)
        {
            if(tbMaLoaiKhach.Text=="")
            {
                MessageBox.Show("Mời bạn chọn Loại Khách trước");
                return;
            }    
            if(checkDieuKienLoaiKhach(1))
            {
                UpdateLoaiKhach();
                getLoaiKhach();
                MessageBox.Show("Sửa thành công.");
            }    
        }
        private void DeleteLoaiKhach()
        {
            LoaiKhachDAO.Instance.DeleteLoaiKhach(tbMaLoaiKhach.Text);
        }    
        private void btnXoaLoaiKhach_Click(object sender, EventArgs e)
        {
            if (tbMaLoaiKhach.Text == "")
            {
                MessageBox.Show("Mời bạn chọn Loại Khách trước");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xóa loại khách đang chọn?","Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteLoaiKhach();
                getLoaiKhach();
                MessageBox.Show("Đã xóa thành công");
            }
        }

        private void dgvLoaiKhach_Sorted(object sender, EventArgs e)
        {
            BoChonLoaiKhach();
        }

        private void dgvThamSo_Sorted(object sender, EventArgs e)
        {

        }

        private void dgvPhuThu_Sorted(object sender, EventArgs e)
        {
            BoChonPhuThu();
        }

        private void dgvLoaiPhong_Sorted(object sender, EventArgs e)
        {
            BoChonLoaiPhong();
        }
    }
    }

