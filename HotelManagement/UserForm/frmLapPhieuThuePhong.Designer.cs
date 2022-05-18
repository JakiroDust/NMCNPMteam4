namespace QuanLyKhachSan
{
    partial class frmLapPhieuThuePhong
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
            System.Windows.Forms.Label maLoaiPhongLabel;
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCTPhieuThuePhong = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbTenPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.tbSoLuongKhach = new System.Windows.Forms.TextBox();
            this.tbMaPhieu = new System.Windows.Forms.TextBox();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnSelectedRoom = new System.Windows.Forms.Button();
            maLoaiPhongLabel = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuThuePhong)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maLoaiPhongLabel
            // 
            maLoaiPhongLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            maLoaiPhongLabel.AutoSize = true;
            maLoaiPhongLabel.Location = new System.Drawing.Point(160, 6);
            maLoaiPhongLabel.Name = "maLoaiPhongLabel";
            maLoaiPhongLabel.Size = new System.Drawing.Size(84, 20);
            maLoaiPhongLabel.TabIndex = 14;
            maLoaiPhongLabel.Text = "Loại phòng";
            maLoaiPhongLabel.Click += new System.EventHandler(this.maLoaiPhongLabel_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1180, 749);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lập phiếu thuê phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(627, 741);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.flpRoom);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(627, 709);
            this.panel6.TabIndex = 2;
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRoom.Location = new System.Drawing.Point(0, 0);
            this.flpRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(627, 709);
            this.flpRoom.TabIndex = 0;
            this.flpRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.flpRoom_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbTinhTrang);
            this.panel5.Controls.Add(this.cbLoaiPhong);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(maLoaiPhongLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(627, 32);
            this.panel5.TabIndex = 1;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "",
            "Trống",
            "Đầy"});
            this.cbTinhTrang.Location = new System.Drawing.Point(411, 4);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(72, 28);
            this.cbTinhTrang.TabIndex = 13;
            this.cbTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbSearchRoomState_SelectedIndexChanged);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(245, 3);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(81, 28);
            this.cbLoaiPhong.TabIndex = 15;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbSearchRoomType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tình trạng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCTPhieuThuePhong);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(630, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 741);
            this.panel2.TabIndex = 3;
            // 
            // dgvCTPhieuThuePhong
            // 
            this.dgvCTPhieuThuePhong.AllowUserToAddRows = false;
            this.dgvCTPhieuThuePhong.AllowUserToDeleteRows = false;
            this.dgvCTPhieuThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuThuePhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPhieuThuePhong.Location = new System.Drawing.Point(0, 341);
            this.dgvCTPhieuThuePhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCTPhieuThuePhong.Name = "dgvCTPhieuThuePhong";
            this.dgvCTPhieuThuePhong.ReadOnly = true;
            this.dgvCTPhieuThuePhong.RowHeadersVisible = false;
            this.dgvCTPhieuThuePhong.RowHeadersWidth = 51;
            this.dgvCTPhieuThuePhong.RowTemplate.Height = 24;
            this.dgvCTPhieuThuePhong.Size = new System.Drawing.Size(547, 285);
            this.dgvCTPhieuThuePhong.TabIndex = 4;
            this.dgvCTPhieuThuePhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPhieuThuePhong_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSelectedRoom);
            this.panel3.Controls.Add(this.tbTenPhong);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnXoaPhieu);
            this.panel3.Controls.Add(this.dtpEnd);
            this.panel3.Controls.Add(this.btnLapPhieu);
            this.panel3.Controls.Add(this.dtpStart);
            this.panel3.Controls.Add(this.tbSoLuongKhach);
            this.panel3.Controls.Add(this.tbMaPhieu);
            this.panel3.Controls.Add(this.tbMaPhong);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 341);
            this.panel3.TabIndex = 1;
            // 
            // tbTenPhong
            // 
            this.tbTenPhong.Location = new System.Drawing.Point(72, 138);
            this.tbTenPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenPhong.Name = "tbTenPhong";
            this.tbTenPhong.ReadOnly = true;
            this.tbTenPhong.Size = new System.Drawing.Size(85, 27);
            this.tbTenPhong.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên phòng";
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoaPhieu.Location = new System.Drawing.Point(448, 264);
            this.btnXoaPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(65, 59);
            this.btnXoaPhieu.TabIndex = 4;
            this.btnXoaPhieu.Text = "Xóa phiếu";
            this.btnXoaPhieu.UseVisualStyleBackColor = false;
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(407, 84);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(102, 27);
            this.dtpEnd.TabIndex = 1;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(242, 185);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(75, 52);
            this.btnLapPhieu.TabIndex = 2;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(407, 49);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(102, 27);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // tbSoLuongKhach
            // 
            this.tbSoLuongKhach.Location = new System.Drawing.Point(424, 125);
            this.tbSoLuongKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSoLuongKhach.Name = "tbSoLuongKhach";
            this.tbSoLuongKhach.Size = new System.Drawing.Size(85, 27);
            this.tbSoLuongKhach.TabIndex = 3;
            // 
            // tbMaPhieu
            // 
            this.tbMaPhieu.Location = new System.Drawing.Point(238, 260);
            this.tbMaPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaPhieu.Name = "tbMaPhieu";
            this.tbMaPhieu.ReadOnly = true;
            this.tbMaPhieu.Size = new System.Drawing.Size(85, 27);
            this.tbMaPhieu.TabIndex = 3;
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Location = new System.Drawing.Point(71, 82);
            this.tbMaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.ReadOnly = true;
            this.tbMaPhong.Size = new System.Drawing.Size(85, 27);
            this.tbMaPhong.TabIndex = 0;
            this.tbMaPhong.TextChanged += new System.EventHandler(this.tbMaPhong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danh sách khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày thuê:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(319, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số lượng khách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã phiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 626);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 115);
            this.panel1.TabIndex = 3;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(418, 34);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 52);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(91, 32);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 54);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 782);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // btnSelectedRoom
            // 
            this.btnSelectedRoom.Enabled = false;
            this.btnSelectedRoom.Location = new System.Drawing.Point(63, 47);
            this.btnSelectedRoom.Name = "btnSelectedRoom";
            this.btnSelectedRoom.Size = new System.Drawing.Size(120, 120);
            this.btnSelectedRoom.TabIndex = 12;
            this.btnSelectedRoom.Text = "Chưa chọn phòng";
            this.btnSelectedRoom.UseVisualStyleBackColor = true;
            // 
            // frmLapPhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 782);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLapPhieuThuePhong";
            this.Text = "Lập phiếu thuê phòng";
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuThuePhong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox tbSoLuongKhach;
        private System.Windows.Forms.TextBox tbMaPhieu;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvCTPhieuThuePhong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectedRoom;
    }
}