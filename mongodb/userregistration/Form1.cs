using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace userregistration
{
    public partial class Form1 : Form
    {
        // MongoDB class-level variables
        private MongoClient? _client;
        private IMongoDatabase? _database;
        private IMongoCollection<BsonDocument>? _collection;
        private string DatabaseName = "";
        private string CollectionName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectToMongoDB(string connectionString)
        {
            _client = new MongoClient(connectionString);
            DatabaseName = txtDatabaseName.Text;
            CollectionName = txtCollectionName.Text;
            _database = _client.GetDatabase(DatabaseName);
            _collection = _database.GetCollection<BsonDocument>(CollectionName);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to MongoDB using provided connection string
                ConnectToMongoDB(txtConnectionString.Text);

                var document = new BsonDocument
        {
            { "firstName", txtName.Text },
            { "middleName", txtMName.Text },
            { "lastName", txtLName.Text },
            { "birthday", dateBdayPicker.Value.ToString("yyyy-MM-dd") },
            { "phoneNumber", intPhone.Text },
            { "email", txtEmail.Text },
            { "address", txtAdd.Text }
        };

                if (_collection != null)
                {
                    _collection.InsertOne(document);
                    MessageBox.Show("Data inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to connect to MongoDB.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // Clearing all text boxes and the date picker
            txtName.Clear();
            txtMName.Clear();
            txtLName.Clear();
            dateBdayPicker.Value = DateTime.Now;
            intPhone.Clear();
            txtEmail.Clear();
            txtAdd.Clear();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}