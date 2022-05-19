using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan.DAO;
///Xuat pdf
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
/// 
namespace QuanLyKhachSan
{
    public partial class frmThongKe : Form
    {
        SqlConnection connection;
        SqlCommand command;
        int month, year;
        string str =@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        decimal maxMonth;
        private static frmThongKe instance;
        public frmThongKe()
        {
            InitializeComponent();
            ReportSalebaseonType(nudThang.Text,nudNam.Text);
        }
        public static frmThongKe GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmThongKe();
                }
                return instance;
            }
        }
        private DataTable GetHoaDon()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            return table;
        }

        private void connecttoDB()
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    
        private void mnuConnect_Click(object sender, EventArgs e)
        {
            connecttoDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exportReport_Click(object sender, EventArgs e)
        {
            string arialpath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\arial.ttf";
            BaseFont basearial= BaseFont.CreateFont(arialpath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font bbbb = FontFactory.GetFont("Arial", 12);
            iTextSharp.text.Font arial = new iTextSharp.text.Font(basearial, 12);
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = $"Sale report of m{month.ToString()}y{year.ToString()}.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvBaoCao.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvBaoCao.Columns)
                            {
                                Phrase b=new Phrase();
                                b.Font = arial;
                                b.Add(column.HeaderText.ToString());
                                PdfPCell cell = new PdfPCell(b);
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvBaoCao.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Phrase("Tổng doanh thu :" + lbTongDoanhThu.Text, arial));
                                if(dgvBaoCao.Rows.Count!=0)
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dữ liệu Export thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
        }
        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void searchMonthreport_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void searchRoomTextBox_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchMonthreport_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchYearreport_ValueChanged(object sender, EventArgs e)
        {
            if(nudNam.Value==DateTime.Now.Year)
            nudThang.Maximum = DateTime.Now.Month;
        }
        private void ReportSalebaseonType(string nmonth,string nyear)
        {
            dgvBaoCao.DataSource = DataProvider.Instance.ExecuteQuery($"declare @temp int;select @temp=MaBaoCaoDoanhThuTheoLoaiPhong from BAOCAODOANHTHUTHEOLOAIPHONG where  Thang={nmonth} and Nam={nyear};select TenLoaiPhong as 'Loại Phòng',TongDoanhThu  as 'Doanh Thu',TiLe*100 as 'Tỉ Lệ (%)' from CT_BAOCAODOANHTHUTHEOLOAIPHONG,LOAIPHONG where MaBaoCaoDoanhThuTheoLoaiPhong=@temp and CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong;");
            Object getTotalSale = DataProvider.Instance.ExecuteScalar($"select TongTatCaDoanhThu from BAOCAODOANHTHUTHEOLOAIPHONG where Thang={nmonth} and Nam={nyear}");
            float TotalSale = Convert.ToSingle(getTotalSale);
            lbTongDoanhThu.Text = $" {TotalSale.ToString()} VNĐ của tháng {nmonth}/{nyear}";
            year = int.Parse(nmonth);
            month = int.Parse(nyear);
        }
        private void button1_Click_3(object sender, EventArgs e)
        {


        }
        private void dgvReport_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          object b=  DataProvider.Instance.ExecuteScalar("select DonGia from LOAIPHONG WHERE TenLoaiPhong='A'");
            float a = Convert.ToSingle(b);
            MessageBox.Show(a.ToString());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NumsearchYearreport_ValueChanged(object sender, EventArgs e)
        {
            string text = (sender as NumericUpDown).Value.ToString() as string;
            if (nudThang.Text == "")
            {
                nudThang.Text = nudThang.Minimum.ToString();
            }
            if (text== "")
            {
                nudNam.Text = nudNam.Minimum.ToString();
            }
            ReportSalebaseonType(nudThang.Text,text);
        }

        private void searchMonthreport_ValueChanged_1(object sender, EventArgs e)
        {
            string text = (sender as NumericUpDown).Value.ToString() as string;
            if (text == "")
            {
                nudThang.Text = nudThang.Minimum.ToString();
            }
            if (nudNam.Text == "")
            {
                nudNam.Text = nudNam.Minimum.ToString();
            }
            ReportSalebaseonType(text, nudNam.Text);
        }
    }
}    



