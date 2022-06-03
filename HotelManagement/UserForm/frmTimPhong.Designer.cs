
namespace QuanLyKhachSan
{
    partial class frmTimPhong
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
            System.Windows.Forms.Label lbLoaiPhong;
            this.btTimPhong = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.lbPhong = new System.Windows.Forms.Label();
            this.tbPhong = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            lbLoaiPhong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLoaiPhong
            // 
            lbLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lbLoaiPhong.AutoSize = true;
            lbLoaiPhong.Location = new System.Drawing.Point(219, 41);
            lbLoaiPhong.Name = "lbLoaiPhong";
            lbLoaiPhong.Size = new System.Drawing.Size(84, 20);
            lbLoaiPhong.TabIndex = 10;
            lbLoaiPhong.Text = "Loại phòng";
            // 
            // btTimPhong
            // 
            this.btTimPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTimPhong.Location = new System.Drawing.Point(544, 39);
            this.btTimPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTimPhong.Name = "btTimPhong";
            this.btTimPhong.Size = new System.Drawing.Size(94, 29);
            this.btTimPhong.TabIndex = 2;
            this.btTimPhong.Text = "Tìm";
            this.btTimPhong.UseVisualStyleBackColor = true;
            this.btTimPhong.Click += new System.EventHandler(this.btFindRoom_Click);
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeight = 29;
            this.dgvPhong.Location = new System.Drawing.Point(3, 128);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 29;
            this.dgvPhong.Size = new System.Drawing.Size(860, 311);
            this.dgvPhong.TabIndex = 3;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomSearch_CellContentClick);
            // 
            // lbPhong
            // 
            this.lbPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(80, 41);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(51, 20);
            this.lbPhong.TabIndex = 4;
            this.lbPhong.Text = "Phòng";
            this.lbPhong.Click += new System.EventHandler(this.lbPhong_Click);
            // 
            // tbPhong
            // 
            this.tbPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPhong.Location = new System.Drawing.Point(138, 39);
            this.tbPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Size = new System.Drawing.Size(75, 27);
            this.tbPhong.TabIndex = 5;
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRefresh.Location = new System.Drawing.Point(655, 38);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(142, 29);
            this.btRefresh.TabIndex = 6;
            this.btRefresh.Text = "Bỏ chọn Filter";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Location = new System.Drawing.Point(391, 41);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(76, 20);
            this.lbTinhTrang.TabIndex = 8;
            this.lbTinhTrang.Text = "Tình trạng";
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
            this.cbTinhTrang.Location = new System.Drawing.Point(470, 39);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(56, 28);
            this.cbTinhTrang.TabIndex = 10;
            this.cbTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbSearchRoomState_SelectedIndexChanged);
            this.cbTinhTrang.Validated += new System.EventHandler(this.cbSearchRoomState_Validated);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(304, 35);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(81, 28);
            this.cbLoaiPhong.TabIndex = 11;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbSearchRoomType_SelectedIndexChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.lbPhong);
            this.panelMenu.Controls.Add(this.btRefresh);
            this.panelMenu.Controls.Add(this.cbTinhTrang);
            this.panelMenu.Controls.Add(this.cbLoaiPhong);
            this.panelMenu.Controls.Add(this.btTimPhong);
            this.panelMenu.Controls.Add(this.lbTinhTrang);
            this.panelMenu.Controls.Add(lbLoaiPhong);
            this.panelMenu.Controls.Add(this.tbPhong);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(868, 121);
            this.panelMenu.TabIndex = 12;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmTimPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 464);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dgvPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTimPhong";
            this.Text = "Danh sách các phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btTimPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.TextBox tbPhong;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.BindingSource lOAIPHONGBindingSource;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Panel panelMenu;
    }
}