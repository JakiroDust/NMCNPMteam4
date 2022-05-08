using FontAwesome.Sharp;
using QuanLyKhachSan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan
{
    public partial class FormMainMenu : Form
    {
        private readonly Panel _leftBorderBtn;
        private IconButton _currentBtn;
        private Form _currentChildForm;

        public FormMainMenu()
        {
            InitializeComponent();

            _leftBorderBtn = new Panel();
            _leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(_leftBorderBtn);
            //Form
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                _currentBtn = (IconButton)senderBtn;
                _currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                _currentBtn.ForeColor = color;
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                _currentBtn.IconColor = color;
                _currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                _leftBorderBtn.BackColor = color;
                _leftBorderBtn.Location = new Point(0, _currentBtn.Location.Y);
                _leftBorderBtn.Visible = true;
                _leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = _currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                _currentBtn.ForeColor = Color.Gainsboro;
                _currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                _currentBtn.IconColor = Color.Gainsboro;
                _currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            _currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            _leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = @"Home";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _currentChildForm?.Close();
            Reset();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenChildForm(new frmNhapPhong());
                ActivateButton(sender, RgbColors.Color1);
            }

            catch(IndexOutOfRangeException errr)
            {
                MessageBox.Show("Mời bạn tạo loại phòng trước");
            }
            }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.Color2);
            OpenChildForm(SearchRoom.GetInstance);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.Color3);
            OpenChildForm(new frmLapPhieuThuePhong());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.Color4);
        OpenChildForm(new frmThanhToan());
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.Color5);
            OpenChildForm(ReportSale.GetInstance);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.Color6);
////            OpenChildForm(new FormSetting());
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private struct RgbColors
        {
            public static readonly Color Color1 = Color.FromArgb(172, 126, 241);
            public static readonly Color Color2 = Color.FromArgb(249, 118, 176);
            public static readonly Color Color3 = Color.FromArgb(253, 138, 114);
            public static readonly Color Color4 = Color.FromArgb(95, 77, 221);
            public static readonly Color Color5 = Color.FromArgb(249, 88, 155);
            public static readonly Color Color6 = Color.FromArgb(24, 161, 251);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
