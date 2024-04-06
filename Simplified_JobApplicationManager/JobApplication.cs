//Author: Levi Liljedahl
//Date: 04/04/2024
//Purpose: Manage the Job Application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified_JobApplicationManager
{
    internal class JobApplication
    {
        //Class level variables

        private string cApplicationID;
        private string cCompanyName;
        private string cCompanyLocated;

        private string cJobTitle;
        private string cJobLocation;
        private string cPayRate;

        private DateTime cDateApplied;
        //private DateTime cDaysSince;
        private string cAppliedLocation;
        private string cStatus;

        private string cSourceDocument;
        private string cNotes;
        private string cLevelOfInterest;
        private string cGoodFit;

        public string ApplicationID
        { get { return cApplicationID; } set { cApplicationID = value; } }

        public string CompanyName
        { get { return cCompanyName; } set { cCompanyName = value; } }

        public string CompanyLocated
        { get { return cCompanyLocated; } set { cCompanyLocated = value; } }

        public string JobTitle
        { get { return cJobTitle; } set { cJobTitle = value; } }

        public string JobLocation
        { get { return cJobLocation; } set { cJobLocation = value; } }

        public string PayRate
        { get { return cPayRate; } set { cPayRate = value; } }

        public DateTime DateApplied
        { get { return cDateApplied; } set { cDateApplied = value; } }

        //public DateTime DaysSince 
        //   { get {  return cDaysSince; } set {  cDaysSince = value; } }

        public string AppliedLocation
        { get { return cAppliedLocation; } set { cAppliedLocation = value; } }

        public string Status
        { get { return cStatus; } set { cStatus = value; } }

        public string SourceDocument
        { get { return cSourceDocument; } set { cSourceDocument = value; } }

        public string Notes
        { get { return cNotes; } set { cNotes = value; } }

        public string LevelOfInterest
        { get { return cLevelOfInterest; } set { cLevelOfInterest = value; } }

        public string GoodFit
        { get { return cGoodFit; } set { cGoodFit = value; } }

        //Default Constructor
        public JobApplication()
        {
            cApplicationID = string.Empty;
            cCompanyName = string.Empty;
            cCompanyLocated = string.Empty;
            cJobTitle = string.Empty;
            cJobLocation = string.Empty;
            cPayRate = string.Empty;
            cDateApplied = new DateTime(1901, 01, 01);
            //cDaysSince = new DateTime(1901, 01, 01);
            cAppliedLocation = string.Empty;
            cStatus = string.Empty;
            cSourceDocument = string.Empty;
            cNotes = string.Empty;
            cLevelOfInterest = string.Empty;
            cGoodFit = string.Empty;
        }

        //Overload Construcor
        public JobApplication(string JobApplicationID)
        {
            cApplicationID = JobApplicationID;
            cCompanyName = string.Empty;
            cCompanyLocated = string.Empty;
            cJobTitle = string.Empty;
            cJobLocation = string.Empty;
            cPayRate = string.Empty;
            cDateApplied = new DateTime(1901, 01, 01);
            //cDaysSince = new DateTime(1901, 01, 01);
            cAppliedLocation = string.Empty;
            cStatus = string.Empty;
            cSourceDocument = string.Empty;
            cNotes = string.Empty;
            cLevelOfInterest = string.Empty;
            cGoodFit = string.Empty;
        }

        //Methods
        public void Calculate_DaysSince(DateTime dateApplied, ref int returnDays)
        {
            //    //Calculate and populate days since text box
                TimeSpan days = new TimeSpan();
                int daysInt = 0;
            //    selectedApplication.Calculate_DaysSince(selectedApplication.DateApplied, ref days);
                days = System.DateTime.Now - dateApplied;
                daysInt = days.Days;
                returnDays = daysInt;
        }


        // Override to string for listbox
        public override string ToString()
        {
            return cApplicationID + " - " + cJobTitle + " @ " + cCompanyName;
        }

    }
}