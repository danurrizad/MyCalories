using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace MyCalories
{
    public class User
    {
       //Fields ------------------
        private int _id;
        private string _fullName;
        private string _email;
        private string _password;   
        private int _age;
        private string _gender;
        private float _height;
        private float _weight;
        private string _healthStatus;
        private string _roles;


        // Connection variables
        private NpgsqlCommand cmd;
        private NpgsqlDataReader rd;

        //Constructor

        public User() { }

        public User(string _email, string _password)
        {
            Email = _email;
            Password = _password;
        }
        //Properties ------------------
        public int ID
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        
        public string Email
        {
            get { return _email; }  
            set { _email = value; } 
        }
        public string Password
        {
            get { return _password; } 
            set { _password = value; }  
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

        public string Roles
        {
            get { return _roles; }
            set { _roles = value; }
        }


        //Method ------------------

        public bool Login(string Email, string Password)
        {
            try
            {
                NpgsqlConnection login = new Connection().GetConnection();
                login.Open();
                cmd = new NpgsqlCommand("select name, roles from users where email='" + Email + "' and password='" + Password + "'");
                cmd.Connection = login;
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();

                if (rd.HasRows && rd.Read())
                {
                    this.Name = rd.GetString(0);
                    this.Roles = rd.GetString(1);
                    

                    return true;
                }
                else return false; 
            }
            catch (Exception ex)
            {
                return false;
            }

        }

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
