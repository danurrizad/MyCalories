using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyCalories
{
    public partial class FormDashboard : Form
    {
        User user;
  
        public FormDashboard(User user)
        {
            InitializeComponent();

            //Membuat Back Color Button Pada Sidebar ketika MouseHover menjadi Transparan
            btnDailyRecords.FlatAppearance.MouseDownBackColor = btnDailyRecords.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBMI.FlatAppearance.MouseDownBackColor = btnBMI.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBMR.FlatAppearance.MouseDownBackColor = btnBMR.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExercise.FlatAppearance.MouseDownBackColor = btnExercise.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNutriFact.FlatAppearance.MouseDownBackColor =  btnNutriFact.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseDownBackColor = btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnLogo.FlatAppearance.MouseDownBackColor = btnLogo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUsers.FlatAppearance.MouseDownBackColor = btnUsers.FlatAppearance.MouseOverBackColor = Color.Transparent;

            lblNamaUser.Text = "Hello " + user.Name + "\nas " + user.Roles;
            this.user = user;
        }
        private void FormHomepage_Load(object sender, EventArgs e)
        {
            //Menampilkan FormHome
            FormHome formHome = new FormHome(this.user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formHome.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formHome);
            formHome.Show();
        }

        private void ClearButtonColor()
        {
            panelDailyRecords.BackColor = panelBMI.BackColor = panelBMR.BackColor = panelExercise.BackColor = panelNutriFact.BackColor = panelUser.BackColor = Color.Transparent;
        }


        //--------------------------------------------------------LOGO BUTTON-------------------------------------------------------------------------------------
        private void btnLogo_Click(object sender, EventArgs e)
        {
            //Menampilkan FormHome
            this.pnlFormLoader.Controls.Clear();
            FormHome formHome = new FormHome(this.user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formHome.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formHome);
            formHome.Show();
            this.Text = "Home";

            //Backcolor Button Lain Menjadi Transparan
            ClearButtonColor();
        }
        //--------------------------------------------------------BUTTON DAILY RECORDS----------------------------------------------------------------------
        private void btnDailyRecords_Click(object sender, EventArgs e)
        {
            //Backcolor Button Lain Menjadi Transparan
            ClearButtonColor();
            panelDailyRecords.BackColor = Color.FromArgb(156, 156, 156);

            //Menampilkan FormDailyRecords
            this.pnlFormLoader.Controls.Clear();
            FormDailyRecords formDailyRecords = new FormDailyRecords() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true};
            formDailyRecords.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formDailyRecords);
            formDailyRecords.Show();

            //Mengubah Judul Form
            this.Text = "Daily Records";
        }
        //--------------------------------------------------------Button Calculate BMI----------------------------------------------------------------------
      
     
        private void btnBMI_Click(object sender, EventArgs e)
        {
            //Backcolor Button Lain Menjadi Transparan
            ClearButtonColor();
            panelBMI.BackColor = Color.FromArgb(156, 156, 156);

            //Menampilkan FormBMI
            this.pnlFormLoader.Controls.Clear();
            FormBMI formBMI = new FormBMI(this.user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formBMI.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formBMI);
            formBMI.Show();

            //Mengubah Judul Form
            this.Text = "Calculate BMI";

        }


        //--------------------------------------------------------Button Calculate BMR----------------------------------------------------------------------
        private void btnBMR_Click(object sender, EventArgs e)
        {
            //Backcolor Button Lain Menjadi Transparan
            ClearButtonColor();
            panelBMR.BackColor = Color.FromArgb(156, 156, 156);


            //Menampilkan FormBMR
            this.pnlFormLoader.Controls.Clear();
            FormBMR formBMR = new FormBMR(this.user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formBMR.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formBMR);
            formBMR.Show();

            //Mengubah Judul Form
            this.Text = "Calculate BMR";
        }


        //--------------------------------------------------------Button Food Energy Converter----------------------------------------------------------------------
        private void btnFoodEnConv_Click_1(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------Button Nutricion Facts List----------------------------------------------------------------------
        private void btnNutriFact_Click(object sender, EventArgs e)
        {

            //Backcolor Button Lain Menjadi Transparan
            ClearButtonColor();
            panelNutriFact.BackColor = Color.FromArgb(156, 156, 156);

            //Menampilkan FormNutriFacts
            this.pnlFormLoader.Controls.Clear();
            FormNutriFacts formNutriFacts = new FormNutriFacts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formNutriFacts.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formNutriFacts);
            formNutriFacts.Show();

            //Mengubah Judul Form
            this.Text = "Nutricion Facts";

        }


        //--------------------------------------------------------Button Logout----------------------------------------------------------------------
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Menampilkan FormDailyRecords
            this.pnlFormLoader.Controls.Clear();
            FormDailyRecords formDailyRecords = new FormDailyRecords() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formDailyRecords.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formDailyRecords);
            formDailyRecords.Show();

            //Mengubah Judul Form
            this.Text = "Daily Records";
        }
        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            if(user.Roles.ToLower() == "admin")
            {
                ClearButtonColor();
                panelUser.BackColor = Color.FromArgb(156, 156, 156);

                //Menampilkan FormNutriFacts
                this.pnlFormLoader.Controls.Clear();
                FormUser formUser = new FormUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                formUser.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(formUser);
                formUser.Show();
               

                //Mengubah Judul Form
                this.Text = "Users";
            }
            else
            {
                btnUsers.Enabled = false;
            }
        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelExercise_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExercise_Click(object sender, EventArgs e)
        { 

            //Backcolor Button Lain Menjadi Transparan
            ClearButtonColor();
            panelExercise.BackColor = Color.FromArgb(156, 156, 156);

            //Menampilkan FormFoodEnConv
            this.pnlFormLoader.Controls.Clear();
            FormExercise formExercise = new FormExercise() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formExercise.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formExercise);
            formExercise.Show();

            //Mengubah Judul Form
            this.Text = "Exercise List";

        }
    }
}
