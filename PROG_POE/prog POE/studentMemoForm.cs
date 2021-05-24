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
    public partial class studentMemoForm : Form
    {
        SqlConnection dbConn;
        String connectionString;
        double percent;
        int questionAmount = 0;
        int counter = 1;
        int correctly = 0;

        public studentMemoForm()
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

            calculateAnsweredQuestions();
            calculatePercent();
            populateTextBoxes();
            questionCountLabel.Text = "Question " + counter + " of " + questionAmount;
            greetingLabel.Text = "You answered " + correctly + " Questions of " + questionAmount + " questions correctly \ngiving you a total percentage mark of: " + percent + "%";

        }

        public void calculatePercent()
        {
            try
            {
                string sql = "select  studentAnswer.answer, question.correctAnswer, studentAnswer.portalUser_ID from studentAnswer inner join question on studentAnswer.question_ID = question.question_ID where studentAnswer.portalUser_ID = '" + loginForm.UserID + "'";
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
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void calculateAnsweredQuestions()
        {
            //used to count the amount of questions in the test
            try
            {
                string sql = "SELECT * FROM studentAnswer";

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
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            counter++;
            populateTextBoxes();
        }

        ////pulls data from database and inserts to textboxes
        private void populateTextBoxes()
        {
            try
            {
                dbConn.Open();
                string sql = "select question.questionText, question.question_ID, studentAnswer.answer, question.correctAnswer, studentAnswer.portalUser_ID, question.optionA, question.optionB, question.optionC, question.optionD from studentAnswer inner join question on studentAnswer.question_ID = question.question_ID where studentAnswer.portalUser_ID = '" + loginForm.UserID + "' AND question.question_ID = '" + counter + "'";

                SqlCommand dbCommand = new SqlCommand(sql, dbConn);

                SqlDataReader dbReader = dbCommand.ExecuteReader();
                dbReader.Read();

                yourChar.Text = dbReader["answer"].ToString();
                correctChar.Text = dbReader["correctAnswer"].ToString();
                questionTextBox.Text = dbReader["questionText"].ToString();

                if(dbReader["answer"].ToString() == "A")
                {
                    yourAnswerTextBox.Text = dbReader["optionA"].ToString();
                }
                if (dbReader["answer"].ToString() == "B")
                {
                    yourAnswerTextBox.Text = dbReader["optionB"].ToString();
                }
                if (dbReader["answer"].ToString() == "C")
                {
                    yourAnswerTextBox.Text = dbReader["optionC"].ToString();
                }
                if (dbReader["answer"].ToString() == "D")
                {
                    yourAnswerTextBox.Text = dbReader["optionD"].ToString();
                }


                if(dbReader["correctAnswer"].ToString() == "A")
                {
                    correctAnswerTextbox.Text = dbReader["optionA"].ToString();
                }
                if (dbReader["correctAnswer"].ToString() == "B")
                {
                    correctAnswerTextbox.Text = dbReader["optionB"].ToString();
                }
                if (dbReader["correctAnswer"].ToString() == "C")
                {
                    correctAnswerTextbox.Text = dbReader["optionC"].ToString();

                }
                if (dbReader["correctAnswer"].ToString() == "D")
                {
                    correctAnswerTextbox.Text = dbReader["optionD"].ToString();
                }

                questionCountLabel.Text = "Question " + counter + " of " + questionAmount;

                dbReader.Close();
                dbConn.Close();
            }
            catch (System.Exception ax)
            {
                MessageBox.Show("You have completely read the memo");

                dbConn.Close();

                this.Close();
            }
        }
    }
}
