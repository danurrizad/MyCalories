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
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            panelRegister.BackColor = Color.FromArgb(220, 255, 255, 255);
 

            //Membuat Warna Mouse Back Button Daftar Sekarang Menjadi Transparan
            btnDaftarSkrg.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDaftarSkrg.FlatAppearance.MouseOverBackColor = Color.Transparent;   
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
            User user = new User();
            if (tbEmail.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Email dan Password tidak boleh kosong!");
            }
            else if (user.Login(tbEmail.Text, tbPass.Text))
            {
                FormDashboard formHomepage = new FormDashboard(user);
                formHomepage.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Email atau password yang anda masukkan salah");
            }

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
