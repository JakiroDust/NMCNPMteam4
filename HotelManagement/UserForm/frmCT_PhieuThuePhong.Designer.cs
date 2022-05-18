namespace QuanLyKhachSan
{
    partial class frmCT_PhieuThuePhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbSoKhachToiDa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tbThoat = new System.Windows.Forms.Button();
            this.tbSua = new System.Windows.Forms.Button();
            this.cbLoaiKhach = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.tbMaPhieu = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTenPhong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 549);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSachKhachHang);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 549);
            this.panel2.TabIndex = 5;
            // 
            // dgvDanhSachKhachHang
            // 
            this.dgvDanhSachKhachHang.AllowUserToAddRows = false;
            this.dgvDanhSachKhachHang.AllowUserToDeleteRows = false;
            this.dgvDanhSachKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachKhachHang.Location = new System.Drawing.Point(0, 125);
            this.dgvDanhSachKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachKhachHang.MultiSelect = false;
            this.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            this.dgvDanhSachKhachHang.ReadOnly = true;
            this.dgvDanhSachKhachHang.RowHeadersVisible = false;
            this.dgvDanhSachKhachHang.RowHeadersWidth = 51;
            this.dgvDanhSachKhachHang.RowTemplate.Height = 24;
            this.dgvDanhSachKhachHang.Size = new System.Drawing.Size(480, 424);
            this.dgvDanhSachKhachHang.TabIndex = 1;
            this.dgvDanhSachKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachKhachHang_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 125);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbTenPhong);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.tbSoKhachToiDa);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.tbThoat);
            this.panel3.Controls.Add(this.tbSua);
            this.panel3.Controls.Add(this.cbLoaiKhach);
            this.panel3.Controls.Add(this.tbID);
            this.panel3.Controls.Add(this.tbDiaChi);
            this.panel3.Controls.Add(this.tbCMND);
            this.panel3.Controls.Add(this.tbMaPhong);
            this.panel3.Controls.Add(this.tbMaPhieu);
            this.panel3.Controls.Add(this.tbTenKH);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(480, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 549);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // tbSoKhachToiDa
            // 
            this.tbSoKhachToiDa.Location = new System.Drawing.Point(310, 15);
            this.tbSoKhachToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSoKhachToiDa.Name = "tbSoKhachToiDa";
            this.tbSoKhachToiDa.ReadOnly = true;
            this.tbSoKhachToiDa.Size = new System.Drawing.Size(99, 27);
            this.tbSoKhachToiDa.TabIndex = 7;
            this.tbSoKhachToiDa.Text = "aaa";
            this.tbSoKhachToiDa.TextChanged += new System.EventHandler(this.tbSoKhachToiDa_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số khách tối đa";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(208, 470);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 55);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(26, 470);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 55);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbThoat
            // 
            this.tbThoat.Location = new System.Drawing.Point(331, 470);
            this.tbThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbThoat.Name = "tbThoat";
            this.tbThoat.Size = new System.Drawing.Size(75, 55);
            this.tbThoat.TabIndex = 3;
            this.tbThoat.Text = "Thoát";
            this.tbThoat.UseVisualStyleBackColor = true;
            this.tbThoat.Click += new System.EventHandler(this.tbThoat_Click);
            // 
            // tbSua
            // 
            this.tbSua.Location = new System.Drawing.Point(115, 470);
            this.tbSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSua.Name = "tbSua";
            this.tbSua.Size = new System.Drawing.Size(75, 55);
            this.tbSua.TabIndex = 3;
            this.tbSua.Text = "Sửa";
            this.tbSua.UseVisualStyleBackColor = true;
            this.tbSua.Click += new System.EventHandler(this.tbSua_Click);
            // 
            // cbLoaiKhach
            // 
            this.cbLoaiKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiKhach.FormattingEnabled = true;
            this.cbLoaiKhach.Location = new System.Drawing.Point(157, 258);
            this.cbLoaiKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiKhach.Name = "cbLoaiKhach";
            this.cbLoaiKhach.Size = new System.Drawing.Size(170, 28);
            this.cbLoaiKhach.TabIndex = 2;
            this.cbLoaiKhach.SelectedIndexChanged += new System.EventHandler(this.cbLoaiKhach_SelectedIndexChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(157, 142);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(121, 27);
            this.tbID.TabIndex = 1;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(157, 379);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDiaChi.Multiline = true;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(215, 69);
            this.tbDiaChi.TabIndex = 1;
            this.tbDiaChi.Text = "Trống";
            this.tbDiaChi.Validated += new System.EventHandler(this.tbDiaChi_Validated);
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(157, 316);
            this.tbCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(219, 27);
            this.tbCMND.TabIndex = 1;
            this.tbCMND.Text = "Trống";
            this.tbCMND.Validated += new System.EventHandler(this.tbCMND_Validated);
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Location = new System.Drawing.Point(90, 15);
            this.tbMaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.ReadOnly = true;
            this.tbMaPhong.Size = new System.Drawing.Size(99, 27);
            this.tbMaPhong.TabIndex = 1;
            this.tbMaPhong.TextChanged += new System.EventHandler(this.tbMaPhong_TextChanged);
            // 
            // tbMaPhieu
            // 
            this.tbMaPhieu.Location = new System.Drawing.Point(312, 60);
            this.tbMaPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaPhieu.Name = "tbMaPhieu";
            this.tbMaPhieu.ReadOnly = true;
            this.tbMaPhieu.Size = new System.Drawing.Size(99, 27);
            this.tbMaPhieu.TabIndex = 1;
            this.tbMaPhieu.TextChanged += new System.EventHandler(this.tbMaPhieu_TextChanged);
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(157, 200);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(230, 27);
            this.tbTenKH.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại khách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã phiếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã phòng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tên Phòng";
            // 
            // tbTenPhong
            // 
            this.tbTenPhong.Location = new System.Drawing.Point(90, 64);
            this.tbTenPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenPhong.Name = "tbTenPhong";
            this.tbTenPhong.ReadOnly = true;
            this.tbTenPhong.Size = new System.Drawing.Size(99, 27);
            this.tbTenPhong.TabIndex = 9;
            this.tbTenPhong.TextChanged += new System.EventHandler(this.tbTenPhong_TextChanged);
            // 
            // frmCT_PhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 549);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCT_PhieuThuePhong";
            this.Text = "frmSuaThanhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCT_PhieuThuePhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhSachKhachHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbLoaiKhach;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaPhieu;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button tbThoat;
        private System.Windows.Forms.Button tbSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tbSoKhachToiDa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTenPhong;
        private System.Windows.Forms.Label label10;
    }
}