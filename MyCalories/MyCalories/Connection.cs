using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Npgsql;

namespace MyCalories
{  
    internal class Connection
    {
        private NpgsqlConnection _conn;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatikaku;Database=dbMyCalories";

        public NpgsqlConnection GetConnection()
        {
            this._conn = new NpgsqlConnection(this.connstring);
            return this._conn;
        }

    }
}
