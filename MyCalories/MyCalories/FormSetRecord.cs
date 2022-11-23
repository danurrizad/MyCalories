using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalories
{
    public partial class FormSetRecord : Form
    {
        User user;
        DailyRecords record;

        public FormSetRecord(User user)
        {
            InitializeComponent();
            this.user = user;
            record = new DailyRecords();
            record.IDUser = this.user.ID;
            record.Datetime = DateTime.Now;
        }

        private double GetRDA()
        {
            return user.GetRDA();
        }

        private void ClearRecord()
        {
            lblFood.Text = lblFoodCalories.Text = lblIntake.Text = lblWorkout.Text = lblWorkoutBurnedCalories.Text = "";
        }
        
        private void ShowFoodNames()
        {
            List<object[]> foods = DailyRecords.GetFoodNamesCalories();
            tbFood.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbFood.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach(var food in foods)
            {
                // food[1] -> Food Name
                // food[2] -> Food Calories

                tbFood.AutoCompleteCustomSource.Add(food[1].ToString());
            }
        }

        private void ShowWorkoutNames()
        {
            List<object[]> workouts = DailyRecords.GetWorkoutNamesCalories();
            tbWorkout.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbWorkout.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (var workout in workouts)
            {
                // workout[1] -> Workout Name
                // workout[2] -> Workout Burned Calories

                tbWorkout.AutoCompleteCustomSource.Add(workout[1].ToString());
            }
        }

        private double GetTotalIntake()
        {
            double total = 0;

            if(lblFoodCalories.Text == "" && lblWorkoutBurnedCalories.Text == "")
            {
                total += 0;
            }
            else if(lblWorkoutBurnedCalories.Text == "")
            {
                total += double.Parse(lblFoodCalories.Text);
            }
            else if(lblFoodCalories.Text == "")
            {
                total -= double.Parse(lblWorkoutBurnedCalories.Text);
            }
            else
            {
                total += double.Parse(lblFoodCalories.Text) - double.Parse(lblWorkoutBurnedCalories.Text);
            }

            return total;
        }

        private void FormSetRecord_Load(object sender, EventArgs e)
        {
            lblRDA.Text = GetRDA().ToString("0.##");
            ShowFoodNames();
            ShowWorkoutNames();
            ClearRecord();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            List<object[]> foods = DailyRecords.GetFoodNamesCalories();

            try
            {
                foreach(var food in foods)
                {
                    if (food[1].ToString() == tbFood.Text)
                    {
                        record.IDFood = int.Parse(food[0].ToString());
                        lblFood.Text = food[1].ToString();
                        lblFoodCalories.Text = food[2].ToString();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            List<object[]> workouts = DailyRecords.GetWorkoutNamesCalories();

            try
            {
                foreach (var workout in workouts)
                {
                    if (workout[1].ToString() == tbWorkout.Text)
                    {
                        record.IDWorkout = int.Parse(workout[0].ToString());
                        lblWorkout.Text = workout[1].ToString();
                        lblWorkoutBurnedCalories.Text = workout[2].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFood.Text = tbWorkout.Text = "";
            ClearRecord();
        }

        private void lblFoodCalories_TextChanged(object sender, EventArgs e)
        {
            lblIntake.Text = GetTotalIntake().ToString();
        }

        private void lblWorkoutBurnedCalories_TextChanged(object sender, EventArgs e)
        {
            lblIntake.Text = GetTotalIntake().ToString();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                record.AddRecord(record);
                ClearRecord();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
