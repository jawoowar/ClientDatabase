
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Client // setting up Client class to be used
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ProductCatagory { get; set; }

        public Client(int ClientID, string ClientName, string ClientAddress, string PhoneNumber, string Email, string ProductCatagory)
        { // setting up Client class to be used
            this.ClientID = ClientID;
            this.ClientName = ClientName;
            this.ClientAddress = ClientAddress;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.ProductCatagory = ProductCatagory;
        }

        public static void AddClient(Client Clients) // adding client to db based on user input
        {
            using var Connection = new MySqlConnection(Database.ConnectionString); // connects to db based on assigned db path
            Connection.Open();
            string InsertQuery = "INSERT INTO Clients (ClientName, ClientAddress, PhoneNumber, Email, ProductCatagory) VALUES (@ClientName, @ClientAddress, @PhoneNumber, @Email, @Product)";
            using (var Command = new MySqlCommand(InsertQuery, Connection)) // adds values to db using above SQlite Query
            {
                Command.Parameters.AddWithValue("@ClientName", Clients.ClientName);
                Command.Parameters.AddWithValue("@ClientAddress", Clients.ClientAddress);
                Command.Parameters.AddWithValue("@PhoneNumber", Clients.PhoneNumber);
                Command.Parameters.AddWithValue("@Email", Clients.Email);
                Command.Parameters.AddWithValue("@Product", Clients.ProductCatagory);
                Command.ExecuteNonQuery();
            }
            Connection.Close();
        }

        public static void EditClient(string id, string Value, string Column) // edit db based on edits the user made (gets values through stated veriables)
        {

            using var Connection = new MySqlConnection(Database.ConnectionString); // setting up Client class to be used
            Connection.Open();
            string EditQuery = $"UPDATE Clients SET {Column} = @AlteredValue WHERE ClientID = @id";
            using var Command = new MySqlCommand(EditQuery, Connection); // edits db using above SQlite Query
            Command.Parameters.AddWithValue("@id", Convert.ToInt32(id)); // converts ID to int32 value
            Command.Parameters.AddWithValue("@AlteredValue", Value);

            Command.ExecuteNonQuery(); // executes Query

        }

        public static List<Client> LoadAllClients() // Loads Clients by storing them in a list that can be displayed
        {
            List<Client> Clients = []; // creates list
            using var Connection = new MySqlConnection(Database.ConnectionString);
            Connection.Open();
            string SelectQuery = "SELECT * FROM Clients"; // gets all data in db
            using (var Command = new MySqlCommand(SelectQuery, Connection))
            using (var Reader = Command.ExecuteReader()) // uses Reader to get and store values as veriables
            {
                while (Reader.Read())
                {
                    int Clientid = Reader.GetInt32(0); // sets values as veriables
                    string ClientName = Reader.GetString(1);
                    string ClientAddress = Reader.GetString(2);
                    string PhoneNumber = Reader.GetString(3);
                    string Email = Reader.GetString(4);
                    string ProductCatagory = Reader.GetString(5);

                    Clients.Add(new Client(Clientid, ClientName, ClientAddress, PhoneNumber, Email, ProductCatagory)); // creates a new client using veriables


                }
            }
            return Clients; // returns completed list
        }

        public static List<Client> ClientSearch(string SelectedColumn, string SearchValue) // searches through db for wanted items using user input (got through listen veriables) and storing output into a list
        {
            List<Client> SearchClients = []; // creates new list
            using var Connection = new MySqlConnection(Database.ConnectionString);
            Connection.Open();
            string SearchQuery = $"SELECT * FROM Clients WHERE {SelectedColumn} LIKE '%{SearchValue}%'";

            using (var Command = new MySqlCommand(SearchQuery, Connection))
            using (var Reader = Command.ExecuteReader()) // uses reader to get and set data and veriables
            {
                while (Reader.Read())
                {
                    int Clientid = Reader.GetInt32(0); // sets db data as veriables
                    string ClientName = Reader.GetString(1);
                    string ClientAddress = Reader.GetString(2);
                    string PhoneNumber = Reader.GetString(3);
                    string Email = Reader.GetString(4);
                    string ProductCatagory = Reader.GetString(5);

                    SearchClients.Add(new Client(Clientid, ClientName, ClientAddress, PhoneNumber, Email, ProductCatagory)); // creates new Client in new list
                }
            }
            return SearchClients; // returns the new SearchListS

        }
    }
}