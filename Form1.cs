using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;


namespace Assessment
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Database.InitializeDatabase(); // inisialises the database (checks if it exists and creates it if it doesnt)
        }

        BindingSource ClientBindingSource = [];

        private void LoadClients() // loads clients into the table for users to see
        {
            var Clients = Client.LoadAllClients();
            ClientBindingSource.DataSource = Clients;
            DataGridViewClient.DataSource = ClientBindingSource;
            TestLbl1.Text = Clients.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e) // makes adding ui visible to user
        {
            TxtName.Visible = true;
            TxtAddress.Visible = true;
            TxtPhone.Visible = true;
            TxtEmail.Visible = true;
            DdCatagory.Visible = true;
            SubmitBtn.Visible = true;
            BackBtn.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e) // hides adding ui
        {
            TxtName.Visible = false;
            TxtAddress.Visible = false;
            TxtPhone.Visible = false;
            TxtEmail.Visible = false;
            DdCatagory.Visible = false;
            SubmitBtn.Visible = false;
            BackBtn.Visible = false;
        }

        private void SubmitBtn_Click(object sender, EventArgs e) // sends inputted values to database adding a new item to the db
        {

            List<bool> Validation = [false, false, false, false, false]; // validation checks for all relevent values

            // name validation
            if (string.IsNullOrEmpty(TxtName.Text)) // checks if name is empty
            {
                Validation[0] = false; // name invalid
            }
            else
            {
                Validation[0] = true; // name valid
            }

            // address validation

            if (string.IsNullOrEmpty(TxtAddress.Text)) // checks if address is empty
            {
                Validation[1] = false; // address invalid 
            }
            else
            {
                Validation[1] = true; // address valid
            }

            // phone number validation

            var PhoneNumber = TxtPhone.Text.Trim(); // trims unnessacery spaces
            bool IsNumber = !string.IsNullOrEmpty(PhoneNumber) && PhoneNumber.All(char.IsDigit); // checks if phonenumber is inputted and that all stuff inside it is a numerical digit

            Validation[2] = IsNumber; // sets IsParse value to validation list

            // Email validation

            var Email = TxtEmail.Text;
            string[] words = Email.Split('@'); // splits at the @ symbol

            if (words.Length > 2 || words.Length < 2)
            {
                Validation[3] = false; // email invalid
            }

            List<string> EmailEnds = [".com", ".co.uk", ".uk", ".co.org", ".org"]; // valid email ends
            string[] dots = Email.Split('.'); // splits at the @ symbol

            if (dots.Length == 2)
            {
                Validation[3] = true; // email invalid
            }

            for (int i = 0; i < EmailEnds.Count; i++) // checks through all valid email ends to see if there in the email
            {
                if (Email.EndsWith(EmailEnds[i]))
                {
                    Validation[3] = true; // email valid
                    break;
                }
            }

            // catagory validation
            var ProductCatagory = "";

            if (DdCatagory.SelectedItem != null)
            {
                if (DdCatagory.SelectedItem.ToString() is string)
                {
                    Validation[4] = true; // catagory valid
                    ProductCatagory = DdCatagory.SelectedItem.ToString();
                }

            }


            if (Validation.Any(x => x == false)) // checks if all relevent values have been inputted
            {
                for (int i = 0; i < Validation.Count; i++)
                {
                    Console.WriteLine(Validation[i]);
                }
                MessageBox.Show("Please Input All Relevent Values");
                return;
            }
            else
            {
                Client NewClient = new(0, TxtName.Text, TxtAddress.Text, PhoneNumber, TxtEmail.Text, ProductCatagory!);
                Client.AddClient(NewClient);
                LoadClients(); // reloads clients

                TxtName.Visible = false;
                TxtAddress.Visible = false;
                TxtPhone.Visible = false;
                TxtEmail.Visible = false;
                DdCatagory.Visible = false;
                SubmitBtn.Visible = false;
                BackBtn.Visible = false;

            }

        }

        private void DataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e) // takes edits from DataGrid and alteres the db
        {

            var row = DataGridViewClient.Rows[e.RowIndex];

            var ColumnIndex = DataGridViewClient.CurrentCell.ColumnIndex;
            var ColumnName = DataGridViewClient.Columns[ColumnIndex].Name;
            TestLbl2.Text = ColumnName.ToString();

            var ID = Convert.ToString(row.Cells["ClientID"].Value);
            TestLbl1.Text = ID;

            if (ColumnIndex != 0)
            {
                var ChangeValue = (string)row.Cells[e.ColumnIndex].Value;
                TestLbl3.Text = ChangeValue;
                Client.EditClient(ID!, ChangeValue, ColumnName);
                Client.LoadAllClients();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e) // searchign through the db using inputted values depending on selected column
        {
            string SortValue;

            if (SortBox.SelectedItem == null || string.IsNullOrEmpty(SearchBox.Text))
            {
                MessageBox.Show("Please input Relevent Values");
            }
            else
            {
                SortValue = SortBox.SelectedItem.ToString()!;

                var Clients = Client.ClientSearch(SortValue, SearchBox.Text);
                ClientBindingSource.DataSource = Clients;
                DataGridViewClient.DataSource = ClientBindingSource; // sets table to output information from new search List
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            LoadClients();
        }
    }
}
