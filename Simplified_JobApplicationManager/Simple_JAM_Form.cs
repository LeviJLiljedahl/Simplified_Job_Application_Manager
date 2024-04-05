//Author: Levi Liljedahl
//Date: 04/04/2024
//Purpose: Allow users to keep track of the jobs they apply for and have access to all the data about an application in one spot.

namespace Simplified_JobApplicationManager
{
    public partial class Simple_JAM_Form : Form
    {
        public Simple_JAM_Form()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            DateTime valueDAT;

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
                Msg("Good Code");
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

        }

        private void ClearAllTextBoxes()
        {
            // Clear company info textboxes
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
    }
}
