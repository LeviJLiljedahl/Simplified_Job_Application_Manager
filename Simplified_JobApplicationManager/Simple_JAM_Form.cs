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
            UpdateApplication();
            jobApplicationsList.Clear();
            ReloadApplications();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteApplication();
            jobApplicationsList.Remove(selectedApplication);
            jobApplicationsList.Clear();
            ReloadApplications();
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

        }

        public void Msg(string msg)
        {
            MessageBox.Show(msg, "Job Application Manager", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void Simple_JAM_Form_Load(object sender, EventArgs e)
        {
            applicationsListBox.DataSource = jobApplicationsList;
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
                this.aDaysSinceTextBox.Text = selectedApplication.DaysSince + " days";

                //Modify Colors based on values
                DaysSinceColor(selectedApplication.DaysSince);
                StatusColor();

            }
        }

        private void DaysSinceColor(int daysInt)
        {
            // Modify the color of the days since box based on length of days since

            if (daysInt < 7)
            {
                aDaysSinceTextBox.BackColor = Color.MediumSpringGreen;
            }
            else if (daysInt > 7 && daysInt < 14)
            {
                aDaysSinceTextBox.BackColor = Color.Khaki;
            }
            else if (daysInt > 14)
            {
                aDaysSinceTextBox.BackColor = Color.PaleVioletRed;
            }
            else
            {
                aDaysSinceTextBox.BackColor = Color.MediumAquamarine;
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

        private void InsertApplication()
        {

        }

        private void ReloadApplications()
        {

        }

        private void DeleteApplication()
        {

        }

        private void UpdateApplication()
        {

        }
    }
}
