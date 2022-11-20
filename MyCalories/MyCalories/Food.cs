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
    public class Food
    {
        //Fields ------------------
        private int _id;
        private string _name;
        private string _description;
        private double _calories;
        private double _portion;
        private double _carbohydrate;
        private double _sugar;
        private double _fat;

        // Connection variables
        private static NpgsqlCommand cmd;
        private static NpgsqlDataReader rd;

        public Food() { }

        public Food(int id, string name, string description, double calories, double portion, double carbohydrate, double sugar, double fat)
        {
            this._id = id;
            this._name = name;
            this._description = description;
            this._calories = calories;
            this._portion = portion;    
            this._carbohydrate = carbohydrate;
            this._sugar = sugar;
            this._fat = fat;
        }
        
        // Properties ------------------
        public int ID
        {
            get { return _id; }
            set { _id = value; }
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

        public double Calories
        {
            get { return _calories; }
            set { _calories = value; }
        }
        
        public double Portion 
        {
            get { return _portion; }  
            set { _portion = value; } 
        }

        public double Carbohydrate
        {
            get { return _carbohydrate; }
            set { _carbohydrate = value; }
        }

        public double Sugar
        {
            get { return _sugar; }
            set { _sugar = value; }
        }

        public double Fat
        {
            get { return _fat; }
            set { _fat = value; }
        }

        // Methods ------------------
        public Dictionary<string, Food> GetNutritionFacts()
        {
            Dictionary<string, Food> nutritionFacts = new Dictionary<string, Food>();

            // code here

            return nutritionFacts;
        }

        public void AddFood(Food newFood)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            MessageBox.Show(ID.ToString());

            string query = "insert into food values (@id_food, @name, @description, @calories, @portion, @sugar, @carbohydrate, @fat)";
            string check = "select * from food where id_food='" + newFood.ID + "'";

            NpgsqlCommand checking = new NpgsqlCommand(check, conn);
            checking.ExecuteNonQuery();
            rd = checking.ExecuteReader();

            if (rd.HasRows && rd.Read() && rd[0].ToString() == newFood.ID.ToString())
            {
                MessageBox.Show("ID '" + newFood.ID + "' already exist!");
                rd.Close();
            }
            else
            {
                rd.Close();
                try
                {
                    cmd = new NpgsqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@id_food", NpgsqlDbType.Integer).Value = newFood.ID;
                    cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = newFood.Name;
                    cmd.Parameters.Add("@description", NpgsqlDbType.Varchar).Value = newFood.Description;
                    cmd.Parameters.Add("@calories", NpgsqlDbType.Double).Value = newFood.Calories;
                    cmd.Parameters.Add("@portion", NpgsqlDbType.Double).Value = newFood.Portion;
                    cmd.Parameters.Add("@sugar", NpgsqlDbType.Double).Value = newFood.Sugar;
                    cmd.Parameters.Add("@carbohydrate", NpgsqlDbType.Double).Value = newFood.Carbohydrate;
                    cmd.Parameters.Add("@fat", NpgsqlDbType.Double).Value = newFood.Fat;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            conn.Close();
        }

        public void EditFood(Food food, int id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "update food set " +
                "name = @name, " +
                "description = @description, " +
                "calories = @calories, " +
                "portion = @portion, " +
                "sugar = @sugar, " +
                "carbohydrate = @carbohydrate, " +
                "fat = @fat " +
                "where id_food = @id_food";

            cmd = new NpgsqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.Add("@id_food", NpgsqlDbType.Integer).Value = food.ID;
            cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = food.Name;
            cmd.Parameters.Add("@description", NpgsqlDbType.Varchar).Value = food.Description;
            cmd.Parameters.Add("@calories", NpgsqlDbType.Double).Value = food.Calories;
            cmd.Parameters.Add("@portion", NpgsqlDbType.Double).Value = food.Portion;
            cmd.Parameters.Add("@sugar", NpgsqlDbType.Double).Value = food.Sugar;
            cmd.Parameters.Add("@carbohydrate", NpgsqlDbType.Double).Value = food.Carbohydrate;
            cmd.Parameters.Add("@fat", NpgsqlDbType.Double).Value = food.Fat;

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

        public static void DeleteFood(int id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "delete from food where id_food = @id_food";

            cmd = new NpgsqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id_food", NpgsqlDbType.Integer).Value = id;

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

        public static void SearchFood(string query, DataGridView dgvData)
        {
            GetData.ShowData("select * FROM food where lower(name) LIKE lower('%" + query + "%') " +
            "OR lower(description) LIKE lower('%" + query + "%') ", dgvData);
        }
    }
}
