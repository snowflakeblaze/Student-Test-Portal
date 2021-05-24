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

//textboxes used to input new data are set to 30 max length to ensure no conflict arises from database varchar limit
namespace prog_POE
{
    public partial class changePasswordForm : Form
    {
        SqlConnection dbConn;
        String connectionString;

        public changePasswordForm()
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

        private void confirmChangeButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmChangeButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbConn.Open();
                string sql = "SELECT * FROM portalUser WHERE portalUser_ID='" + loginForm.UserID + "'";
                SqlCommand dbCommand = new SqlCommand(sql, dbConn);

                SqlDataReader dbReader = dbCommand.ExecuteReader();

                if (dbReader.HasRows)
                {

                    while (dbReader.Read())
                    {
                        if (currentPasswordTextBox.Text == dbReader["portalPassword"].ToString() && newPasswordTextBox.Text == confirmPassTextBox.Text)
                        {
                            dbConn.Close();
                            string markup = "Update portalUser SET portalPassword = '" + newPasswordTextBox.Text + "' Where portalUser_ID = " + loginForm.UserID + ""; ;

                            SqlCommand market = new SqlCommand(markup, dbConn);

                            dbConn.Open();
                            market.ExecuteNonQuery();

                            MessageBox.Show("password has been updated");

                            teacherForm teaherPortal = new teacherForm();
                            this.Hide();
                            teaherPortal.ShowDialog();
                            this.Show();

                            break;
                        }
                        if (currentPasswordTextBox.Text == dbReader["portalPassword"].ToString() && newPasswordTextBox.Text != confirmPassTextBox.Text)
                        {
                            MessageBox.Show("NEW PASSWORDS DO NOT MATCH");
                            this.Show();

                            

                            break;
                        }
                        if (currentPasswordTextBox.Text != dbReader["portalPassword"].ToString())
                        {

                            MessageBox.Show("incorrect password");
                           
                            break;
                        }
                    }

                }
                dbReader.Close();
                dbConn.Close();
                
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                dbConn.Close();

            }
        }
    }
}
