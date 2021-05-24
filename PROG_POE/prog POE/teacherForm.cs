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
// All textboxes max length has been set to 30 or 500 respectively to ensure that there are no conflicts with database varchar limit.
namespace prog_POE
{
    public partial class teacherForm : Form
    {
        SqlConnection dbConn;
        String connectionString;
        string correct;
        int counter;

        public teacherForm()
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

            createTestGroupBox.Hide();
            accountTypeComboBox.SelectedIndex = 0;
            radioButtonA.Checked = true;
            counter = 0;

            // Set up the database connection 
            dbConn.Open();

            // Set up the SQL command 
            string sql = "select * from portalUser where mark is not NULL";
            SqlCommand dbCommand = new SqlCommand(sql, dbConn);

            // Create the reader 
            SqlDataReader dbReader = dbCommand.ExecuteReader();

            // Use the data through the reader - one record at a time 
            viewMarksTextBox.Clear();
            viewMarksTextBox.AppendText(String.Format("{0,-20}{1,-20}{2,-20}", "Firstname", "Surname", "Mark"));
            viewMarksTextBox.AppendText("\r\n=============== =============== ===============\r\n");

            while (dbReader.Read())
            {
                viewMarksTextBox.AppendText(String.Format("{0,-20}{1,-20}{2,-20}\r\n", dbReader["firstname"], dbReader["lastname"], dbReader["mark"]));
            }

            // Close the reader 
            dbReader.Close();

            // Close the DB connection 
            dbConn.Close();

        }

        private void createTestButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmCreation = MessageBox.Show("Are you sure you would like to create a new test hereby deleting the current test and all student answers and results?", "Confirm New Test", MessageBoxButtons.YesNo);

            if (confirmCreation == DialogResult.Yes)
            {
                dbConn.Open();
                string sql = "delete FROM studentAnswer";
                SqlCommand sqlCmd = new SqlCommand(sql, dbConn);
                sqlCmd.ExecuteNonQuery();
                dbConn.Close();
                dbConn.Open();
                sql = "delete FROM question";
                SqlCommand sqlCmd2 = new SqlCommand(sql, dbConn);
                sqlCmd2.ExecuteNonQuery();
                dbConn.Close();

                MessageBox.Show("Test creation has begun all relevant data has been removed from the database to make room for the new test.");
                createTestButton.Hide();
                confirmationLabel.Hide();
                createTestGroupBox.Show();
            }
            if (confirmCreation == DialogResult.No)
            {
                MessageBox.Show("Test creation has been cancelled all relevant data is still available.");
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && usernameTextBox.Text != "" && surnameTextBox.Text != "")
            {
                try
                {
                    // Concatenate the entered values from the text fields into the SQL insert statement 
                    string sql = "insert into portalUser (username, portalPassword, firstName, lastName, accountType) values ('" +
                    usernameTextBox.Text + "','Password1','" + nameTextBox.Text + "','" + surnameTextBox.Text + "','" + accountTypeComboBox.SelectedIndex + "')";

                    // Create the Command object 
                    SqlCommand sqlCmd = new SqlCommand(sql, dbConn);

                    // Connect to the DB 
                    dbConn.Open();

                    // Execute the insert statement - it returns no result set and that is why ExecuteNonQuery is used 
                    sqlCmd.ExecuteNonQuery();

                    // Remember to close the DB connection again 
                    dbConn.Close();

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("user " + nameTextBox.Text + " " + surnameTextBox.Text + " has been registered with the username " + usernameTextBox.Text);
                usernameTextBox.Text = "";
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
                accountTypeComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Please ensure that all fields are filled in before attempting to register a new user");
            }
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            counter++;

            if(radioButtonA.Checked == true)
            {
                correct = "A";
            }
            if (radioButtonB.Checked == true)
            {
                correct = "B";
            }
            if (radioButtonC.Checked == true)
            {
                correct = "C";
            }
            if (radioButtonD.Checked == true)
            {
                correct = "D";
            }

            if(questionTextBox.Text != "" && optionATextBox.Text != "" && optionBTextBox.Text != "" && optionCTextBox.Text != "" && optionDTextBox.Text != "")
            {
                try
                {
                    // Concatenate the entered values from the text fields into the SQL insert statement 
                    string sql = "insert into question (questionText, optionA, optionB, optionC, optionD, correctAnswer, question_ID) values ('" +
                    questionTextBox.Text + "','" + optionATextBox.Text + "','" + optionBTextBox.Text + "','" + optionCTextBox.Text + "','" + optionDTextBox.Text + "','" + correct + "','" + counter + "')";

                    // Create the Command object 
                    SqlCommand sqlCmd = new SqlCommand(sql, dbConn);

                    // Connect to the DB 
                    dbConn.Open();

                    // Execute the insert statement - it returns no result set and that is why ExecuteNonQuery is used 
                    sqlCmd.ExecuteNonQuery();

                    // Remember to close the DB connection again 
                    dbConn.Close();


                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Your question was successfully added to the test. Click finalise to stop the test creation process and save all progress.");
                questionTextBox.Text = "";
                optionATextBox.Text = "";
                optionBTextBox.Text = "";
                optionCTextBox.Text = "";
                optionDTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please ensure that all fields are filled in.");
            }
                
        }

        private void finishCreationButton_Click(object sender, EventArgs e)
        {
            createTestGroupBox.Hide();
            createTestButton.Show();
            confirmationLabel.Show();
            counter = 0;
            MessageBox.Show("Your test has been successfully saved.");
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            changePasswordForm change = new changePasswordForm();
            this.Hide();
            change.ShowDialog();
            this.Show();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
