using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalories
{
    public class User
    {
<<<<<<< HEAD
        private string _fullName;
=======
        //Fields ------------------
        private int _id;
        private string _name;
>>>>>>> 890c0526e19a44e928d86cf3eac475f2fe241054
        private int _age;
        private string _gender;
        private float _height;
        private float _weight;
<<<<<<< HEAD
        private string health_status;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
=======
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
>>>>>>> 890c0526e19a44e928d86cf3eac475f2fe241054
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

<<<<<<< HEAD
        //Methods
        public float CalculateBMI(float height, float weight)
        {
            
        }

        public float CalculateBRI(float height, float weight)
        {
            
=======
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
>>>>>>> 890c0526e19a44e928d86cf3eac475f2fe241054
        }

        public void AddUser()
        {

        }

        public void EditUser()
        {

        }

<<<<<<< HEAD
        public void UpdateUser()
=======
        public void DeleteUser()
>>>>>>> 890c0526e19a44e928d86cf3eac475f2fe241054
        {

        }

        public void SearchUser()
        {

        }
<<<<<<< HEAD


=======
>>>>>>> 890c0526e19a44e928d86cf3eac475f2fe241054
    }
}
