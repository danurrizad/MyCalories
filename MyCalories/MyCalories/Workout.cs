using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyCalories
{
    public class Workout
    {
        //Fields ------------------
        private int _id;
        private string _name;
        private string _description;
        private float _burned_calories;
        private string _type;
        private int _duration;
        private DateTime _date;

        // Properties ------------------
        public int ID
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public float BurnedCalories
        {
            get { return _burned_calories; }
            set { _burned_calories = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }


        // Methods ------------------

        public void AddWorkout()
        {

        }

        public void EditWorkout()
        {

        }

        public void DeleteWorkout()
        {

        }

        public void SearchWorkout()
        {

        }
    }
}
