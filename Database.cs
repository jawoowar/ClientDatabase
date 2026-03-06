using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assessment
{
    public class Database
    {

        public static string ConnectionString = string.Empty;
        public static void InitializeDatabase()
        {
            ConnectionString = "Server= ;Port= ;Database ;Uid= ;Pwd= ;"; // string with all credentials for database connection in mySQL

            using MySqlConnection connection = new(ConnectionString);
            try
            {
                connection.Open();
                Console.WriteLine("connection open");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); // error massage if database can not be reached
            }
        }
    }
}
