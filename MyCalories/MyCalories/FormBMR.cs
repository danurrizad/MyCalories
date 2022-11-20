using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalories
{
    public partial class FormBMR : Form
    {
        User user;
        public FormBMR(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormBMR_Load(object sender, EventArgs e)
        {

        }

        private void FormBMR_Load_1(object sender, EventArgs e)
        {
            lblBMR.Text = user.CalculateBMR().ToString("0.##");
        }
    }
}
