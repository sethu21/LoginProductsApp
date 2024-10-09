using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginProductsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Input Validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both Username and Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if fields are empty
            }
            // Connection string to your database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Welcome\Vs_code\LoginProductsApp\LoginProductsApp\UserProductsDatabase.mdf;Integrated Security=True";

            // Query to check if user exists
            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Login success - Notify user and proceed to next form (UserProductsForm)
                        //MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //reader.Close();
                        // Open UserProductsForm (not created yet)
                        //UserProductsForm userProductsForm = new UserProductsForm();
                        //userProductsForm.Show();
                        //this.Hide(); // Hide the login form
                        // Login success - Notify user
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reader.Close();
                        // For now, just show a message instead of opening UserProductsForm
                        MessageBox.Show("This is where UserProductsForm would open.");
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        }
    }
}
