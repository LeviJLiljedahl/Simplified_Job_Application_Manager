namespace Simplified_JobApplicationManager
{
    partial class Simple_JAM_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cNameLabel = new Label();
            cLocatedLabel = new Label();
            aAppliedDateLabel = new Label();
            aDaysSinceLabel = new Label();
            aLocationLabel = new Label();
            aStatusLabel = new Label();
            jTitleLabel = new Label();
            jLocationLabel = new Label();
            groupBox1 = new GroupBox();
            cApplicationIDTextBox = new TextBox();
            cApplicationIDLabel = new Label();
            cLocatedTextBox = new TextBox();
            cNameTextBox = new TextBox();
            groupBox2 = new GroupBox();
            jPayRateTextBox = new TextBox();
            jLocationTextBox = new TextBox();
            jTitleTextBox = new TextBox();
            jPayRateLabel = new Label();
            groupBox3 = new GroupBox();
            aStatusComboBox = new ComboBox();
            aLocationTextBox = new TextBox();
            aDaysSinceTextBox = new TextBox();
            aAppliedOnTextBox = new TextBox();
            groupBox4 = new GroupBox();
            eGoodFitComboBox = new ComboBox();
            eInterestComboBox = new ComboBox();
            eNotesTextBox = new TextBox();
            eSourceDocTextBox = new TextBox();
            eGoodFitLabel = new Label();
            eInterestLabel = new Label();
            eNotesLabel = new Label();
            eSourceDocLabel = new Label();
            addButton = new Button();
            clearButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            applicationsListBox = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // cNameLabel
            // 
            cNameLabel.AutoSize = true;
            cNameLabel.Location = new Point(6, 59);
            cNameLabel.Name = "cNameLabel";
            cNameLabel.Size = new Size(127, 18);
            cNameLabel.TabIndex = 0;
            cNameLabel.Text = "Company Name:";
            // 
            // cLocatedLabel
            // 
            cLocatedLabel.AutoSize = true;
            cLocatedLabel.Location = new Point(8, 90);
            cLocatedLabel.Name = "cLocatedLabel";
            cLocatedLabel.Size = new Size(139, 18);
            cLocatedLabel.TabIndex = 1;
            cLocatedLabel.Text = "Company Located:";
            // 
            // aAppliedDateLabel
            // 
            aAppliedDateLabel.AutoSize = true;
            aAppliedDateLabel.Location = new Point(6, 35);
            aAppliedDateLabel.Name = "aAppliedDateLabel";
            aAppliedDateLabel.Size = new Size(130, 18);
            aAppliedDateLabel.TabIndex = 2;
            aAppliedDateLabel.Text = "Date Applied On:";
            // 
            // aDaysSinceLabel
            // 
            aDaysSinceLabel.AutoSize = true;
            aDaysSinceLabel.Location = new Point(6, 66);
            aDaysSinceLabel.Name = "aDaysSinceLabel";
            aDaysSinceLabel.Size = new Size(147, 18);
            aDaysSinceLabel.TabIndex = 3;
            aDaysSinceLabel.Text = "Days Since Applied:";
            // 
            // aLocationLabel
            // 
            aLocationLabel.AutoSize = true;
            aLocationLabel.Location = new Point(8, 97);
            aLocationLabel.Name = "aLocationLabel";
            aLocationLabel.Size = new Size(130, 18);
            aLocationLabel.TabIndex = 4;
            aLocationLabel.Text = "Applied Location:";
            // 
            // aStatusLabel
            // 
            aStatusLabel.AutoSize = true;
            aStatusLabel.Location = new Point(8, 128);
            aStatusLabel.Name = "aStatusLabel";
            aStatusLabel.Size = new Size(54, 18);
            aStatusLabel.TabIndex = 5;
            aStatusLabel.Text = "Status:";
            // 
            // jTitleLabel
            // 
            jTitleLabel.AutoSize = true;
            jTitleLabel.Location = new Point(6, 32);
            jTitleLabel.Name = "jTitleLabel";
            jTitleLabel.Size = new Size(71, 18);
            jTitleLabel.TabIndex = 6;
            jTitleLabel.Text = "Job Title:";
            // 
            // jLocationLabel
            // 
            jLocationLabel.AutoSize = true;
            jLocationLabel.Location = new Point(8, 63);
            jLocationLabel.Name = "jLocationLabel";
            jLocationLabel.Size = new Size(99, 18);
            jLocationLabel.TabIndex = 7;
            jLocationLabel.Text = "Job Location:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cApplicationIDTextBox);
            groupBox1.Controls.Add(cApplicationIDLabel);
            groupBox1.Controls.Add(cLocatedTextBox);
            groupBox1.Controls.Add(cNameTextBox);
            groupBox1.Controls.Add(cNameLabel);
            groupBox1.Controls.Add(cLocatedLabel);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 127);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Company Information";
            // 
            // cApplicationIDTextBox
            // 
            cApplicationIDTextBox.BackColor = Color.Aquamarine;
            cApplicationIDTextBox.Enabled = false;
            cApplicationIDTextBox.Location = new Point(155, 25);
            cApplicationIDTextBox.Name = "cApplicationIDTextBox";
            cApplicationIDTextBox.Size = new Size(283, 25);
            cApplicationIDTextBox.TabIndex = 4;
            // 
            // cApplicationIDLabel
            // 
            cApplicationIDLabel.AutoSize = true;
            cApplicationIDLabel.Location = new Point(8, 28);
            cApplicationIDLabel.Name = "cApplicationIDLabel";
            cApplicationIDLabel.Size = new Size(141, 18);
            cApplicationIDLabel.TabIndex = 3;
            cApplicationIDLabel.Text = "Job Application ID:";
            // 
            // cLocatedTextBox
            // 
            cLocatedTextBox.BackColor = Color.MintCream;
            cLocatedTextBox.Font = new Font("Garamond", 12F);
            cLocatedTextBox.Location = new Point(151, 87);
            cLocatedTextBox.Name = "cLocatedTextBox";
            cLocatedTextBox.Size = new Size(287, 25);
            cLocatedTextBox.TabIndex = 2;
            // 
            // cNameTextBox
            // 
            cNameTextBox.BackColor = Color.MintCream;
            cNameTextBox.Font = new Font("Garamond", 12F);
            cNameTextBox.Location = new Point(145, 56);
            cNameTextBox.Name = "cNameTextBox";
            cNameTextBox.Size = new Size(293, 25);
            cNameTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(jPayRateTextBox);
            groupBox2.Controls.Add(jLocationTextBox);
            groupBox2.Controls.Add(jTitleTextBox);
            groupBox2.Controls.Add(jPayRateLabel);
            groupBox2.Controls.Add(jTitleLabel);
            groupBox2.Controls.Add(jLocationLabel);
            groupBox2.Location = new Point(12, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(444, 126);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Job Information:";
            // 
            // jPayRateTextBox
            // 
            jPayRateTextBox.BackColor = Color.MintCream;
            jPayRateTextBox.Font = new Font("Garamond", 12F);
            jPayRateTextBox.Location = new Point(86, 91);
            jPayRateTextBox.Name = "jPayRateTextBox";
            jPayRateTextBox.Size = new Size(352, 25);
            jPayRateTextBox.TabIndex = 5;
            // 
            // jLocationTextBox
            // 
            jLocationTextBox.BackColor = Color.MintCream;
            jLocationTextBox.Font = new Font("Garamond", 12F);
            jLocationTextBox.Location = new Point(111, 60);
            jLocationTextBox.Name = "jLocationTextBox";
            jLocationTextBox.Size = new Size(327, 25);
            jLocationTextBox.TabIndex = 4;
            // 
            // jTitleTextBox
            // 
            jTitleTextBox.BackColor = Color.MintCream;
            jTitleTextBox.Font = new Font("Garamond", 12F);
            jTitleTextBox.Location = new Point(83, 29);
            jTitleTextBox.Name = "jTitleTextBox";
            jTitleTextBox.Size = new Size(355, 25);
            jTitleTextBox.TabIndex = 3;
            // 
            // jPayRateLabel
            // 
            jPayRateLabel.AutoSize = true;
            jPayRateLabel.Location = new Point(6, 94);
            jPayRateLabel.Name = "jPayRateLabel";
            jPayRateLabel.Size = new Size(74, 18);
            jPayRateLabel.TabIndex = 8;
            jPayRateLabel.Text = "Pay Rate:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(aStatusComboBox);
            groupBox3.Controls.Add(aLocationTextBox);
            groupBox3.Controls.Add(aDaysSinceTextBox);
            groupBox3.Controls.Add(aAppliedOnTextBox);
            groupBox3.Controls.Add(aAppliedDateLabel);
            groupBox3.Controls.Add(aDaysSinceLabel);
            groupBox3.Controls.Add(aLocationLabel);
            groupBox3.Controls.Add(aStatusLabel);
            groupBox3.Location = new Point(12, 277);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(444, 158);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Application Information:";
            // 
            // aStatusComboBox
            // 
            aStatusComboBox.BackColor = Color.MintCream;
            aStatusComboBox.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aStatusComboBox.FormattingEnabled = true;
            aStatusComboBox.Items.AddRange(new object[] { "Need To Apply", "Application In Progress", "Submitted Application/Waiting on Response", "Company Responded", "Company Responded/Waiting on More Info", "Company Responded/Waiting for My Response", "Communicating Back and Forth", "Interview Scheduled", "Technical Interview Scheduled", "Interview Complete", "Interview Complete/Waiting on Response", "Interview Complete/Waiting for Information from me", "Interview Complete/Waiting for My Response", "Rejected", "Hired" });
            aStatusComboBox.Location = new Point(68, 125);
            aStatusComboBox.Name = "aStatusComboBox";
            aStatusComboBox.Size = new Size(370, 26);
            aStatusComboBox.TabIndex = 9;
            // 
            // aLocationTextBox
            // 
            aLocationTextBox.BackColor = Color.MintCream;
            aLocationTextBox.Font = new Font("Garamond", 12F);
            aLocationTextBox.Location = new Point(142, 94);
            aLocationTextBox.Name = "aLocationTextBox";
            aLocationTextBox.Size = new Size(296, 25);
            aLocationTextBox.TabIndex = 8;
            // 
            // aDaysSinceTextBox
            // 
            aDaysSinceTextBox.BackColor = Color.MediumAquamarine;
            aDaysSinceTextBox.Enabled = false;
            aDaysSinceTextBox.Font = new Font("Garamond", 12F);
            aDaysSinceTextBox.Location = new Point(159, 63);
            aDaysSinceTextBox.Name = "aDaysSinceTextBox";
            aDaysSinceTextBox.Size = new Size(279, 25);
            aDaysSinceTextBox.TabIndex = 7;
            aDaysSinceTextBox.TabStop = false;
            // 
            // aAppliedOnTextBox
            // 
            aAppliedOnTextBox.BackColor = Color.MintCream;
            aAppliedOnTextBox.Font = new Font("Garamond", 12F);
            aAppliedOnTextBox.Location = new Point(142, 32);
            aAppliedOnTextBox.Name = "aAppliedOnTextBox";
            aAppliedOnTextBox.Size = new Size(296, 25);
            aAppliedOnTextBox.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(eGoodFitComboBox);
            groupBox4.Controls.Add(eInterestComboBox);
            groupBox4.Controls.Add(eNotesTextBox);
            groupBox4.Controls.Add(eSourceDocTextBox);
            groupBox4.Controls.Add(eGoodFitLabel);
            groupBox4.Controls.Add(eInterestLabel);
            groupBox4.Controls.Add(eNotesLabel);
            groupBox4.Controls.Add(eSourceDocLabel);
            groupBox4.Location = new Point(12, 441);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(444, 156);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Extra Information:";
            // 
            // eGoodFitComboBox
            // 
            eGoodFitComboBox.BackColor = Color.MintCream;
            eGoodFitComboBox.FormattingEnabled = true;
            eGoodFitComboBox.Items.AddRange(new object[] { "Good Fit", "Poor Fit", "Sort Of Fit", "Good Chances", "Poor Chances", "50/50 Chances", "Likely", "Unlikely", "HomeRun", "LongShot", "Possibly", "N/A" });
            eGoodFitComboBox.Location = new Point(153, 121);
            eGoodFitComboBox.Name = "eGoodFitComboBox";
            eGoodFitComboBox.Size = new Size(285, 26);
            eGoodFitComboBox.TabIndex = 13;
            // 
            // eInterestComboBox
            // 
            eInterestComboBox.BackColor = Color.MintCream;
            eInterestComboBox.FormattingEnabled = true;
            eInterestComboBox.Items.AddRange(new object[] { "1 - Not Very Interested", "2", "3", "4 ", "5 - Sort Of Interested", "6", "7", "8", "9", "10 - Extremely Interested" });
            eInterestComboBox.Location = new Point(142, 90);
            eInterestComboBox.Name = "eInterestComboBox";
            eInterestComboBox.Size = new Size(296, 26);
            eInterestComboBox.TabIndex = 12;
            // 
            // eNotesTextBox
            // 
            eNotesTextBox.BackColor = Color.MintCream;
            eNotesTextBox.Font = new Font("Garamond", 12F);
            eNotesTextBox.Location = new Point(66, 59);
            eNotesTextBox.Name = "eNotesTextBox";
            eNotesTextBox.ScrollBars = ScrollBars.Horizontal;
            eNotesTextBox.Size = new Size(372, 25);
            eNotesTextBox.TabIndex = 11;
            // 
            // eSourceDocTextBox
            // 
            eSourceDocTextBox.BackColor = Color.MintCream;
            eSourceDocTextBox.Font = new Font("Garamond", 12F);
            eSourceDocTextBox.Location = new Point(149, 28);
            eSourceDocTextBox.Name = "eSourceDocTextBox";
            eSourceDocTextBox.ScrollBars = ScrollBars.Horizontal;
            eSourceDocTextBox.Size = new Size(289, 25);
            eSourceDocTextBox.TabIndex = 10;
            // 
            // eGoodFitLabel
            // 
            eGoodFitLabel.AutoSize = true;
            eGoodFitLabel.Location = new Point(8, 124);
            eGoodFitLabel.Name = "eGoodFitLabel";
            eGoodFitLabel.Size = new Size(141, 18);
            eGoodFitLabel.TabIndex = 3;
            eGoodFitLabel.Text = "Good Fit/Chances:";
            // 
            // eInterestLabel
            // 
            eInterestLabel.AutoSize = true;
            eInterestLabel.Location = new Point(8, 93);
            eInterestLabel.Name = "eInterestLabel";
            eInterestLabel.Size = new Size(128, 18);
            eInterestLabel.TabIndex = 2;
            eInterestLabel.Text = "Level Of Interest:";
            // 
            // eNotesLabel
            // 
            eNotesLabel.AutoSize = true;
            eNotesLabel.Location = new Point(8, 62);
            eNotesLabel.Name = "eNotesLabel";
            eNotesLabel.Size = new Size(54, 18);
            eNotesLabel.TabIndex = 1;
            eNotesLabel.Text = "Notes:";
            // 
            // eSourceDocLabel
            // 
            eSourceDocLabel.AutoSize = true;
            eSourceDocLabel.Location = new Point(6, 31);
            eSourceDocLabel.Name = "eSourceDocLabel";
            eSourceDocLabel.Size = new Size(137, 18);
            eSourceDocLabel.TabIndex = 0;
            eSourceDocLabel.Text = "Source Document:";
            // 
            // addButton
            // 
            addButton.BackColor = Color.MediumAquamarine;
            addButton.Location = new Point(12, 603);
            addButton.Name = "addButton";
            addButton.Size = new Size(107, 39);
            addButton.TabIndex = 14;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.MediumAquamarine;
            clearButton.Location = new Point(125, 603);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(107, 39);
            clearButton.TabIndex = 15;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.MediumAquamarine;
            updateButton.Location = new Point(238, 603);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(107, 39);
            updateButton.TabIndex = 16;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.MediumAquamarine;
            deleteButton.Location = new Point(351, 603);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(107, 39);
            deleteButton.TabIndex = 17;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // applicationsListBox
            // 
            applicationsListBox.BackColor = Color.MintCream;
            applicationsListBox.Font = new Font("Garamond", 12F);
            applicationsListBox.FormattingEnabled = true;
            applicationsListBox.HorizontalScrollbar = true;
            applicationsListBox.ItemHeight = 18;
            applicationsListBox.Location = new Point(471, 22);
            applicationsListBox.Name = "applicationsListBox";
            applicationsListBox.Size = new Size(288, 616);
            applicationsListBox.TabIndex = 16;
            applicationsListBox.TabStop = false;
            applicationsListBox.SelectedIndexChanged += applicationsListBox_SelectedIndexChanged;
            // 
            // Simple_JAM_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(771, 649);
            Controls.Add(applicationsListBox);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Simple_JAM_Form";
            Text = "Job Application Manager - Simplified";
            Load += Simple_JAM_Form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label cNameLabel;
        private Label cLocatedLabel;
        private Label aAppliedDateLabel;
        private Label aDaysSinceLabel;
        private Label aLocationLabel;
        private Label aStatusLabel;
        private Label jTitleLabel;
        private Label jLocationLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label jPayRateLabel;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label eGoodFitLabel;
        private Label eInterestLabel;
        private Label eNotesLabel;
        private Label eSourceDocLabel;
        private TextBox cLocatedTextBox;
        private TextBox cNameTextBox;
        private TextBox jPayRateTextBox;
        private TextBox jLocationTextBox;
        private TextBox jTitleTextBox;
        private TextBox aLocationTextBox;
        private TextBox aDaysSinceTextBox;
        private TextBox aAppliedOnTextBox;
        private TextBox eSourceDocTextBox;
        private TextBox eNotesTextBox;
        private Button addButton;
        private Button clearButton;
        private Button updateButton;
        private Button deleteButton;
        private ListBox applicationsListBox;
        private ComboBox aStatusComboBox;
        private ComboBox eGoodFitComboBox;
        private ComboBox eInterestComboBox;
        private TextBox cApplicationIDTextBox;
        private Label cApplicationIDLabel;
    }
}
