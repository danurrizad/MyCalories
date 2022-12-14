using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyCalories
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void panelTbEmail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoginSkrg_Click(object sender, EventArgs e)
        {
            FormLogin formLogin= new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tbPass.UseSystemPasswordChar == false)
            {
                pictureBox2.BringToFront();
                tbPass.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tbPass.UseSystemPasswordChar == true)
            {
                pictureBox4.BringToFront();
                tbPass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tbKonfPass.UseSystemPasswordChar == false)
            {
                pictureBox3.BringToFront();
                tbKonfPass.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (tbKonfPass.UseSystemPasswordChar == true)
            {
                pictureBox1.BringToFront();
                tbKonfPass.UseSystemPasswordChar = false;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user = new User();


            if (tbName.Text==""||tbAge.Text==""||lbGender.Text==""||tbHeight.Text==""||tbWeight.Text==""|| tbActivities.Text==""||tbEmail.Text==""||tbPass.Text==""||tbKonfPass.Text=="")
            {
                if (string.IsNullOrEmpty(tbName.Text))
                {

                    tbName.Focus();
                    errorProvider1.SetError(tbName, "Please Enter Name");
                }
                else
                {
                    errorProvider1.Clear();
                }

                if (string.IsNullOrEmpty(tbAge.Text))
                {
                    lblYO.Focus();
                    errorProvider2.SetError(lblYO, "Please Enter Age");
                }
                else
                {
                    errorProvider2.Clear();
                }

                if (string.IsNullOrEmpty(lbGender.Text))
                {

                    lbGender.Focus();
                    errorProvider3.SetError(lbGender, "Please Choose Your Gender");
                }
                else
                {
                    errorProvider3.Clear();
                }

                if (string.IsNullOrEmpty(tbHeight.Text))
                {
                    lblCM.Focus();
                    errorProvider4.SetError(lblCM, "Please Enter Height");
                }
                else
                {
                    errorProvider4.Clear();
                }

                if (string.IsNullOrEmpty(tbWeight.Text))
                {
                    lblKG.Focus();
                    errorProvider5.SetError(lblKG, "Please Enter Weight");
                }
                else
                {
                    errorProvider5.Clear();
                }

                if (string.IsNullOrEmpty(tbActivities.Text))
                {
                    tbActivities.Focus();
                    errorProvider6.SetError(tbActivities, "Please Enter Activity");
                }
                else
                {
                    errorProvider6.Clear();
                }

                if (string.IsNullOrEmpty(tbEmail.Text))
                {
                    tbEmail.Focus();
                    errorProvider7.SetError(tbEmail, "Please Enter Email");
                }
                else
                {
                    errorProvider7.Clear();
                }

                if (string.IsNullOrEmpty(tbPass.Text))
                {
                    tbPass.Focus();
                    errorProvider8.SetError(tbPass, "Please Enter Password");
                }
                else
                {
                    errorProvider8.Clear();
                }

                if (string.IsNullOrEmpty(tbKonfPass.Text))
                {
                    tbKonfPass.Focus();
                    errorProvider9.SetError(tbKonfPass, "Please Re-enter Password");
                }
                else
                {
                    errorProvider9.Clear();
                }
            }


            else
            {
                user.SignUp(tbName.Text, Convert.ToInt32(tbAge.Text), Convert.ToString(lbGender.Text), Convert.ToDouble(tbHeight.Text), Convert.ToDouble(tbWeight.Text), int.Parse(tbActivities.Text), tbEmail.Text, tbPass.Text, tbKonfPass.Text);
                if (user.condition == true)
                {
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sign Up failed");
                }
            }
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            btnLoginSkrg.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLoginSkrg.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}
