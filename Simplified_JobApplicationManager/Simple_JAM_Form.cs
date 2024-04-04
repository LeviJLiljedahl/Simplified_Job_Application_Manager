using Microsoft.VisualBasic;

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
            if ((cNameTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Company Name TextBox can not be blank.");
                cNameTextBox.Focus();
                return;
            }
            else if ((cLocatedTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Company Located TextBox can not be blank.");
                cNameTextBox.Focus();
                return;
            }
            // Add rest of if else statements here
            //else if ()
            // {

            // } 
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
