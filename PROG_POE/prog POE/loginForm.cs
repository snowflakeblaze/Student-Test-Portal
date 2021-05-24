using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog_POE
{
    public partial class loginForm : Form
    {
        SqlConnection dbConn;
        String connectionString;
        public static string userID;

        //enables passing of users ID from database to other forms enabling simplified SQL queries
        public static string UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public loginForm()
        {
            InitializeComponent();

            try
            {
                // Retrieve connection string from settings 
                connectionString = Properties.Settings.Default.ConnectionString;

                // Create the connection object once - do not connect 
                dbConn = new SqlConnection(connectionString);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //enables enter key to click login button
        // The keypressed method uses the KeyChar property to check 
        // whether the ENTER key is pressed. 

        // If the ENTER key is pressed, the Handled property is set to true, 
        // to indicate the event is handled.
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            try
            {
                dbConn.Open();
                string sql = "SELECT * FROM portalUser WHERE username='" + usernameTextBox.Text + "'";
                SqlCommand dbCommand = new SqlCommand(sql, dbConn);

                SqlDataReader dbReader = dbCommand.ExecuteReader();

                if (dbReader.HasRows)
                {

                    while (dbReader.Read())
                    {
                        if (usernameTextBox.Text == dbReader["username"].ToString() && passwordTextBox.Text != dbReader["portalPassword"].ToString())
                        {
                            MessageBox.Show("incorrect login details");

                        }
                        if (dbReader["username"].ToString() == usernameTextBox.Text && dbReader["portalPassword"].ToString() == passwordTextBox.Text && dbReader["accountType"].ToString() == "1")
                        {
                            UserID = dbReader["portalUser_ID"].ToString();
                            MessageBox.Show("Welcome " + dbReader["firstName"].ToString());
                            teacherForm teacher = new teacherForm();
                            this.Hide();
                            passwordTextBox.Text = "";
                            usernameTextBox.Text = "";
                            teacher.ShowDialog();
                            this.Show();
                            
                            break;
                        }
                        if (dbReader["username"].ToString() == usernameTextBox.Text && dbReader["portalPassword"].ToString() == passwordTextBox.Text && dbReader["accountType"].ToString() == "0")
                        {
                            UserID = dbReader["portalUser_ID"].ToString();
                            MessageBox.Show("Welcome " + dbReader["firstName"].ToString());
                            studentForm student = new studentForm();
                            this.Hide();
                            passwordTextBox.Text = "";
                            usernameTextBox.Text = "";
                            student.ShowDialog();
                            this.Show();
                            
                            break;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("incorrect login details");
                }
                dbConn.Close();
                dbReader.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                dbConn.Close();
  
            }
        }
    }
}
