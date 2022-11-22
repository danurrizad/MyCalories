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
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace MyCalories
{
    internal class DailyRecords
    {
        private int _id_dailycalories;
        private int _id_user;
        private int _id_food;
        private int _id_workout;
        private DateTime _datetime;

        // Connection variables
        private static NpgsqlCommand cmd;
        private static NpgsqlDataAdapter da;
        private static DataTable dt;

        //Other classes
        Food food;
        Workout workout;

        // Generic SQL
        private static string sql = "select id_calories_flow, users.id_user, users.name, food.id_food, food.name, food.calories, workout.id_workout, workout.name, workout.burned_calories, datetime from calories_flow " +
                "inner join users on calories_flow.id_user = users.id_user " +
                "inner join food on calories_flow.id_food = food.id_food " +
                "inner join workout on calories_flow.id_workout = workout.id_workout ";


        public DailyRecords() { }

        public DailyRecords(int id_dailycalories, int id_user, int id_food, int id_workout, DateTime datetime)
        {
            this._id_dailycalories = id_dailycalories;
            this._id_user = id_user;
            this._id_food = id_food;
            this._id_workout = id_workout;
            this._datetime = datetime;
        }

        public int IDDailyCalories
        {
            get { return _id_dailycalories; }
            set { _id_dailycalories = value; }
        }

        public int IDUser
        {
            get { return _id_user; }
            set { _id_user = value; }
        }

        public int IDFood
        {
            get { return _id_food; }
            set { _id_food = value; }
        }

        public int IDWorkout
        {
            get { return _id_workout; }
            set { _id_workout = value; }
        }

        public DateTime Datetime
        {
            get { return _datetime; }
            set { _datetime = value; }
        }

        public void AddRecord(DailyRecords newRecord)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "insert into calories_flow values (default, @id_user, @id_food, @id_workout, @datetime)";

            try
            {
                cmd = new NpgsqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@id_user", NpgsqlDbType.Integer).Value = newRecord.IDUser;
                cmd.Parameters.Add("@id_food", NpgsqlDbType.Integer).Value = newRecord.IDFood;
                cmd.Parameters.Add("@id_workout", NpgsqlDbType.Integer).Value = newRecord.IDWorkout;
                cmd.Parameters.Add("@datetime", NpgsqlDbType.Date).Value = newRecord.Datetime;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conn.Close();
        }

        public void EditRecord(DailyRecords record, int id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "update calories_flow set " +
                "id_user = @id_user, " +
                "id_food = @id_food, " +
                "id_workout = @id_workout, " +
                "datetime = @datetime " +
                "where id_calories_flow = @id_calories_flow";

            cmd = new NpgsqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id_calories_flow", NpgsqlDbType.Integer).Value = record.IDDailyCalories;
            cmd.Parameters.Add("@id_user", NpgsqlDbType.Integer).Value = record.IDUser;
            cmd.Parameters.Add("@id_food", NpgsqlDbType.Integer).Value = record.IDFood;
            cmd.Parameters.Add("@id_workout", NpgsqlDbType.Integer).Value = record.IDWorkout;
            cmd.Parameters.Add("@datetime", NpgsqlDbType.Date).Value = record.Datetime;

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

        public static void DeleteRecord(int id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string query = "delete from calories_flow where id_calories_flow = @id_calories_flow";

            cmd = new NpgsqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id_calories_flow", NpgsqlDbType.Integer).Value = id;

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

        public static void SearchRecord(string query, DataGridView dgvData)
        {
            sql += $"OR lower(food.name) LIKE lower('%{query}%') ";

            GetData.ShowData(sql, dgvData);
        }

        public static void GetAllRecords(DataGridView dgvData)
        {
            sql +=  "";

            GetData.ShowData(sql, dgvData);
        }

        public static void ClearAllRecords(DataGridView dgvData)
        {
            string sql = "truncate table calories_flow";
            GetData.ShowData(sql, dgvData);
        }

        public static List<object[]> GetFoodNamesCalories()
        {
            string query = "select id_food, food.name, food.calories from food";

            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            cmd = new NpgsqlCommand(query, conn);
            da = new NpgsqlDataAdapter(cmd);
            dt = new DataTable();
            try
            {
                da.Fill(dt);
                List<object[]> foods = dt.AsEnumerable().Select(n => n.ItemArray).ToList();
                return foods;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            conn.Close();
        }

        public static List<object[]> GetWorkoutNamesCalories()
        {
            string query = "select id_workout, workout.name, workout.burned_calories from workout";

            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            cmd = new NpgsqlCommand(query, conn);
            da = new NpgsqlDataAdapter(cmd);
            dt = new DataTable();
            try
            {
                da.Fill(dt);
                List<object[]> workouts = dt.AsEnumerable().Select(n => n.ItemArray).ToList();
                return workouts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            conn.Close();
        }

        public static List<object[]> GetFoodsToday()
        {
            string query = $"select food.name, food.calories from calories_flow inner join food on calories_flow.id_food = food.id_food where datetime='{DateTime.UtcNow.Date}' order by datetime desc";

            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            cmd = new NpgsqlCommand(query, conn);
            da = new NpgsqlDataAdapter(cmd);
            dt = new DataTable();
            try
            {
                da.Fill(dt);
                List<object[]> foods = dt.AsEnumerable().Select(n => n.ItemArray).ToList();
                return foods;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            conn.Close();
        }

        public static List<object[]> GetWorkoutsToday()
        {
            string query = $"select workout.name, workout.burned_calories from calories_flow inner join workout on calories_flow.id_workout = workout.id_workout where datetime='{DateTime.UtcNow.Date}' order by datetime desc";

            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            cmd = new NpgsqlCommand(query, conn);
            da = new NpgsqlDataAdapter(cmd);
            dt = new DataTable();
            try
            {
                da.Fill(dt);
                List<object[]> workouts = dt.AsEnumerable().Select(n => n.ItemArray).ToList();
                return workouts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            conn.Close();
        }

        public static int GetFoodsTodayCount()
        {
            try
            {
                cmd.CommandText = "select count(*) FROM food";
                return (int)(long)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int GetWorkoutsTodayCount()
        {
            try
            {
                cmd.CommandText = "select count(*) FROM workout";
                return (int)(long)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
