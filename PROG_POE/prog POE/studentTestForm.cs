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
    public partial class studentTestForm : Form
    {
        SqlConnection dbConn;
        String connectionString;
        int counter;
        int questionAmount = 0;
        string correct;
        int correctly = 0;
        double percent;
        int mark;


        public studentTestForm()
        {
            InitializeComponent();
            counter = 1;
            testRadioButtonA.Checked = true;

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

            //used to count the amount of questions in the test
            try
            {
                string sql = "SELECT * FROM question";
 
                SqlCommand sqlCmd = new SqlCommand(sql, dbConn);

                dbConn.Open();

                SqlDataReader qcounter = sqlCmd.ExecuteReader();

                while (qcounter.Read())
                {
                    questionAmount++;
                }

                qcounter.Close();
                dbConn.Close();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //pulls data from database and inserts to textboxes
            populateTextBoxes();
            tesHubGroupBox.Text = "Question " + counter + " of " + questionAmount;




        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (testRadioButtonA.Checked == true)
            {
                correct = "A";
            }
            if (testRadioButtonB.Checked == true)
            {
                correct = "B";
            }
            if (testRadioButtonC.Checked == true)
            {
                correct = "C";
            }
            if (testRadioButtonD.Checked == true)
            {
                correct = "D";
            }


            try
            {
                string sql = "insert into studentAnswer (portalUser_ID, question_ID, answer) values ('" + loginForm.UserID + "','" + counter + "','" + correct + "')";

                SqlCommand sqlCmd = new SqlCommand(sql, dbConn);

                dbConn.Open();

                sqlCmd.ExecuteNonQuery();

                dbConn.Close();


            counter++;

            populateTextBoxes();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("You have already taken this test and cannot retake it.");
                    dbConn.Close();
                    this.Close();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        ////pulls data from database and inserts to textboxes
        private void populateTextBoxes()
        {
            try
            {
                dbConn.Open();
                string sql = "SELECT * FROM question WHERE question_ID = '" + counter + "'";

                SqlCommand dbCommand = new SqlCommand(sql, dbConn);

                SqlDataReader dbReader = dbCommand.ExecuteReader();
                dbReader.Read();

                testQuestionTextBox.Text = dbReader["questionText"].ToString();
                testOptionATextBox.Text = dbReader["optionA"].ToString();
                testOptionBTextBox.Text = dbReader["optionB"].ToString();
                testOptionCTextBox.Text = dbReader["optionC"].ToString();
                testOptionDTextBox.Text = dbReader["optionD"].ToString();

                dbReader.Close();
                dbConn.Close();

                tesHubGroupBox.Text = "Question " + counter + " of " + questionAmount;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("You have completed the test!");

                dbConn.Close();
                
                this.Close();
            }
        }

        //calculates students mark out of 100 upon closing of the test and saves it to database.
        private void studentTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sql = "select  studentAnswer.answer, question.correctAnswer, studentAnswer.portalUser_ID from studentAnswer inner join question on studentAnswer.question_ID = question.question_ID where studentAnswer.portalUser_ID = '"+ loginForm.UserID +"'";
            dbConn.Open();
            SqlCommand dbCommand = new SqlCommand(sql, dbConn);

            // Create the reader 
            SqlDataReader dbReader = dbCommand.ExecuteReader();

            // Use the data through the reader - one record at a time 

            while (dbReader.Read())
            {
                if (dbReader["answer"].ToString() == dbReader["correctAnswer"].ToString())
                {
                    correctly++;
                }
            }

            dbReader.Close();
            dbConn.Close();

            studentForm.Correct = correctly;
            studentForm.TotalQuestions = questionAmount;

            percent = ((Convert.ToDouble(correctly) / Convert.ToDouble(questionAmount)) * 100);
            mark = Convert.ToInt32(percent);

            try
            {
                // Concatenate the entered values from the text fields into the SQL insert statement 
                string markup = "Update portalUser SET mark = '" + mark + "' Where portalUser_ID = '" + loginForm.UserID + "'"; ;

                // Create the Command object 
                SqlCommand market = new SqlCommand(markup, dbConn);

                // Connect to the DB 
                dbConn.Open();

                // Execute the insert statement - it returns no result set and that is why ExecuteNonQuery is used 
                market.ExecuteNonQuery();

                // Remember to close the DB connection again 
                dbConn.Close();

            }
            catch (System.Exception ax)
            {
                MessageBox.Show(ax.Message, "here");
            }

        }
    }
}
