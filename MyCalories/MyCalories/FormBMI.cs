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
            lblAdvice.Text = Advice();

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
            double BMI = user.CalculateBMI();

            if (BMI <= 18.4) return "Increase your weight!";
            else if (BMI <= 24.9) return "Keep your good works!";
            else if (BMI <= 39.9) return "Dont worry, but increase your workout frequency and eat healthy foods!";
            else return "Watch out with your weight sir, obese can lead you to many dangerous illness";
        }

    }
}