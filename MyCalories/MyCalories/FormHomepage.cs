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
        }
        private void FormHomepage_Load(object sender, EventArgs e)
        {
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

        //--------------------------------------------------------BUTTON DAILY RECORDS----------------------------------------------------------------------
        private void btnDailyRecords_Click(object sender, EventArgs e)
        {
            panelDailyRecords.BackColor = Color.FromArgb(156, 156, 156);
            panelDailyRecords.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDailyRecords.Width, panelDailyRecords.Height, 50, 50));

            //FormHomepage formHomepage = new FormHomepage();
            //formHomepage.Show();
            //this.Hide();

        }
        //--------------------------------------------------------Button Calculate BMI----------------------------------------------------------------------
      
     
        private void btnBMI_Click(object sender, EventArgs e)
        {
            panelBMI.BackColor = Color.FromArgb(156, 156, 156);
            panelBMI.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelBMI.Width, panelBMI.Height, 50, 50));

        }


        //--------------------------------------------------------Button Calculate BMR----------------------------------------------------------------------
        private void btnBMR_Click(object sender, EventArgs e)
        {
            panelBMR.BackColor = Color.FromArgb(156, 156, 156);
            panelBMR.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelBMR.Width, panelBMR.Height, 50, 50));

        }


        //--------------------------------------------------------Button Food Energy Converter----------------------------------------------------------------------
        private void btnFoodEnConv_Click(object sender, EventArgs e)
        {
            panelFoodEnConv.BackColor = Color.FromArgb(156, 156, 156);
            panelFoodEnConv.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelFoodEnConv.Width, panelFoodEnConv.Height, 50, 50));

        }


        //--------------------------------------------------------Button Nutricion Facts List----------------------------------------------------------------------
        private void btnNutriFact_Click(object sender, EventArgs e)
        {
            panelNutriFact.BackColor = Color.FromArgb(156, 156, 156);
            panelNutriFact.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelNutriFact.Width, panelNutriFact.Height, 50, 50));

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
