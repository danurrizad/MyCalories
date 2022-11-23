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
            if(user.Gender.ToLower() == "male")
            {
                MaleUser male = new MaleUser
                {
                    Weight = user.Weight,
                    Height = user.Height,
                    Age = user.Age,
                    Activities = user.Activities
                };
                lblBMR.Text = male.CalculateBMR().ToString("0.##");
            }
            else if(user.Gender.ToLower() == "female")
            {
                FemaleUser female = new FemaleUser
                {
                    Weight = user.Weight,
                    Height = user.Height,
                    Age = user.Age,
                    Activities = user.Activities
                };
                lblBMR.Text = female.CalculateBMR().ToString("0.##"); ;
            }

        }
    }
}
