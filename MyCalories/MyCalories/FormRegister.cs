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
            //Membuat Panel Memiliki Efek Transparan
            panelLogin.BackColor = Color.FromArgb(220, 255, 255, 255);

            //Membuat Bentuk Panel dan Button Memiliki Rounded Border
            panelLogin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelLogin.Width, panelLogin.Height, 50, 50));
            
            panelTbNama.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTbNama.Width, panelTbNama.Height, 30, 30));
            panelNama.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelNama.Width, panelNama.Height, 35, 35));

            panelTbEmail.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTbEmail.Width, panelTbEmail.Height, 30, 30));
            panelEmail.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelEmail.Width, panelEmail.Height, 30, 30));

            panelTbPass.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTbPass.Width, panelTbPass.Height, 30, 30));
            panelPass.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelPass.Width, panelPass.Height, 30, 30));

            panelTbKonfPass.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTbKonfPass.Width, panelTbKonfPass.Height, 30, 30));
            panelKonfPass.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelKonfPass.Width, panelKonfPass.Height, 30, 30));


            btnDaftar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDaftar.Width, btnDaftar.Height, 75, 75));


        }

        private void btnLoginSkrg_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();

        }
    }
}
