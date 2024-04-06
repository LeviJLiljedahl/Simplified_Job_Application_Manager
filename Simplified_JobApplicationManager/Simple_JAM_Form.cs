//Author: Levi Liljedahl
//Date: 04/04/2024
//Purpose: Allow users to keep track of the jobs they apply for and have access to all the data about an application in one spot.

using System;
using System.ComponentModel;

namespace Simplified_JobApplicationManager
{
    public partial class Simple_JAM_Form : Form
    {
        public Simple_JAM_Form()
        {
            InitializeComponent();
        }

        //Class level object - binding list
        private BindingList<Simplified_JobApplicationManager.JobApplication> jobApplications = new BindingList<Simplified_JobApplicationManager.JobApplication>();

        //Class level Object Application
        private Simplified_JobApplicationManager.JobApplication jobApplicationObject = new Simplified_JobApplicationManager.JobApplication();

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
                // GOOD CODE GOES HERE
                //Objects and variables
                var applicationYears = default(int);

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

                //set selected object and add data to list
                jobApplicationObject = newApplication;
                jobApplications.Add(newApplication);
                applicationsListBox.SelectedItem = jobApplicationObject;

                ClearAllTextBoxes();


            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void applicationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        public void Msg(string msg)
        {
            MessageBox.Show(msg, "Job Application Manager", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void Simple_JAM_Form_Load(object sender, EventArgs e)
        {
            applicationsListBox.DataSource = jobApplications;
        }

        private void DisplayAll()
        {
            // Populate company info textboxes
            this.cApplicationIDTextBox.Text = jobApplicationObject.ApplicationID;
            this.cNameTextBox.Text = jobApplicationObject.CompanyName;
            this.cLocatedTextBox.Text = jobApplicationObject.CompanyLocated;

            // Populate job info textboxes
            this.jTitleTextBox.Text = jobApplicationObject.JobTitle;
            this.jLocationTextBox.Text = jobApplicationObject.JobLocation;
            this.jPayRateTextBox.Text = jobApplicationObject.PayRate;

            //Populate application info textboxes
            this.aAppliedOnTextBox.Text = jobApplicationObject.DateApplied.ToString();
            this.aLocationTextBox.Text = jobApplicationObject.AppliedLocation;
            this.aStatusComboBox.Text = jobApplicationObject.Status;

            //Populate extra information textboxes
            this.eSourceDocTextBox.Text = jobApplicationObject.SourceDocument;
            this.eNotesTextBox.Text = jobApplicationObject.Notes;
            this.eInterestComboBox.Text = jobApplicationObject.LevelOfInterest;
            this.eGoodFitComboBox.Text = jobApplicationObject.GoodFit;

            //Calculate and populate days since text box
            TimeSpan days = new TimeSpan();
            int daysInt = 0;
            jobApplicationObject.Calculate_DaysSince(jobApplicationObject.DateApplied, ref days);
            daysInt = days.Days;
            this.aDaysSinceTextBox.Text = daysInt.ToString() + " days";

        }

        public void DaysSinceColor()
        {
            // Modify the color of the days since box based on length of days since
            //Do the same for status below in StatusColor()
        }
    }
}
