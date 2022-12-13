using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeTracking
{
    class DbConnect
    {
        SqlConnection sqlConnection = new SqlConnection("Server=.;Database=Workers;Trusted_Connection=True;");
        public void OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
        public async void Execute(string cmd)
        {
            using (sqlConnection)
            {
                SqlCommand command = new SqlCommand();
                command.CommandText= cmd;
                command.Connection = sqlConnection;
                OpenConnection();
                await command.ExecuteNonQueryAsync();
                CloseConnection();
            }
        }
    }
}
