using System.Runtime.InteropServices;

namespace MyCalories
{
    public partial class FormBMI : Form
    {
        User user;

        public FormBMI(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormBMI_Load(object sender, EventArgs e)
        {
            lblBMI.Text = user.CalculateBMI().ToString("0.##");
            lblBMICategory.Text = CategorizeBMI();
        }

        private string CategorizeBMI()
        {
            double BMI = user.CalculateBMI();

            if (BMI <= 18.4) return "Underweight";
            else if (BMI <= 24.9) return "Normal";
            else if (BMI <= 39.9) return "Overweight";
            else return "Obese";
        }

        private string Advice()
        {
            return "";
        }

    }
}