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
        User user;

        public FormHome(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void LoadFoodsPanel()
        {
            try
            {
                List<object[]> foods = DailyRecords.GetFoodsToday();
                int foodsCount = DailyRecords.GetFoodsTodayCount();

                // food[0][0] -> Food Name in first row
                // food[0][1] -> Food Calories in first row
                if(foods == null)
                {
                    lblFoodTodayCount.Text = foodsCount.ToString();
                    lblFoodTodayName.Text = "";
                    lblFoodTodayCals.Text = "" + " cals";
                }
                else
                {
                    lblFoodTodayCount.Text = foodsCount.ToString();
                    lblFoodTodayName.Text = foods[0][0].ToString();
                    lblFoodTodayCals.Text = foods[0][1].ToString() + " cals";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadWorkoutsPanel()
        {
            try
            {
                List<object[]> workouts = DailyRecords.GetWorkoutsToday();
                int workoutCount = DailyRecords.GetWorkoutsTodayCount();

                // workouts[0][0] -> Workouts Name in first row
                // workouts[0][1] -> Workouts Calories in first row

                if (workouts == null)
                {
                    lblWorkoutTodayCount.Text = workoutCount.ToString();
                    lblWorkoutTodayName.Text = "";
                    lblWorkoutTodayCals.Text = "" + " cals";
                }
                else
                {
                    lblWorkoutTodayCount.Text = workoutCount.ToString();
                    lblWorkoutTodayName.Text = workouts[0][0].ToString();
                    lblWorkoutTodayCals.Text = workouts[0][1].ToString() + " cals";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double GetTotalWorkoutCaloriesToday()
        {
            double total = 0;
            List<object[]> workouts = DailyRecords.GetWorkoutsToday();

            if (workouts != null)
            {
                foreach (var workout in workouts)
                {
                    total += double.Parse(workout[1].ToString());
                }
            }
            else
            {
                total = 0;
            }

            return total;
        }

        private double GetTotalFoodCaloriesToday()
        {
            double total = 0;

            List<object[]> foods = DailyRecords.GetFoodsToday();

            if(foods != null)
            {
                foreach (var food in foods)
                {
                    total += double.Parse(food[1].ToString());
                }
            }
            else
            {
                total = 0;
            }

            return total;
        }

        private void LoadGoalsPanel()
        {
            double foodCal = GetTotalFoodCaloriesToday();
            double workoutCal = GetTotalWorkoutCaloriesToday();
            double goalsCal = 0;

            if(user.Gender.ToLower() == "male")
            {
                MaleUser male = new MaleUser
                {
                    Weight = user.Weight,
                    Height = user.Height,
                    Age = user.Age,
                    Activities = user.Activities
                };
                goalsCal = male.GetRDA();
            }
            else if (user.Gender.ToLower() == "female")
            {
                FemaleUser female = new FemaleUser
                {
                    Weight = user.Weight,
                    Height = user.Height,
                    Age = user.Age,
                    Activities = user.Activities
                };
                goalsCal = female.GetRDA();
            }

            lblGoals.Text = goalsCal.ToString("0.#") + " cals" ;
            lblFoods.Text = foodCal.ToString("0.#") + " cals";
            lblWorkouts.Text = workoutCal.ToString("0.#") + " cals";
            lblGoalsRemain.Text = (goalsCal - foodCal + workoutCal).ToString("0.#");


        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            //Load all data
            LoadFoodsPanel();
            LoadWorkoutsPanel();
            LoadGoalsPanel();

        }

        private void linkLabelGoals_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSetRecord formSetRecord = new FormSetRecord(this.user);
            formSetRecord.Show();
        }

        private void lblGoalsRemain_Click(object sender, EventArgs e)
        {

        }

        private void linkSetMeasurement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSetMeasurement formSetMeasurement = new FormSetMeasurement(this.user);
            formSetMeasurement.Show();
        }

        private void lblWorkoutTodayCals_Click(object sender, EventArgs e)
        {

        }
    }
}
