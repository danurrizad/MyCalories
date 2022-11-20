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
    public class Workout
    {
        //Fields ------------------
        private int _id;
        private string _name;
        private string _description;
        private double _burned_calories;
        private int _duration;
        private string _type;


        // Connection variables
        private static NpgsqlCommand cmd;
        private static NpgsqlDataReader rd;

        public Workout() { }

        public Workout(int id, string name, string description, double burned_calories, int duration, string type)
        {
            this._id = id;
            this._name = name;
            this._description = description;
            this._burned_calories = burned_calories;
            this._type = type;
            this._duration = duration;
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

        public double BurnedCalories
        {
            get { return _burned_calories; }
            set { _burned_calories = value; }
        }
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }



        // Methods ------------------

        public void AddWorkout(Workout newWorkout)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "insert into workout values (@id_workout, @name, @description, @burned_calories, @duration, @type)";
            string check = "select * from workout where id_workout='" + newWorkout.ID + "'";

            NpgsqlCommand checking = new NpgsqlCommand(check, conn);
            checking.ExecuteNonQuery();
            rd = checking.ExecuteReader();

            if (rd.HasRows && rd.Read() && rd[0].ToString() == newWorkout.ID.ToString())
            {
                MessageBox.Show("ID '" + newWorkout.ID + "' already exist!");
                rd.Close();
            }
            else
            {
                rd.Close();
                try
                {
                    cmd = new NpgsqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@id_workout", NpgsqlDbType.Integer).Value = newWorkout.ID;
                    cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = newWorkout.Name;
                    cmd.Parameters.Add("@description", NpgsqlDbType.Varchar).Value = newWorkout.Description;
                    cmd.Parameters.Add("@burned_calories", NpgsqlDbType.Double).Value = newWorkout.BurnedCalories;
                    cmd.Parameters.Add("@duration", NpgsqlDbType.Integer).Value = newWorkout.Duration;
                    cmd.Parameters.Add("@type", NpgsqlDbType.Varchar).Value = newWorkout.Type;

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

        public void EditWorkout(Workout workout, int id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "update workout set " +
                "name = @name, " +
                "description = @description, " +
                "burned_calories = @burned_calories, " +
                "duration = @duration, " +
                "type = @type " +
                "where id_workout = @id_workout";

            cmd = new NpgsqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.Add("@id_workout", NpgsqlDbType.Integer).Value = workout.ID;
            cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = workout.Name;
            cmd.Parameters.Add("@description", NpgsqlDbType.Varchar).Value = workout.Description;
            cmd.Parameters.Add("@burned_calories", NpgsqlDbType.Double).Value = workout.BurnedCalories;
            cmd.Parameters.Add("@duration", NpgsqlDbType.Integer).Value = workout.Duration;
            cmd.Parameters.Add("@type", NpgsqlDbType.Varchar).Value = workout.Type;

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

        public static void DeleteWorkout(int id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "delete from workout where id_workout = @id_workout";

            cmd = new NpgsqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id_workout", NpgsqlDbType.Integer).Value = id;

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

        public static void SearchWorkout(string query, DataGridView dgvData)
        {
            GetData.ShowData("select * FROM workout where lower(name) LIKE lower('%" + query + "%') " +
                "OR lower(description) LIKE lower('%" + query + "%') ", dgvData);
        }
    }
}
