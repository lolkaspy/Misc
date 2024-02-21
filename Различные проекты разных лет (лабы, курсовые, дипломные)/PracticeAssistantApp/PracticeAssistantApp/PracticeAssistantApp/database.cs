using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace PracticeAssistantApp
{
    
    class Database
    {
       
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\sourcekirill\PracticeAssistantApp\PracticeAssistantApp\Source.mdf;Integrated Security=True; MultipleActiveResultSets=True;");

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }

    
}
