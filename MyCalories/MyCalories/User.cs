﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using NpgsqlTypes;

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
        private double _height;
        private double _weight;
        private string _healthStatus;
        private string _roles;


        // Connection variables
        private NpgsqlCommand cmd;
        private NpgsqlDataReader rd;

        //Constructor

        public User() { }

        public User(int id, string fullName, string email, string password, int age, string gender, double height, double weight, string healthStatus, string roles)
        {
            this._id = id;
            this._fullName = fullName;
            this._email = email;
            this._password = password;
            this._age = age;
            this._gender = gender;
            this._height = height;
            this._weight = weight;
            this._healthStatus = healthStatus;
            this._roles = roles;
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

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double Weight
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

        public double CalculateBMI()
        {
            double BMI = 0;
            return BMI;
        }

        public double CalculateBMR()
        {
            double BMR = 0;

            // Rumus BMR berdasarkan Harris-Benedict
            if(this.Gender == "male")
                BMR = 88.362 + (13.397 * this.Weight) + (4.799 * this.Height) - (5.677 * this.Age);
            else
                BMR = 88.362 + (13.397 * this.Weight) + (4.799 * this.Height) - (5.677 * this.Age);

            return BMR;

        }

        public void AddUser(User newUser)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "insert into users values (@id_user, @name, @age, @gender, @height, @weight, @health_status, @roles, @email, @password)";
            string check = "select * from users where id_user='" + newUser.ID + "'";

            NpgsqlCommand checking = new NpgsqlCommand(check, conn);
            checking.ExecuteNonQuery();
            rd = checking.ExecuteReader();

            if(rd.HasRows && rd.Read() && rd[0].ToString() == newUser.ID.ToString())
            {
                MessageBox.Show("ID '" + newUser.ID + "' already exist!");
                rd.Close();
            }
            else
            {
                rd.Close();
                try
                {
                    cmd = new NpgsqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@id_user", NpgsqlDbType.Integer).Value = newUser.ID;
                    cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = newUser.Name;
                    cmd.Parameters.Add("@age", NpgsqlDbType.Integer).Value = newUser.Age;
                    cmd.Parameters.Add("@gender", NpgsqlDbType.Varchar).Value = newUser.Gender;
                    cmd.Parameters.Add("@height", NpgsqlDbType.Double).Value = newUser.Height;
                    cmd.Parameters.Add("@weight", NpgsqlDbType.Double).Value = newUser.Weight;
                    cmd.Parameters.Add("@health_status", NpgsqlDbType.Varchar).Value = newUser.HealthStatus;
                    cmd.Parameters.Add("@roles", NpgsqlDbType.Varchar).Value = newUser.Roles;
                    cmd.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = newUser.Email;
                    cmd.Parameters.Add("@password", NpgsqlDbType.Varchar).Value = newUser.Password;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            conn.Close();
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
