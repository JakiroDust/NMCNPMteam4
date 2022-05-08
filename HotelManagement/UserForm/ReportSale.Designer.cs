using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan.DAO;
namespace QuanLyKhachSan
{
    partial class ReportSale
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
            this.exportReport = new System.Windows.Forms.Button();
            this.searchYearreport = new System.Windows.Forms.NumericUpDown();
            this.searchMonthreport = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchYearreport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchMonthreport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exportReport
            // 
            this.exportReport.Location = new System.Drawing.Point(464, 30);
            this.exportReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportReport.Name = "exportReport";
            this.exportReport.Size = new System.Drawing.Size(94, 29);
            this.exportReport.TabIndex = 2;
            this.exportReport.Text = "Xuất";
            this.exportReport.UseVisualStyleBackColor = true;
            this.exportReport.Click += new System.EventHandler(this.exportReport_Click);
            // 
            // searchYearreport
            // 
            this.searchYearreport.Location = new System.Drawing.Point(283, 30);
            this.searchYearreport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchYearreport.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.searchYearreport.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.searchYearreport.Name = "searchYearreport";
            this.searchYearreport.Size = new System.Drawing.Size(59, 27);
            this.searchYearreport.TabIndex = 4;
            this.searchYearreport.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // searchMonthreport
            // 
            this.searchMonthreport.Location = new System.Drawing.Point(236, 30);
            this.searchMonthreport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchMonthreport.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.searchMonthreport.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.searchMonthreport.Name = "searchMonthreport";
            this.searchMonthreport.Size = new System.Drawing.Size(41, 27);
            this.searchMonthreport.TabIndex = 3;
            this.searchMonthreport.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.searchMonthreport.ValueChanged += new System.EventHandler(this.searchMonthreport_ValueChanged_1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tạo báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.exportReport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchYearreport);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.searchMonthreport);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToOrderColumns = true;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(0, 105);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 29;
            this.dgvReport.Size = new System.Drawing.Size(800, 316);
            this.dgvReport.TabIndex = 5;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 27);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "oke123";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // ReportSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportSale";
            this.Text = "ReportSale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchYearreport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchMonthreport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
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
        private Button exportReport;
        private NumericUpDown searchYearreport;
        private NumericUpDown searchMonthreport;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private DataGridView dgvReport;
        private Panel panel2;
        private Label label3;
        private Label label2;
    }
}

