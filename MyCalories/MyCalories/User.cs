﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalories
{
    public class User
    {
       //Fields ------------------
        private int _id;
        private string _name;
        private int _age;
        private string _gender;
        private float _height;
        private float _weight;
        private string _healthStatus;

        //Properties ------------------
        public int ID
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string HealthStatus
        {
            get { return _healthStatus; }
            set { _healthStatus = value; }
        }

        //Method ------------------
        public float CalculateBMI()
        {
            float BMI = 0;
            return BMI;
        }

        public float CalculateBMR()
        {
            float BMR = 0;
            return BMR;
        }

        public void AddUser()
        {

        }

        public void EditUser()
        {

        }

        public void DeleteUser()
        {

        }

        public void SearchUser()
        {

        }
    }
}