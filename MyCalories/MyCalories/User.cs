using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalories
{
    public class User
    {
        private string _fullName;
        private int _age;
        private string _gender;
        private float _height;
        private float _weight;
        private string health_status;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
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

        //Methods
        public float CalculateBMI(float height, float weight)
        {
            
        }

        public float CalculateBRI(float height, float weight)
        {
            
        }

        public void AddUser()
        {

        }

        public void EditUser()
        {

        }

        public void UpdateUser()
        {

        }

        public void SearchUser()
        {

        }


    }
}
