using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan.DAO;
namespace QuanLyKhachSan
{
    partial class frmThongKe
    {
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlConnection sqlCon = null;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; x, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXuatPDF = new System.Windows.Forms.Button();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.lbTongDoanhThuText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.Location = new System.Drawing.Point(348, 30);
            this.btnXuatPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatPDF.Name = "btnXuatPDF";
            this.btnXuatPDF.Size = new System.Drawing.Size(94, 29);
            this.btnXuatPDF.TabIndex = 2;
            this.btnXuatPDF.Text = "Xuất ra PDF";
            this.btnXuatPDF.UseVisualStyleBackColor = true;
            this.btnXuatPDF.Click += new System.EventHandler(this.exportReport_Click);
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(283, 30);
            this.nudNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudNam.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(59, 27);
            this.nudNam.TabIndex = 4;
            this.nudNam.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.nudNam.ValueChanged += new System.EventHandler(this.NumsearchYearreport_ValueChanged);
            // 
            // nudThang
            // 
            this.nudThang.Location = new System.Drawing.Point(236, 30);
            this.nudThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.Name = "nudThang";
            this.nudThang.Size = new System.Drawing.Size(41, 27);
            this.nudThang.TabIndex = 3;
            this.nudThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.ValueChanged += new System.EventHandler(this.searchMonthreport_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tháng";
            // 
            // panelmenu
            // 
            this.panelmenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelmenu.Controls.Add(this.btnXuatPDF);
            this.panelmenu.Controls.Add(this.label1);
            this.panelmenu.Controls.Add(this.nudNam);
            this.panelmenu.Controls.Add(this.nudThang);
            this.panelmenu.Location = new System.Drawing.Point(0, 24);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(800, 85);
            this.panelmenu.TabIndex = 6;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            this.dgvBaoCao.AllowUserToOrderColumns = true;
            this.dgvBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(0, 105);
            this.dgvBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.RowTemplate.Height = 29;
            this.dgvBaoCao.Size = new System.Drawing.Size(800, 316);
            this.dgvBaoCao.TabIndex = 5;
            this.dgvBaoCao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbTongDoanhThu);
            this.panel2.Controls.Add(this.lbTongDoanhThuText);
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 27);
            this.panel2.TabIndex = 7;
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(392, 1);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(17, 20);
            this.lbTongDoanhThu.TabIndex = 2;
            this.lbTongDoanhThu.Text = "0";
            this.lbTongDoanhThu.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbTongDoanhThuText
            // 
            this.lbTongDoanhThuText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTongDoanhThuText.AutoSize = true;
            this.lbTongDoanhThuText.Location = new System.Drawing.Point(271, 1);
            this.lbTongDoanhThuText.Name = "lbTongDoanhThuText";
            this.lbTongDoanhThuText.Size = new System.Drawing.Size(117, 20);
            this.lbTongDoanhThuText.TabIndex = 1;
            this.lbTongDoanhThuText.Text = "Tổng doanh thu:";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.panelmenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKe";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridViewTextBoxColumn accessibleDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessibleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessibleRoleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn backColorDataGridViewTextBoxColumn;
        private DataGridViewImageColumn backgroundImageDataGridViewImageColumn;
        private DataGridViewTextBoxColumn backgroundImageLayoutDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foreColorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rightToLeftDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn paddingDataGridViewTextBoxColumn;
        private Button btnXuatPDF;
        private NumericUpDown nudNam;
        private NumericUpDown nudThang;
        private Label label1;
        private Panel panelmenu;
        private DataGridView dgvBaoCao;
        private Panel panel2;
        private Label lbTongDoanhThu;
        private Label lbTongDoanhThuText;
    }
}

