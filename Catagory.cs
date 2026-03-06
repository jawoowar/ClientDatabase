using Assessment;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Catagory
    {
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }

        public Catagory(int CatagoryID, string CatagoryName)
        {
            this.CatagoryId = CatagoryID;
            this.CatagoryName = CatagoryName;
        }

        public static List<Catagory> LoadAllCatagorys()
        {
            List<Catagory> Catagoryies = new List<Catagory>();
            using (var connection = new SqliteConnection("Data Source=ProductCatagoriesDB.sqlite"))
            {
                connection.Open(); ;
                string selectQuery = "SELECT * FROM ProductCatagories";
                using (var command = new SqliteCommand(selectQuery, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int CatagoryID = reader.GetInt32(0);
                        string CatagoryName = reader.GetString(1);
                    }
                }
                return Catagoryies;

            }
        }
    }
}
