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
    public partial class FormHome : Form
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
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            //Transparan Background Panel Goals dan Workouts
            panelGoals.BackColor = Color.FromArgb(220, 255, 255, 255);
            panelWorkouts.BackColor = Color.FromArgb(220, 255, 255, 255);

            //Bentuk Panel Goals dan Workouts Menjadi Rounded Border
            panelGoals.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelGoals.Width, panelGoals.Height, 50, 50));
            panelWorkouts.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelWorkouts.Width, panelWorkouts.Height, 50, 50));
            panelRecentWorkouts.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelRecentWorkouts.Width, panelRecentWorkouts.Height, 50, 50));
        }

        private void linkLabelGoals_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
