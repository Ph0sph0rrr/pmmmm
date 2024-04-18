using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace pm
{
    internal class Database
    {
        

        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5433; User name=postgres; Password=1111; Database=exxx");
        DateOnly date = DateOnly.FromDateTime(DateTime.Now);

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }


        public void updTable(DataTable dt, int id)
        {
            openConnection();
            string updateQueryString = $"SELECT * FROM application WHERE id = {id}";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(updateQueryString, getConnection());
            adapter.Fill(dt);
            closeConnection();
        }














    }
}
