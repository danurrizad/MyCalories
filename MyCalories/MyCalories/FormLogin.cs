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
    public partial class FormLogin : Form
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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panelRegister.BackColor = Color.FromArgb(220, 255, 255, 255);

            //Membuat Bentuk Panel dan Button Menjadi Rounded Border
            panelRegister.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelRegister.Width, panelRegister.Height, 50, 50));

            panelTbEmail.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTbEmail.Width, panelTbEmail.Height, 30, 30));
            panelEmail.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelEmail.Width, panelEmail.Height, 35, 35));


            panelTbPass.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTbPass.Width, panelTbPass.Height, 30, 30));
            panelPass.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelPass.Width, panelPass.Height, 35, 35));

            btnLogin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 75, 75));
        }

        private void btnDaftarSkrg_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tbPass.UseSystemPasswordChar == true)
            {
                pictureBox4.BringToFront();
                tbPass.UseSystemPasswordChar = false;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tbPass.UseSystemPasswordChar == false)
            {
                pictureBox2.BringToFront();
                tbPass.UseSystemPasswordChar = true;

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
