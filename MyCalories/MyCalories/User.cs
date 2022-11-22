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
        private string _healthStatus;
        private string _roles;


        // Connection variables
        private static NpgsqlCommand cmd;
        private static NpgsqlDataReader rd;
        private DataGridView r;

        //Constructor

        public User() { }

        public User(int id, string fullName, int age, string gender, double height, double weight, string healthStatus, string roles="user", string email="admin@gmail.com", string password = "abcABC123!")
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

        public bool condition;


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
                    this.HealthStatus = rd.GetString(6);
                    this.Roles = rd.GetString(7);
                    this.Email = rd.GetString(8);
                    this.Password = rd.GetString(9);

                    return true;
                }
                else return false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public double CalculateBMI()
        {
            double BMI = 0;

            BMI = this.Weight / Math.Pow((this.Height * 0.01), 2);

            return BMI;
        }

        public double CalculateBMR()
        {
            double BMR = 0;

            if (this.Gender == "male")
                BMR = 88.362 + (13.397 * this.Weight) + (4.799 * this.Height) - (5.677 * this.Age);
            else
                BMR = 447.593 + (9.247 * this.Weight) + (3.098 * this.Height) - (4.330 * this.Age);

            return BMR;

        }

        public void SignUp(string name, int age, string gender, double height, double weight, string health_status, string email, string pass, string konfPass)
        {
            condition = false;
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "insert into users values (default, @name, @age, @gender, @height, @weight, @health_status, @roles, @email, @password)";
            string check = "select * from users where email='" + email + "'";

            NpgsqlCommand checking = new NpgsqlCommand(check, conn);
            checking.ExecuteNonQuery();
            rd = checking.ExecuteReader();

            if (rd.HasRows && rd.Read() && rd[8].ToString() == email)
            {
                MessageBox.Show("Email '" + email + "' already exist!");
                rd.Close();
            }
            else if (pass == konfPass)
            {
                rd.Close();
                try
                {
                    cmd = new NpgsqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                   
                    cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = name;
                    cmd.Parameters.Add("@age", NpgsqlDbType.Integer).Value = age;
                    cmd.Parameters.Add("@gender", NpgsqlDbType.Varchar).Value = gender;
                    cmd.Parameters.Add("@height", NpgsqlDbType.Double).Value = height;
                    cmd.Parameters.Add("@weight", NpgsqlDbType.Double).Value = weight;
                    cmd.Parameters.Add("@health_status", NpgsqlDbType.Varchar).Value = health_status;
                    cmd.Parameters.Add("@roles", NpgsqlDbType.Varchar).Value = "User";
                    cmd.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = email;
                    cmd.Parameters.Add("@password", NpgsqlDbType.Varchar).Value = pass;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    condition = true;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    condition = false;
                }
            }
            else
            {
                MessageBox.Show("Pastikan password sudah sesuai!");
            }

            conn.Close();
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
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                "health_status = @health_status, " +
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
            cmd.Parameters.Add("@health_status", NpgsqlDbType.Varchar).Value = user.HealthStatus;
            cmd.Parameters.Add("@roles", NpgsqlDbType.Varchar).Value = user.Roles;
            cmd.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = user.Email;
            cmd.Parameters.Add("@password", NpgsqlDbType.Varchar).Value = user.Password;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void SearchUser(string query, DataGridView dgvData)
        {
            GetData.ShowData("select * FROM users where lower(name) LIKE lower('%" + query + "%') " +
                "OR lower(gender) LIKE lower('%" + query + "%') ", dgvData);
        }
    }
}
