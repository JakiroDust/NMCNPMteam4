
namespace QuanLyKhachSan.UserForm
{
    partial class frmChinhThamSo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvThamSo = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSuaThamSo = new System.Windows.Forms.Button();
            this.tbHeSo = new System.Windows.Forms.TextBox();
            this.tbTenThamSo = new System.Windows.Forms.TextBox();
            this.lbHeSo = new System.Windows.Forms.Label();
            this.lbThamSo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBoChonLoaiPhong = new System.Windows.Forms.Button();
            this.tbMaLoaiPhong = new System.Windows.Forms.TextBox();
            this.lbMaLoaiPhong = new System.Windows.Forms.Label();
            this.btnXoaLoaiPhong = new System.Windows.Forms.Button();
            this.btnThemLoaiPhong = new System.Windows.Forms.Button();
            this.btnSuaLoaiPhong = new System.Windows.Forms.Button();
            this.tbDonGiaLoaiPhong = new System.Windows.Forms.TextBox();
            this.tbTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbChuThichPhuThu = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvPhuThu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbMaPhuThu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBoChonPhuThu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThemPhuThu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbHeSoPhuThu = new System.Windows.Forms.TextBox();
            this.tbMocPhuThu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLoaiKhach = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbMaLoaiKhach = new System.Windows.Forms.TextBox();
            this.lbMaLoaiKhach = new System.Windows.Forms.Label();
            this.tbBoChonLoaiKhach = new System.Windows.Forms.Button();
            this.btnXoaLoaiKhach = new System.Windows.Forms.Button();
            this.btnThemLoaiKhach = new System.Windows.Forms.Button();
            this.btnSuaLoaiKhach = new System.Windows.Forms.Button();
            this.tbHeSoLoaiKhach = new System.Windows.Forms.TextBox();
            this.tbLoaiKhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLoaiKhach = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamSo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKhach)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.panel4);
            this.tab1.Controls.Add(this.panelMenu);
            this.tab1.Location = new System.Drawing.Point(4, 29);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(792, 417);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Tham Số";
            this.tab1.UseVisualStyleBackColor = true;
            this.tab1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvThamSo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(786, 312);
            this.panel4.TabIndex = 2;
            // 
            // dgvThamSo
            // 
            this.dgvThamSo.AllowUserToAddRows = false;
            this.dgvThamSo.AllowUserToDeleteRows = false;
            this.dgvThamSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThamSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThamSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThamSo.Location = new System.Drawing.Point(0, 0);
            this.dgvThamSo.MultiSelect = false;
            this.dgvThamSo.Name = "dgvThamSo";
            this.dgvThamSo.ReadOnly = true;
            this.dgvThamSo.RowHeadersVisible = false;
            this.dgvThamSo.RowHeadersWidth = 51;
            this.dgvThamSo.RowTemplate.Height = 29;
            this.dgvThamSo.Size = new System.Drawing.Size(786, 312);
            this.dgvThamSo.TabIndex = 0;
            this.dgvThamSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvThamSo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvThamSo.Sorted += new System.EventHandler(this.dgvThamSo_Sorted);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnSuaThamSo);
            this.panelMenu.Controls.Add(this.tbHeSo);
            this.panelMenu.Controls.Add(this.tbTenThamSo);
            this.panelMenu.Controls.Add(this.lbHeSo);
            this.panelMenu.Controls.Add(this.lbThamSo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(786, 99);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSuaThamSo
            // 
            this.btnSuaThamSo.Location = new System.Drawing.Point(484, 30);
            this.btnSuaThamSo.Name = "btnSuaThamSo";
            this.btnSuaThamSo.Size = new System.Drawing.Size(94, 29);
            this.btnSuaThamSo.TabIndex = 4;
            this.btnSuaThamSo.Text = "Sửa";
            this.btnSuaThamSo.UseVisualStyleBackColor = true;
            this.btnSuaThamSo.Click += new System.EventHandler(this.btEditThamSo_Click);
            // 
            // tbHeSo
            // 
            this.tbHeSo.Location = new System.Drawing.Point(410, 31);
            this.tbHeSo.Name = "tbHeSo";
            this.tbHeSo.Size = new System.Drawing.Size(59, 27);
            this.tbHeSo.TabIndex = 3;
            // 
            // tbTenThamSo
            // 
            this.tbTenThamSo.Location = new System.Drawing.Point(193, 31);
            this.tbTenThamSo.Name = "tbTenThamSo";
            this.tbTenThamSo.ReadOnly = true;
            this.tbTenThamSo.Size = new System.Drawing.Size(145, 27);
            this.tbTenThamSo.TabIndex = 2;
            this.tbTenThamSo.Text = "Chưa chọn tham số";
            this.tbTenThamSo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbHeSo
            // 
            this.lbHeSo.AutoSize = true;
            this.lbHeSo.Location = new System.Drawing.Point(354, 34);
            this.lbHeSo.Name = "lbHeSo";
            this.lbHeSo.Size = new System.Drawing.Size(47, 20);
            this.lbHeSo.TabIndex = 1;
            this.lbHeSo.Text = "Hệ số";
            // 
            // lbThamSo
            // 
            this.lbThamSo.AutoSize = true;
            this.lbThamSo.Location = new System.Drawing.Point(120, 35);
            this.lbThamSo.Name = "lbThamSo";
            this.lbThamSo.Size = new System.Drawing.Size(70, 20);
            this.lbThamSo.TabIndex = 0;
            this.lbThamSo.Text = "Tham Số:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại Phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvLoaiPhong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(786, 312);
            this.panel5.TabIndex = 3;
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AllowUserToAddRows = false;
            this.dgvLoaiPhong.AllowUserToDeleteRows = false;
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaiPhong.MultiSelect = false;
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.RowHeadersVisible = false;
            this.dgvLoaiPhong.RowHeadersWidth = 51;
            this.dgvLoaiPhong.RowTemplate.Height = 29;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(786, 312);
            this.dgvLoaiPhong.TabIndex = 1;
            this.dgvLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiPhong_CellContentClick);
            this.dgvLoaiPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiPhong_CellContentClick);
            this.dgvLoaiPhong.Sorted += new System.EventHandler(this.dgvLoaiPhong_Sorted);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBoChonLoaiPhong);
            this.panel3.Controls.Add(this.tbMaLoaiPhong);
            this.panel3.Controls.Add(this.lbMaLoaiPhong);
            this.panel3.Controls.Add(this.btnXoaLoaiPhong);
            this.panel3.Controls.Add(this.btnThemLoaiPhong);
            this.panel3.Controls.Add(this.btnSuaLoaiPhong);
            this.panel3.Controls.Add(this.tbDonGiaLoaiPhong);
            this.panel3.Controls.Add(this.tbTenLoaiPhong);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 99);
            this.panel3.TabIndex = 1;
            // 
            // btnBoChonLoaiPhong
            // 
            this.btnBoChonLoaiPhong.Location = new System.Drawing.Point(117, 70);
            this.btnBoChonLoaiPhong.Name = "btnBoChonLoaiPhong";
            this.btnBoChonLoaiPhong.Size = new System.Drawing.Size(94, 29);
            this.btnBoChonLoaiPhong.TabIndex = 14;
            this.btnBoChonLoaiPhong.Text = "Bỏ chọn";
            this.btnBoChonLoaiPhong.UseVisualStyleBackColor = true;
            this.btnBoChonLoaiPhong.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbMaLoaiPhong
            // 
            this.tbMaLoaiPhong.Location = new System.Drawing.Point(117, 36);
            this.tbMaLoaiPhong.Name = "tbMaLoaiPhong";
            this.tbMaLoaiPhong.ReadOnly = true;
            this.tbMaLoaiPhong.Size = new System.Drawing.Size(84, 27);
            this.tbMaLoaiPhong.TabIndex = 13;
            this.tbMaLoaiPhong.TextChanged += new System.EventHandler(this.tbMaLoaiPhong_TextChanged);
            // 
            // lbMaLoaiPhong
            // 
            this.lbMaLoaiPhong.AutoSize = true;
            this.lbMaLoaiPhong.Location = new System.Drawing.Point(5, 37);
            this.lbMaLoaiPhong.Name = "lbMaLoaiPhong";
            this.lbMaLoaiPhong.Size = new System.Drawing.Size(106, 20);
            this.lbMaLoaiPhong.TabIndex = 12;
            this.lbMaLoaiPhong.Text = "Mã loại phòng";
            // 
            // btnXoaLoaiPhong
            // 
            this.btnXoaLoaiPhong.Location = new System.Drawing.Point(558, 64);
            this.btnXoaLoaiPhong.Name = "btnXoaLoaiPhong";
            this.btnXoaLoaiPhong.Size = new System.Drawing.Size(94, 29);
            this.btnXoaLoaiPhong.TabIndex = 11;
            this.btnXoaLoaiPhong.Text = "Xóa";
            this.btnXoaLoaiPhong.UseVisualStyleBackColor = true;
            this.btnXoaLoaiPhong.Click += new System.EventHandler(this.btnXoaLoaiPhong_Click);
            // 
            // btnThemLoaiPhong
            // 
            this.btnThemLoaiPhong.Location = new System.Drawing.Point(558, 3);
            this.btnThemLoaiPhong.Name = "btnThemLoaiPhong";
            this.btnThemLoaiPhong.Size = new System.Drawing.Size(94, 29);
            this.btnThemLoaiPhong.TabIndex = 10;
            this.btnThemLoaiPhong.Text = "Thêm";
            this.btnThemLoaiPhong.UseVisualStyleBackColor = true;
            this.btnThemLoaiPhong.Click += new System.EventHandler(this.btnThemLoaiPhong_Click);
            // 
            // btnSuaLoaiPhong
            // 
            this.btnSuaLoaiPhong.Location = new System.Drawing.Point(558, 33);
            this.btnSuaLoaiPhong.Name = "btnSuaLoaiPhong";
            this.btnSuaLoaiPhong.Size = new System.Drawing.Size(94, 29);
            this.btnSuaLoaiPhong.TabIndex = 9;
            this.btnSuaLoaiPhong.Text = "Sửa";
            this.btnSuaLoaiPhong.UseVisualStyleBackColor = true;
            this.btnSuaLoaiPhong.Click += new System.EventHandler(this.btnSuaLoaiPhong_Click);
            // 
            // tbDonGiaLoaiPhong
            // 
            this.tbDonGiaLoaiPhong.Location = new System.Drawing.Point(447, 34);
            this.tbDonGiaLoaiPhong.Name = "tbDonGiaLoaiPhong";
            this.tbDonGiaLoaiPhong.Size = new System.Drawing.Size(89, 27);
            this.tbDonGiaLoaiPhong.TabIndex = 8;
            this.tbDonGiaLoaiPhong.TextChanged += new System.EventHandler(this.tbDonGiaLoaiPhong_TextChanged);
            // 
            // tbTenLoaiPhong
            // 
            this.tbTenLoaiPhong.Location = new System.Drawing.Point(291, 36);
            this.tbTenLoaiPhong.Name = "tbTenLoaiPhong";
            this.tbTenLoaiPhong.Size = new System.Drawing.Size(84, 27);
            this.tbTenLoaiPhong.TabIndex = 7;
            this.tbTenLoaiPhong.TextChanged += new System.EventHandler(this.tbTenLoaiPhong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại phòng:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phụ Thu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbChuThichPhuThu);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 390);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(786, 24);
            this.panel7.TabIndex = 4;
            // 
            // lbChuThichPhuThu
            // 
            this.lbChuThichPhuThu.AutoSize = true;
            this.lbChuThichPhuThu.Location = new System.Drawing.Point(198, 4);
            this.lbChuThichPhuThu.Name = "lbChuThichPhuThu";
            this.lbChuThichPhuThu.Size = new System.Drawing.Size(395, 20);
            this.lbChuThichPhuThu.TabIndex = 0;
            this.lbChuThichPhuThu.Text = "Phụ thu sẽ lấy theo mốc cao nhất dựa theo số lượng khách";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvPhuThu);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(786, 306);
            this.panel6.TabIndex = 3;
            // 
            // dgvPhuThu
            // 
            this.dgvPhuThu.AllowUserToAddRows = false;
            this.dgvPhuThu.AllowUserToDeleteRows = false;
            this.dgvPhuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhuThu.Location = new System.Drawing.Point(0, 0);
            this.dgvPhuThu.MultiSelect = false;
            this.dgvPhuThu.Name = "dgvPhuThu";
            this.dgvPhuThu.ReadOnly = true;
            this.dgvPhuThu.RowHeadersVisible = false;
            this.dgvPhuThu.RowHeadersWidth = 51;
            this.dgvPhuThu.RowTemplate.Height = 29;
            this.dgvPhuThu.Size = new System.Drawing.Size(786, 306);
            this.dgvPhuThu.TabIndex = 1;
            this.dgvPhuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuThu_CellClick);
            this.dgvPhuThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuThu_CellContentClick);
            this.dgvPhuThu.Sorted += new System.EventHandler(this.dgvPhuThu_Sorted);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tbMaPhuThu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnBoChonPhuThu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnThemPhuThu);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.tbHeSoPhuThu);
            this.panel1.Controls.Add(this.tbMocPhuThu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 105);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbMaPhuThu
            // 
            this.tbMaPhuThu.Location = new System.Drawing.Point(125, 39);
            this.tbMaPhuThu.Name = "tbMaPhuThu";
            this.tbMaPhuThu.ReadOnly = true;
            this.tbMaPhuThu.Size = new System.Drawing.Size(84, 27);
            this.tbMaPhuThu.TabIndex = 24;
            this.tbMaPhuThu.TextChanged += new System.EventHandler(this.tbMaPhuThu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã";
            // 
            // btnBoChonPhuThu
            // 
            this.btnBoChonPhuThu.Location = new System.Drawing.Point(122, 73);
            this.btnBoChonPhuThu.Name = "btnBoChonPhuThu";
            this.btnBoChonPhuThu.Size = new System.Drawing.Size(94, 29);
            this.btnBoChonPhuThu.TabIndex = 21;
            this.btnBoChonPhuThu.Text = "Bỏ chọn";
            this.btnBoChonPhuThu.UseVisualStyleBackColor = true;
            this.btnBoChonPhuThu.Click += new System.EventHandler(this.btnBoChonPhuThu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThemPhuThu
            // 
            this.btnThemPhuThu.Location = new System.Drawing.Point(603, 4);
            this.btnThemPhuThu.Name = "btnThemPhuThu";
            this.btnThemPhuThu.Size = new System.Drawing.Size(94, 29);
            this.btnThemPhuThu.TabIndex = 17;
            this.btnThemPhuThu.Text = "Thêm";
            this.btnThemPhuThu.UseVisualStyleBackColor = true;
            this.btnThemPhuThu.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbHeSoPhuThu
            // 
            this.tbHeSoPhuThu.Location = new System.Drawing.Point(471, 35);
            this.tbHeSoPhuThu.Name = "tbHeSoPhuThu";
            this.tbHeSoPhuThu.Size = new System.Drawing.Size(89, 27);
            this.tbHeSoPhuThu.TabIndex = 15;
            this.tbHeSoPhuThu.TextChanged += new System.EventHandler(this.tbHeSoPhuThu_TextChanged);
            // 
            // tbMocPhuThu
            // 
            this.tbMocPhuThu.Location = new System.Drawing.Point(315, 36);
            this.tbMocPhuThu.Name = "tbMocPhuThu";
            this.tbMocPhuThu.Size = new System.Drawing.Size(84, 27);
            this.tbMocPhuThu.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hệ số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mốc phụ thu";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Controls.Add(this.dgvLoaiKhach);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Loại khách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 393);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(792, 24);
            this.panel9.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phụ thu sẽ được tính nếu có ít nhất 1 người thuộc 1 loại khách";
            // 
            // dgvLoaiKhach
            // 
            this.dgvLoaiKhach.AllowUserToAddRows = false;
            this.dgvLoaiKhach.AllowUserToDeleteRows = false;
            this.dgvLoaiKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiKhach.Location = new System.Drawing.Point(0, 105);
            this.dgvLoaiKhach.MultiSelect = false;
            this.dgvLoaiKhach.Name = "dgvLoaiKhach";
            this.dgvLoaiKhach.ReadOnly = true;
            this.dgvLoaiKhach.RowHeadersVisible = false;
            this.dgvLoaiKhach.RowHeadersWidth = 51;
            this.dgvLoaiKhach.RowTemplate.Height = 29;
            this.dgvLoaiKhach.Size = new System.Drawing.Size(792, 312);
            this.dgvLoaiKhach.TabIndex = 3;
            this.dgvLoaiKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiKhach_CellContentClick);
            this.dgvLoaiKhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiKhach_CellContentClick);
            this.dgvLoaiKhach.Sorted += new System.EventHandler(this.dgvLoaiKhach_Sorted);
            this.dgvLoaiKhach.Validated += new System.EventHandler(this.dgvLoaiKhach_Validated);
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.Controls.Add(this.tbMaLoaiKhach);
            this.panel8.Controls.Add(this.lbMaLoaiKhach);
            this.panel8.Controls.Add(this.tbBoChonLoaiKhach);
            this.panel8.Controls.Add(this.btnXoaLoaiKhach);
            this.panel8.Controls.Add(this.btnThemLoaiKhach);
            this.panel8.Controls.Add(this.btnSuaLoaiKhach);
            this.panel8.Controls.Add(this.tbHeSoLoaiKhach);
            this.panel8.Controls.Add(this.tbLoaiKhach);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.lbLoaiKhach);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(792, 105);
            this.panel8.TabIndex = 2;
            // 
            // tbMaLoaiKhach
            // 
            this.tbMaLoaiKhach.Location = new System.Drawing.Point(125, 39);
            this.tbMaLoaiKhach.Name = "tbMaLoaiKhach";
            this.tbMaLoaiKhach.ReadOnly = true;
            this.tbMaLoaiKhach.Size = new System.Drawing.Size(84, 27);
            this.tbMaLoaiKhach.TabIndex = 24;
            // 
            // lbMaLoaiKhach
            // 
            this.lbMaLoaiKhach.AutoSize = true;
            this.lbMaLoaiKhach.Location = new System.Drawing.Point(10, 40);
            this.lbMaLoaiKhach.Name = "lbMaLoaiKhach";
            this.lbMaLoaiKhach.Size = new System.Drawing.Size(101, 20);
            this.lbMaLoaiKhach.TabIndex = 23;
            this.lbMaLoaiKhach.Text = "Mã loại khách";
            // 
            // tbBoChonLoaiKhach
            // 
            this.tbBoChonLoaiKhach.Location = new System.Drawing.Point(122, 73);
            this.tbBoChonLoaiKhach.Name = "tbBoChonLoaiKhach";
            this.tbBoChonLoaiKhach.Size = new System.Drawing.Size(94, 29);
            this.tbBoChonLoaiKhach.TabIndex = 21;
            this.tbBoChonLoaiKhach.Text = "Bỏ chọn";
            this.tbBoChonLoaiKhach.UseVisualStyleBackColor = true;
            this.tbBoChonLoaiKhach.Click += new System.EventHandler(this.tbBoChonLoaiKhach_Click);
            // 
            // btnXoaLoaiKhach
            // 
            this.btnXoaLoaiKhach.Location = new System.Drawing.Point(604, 66);
            this.btnXoaLoaiKhach.Name = "btnXoaLoaiKhach";
            this.btnXoaLoaiKhach.Size = new System.Drawing.Size(94, 29);
            this.btnXoaLoaiKhach.TabIndex = 18;
            this.btnXoaLoaiKhach.Text = "Xóa";
            this.btnXoaLoaiKhach.UseVisualStyleBackColor = true;
            this.btnXoaLoaiKhach.Click += new System.EventHandler(this.btnXoaLoaiKhach_Click);
            // 
            // btnThemLoaiKhach
            // 
            this.btnThemLoaiKhach.Location = new System.Drawing.Point(603, 4);
            this.btnThemLoaiKhach.Name = "btnThemLoaiKhach";
            this.btnThemLoaiKhach.Size = new System.Drawing.Size(94, 29);
            this.btnThemLoaiKhach.TabIndex = 17;
            this.btnThemLoaiKhach.Text = "Thêm";
            this.btnThemLoaiKhach.UseVisualStyleBackColor = true;
            this.btnThemLoaiKhach.Click += new System.EventHandler(this.btnThemLoaiKhach_Click);
            // 
            // btnSuaLoaiKhach
            // 
            this.btnSuaLoaiKhach.Location = new System.Drawing.Point(604, 36);
            this.btnSuaLoaiKhach.Name = "btnSuaLoaiKhach";
            this.btnSuaLoaiKhach.Size = new System.Drawing.Size(94, 29);
            this.btnSuaLoaiKhach.TabIndex = 16;
            this.btnSuaLoaiKhach.Text = "Sửa";
            this.btnSuaLoaiKhach.UseVisualStyleBackColor = true;
            this.btnSuaLoaiKhach.Click += new System.EventHandler(this.btnSuaLoaiKhach_Click);
            // 
            // tbHeSoLoaiKhach
            // 
            this.tbHeSoLoaiKhach.Location = new System.Drawing.Point(471, 35);
            this.tbHeSoLoaiKhach.Name = "tbHeSoLoaiKhach";
            this.tbHeSoLoaiKhach.Size = new System.Drawing.Size(89, 27);
            this.tbHeSoLoaiKhach.TabIndex = 15;
            // 
            // tbLoaiKhach
            // 
            this.tbLoaiKhach.Location = new System.Drawing.Point(315, 36);
            this.tbLoaiKhach.Name = "tbLoaiKhach";
            this.tbLoaiKhach.Size = new System.Drawing.Size(84, 27);
            this.tbLoaiKhach.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hệ số";
            // 
            // lbLoaiKhach
            // 
            this.lbLoaiKhach.AutoSize = true;
            this.lbLoaiKhach.Location = new System.Drawing.Point(226, 40);
            this.lbLoaiKhach.Name = "lbLoaiKhach";
            this.lbLoaiKhach.Size = new System.Drawing.Size(79, 20);
            this.lbLoaiKhach.TabIndex = 12;
            this.lbLoaiKhach.Text = "Loại khách";
            // 
            // frmChinhThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmChinhThamSo";
            this.Text = "Cài đặt";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamSo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKhach)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvThamSo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTenThamSo;
        private System.Windows.Forms.Label lbHeSo;
        private System.Windows.Forms.Label lbThamSo;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.DataGridView dgvPhuThu;
        private System.Windows.Forms.Button btnSuaThamSo;
        private System.Windows.Forms.TextBox tbHeSo;
        private System.Windows.Forms.Button btnSuaLoaiPhong;
        private System.Windows.Forms.TextBox tbDonGiaLoaiPhong;
        private System.Windows.Forms.TextBox tbTenLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaLoaiPhong;
        private System.Windows.Forms.Button btnThemLoaiPhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThemPhuThu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbHeSoPhuThu;
        private System.Windows.Forms.TextBox tbMocPhuThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaLoaiPhong;
        private System.Windows.Forms.Label lbMaLoaiPhong;
        private System.Windows.Forms.Button btnBoChonLoaiPhong;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbChuThichPhuThu;
        private System.Windows.Forms.Button btnBoChonPhuThu;
        private System.Windows.Forms.TextBox tbMaPhuThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLoaiKhach;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbMaLoaiKhach;
        private System.Windows.Forms.Label lbMaLoaiKhach;
        private System.Windows.Forms.Button tbBoChonLoaiKhach;
        private System.Windows.Forms.Button btnXoaLoaiKhach;
        private System.Windows.Forms.Button btnThemLoaiKhach;
        private System.Windows.Forms.Button btnSuaLoaiKhach;
        private System.Windows.Forms.TextBox tbHeSoLoaiKhach;
        private System.Windows.Forms.TextBox tbLoaiKhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLoaiKhach;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
    }
}