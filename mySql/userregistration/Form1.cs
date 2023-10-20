using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace userregistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=EDO\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO [dbo].[user]
                    ([firstName]
                    , [middleName]
                    , [lastName]
                    , [birthday]
                    , [phoneNumber]
                    , [email]
                    , [address])
                    VALUES
                    (@firstName, @middleName, @lastName, @birthday, @phoneNumber, @email, @address)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@firstName", txtName.Text);
                        cmd.Parameters.AddWithValue("@middleName", txtMName.Text);
                        cmd.Parameters.AddWithValue("@lastName", txtLName.Text);
                        cmd.Parameters.AddWithValue("@birthday", dateBdayPicker.Value); // No need to parse/format
                        cmd.Parameters.AddWithValue("@phoneNumber", intPhone.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@address", txtAdd.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Data insertion failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}