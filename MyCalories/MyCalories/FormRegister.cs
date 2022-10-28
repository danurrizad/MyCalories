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

namespace MyCalories
{
    public partial class FormRegister : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse

        );
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.FromArgb(220, 255, 255, 255);
            panelLogin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelLogin.Width, panelLogin.Height, 50, 50));
            btnDaftar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDaftar.Width, btnDaftar.Height, 75, 75));

        }
    }
}
