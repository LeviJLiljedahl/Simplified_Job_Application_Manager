//Author: Levi Liljedahl
//Date: 04/04/2024
//Purpose: Allow users to keep track of the jobs they apply for and have access to all the data about an application in one spot.

using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;

namespace Simplified_JobApplicationManager
{
    public partial class Simple_JAM_Form : Form
    {
        public Simple_JAM_Form()
        {
            InitializeComponent();
        }

        //Class level object - binding list
        private BindingList<Simplified_JobApplicationManager.JobApplication> jobApplicationsList = new BindingList<Simplified_JobApplicationManager.JobApplication>();

        //Class level Object Application
        private Simplified_JobApplicationManager.JobApplication selectedApplication = new Simplified_JobApplicationManager.JobApplication();

        int applicationLastNumber = 0;

        private void addButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            DateTime valueDAT;

            JobApplication newApplication = new JobApplication();

            if ((cNameTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Company Name TextBox can not be blank.");
                cNameTextBox.Focus();
                return;
            }
            else if ((cLocatedTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Company Located TextBox can not be blank.");
                cLocatedTextBox.Focus();
                return;
            }
            else if ((jTitleTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Job Title TextBox can not be blank.");
                jTitleTextBox.Focus();
                return;
            }
            else if ((jLocationTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Job Location TextBox can not be blank.");
                jLocationTextBox.Focus();
                return;
            }
            else if ((jPayRateTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Pay Rate TextBox can not be blank. If not listed, enter 'Not Listed'.");
                jPayRateTextBox.Focus();
                return;
            }
            else if (DateTime.TryParse(aAppliedOnTextBox.Text, out valueDAT) == false)
            {
                Msg("Date Applied On TextBox can not be blank and must be a valid date (dd/mm/yyyy).");
                aAppliedOnTextBox.Focus();
                return;
            }
            else if ((aLocationTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Applied Location TextBox can not be blank.");
                aLocationTextBox.Focus();
                return;
            }
            else if ((aStatusComboBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Application Status ComboBox can not be blank.");
                aStatusComboBox.Focus();
                return;
            }
            else if ((eSourceDocTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Source Document TextBox can not be blank.");
                eSourceDocTextBox.Focus();
                return;
            }
            else if ((eNotesTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Notes TextBox can not be blank. If you have no notes at this time enter 'None'.");
                eNotesTextBox.Focus();
                return;
            }
            else if ((eInterestComboBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Interest Level ComboBox can not be blank.");
                eInterestComboBox.Focus();
                return;
            }
            else if ((eGoodFitComboBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Good Fit/Chances ComboBox can not be blank.");
                eGoodFitComboBox.Focus();
                return;
            }
            else
            {
                // GOOD/Validated CODE GOES HERE
                //Objects and variables
                int returnDays = 0;

                //Assign Customer Properties
                if (cApplicationIDTextBox.Text == string.Empty)
                {
                    //If new record increment application Last number
                    applicationLastNumber++;
                    newApplication.ApplicationID = applicationLastNumber.ToString();
                }
                else
                {
                    newApplication.ApplicationID = cApplicationIDTextBox.Text;
                }

                // Set user entered data to objects
                newApplication.CompanyName = cNameTextBox.Text;
                newApplication.CompanyLocated = cLocatedTextBox.Text;
                newApplication.JobTitle = jTitleTextBox.Text;
                newApplication.JobLocation = jLocationTextBox.Text;
                newApplication.PayRate = jPayRateTextBox.Text;
                newApplication.DateApplied = valueDAT;
                newApplication.AppliedLocation = aLocationTextBox.Text;
                newApplication.Status = aStatusComboBox.Text;
                newApplication.SourceDocument = eSourceDocTextBox.Text;
                newApplication.Notes = eNotesTextBox.Text;
                newApplication.LevelOfInterest = eInterestComboBox.Text;
                newApplication.GoodFit = eGoodFitComboBox.Text;

                // Set calculated date to Days since in object
                newApplication.Calculate_DaysSince(newApplication.DateApplied, ref returnDays);
                newApplication.DaysSince = returnDays;


                //set selected object and add data to list
                selectedApplication = newApplication;
                jobApplicationsList.Add(newApplication);
                applicationsListBox.SelectedItem = selectedApplication;

                InsertApplication();

                ClearAllTextBoxes();

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            DateTime valueDAT;

            JobApplication newApplication = new JobApplication();

            if ((cNameTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Company Name TextBox can not be blank.");
                cNameTextBox.Focus();
                return;
            }
            else if ((cLocatedTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Company Located TextBox can not be blank.");
                cLocatedTextBox.Focus();
                return;
            }
            else if ((jTitleTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Job Title TextBox can not be blank.");
                jTitleTextBox.Focus();
                return;
            }
            else if ((jLocationTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Job Location TextBox can not be blank.");
                jLocationTextBox.Focus();
                return;
            }
            else if ((jPayRateTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Pay Rate TextBox can not be blank. If not listed, enter 'Not Listed'.");
                jPayRateTextBox.Focus();
                return;
            }
            else if (DateTime.TryParse(aAppliedOnTextBox.Text, out valueDAT) == false)
            {
                Msg("Date Applied On TextBox can not be blank and must be a valid date (dd/mm/yyyy).");
                aAppliedOnTextBox.Focus();
                return;
            }
            else if ((aLocationTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Applied Location TextBox can not be blank.");
                aLocationTextBox.Focus();
                return;
            }
            else if ((aStatusComboBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Application Status ComboBox can not be blank.");
                aStatusComboBox.Focus();
                return;
            }
            else if ((eSourceDocTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Source Document TextBox can not be blank.");
                eSourceDocTextBox.Focus();
                return;
            }
            else if ((eNotesTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Notes TextBox can not be blank. If you have no notes at this time enter 'None'.");
                eNotesTextBox.Focus();
                return;
            }
            else if ((eInterestComboBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Interest Level ComboBox can not be blank.");
                eInterestComboBox.Focus();
                return;
            }
            else if ((eGoodFitComboBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Good Fit/Chances ComboBox can not be blank.");
                eGoodFitComboBox.Focus();
                return;
            }
            else
            {

                // Set calculated date to Days since in object
                DateTime newDate = DateTime.Parse(this.aAppliedOnTextBox.Text);
                int returnDays = 0;
                selectedApplication.Calculate_DaysSince(newDate, ref returnDays);
                selectedApplication.DaysSince = returnDays;

                UpdateApplication(returnDays);
                jobApplicationsList.Clear();
                ReloadApplications();
                ClearAllTextBoxes();
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteApplication();
            jobApplicationsList.Remove(selectedApplication);
            jobApplicationsList.Clear();
            ReloadApplications();
            ClearAllTextBoxes();
        }

        private void applicationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (applicationsListBox.SelectedItem != null)
            {
                selectedApplication = (JobApplication)(applicationsListBox.SelectedItem);
            }

            DisplayAll();
        }

        private void ClearAllTextBoxes()
        {
            // Clear company info textboxes
            this.cApplicationIDTextBox.Text = string.Empty;
            this.cNameTextBox.Text = string.Empty;
            this.cLocatedTextBox.Text = string.Empty;

            // Clear job info textboxes
            this.jTitleTextBox.Text = string.Empty;
            this.jLocationTextBox.Text = string.Empty;
            this.jPayRateTextBox.Text = string.Empty;

            //clear application info textboxes
            this.aAppliedOnTextBox.Text = string.Empty;
            this.aDaysSinceTextBox.Text = string.Empty;
            this.aLocationTextBox.Text = string.Empty;
            this.aStatusComboBox.Text = string.Empty;

            //clear extra information textboxes
            this.eSourceDocTextBox.Text = string.Empty;
            this.eNotesTextBox.Text = string.Empty;
            this.eInterestComboBox.Text = string.Empty;
            this.eGoodFitComboBox.Text = string.Empty;

            //reset colors
            aDaysSinceTextBox.BackColor = Color.MediumAquamarine;
            aStatusComboBox.BackColor = Color.MintCream;

            //Refocus cursor
            cNameTextBox.Focus();

            //Make days label invisible
            this.daysLabel.Visible = false;

        }

        public void Msg(string msg)
        {
            MessageBox.Show(msg, "Job Application Manager", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void Simple_JAM_Form_Load(object sender, EventArgs e)
        {
            applicationsListBox.DataSource = jobApplicationsList;

            //Load Applications from database
            ReloadApplications();

            //Set cursor to insert record
            cNameTextBox.Focus();

            //make days label invisible
            this.daysLabel.Visible = false;

        }

        private void DisplayAll()
        {

            if (selectedApplication != null)
            {
                // Populate company info textboxes
                this.cApplicationIDTextBox.Text = selectedApplication.ApplicationID;
                this.cNameTextBox.Text = selectedApplication.CompanyName;
                this.cLocatedTextBox.Text = selectedApplication.CompanyLocated;

                // Populate job info textboxes
                this.jTitleTextBox.Text = selectedApplication.JobTitle;
                this.jLocationTextBox.Text = selectedApplication.JobLocation;
                this.jPayRateTextBox.Text = selectedApplication.PayRate;

                //Populate application info textboxes
                this.aAppliedOnTextBox.Text = selectedApplication.DateApplied.ToString();
                this.aLocationTextBox.Text = selectedApplication.AppliedLocation;
                this.aStatusComboBox.Text = selectedApplication.Status;

                //Populate extra information textboxes
                this.eSourceDocTextBox.Text = selectedApplication.SourceDocument;
                this.eNotesTextBox.Text = selectedApplication.Notes;
                this.eInterestComboBox.Text = selectedApplication.LevelOfInterest;
                this.eGoodFitComboBox.Text = selectedApplication.GoodFit;

                //Calculate and populate days since text box
                this.aDaysSinceTextBox.Text = selectedApplication.DaysSince.ToString();

                //Modify Colors based on values
                DaysSinceColor(selectedApplication.DaysSince);
                StatusColor();

                //Display days label
                this.daysLabel.Visible = true;

            }
        }

        private void DaysSinceColor(int daysInt)
        {
            // Modify the color of the days since box based on length of days since

            if (daysInt < 7)
            {
                aDaysSinceTextBox.BackColor = Color.MediumSpringGreen;
                daysLabel.BackColor = Color.MediumSpringGreen;
            }
            else if (daysInt > 7 && daysInt < 14)
            {
                aDaysSinceTextBox.BackColor = Color.Khaki;
                daysLabel.BackColor = Color.Khaki;
            }
            else if (daysInt > 14)
            {
                aDaysSinceTextBox.BackColor = Color.PaleVioletRed;
                daysLabel.BackColor = Color.PaleVioletRed;
            }
            else
            {
                aDaysSinceTextBox.BackColor = Color.MediumAquamarine;
                daysLabel.BackColor = Color.MediumSpringGreen;
            }
        }

        private void StatusColor()
        {
            // Modify the color of the status box based on option selected
            //Red for rejected, green for hired, the rest are yellow for pending

            if (aStatusComboBox.Text == "Hired")
            {
                aStatusComboBox.BackColor = Color.MediumSpringGreen;
            }
            else if (aStatusComboBox.Text == "Rejected")
            {
                aStatusComboBox.BackColor = Color.PaleVioletRed;
            }
            else
            {
                aStatusComboBox.BackColor = Color.Khaki;
            }
        }

        private SqlConnection OpenDBConnection()
        {
            //This gives the full path into the bin/debug folder.
            string path = Application.StartupPath;
            int pathLength = path.Length;

            //This strips off the bin/debug folder to point to the project folder
            path = path.Substring(0, pathLength - 25);

            //Create a connection string
            string connection = @"Server=(LocalDB)\MSSQLLOcalDB;Integrated Security=true;AttachDbFileName=" + path + "JobApplications.mdf";

            //Create a Connection Object to the database 
            var dbConnection = new System.Data.SqlClient.SqlConnection(connection);

            //Open Database
            dbConnection.Open();

            return dbConnection;

        }
        private void ReloadApplications()
        {
            //Clear Listbox
            applicationsListBox.ClearSelected();

            //Open Database
            var connection = OpenDBConnection();

            //Create a command object
            var selectCommand = new SqlCommand("SELECT * FROM JobApplication_Tbl;", connection);

            //Execute Command into a DataReader
            var applicationReader = selectCommand.ExecuteReader();

            if (applicationReader.HasRows)
            {
                while (applicationReader.Read())
                {
                    var storedJobApplicationObject = new Simplified_JobApplicationManager.JobApplication(applicationReader["Application_ID"].ToString());

                    storedJobApplicationObject.CompanyName = applicationReader["Company_Name"].ToString();
                    storedJobApplicationObject.CompanyLocated = applicationReader["Company_Located"].ToString();
                    storedJobApplicationObject.JobTitle = applicationReader["Job_Title"].ToString();
                    storedJobApplicationObject.JobLocation = applicationReader["Job_Location"].ToString();
                    storedJobApplicationObject.PayRate = applicationReader["Pay_Rate"].ToString();
                    storedJobApplicationObject.DateApplied = DateTime.Parse(applicationReader["Date_Applied"].ToString());
                    storedJobApplicationObject.AppliedLocation = applicationReader["Applied_Location"].ToString();
                    storedJobApplicationObject.Status = applicationReader["Status"].ToString();
                    storedJobApplicationObject.SourceDocument = applicationReader["Source_Document"].ToString();
                    storedJobApplicationObject.Notes = applicationReader["Notes"].ToString();
                    storedJobApplicationObject.LevelOfInterest = applicationReader["Level_Of_Interest"].ToString();
                    storedJobApplicationObject.GoodFit = applicationReader["Good_Fit"].ToString();
                    storedJobApplicationObject.DaysSince = int.Parse(applicationReader["Days_Since"].ToString());

                    //Update applicationLastNumber
                    if (int.Parse(storedJobApplicationObject.ApplicationID) > applicationLastNumber)
                    {
                        applicationLastNumber = int.Parse(storedJobApplicationObject.ApplicationID);
                    }

                    jobApplicationsList.Add(storedJobApplicationObject);

                }
            }

            //close DB Connection and dispose
            connection.Close();
            connection.Dispose();
        }

        private void InsertApplication()
        {
            // Open database
            var connection = OpenDBConnection();

            //Create SQL String
            string SQL = "INSERT INTO JobApplication_Tbl(Company_Name, Company_Located, Job_Title, Job_Location, " +
                        "Pay_Rate, Date_Applied, Applied_Location, Status, Source_Document, Notes, Level_Of_Interest, " +
                        "Good_Fit, Days_Since) values (@CompanyName, @CompanyLocated, @JobTitle, @JobLocation, @PayRate, " +
                        "@DateApplied, @AppliedLocation, @Status, @SourceDocument, @Notes, @LevelOfInterest, @GoodFit, " +
                        "@DaysSince);";

            //Create Command
            var insertCommand = new SqlCommand(SQL, connection);

            insertCommand.Parameters.AddWithValue("CompanyName", jobApplicationsList.Last().CompanyName);
            insertCommand.Parameters.AddWithValue("CompanyLocated", jobApplicationsList.Last().CompanyLocated);
            insertCommand.Parameters.AddWithValue("JobTitle", jobApplicationsList.Last().JobTitle);
            insertCommand.Parameters.AddWithValue("JobLocation", jobApplicationsList.Last().JobLocation);
            insertCommand.Parameters.AddWithValue("PayRate", jobApplicationsList.Last().PayRate);
            insertCommand.Parameters.AddWithValue("DateApplied", jobApplicationsList.Last().DateApplied);
            insertCommand.Parameters.AddWithValue("AppliedLocation", jobApplicationsList.Last().AppliedLocation);
            insertCommand.Parameters.AddWithValue("Status", jobApplicationsList.Last().Status);
            insertCommand.Parameters.AddWithValue("SourceDocument", jobApplicationsList.Last().SourceDocument);
            insertCommand.Parameters.AddWithValue("Notes", jobApplicationsList.Last().Notes);
            insertCommand.Parameters.AddWithValue("LevelOfInterest", jobApplicationsList.Last().LevelOfInterest);
            insertCommand.Parameters.AddWithValue("GoodFit", jobApplicationsList.Last().GoodFit);
            insertCommand.Parameters.AddWithValue("DaysSince", jobApplicationsList.Last().DaysSince);

            int intRowsAffected = insertCommand.ExecuteNonQuery();

            if (intRowsAffected == 1)
            {
                MessageBox.Show(jobApplicationsList.Last().ApplicationID + " - " +
                    jobApplicationsList.Last().JobTitle + " @ " + jobApplicationsList.Last().CompanyName +
                    " was inserted");
            }
            else
            {
                MessageBox.Show("The insert failed");
            }

        }


        private void DeleteApplication()
        {
            var YesNo = MessageBox.Show("Are you sure you want to delete this record?", "Job Application Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            MessageBox.Show(YesNo.ToString());

            if (YesNo.ToString() == "Yes")
            {
                //Open Database
                var dbConnection = OpenDBConnection();

                //Create SQL String
                string SQL = "DELETE FROM JobApplication_Tbl WHERE Application_ID = '" + selectedApplication.ApplicationID + "';";

                //Create Command
                var deleteCommand = new SqlCommand(SQL, dbConnection);

                var intRowsAffected = deleteCommand.ExecuteNonQuery();

                if (intRowsAffected == 1)
                {
                    MessageBox.Show("Record was deleted.");
                }

            } else
            {
                MessageBox.Show("Record was NOT deleted.");
            }


        }

        private void UpdateApplication(int returnDays)
        {

            //Open Database
            var dbConnection = OpenDBConnection();

            //Create SQL String
            string SQL = "UPDATE JobApplication_Tbl set Company_Name='" + cNameTextBox.Text + "', Company_Located = '" +
                         cLocatedTextBox.Text + "', Job_Title = '" + jTitleTextBox.Text + "', Job_Location = '" +
                         jLocationTextBox.Text + "', Pay_Rate = '" + jPayRateTextBox.Text + "', Date_Applied = '" +
                         aAppliedOnTextBox.Text + "', Applied_Location = '" + aLocationTextBox.Text + "', Status = '" +
                         aStatusComboBox.Text + "', Source_Document = '" + eSourceDocTextBox.Text + "', Notes = '" +
                         eNotesTextBox.Text + "', Level_Of_Interest = '" + eInterestComboBox.Text + "', Good_Fit = '" +
                         eGoodFitComboBox.Text + "', Days_Since = '" + returnDays + "' WHERE Application_ID = '" +
                         cApplicationIDTextBox.Text + "';";

            //Create Command
            var updateCommand = new SqlCommand(SQL, dbConnection);

            int intRowsAffected = updateCommand.ExecuteNonQuery();

            if (intRowsAffected == 1)
            {
                MessageBox.Show("Application #" + selectedApplication.ApplicationID + " was updated.");
            }
        }
    }
}
