namespace QuanLyKhachSan
{
    partial class frmNhapPhong
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.tbPhong = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lbNhapPhong = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 173);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1038, 623);
            this.dgv.TabIndex = 11;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // txtDonGia
            // 
            this.txtDonGia.AllowDrop = true;
            this.txtDonGia.Location = new System.Drawing.Point(611, 42);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 27);
            this.txtDonGia.TabIndex = 10;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AllowDrop = true;
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(542, 45);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(63, 20);
            this.lbDonGia.TabIndex = 9;
            this.lbDonGia.Text = "Đơn Giá";
            this.lbDonGia.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSua
            // 
            this.btnSua.AllowDrop = true;
            this.btnSua.Location = new System.Drawing.Point(756, 118);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 44);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AllowDrop = true;
            this.btnXoa.Location = new System.Drawing.Point(756, 66);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 44);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AllowDrop = true;
            this.btnThem.Location = new System.Drawing.Point(756, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 44);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.AllowDrop = true;
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(436, 41);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(100, 28);
            this.cbLoaiPhong.TabIndex = 5;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AllowDrop = true;
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(179, 90);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(60, 20);
            this.lbGhiChu.TabIndex = 6;
            this.lbGhiChu.Text = "Ghi Chú";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AllowDrop = true;
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Location = new System.Drawing.Point(346, 45);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(84, 20);
            this.lbLoaiPhong.TabIndex = 5;
            this.lbLoaiPhong.Text = "Loại phòng";
            // 
            // lbPhong
            // 
            this.lbPhong.AllowDrop = true;
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(183, 45);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(51, 20);
            this.lbPhong.TabIndex = 5;
            this.lbPhong.Text = "Phòng";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.AllowDrop = true;
            this.tbGhiChu.Location = new System.Drawing.Point(245, 87);
            this.tbGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(466, 27);
            this.tbGhiChu.TabIndex = 3;
            // 
            // tbPhong
            // 
            this.tbPhong.AllowDrop = true;
            this.tbPhong.Location = new System.Drawing.Point(240, 42);
            this.tbPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Size = new System.Drawing.Size(100, 27);
            this.tbPhong.TabIndex = 0;
            this.tbPhong.TextChanged += new System.EventHandler(this.tbPhong_TextChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.Controls.Add(this.btnSua);
            this.panelMenu.Controls.Add(this.txtDonGia);
            this.panelMenu.Controls.Add(this.btnXoa);
            this.panelMenu.Controls.Add(this.lbNhapPhong);
            this.panelMenu.Controls.Add(this.btnThem);
            this.panelMenu.Controls.Add(this.lbDonGia);
            this.panelMenu.Controls.Add(this.tbGhiChu);
            this.panelMenu.Controls.Add(this.lbGhiChu);
            this.panelMenu.Controls.Add(this.lbPhong);
            this.panelMenu.Controls.Add(this.tbPhong);
            this.panelMenu.Controls.Add(this.cbLoaiPhong);
            this.panelMenu.Controls.Add(this.lbLoaiPhong);
            this.panelMenu.Location = new System.Drawing.Point(0, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1038, 163);
            this.panelMenu.TabIndex = 12;
            // 
            // lbNhapPhong
            // 
            this.lbNhapPhong.AutoSize = true;
            this.lbNhapPhong.Location = new System.Drawing.Point(5, 7);
            this.lbNhapPhong.Name = "lbNhapPhong";
            this.lbNhapPhong.Size = new System.Drawing.Size(92, 20);
            this.lbNhapPhong.TabIndex = 0;
            this.lbNhapPhong.Text = "Nhập phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 796);
            this.panel2.TabIndex = 13;
            // 
            // frmNhapPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 796);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNhapPhong";
            this.Text = "Quản lý phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.TextBox tbPhong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lbNhapPhong;
        private System.Windows.Forms.Panel panel2;
    }
}

