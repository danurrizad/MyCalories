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

namespace MyCalories
{
    public partial class FormHomepage : Form
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
        private bool stopMouseLeave = false;
  
        public FormHomepage()
        {
            InitializeComponent();
            //Membuat Button Dengan Bentuk Rounded Border
            panelDailyRecords.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDailyRecords.Width, panelDailyRecords.Height, 50, 50));
            panelBMI.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelBMI.Width, panelBMI.Height, 50, 50));
            panelBMR.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelBMR.Width, panelBMR.Height, 50, 50));
            panelFoodEnConv.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelFoodEnConv.Width, panelFoodEnConv.Height, 50, 50));
            panelNutriFact.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelNutriFact.Width, panelNutriFact.Height, 50, 50));


            //Membuat Back Color Button Pada Sidebar ketika MouseHover menjadi Transparan
            btnDailyRecords.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDailyRecords.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btnBMI.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBMI.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btnBMR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBMR.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btnFoodEnConv.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFoodEnConv.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btnNutriFact.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNutriFact.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        private void FormHomepage_Load(object sender, EventArgs e)
        {
            
        }

        //--------------------------------------------------------BUTTON DAILY RECORDS----------------------------------------------------------------------
        private void btnDailyRecords_Click(object sender, EventArgs e)
        {
            //Backcolor Button Lain Menjadi Transparan
            panelBMI.BackColor = Color.Transparent;
            panelBMR.BackColor = Color.Transparent;
            panelFoodEnConv.BackColor = Color.Transparent;
            panelNutriFact.BackColor = Color.Transparent;

            panelDailyRecords.BackColor = Color.FromArgb(156, 156, 156);

            //Menampilkan FormDailyRecords
            this.pnlFormLoader.Controls.Clear();
            FormDailyRecords formDailyRecords = new FormDailyRecords() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true};
            formDailyRecords.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formDailyRecords);
            formDailyRecords.Show();
        }
        //--------------------------------------------------------Button Calculate BMI----------------------------------------------------------------------
      
     
        private void btnBMI_Click(object sender, EventArgs e)
        {
            //Backcolor Button Lain Menjadi Transparan
            panelDailyRecords.BackColor = Color.Transparent;
            panelBMR.BackColor = Color.Transparent;
            panelFoodEnConv.BackColor = Color.Transparent;
            panelNutriFact.BackColor = Color.Transparent;

            panelBMI.BackColor = Color.FromArgb(156, 156, 156);

            //Menampilkan FormBMI
            this.pnlFormLoader.Controls.Clear();
            FormBMI formBMI = new FormBMI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formBMI.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formBMI);
            formBMI.Show();

        }


        //--------------------------------------------------------Button Calculate BMR----------------------------------------------------------------------
        private void btnBMR_Click(object sender, EventArgs e)
        {
            //Backcolor Button Lain Menjadi Transparan
            panelBMI.BackColor = Color.Transparent;
            panelDailyRecords.BackColor = Color.Transparent;
            panelFoodEnConv.BackColor = Color.Transparent;
            panelNutriFact.BackColor = Color.Transparent;

            panelBMR.BackColor = Color.FromArgb(156, 156, 156);


            //Menampilkan FormBMR
            this.pnlFormLoader.Controls.Clear();
            FormBMR formBMR = new FormBMR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formBMR.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formBMR);
            formBMR.Show();

        }


        //--------------------------------------------------------Button Food Energy Converter----------------------------------------------------------------------
        private void btnFoodEnConv_Click(object sender, EventArgs e)
        {
            //Backcolor Button Lain Menjadi Transparan
            panelBMI.BackColor = Color.Transparent;
            panelBMR.BackColor = Color.Transparent;
            panelDailyRecords.BackColor = Color.Transparent;
            panelNutriFact.BackColor = Color.Transparent;

            panelFoodEnConv.BackColor = Color.FromArgb(156, 156, 156);

            //Menampilkan FormFoodEnConv
            this.pnlFormLoader.Controls.Clear();
            FormFoodEnConv formFoodEnConv = new FormFoodEnConv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formFoodEnConv.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formFoodEnConv);
            formFoodEnConv.Show();

        }


        //--------------------------------------------------------Button Nutricion Facts List----------------------------------------------------------------------
        private void btnNutriFact_Click(object sender, EventArgs e)
        {
            //Backcolor Button Lain Menjadi Transparan
            panelBMI.BackColor = Color.Transparent;
            panelBMR.BackColor = Color.Transparent;
            panelFoodEnConv.BackColor = Color.Transparent;
            panelDailyRecords.BackColor = Color.Transparent;

            panelNutriFact.BackColor = Color.FromArgb(156, 156, 156);

            //Menampilkan FormNutriFacts
            this.pnlFormLoader.Controls.Clear();
            FormNutriFacts formNutriFacts = new FormNutriFacts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formNutriFacts.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formNutriFacts);
            formNutriFacts.Show();
        }


        //--------------------------------------------------------Button Logout----------------------------------------------------------------------
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        
    }
}
