namespace QuanLyKhachSan
{
    partial class frmThanhToan
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvCTHoaDon = new System.Windows.Forms.ListView();
            this.ColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btLapHoaDon = new System.Windows.Forms.Button();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvCTHoaDon);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(835, 782);
            this.panel4.TabIndex = 3;
            // 
            // lvCTHoaDon
            // 
            this.lvCTHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCTHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCTHoaDon.HideSelection = false;
            this.lvCTHoaDon.Location = new System.Drawing.Point(0, 332);
            this.lvCTHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvCTHoaDon.Name = "lvCTHoaDon";
            this.lvCTHoaDon.Size = new System.Drawing.Size(835, 312);
            this.lvCTHoaDon.TabIndex = 4;
            this.lvCTHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvCTHoaDon.View = System.Windows.Forms.View.Details;
            this.lvCTHoaDon.SelectedIndexChanged += new System.EventHandler(this.lvCTHoaDon_SelectedIndexChanged);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "STT";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phòng";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số ngày thuê";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá sàn";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btLapHoaDon);
            this.panel8.Controls.Add(this.tbSDT);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.tbDiaChi);
            this.panel8.Controls.Add(this.tbTen);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 102);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(835, 230);
            this.panel8.TabIndex = 3;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // btLapHoaDon
            // 
            this.btLapHoaDon.Location = new System.Drawing.Point(343, 158);
            this.btLapHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLapHoaDon.Name = "btLapHoaDon";
            this.btLapHoaDon.Size = new System.Drawing.Size(144, 52);
            this.btLapHoaDon.TabIndex = 2;
            this.btLapHoaDon.Text = "Nhập thông tin";
            this.btLapHoaDon.UseVisualStyleBackColor = true;
            this.btLapHoaDon.Click += new System.EventHandler(this.btLapHoaDon_Click);
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(192, 92);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(184, 27);
            this.tbSDT.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Số điện thoại:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(504, 31);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDiaChi.Multiline = true;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(283, 84);
            this.tbDiaChi.TabIndex = 1;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(192, 31);
            this.tbTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(184, 27);
            this.tbTen.TabIndex = 0;
            this.tbTen.TextChanged += new System.EventHandler(this.tbTen_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Địa chỉ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Khách hàng/Cơ quan:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbTongTien);
            this.panel5.Controls.Add(this.btnThanhToan);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 644);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(835, 138);
            this.panel5.TabIndex = 2;
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(332, 50);
            this.tbTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(185, 27);
            this.tbTongTien.TabIndex = 0;
            this.tbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(541, 38);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 52);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng tiền:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(835, 102);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(319, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "HÓA ĐƠN THANH TOÁN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 782);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThanhToan";
            this.Text = "frmThanhToan";
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvCTHoaDon;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btLapHoaDon;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}