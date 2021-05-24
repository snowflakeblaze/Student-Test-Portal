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
    public partial class studentForm : Form
    {
        SqlConnection dbConn;
        String connectionString;
        public static int correct;
        public static int totalQuestions;

        public static int Correct
        {
            get
            {
                return correct;
            }

            set
            {
                correct = value;
            }
        }

        public static int TotalQuestions
        {
            get
            {
                return totalQuestions;
            }

            set
            {
                totalQuestions = value;
            }
        }

        public studentForm()
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

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            changePasswordForm change = new changePasswordForm();
            this.Hide();
            change.ShowDialog();
            this.Show();
        }

        private void takeTestButton_Click(object sender, EventArgs e)
        {
            dbConn.Open();
            string sql = "SELECT * FROM question";
            SqlCommand dbCommand = new SqlCommand(sql, dbConn);

            SqlDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows)
            {
                studentTestForm takeTest = new studentTestForm();
                this.Hide();
                takeTest.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Your lecturer has not created a test for you to take yet, please wait for one to be available.");
            }
            dbConn.Close();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewMemoButton_Click(object sender, EventArgs e)
        {
            dbConn.Open();
            string sql = "SELECT * FROM studentAnswer where portalUser_ID = '" + loginForm.UserID + "'";
            SqlCommand dbCommand = new SqlCommand(sql, dbConn);

            SqlDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows)
            {
                studentMemoForm viewMemo = new studentMemoForm();
                this.Hide();
                viewMemo.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You have not completed the test yet and can therefore not view the memo. please complete the test if there is one available.");
            }
            dbConn.Close();
        }
    }
}
