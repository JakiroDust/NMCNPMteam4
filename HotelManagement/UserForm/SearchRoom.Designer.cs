
namespace QuanLyKhachSan
{
    partial class SearchRoom
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
            this.btFindRoom = new System.Windows.Forms.Button();
            this.dgvRoomSearch = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchRoomCode = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSearchRoomState = new System.Windows.Forms.ComboBox();
            this.cbSearchRoomType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            maLoaiPhongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maLoaiPhongLabel
            // 
            maLoaiPhongLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            maLoaiPhongLabel.AutoSize = true;
            maLoaiPhongLabel.Location = new System.Drawing.Point(219, 41);
            maLoaiPhongLabel.Name = "maLoaiPhongLabel";
            maLoaiPhongLabel.Size = new System.Drawing.Size(84, 20);
            maLoaiPhongLabel.TabIndex = 10;
            maLoaiPhongLabel.Text = "Loại phòng";
            // 
            // btFindRoom
            // 
            this.btFindRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btFindRoom.Location = new System.Drawing.Point(544, 39);
            this.btFindRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFindRoom.Name = "btFindRoom";
            this.btFindRoom.Size = new System.Drawing.Size(94, 29);
            this.btFindRoom.TabIndex = 2;
            this.btFindRoom.Text = "Tìm";
            this.btFindRoom.UseVisualStyleBackColor = true;
            this.btFindRoom.Click += new System.EventHandler(this.btFindRoom_Click);
            // 
            // dgvRoomSearch
            // 
            this.dgvRoomSearch.AllowUserToAddRows = false;
            this.dgvRoomSearch.AllowUserToDeleteRows = false;
            this.dgvRoomSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoomSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomSearch.ColumnHeadersHeight = 29;
            this.dgvRoomSearch.Location = new System.Drawing.Point(3, 128);
            this.dgvRoomSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRoomSearch.Name = "dgvRoomSearch";
            this.dgvRoomSearch.ReadOnly = true;
            this.dgvRoomSearch.RowHeadersVisible = false;
            this.dgvRoomSearch.RowHeadersWidth = 51;
            this.dgvRoomSearch.RowTemplate.Height = 29;
            this.dgvRoomSearch.Size = new System.Drawing.Size(860, 311);
            this.dgvRoomSearch.TabIndex = 3;
            this.dgvRoomSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomSearch_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Phòng";
            // 
            // tbSearchRoomCode
            // 
            this.tbSearchRoomCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearchRoomCode.Location = new System.Drawing.Point(138, 39);
            this.tbSearchRoomCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchRoomCode.Name = "tbSearchRoomCode";
            this.tbSearchRoomCode.Size = new System.Drawing.Size(75, 27);
            this.tbSearchRoomCode.TabIndex = 5;
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRefresh.Location = new System.Drawing.Point(655, 38);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(94, 29);
            this.btRefresh.TabIndex = 6;
            this.btRefresh.Text = "Tải lại";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tình trạng";
            // 
            // cbSearchRoomState
            // 
            this.cbSearchRoomState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSearchRoomState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchRoomState.FormattingEnabled = true;
            this.cbSearchRoomState.Items.AddRange(new object[] {
            "",
            "Trống",
            "Đầy"});
            this.cbSearchRoomState.Location = new System.Drawing.Point(470, 39);
            this.cbSearchRoomState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSearchRoomState.Name = "cbSearchRoomState";
            this.cbSearchRoomState.Size = new System.Drawing.Size(56, 28);
            this.cbSearchRoomState.TabIndex = 10;
            this.cbSearchRoomState.SelectedIndexChanged += new System.EventHandler(this.cbSearchRoomState_SelectedIndexChanged);
            // 
            // cbSearchRoomType
            // 
            this.cbSearchRoomType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSearchRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchRoomType.FormattingEnabled = true;
            this.cbSearchRoomType.Location = new System.Drawing.Point(304, 35);
            this.cbSearchRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSearchRoomType.Name = "cbSearchRoomType";
            this.cbSearchRoomType.Size = new System.Drawing.Size(81, 28);
            this.cbSearchRoomType.TabIndex = 11;
            this.cbSearchRoomType.SelectedIndexChanged += new System.EventHandler(this.cbSearchRoomType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Controls.Add(this.cbSearchRoomState);
            this.panel1.Controls.Add(this.cbSearchRoomType);
            this.panel1.Controls.Add(this.btFindRoom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(maLoaiPhongLabel);
            this.panel1.Controls.Add(this.tbSearchRoomCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 121);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SearchRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRoomSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchRoom";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btFindRoom;
        private System.Windows.Forms.DataGridView dgvRoomSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchRoomCode;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSearchRoomState;
        private System.Windows.Forms.BindingSource lOAIPHONGBindingSource;
        private System.Windows.Forms.ComboBox cbSearchRoomType;
        private System.Windows.Forms.Panel panel1;
    }
}