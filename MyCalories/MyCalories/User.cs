using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using NpgsqlTypes;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;

namespace MyCalories
{
    public class User
    {
        //Fields ------------------
        private int _id;
        private string _fullName;
        private string _email;
        protected string _password;
        private int _age;
        private string _gender;
        private double _height;
        private double _weight;
        private int _activities;
        private string _roles;


        // Connection variables
        private static NpgsqlCommand cmd;
        private static NpgsqlDataReader rd;

        //Inheritance
        public static User user;

        //Constructor
        public User() { }

        public User(int id, string fullName, int age, string gender, double height, double weight, int activities, string roles, string email = "admin@gmail.com", string password = "abcABC123!")
        {
            this._id = id;
            this._fullName = fullName;
            this._email = email;
            this._password = password;
            this._age = age;
            this._gender = gender;
            this._height = height;
            this._weight = weight;
            this._activities = activities;
            this._roles = roles;
        }
        //Properties ------------------
        public int ID
        {
            get { return _id; }
            set { _id = value; }
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

        public int Activities
        {
            get { return _activities; }
            set { _activities = value; }
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
                cmd = new NpgsqlCommand("select * from users where email='" + Email + "' and password='" + Password + "'");
                cmd.Connection = login;
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();

                if (rd.HasRows && rd.Read())
                {
                    this.ID = rd.GetInt32(0);
                    this.Name = rd.GetString(1);
                    this.Age = rd.GetInt32(2);
                    this.Gender = rd.GetString(3);
                    this.Height = rd.GetDouble(4);
                    this.Weight = rd.GetDouble(5);
                    this.Activities = rd.GetInt32(6);
                    this.Roles = rd.GetString(7);
                    this.Email = rd.GetString(8);
                    this.Password = rd.GetString(9);

                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public virtual double CalculateBMI()
        {
            double BMI = 0;

            BMI = this.Weight / Math.Pow((this.Height * 0.01), 2);

            return BMI;
        }

        public virtual double CalculateBMR()
        {
            double BMR = 0;

            return BMR;
        }

        public virtual double GetRDA()
        {
            double RDA = 0;

            return RDA;
        }


        public static void GetAllUsers(DataGridView dgvData)
        {
            try
            {
                GetData.ShowData("select * from users", dgvData);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddUser(User newUser)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "insert into users values (default, @name, @age, @gender, @height, @weight, @activities, @roles, @email, @password)";
            string check = "select * from users where id_user='" + newUser.ID + "'";

            NpgsqlCommand checking = new NpgsqlCommand(check, conn);
            checking.ExecuteNonQuery();
            rd = checking.ExecuteReader();


            if(rd.HasRows && rd.Read() && rd[0].ToString() == newUser.ID.ToString())
            {
                throw new DuplicateNameException("ID '" + newUser.ID + "' already exist!");
                rd.Close();
            }
            else
            {
                rd.Close();
                try
                {
                    cmd = new NpgsqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = newUser.Name;
                    cmd.Parameters.Add("@age", NpgsqlDbType.Integer).Value = newUser.Age;
                    cmd.Parameters.Add("@gender", NpgsqlDbType.Varchar).Value = newUser.Gender;
                    cmd.Parameters.Add("@height", NpgsqlDbType.Double).Value = newUser.Height;
                    cmd.Parameters.Add("@weight", NpgsqlDbType.Double).Value = newUser.Weight;
                    cmd.Parameters.Add("@activities", NpgsqlDbType.Integer).Value = newUser.Activities;
                    cmd.Parameters.Add("@roles", NpgsqlDbType.Varchar).Value = newUser.Roles;
                    cmd.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = newUser.Email;
                    cmd.Parameters.Add("@password", NpgsqlDbType.Varchar).Value = newUser.Password;

                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            conn.Close();
        }

        public void EditUser(User user, int id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "update users set " +
                "name = @name, " +
                "age = @age, " +
                "gender = @gender, " +
                "height = @height, " +
                "weight = @weight, " +
                "activities = @activities, " +
                "roles = @roles, " +
                "email = @email, " +
                "password = @password " +
                "where id_user = @id_user";

            cmd = new NpgsqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id_user", NpgsqlDbType.Integer).Value = user.ID;
            cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = user.Name;
            cmd.Parameters.Add("@age", NpgsqlDbType.Integer).Value = user.Age;
            cmd.Parameters.Add("@gender", NpgsqlDbType.Varchar).Value = user.Gender;
            cmd.Parameters.Add("@height", NpgsqlDbType.Double).Value = user.Height;
            cmd.Parameters.Add("@weight", NpgsqlDbType.Double).Value = user.Weight;
            cmd.Parameters.Add("@activities", NpgsqlDbType.Integer).Value = user.Activities;
            cmd.Parameters.Add("@roles", NpgsqlDbType.Varchar).Value = user.Roles;
            cmd.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = user.Email;
            cmd.Parameters.Add("@password", NpgsqlDbType.Varchar).Value = user.Password;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            conn.Close();
        }

        public static void DeleteUser(int id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "delete from users where id_user = @id_user";

            cmd = new NpgsqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id_user", NpgsqlDbType.Integer).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void SearchUser(string query, DataGridView dgvData)
        {
            try
            {
                GetData.ShowData("select * FROM users where lower(name) LIKE lower('%" + query + "%') " +
                    "OR lower(gender) LIKE lower('%" + query + "%') ", dgvData);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
