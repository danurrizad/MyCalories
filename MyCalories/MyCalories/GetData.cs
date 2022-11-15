using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace MyCalories
{
    public static class GetData
    {
        private static NpgsqlCommand cmd;
        private static NpgsqlDataAdapter da;
        private static DataTable dt;

        public static void ShowData(string _query, DataGridView dgv)
        {
            string query = _query;

            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            cmd = new NpgsqlCommand(query, conn);
            da = new NpgsqlDataAdapter(cmd);
            dt = new DataTable();
            try
            {
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conn.Close();
        }
    }
}
