using student_eligibility_report.Models;
using student_eligibility_report.StudentEligibilityDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student_eligibility_report
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected async Task SubmitButton_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;

            try
            {
                var eligibleStudent = CreateStudentEligibility();
                await SaveStudentEligibility(eligibleStudent);
                DisplaySuccessMessage(eligibleStudent);
            }
            catch (FormatException)
            {
                LogAndDisplayError("Error parsing dates. Please ensure they are in the correct format.");
            }
            catch (Exception ex)
            {
                LogAndDisplayError($"An unexpected error occurred: {ex.Message}");
            }
        }





        private StudentEligibility CreateStudentEligibility()
        {
            // Retrieving form values
            string thePresentCollege = presentCollege.Text.Trim();
            string thePresentConference = presentConference.Text.Trim();
            string theName = name.Text.Trim();
            string theStudentId = studentId.Text.Trim();
            string thePresentAddress = presentAddress.Text.Trim();
            string theTelephone = telephone.Text.Trim();
            string theHighSchool = highSchool.Text.Trim();
            DateTime theDob = DateTime.Parse(dob.Text);
            DateTime theLastDateAttended = DateTime.Parse(lastDateAttended.Text);
            string theSport = sport.SelectedValue;
            string theGender = genderList.SelectedValue;
            int theSeason = int.Parse(seasonList.SelectedValue);

            // Collecting data from sportsTable
            var sportsList = GetSportsList();

            // Collecting data from collegeTable
            var collegeList = GetCollegeList();

            // Creating the StudentEligibility entity
            return new StudentEligibility
            {
                Id = Guid.NewGuid(),
                PresentCollege = thePresentCollege,
                PresentConference = thePresentConference,
                Name = theName,
                StudentId = theStudentId,
                PresentAddress = thePresentAddress,
                Telephone = theTelephone,
                HighSchool = theHighSchool,
                DateOfBirth = theDob,
                LastDateAttended = theLastDateAttended,
                Sport = theSport,
                Gender = theGender,
                PreviousSeasons = theSeason,
                Sports = sportsList,
                CollegesAttended = collegeList
            };
        }





        private List<Sport> GetSportsList()
        {
            var sportsList = new List<Sport>();
            foreach (TableRow row in sportsTable.Rows)
            {
                // Skip the header row
                if (row.Cells.Count == 0 || row.Cells[0].Controls.Count == 0)
                {
                    continue;
                }
                var sportTextBox = (TextBox)row.Cells[0].Controls[0];
                var collegeTextBox = (TextBox)row.Cells[1].Controls[0];
                var varsityJVClubTextBox = (TextBox)row.Cells[2].Controls[0];
                var semesterTextBox = (TextBox)row.Cells[3].Controls[0];
                var yearTextBox = (TextBox)row.Cells[4].Controls[0];

                string sportValue = sportTextBox.Text.Trim();
                string collegeValue = collegeTextBox.Text.Trim();
                string varsityJVClubValue = varsityJVClubTextBox.Text.Trim();
                string semesterValue = semesterTextBox.Text.Trim();
                string yearValue = yearTextBox.Text.Trim();

                if (!string.IsNullOrEmpty(sportValue) ||
                    !string.IsNullOrEmpty(collegeValue) ||
                    !string.IsNullOrEmpty(varsityJVClubValue) ||
                    !string.IsNullOrEmpty(semesterValue) ||
                    !string.IsNullOrEmpty(yearValue))
                {
                    sportsList.Add(new Sport
                    {
                        SportName = sportValue,
                        College = collegeValue,
                        VarsityJVClub = varsityJVClubValue,
                        Semester = semesterValue,
                        Year = yearValue
                    });
                }
            }
            return sportsList;
        }




        private List<College> GetCollegeList()
        {
            var collegeList = new List<College>();
            foreach (TableRow row in collegeTable.Rows)
            {
                // Skip the header row
                if (row.Cells.Count == 0 || row.Cells[0].Controls.Count == 0)
                {
                    continue;
                }
                var fromTextBox = (TextBox)row.Cells[0].Controls[0];
                var toTextBox = (TextBox)row.Cells[1].Controls[0];
                var collegeAttendedTextBox = (TextBox)row.Cells[2].Controls[0];
                var jobsHeldTextBox = (TextBox)row.Cells[3].Controls[0];
                var cityTextBox = (TextBox)row.Cells[4].Controls[0];
                var stateTextBox = (TextBox)row.Cells[5].Controls[0];

                string fromValue = fromTextBox.Text.Trim();
                string toValue = toTextBox.Text.Trim();
                string collegeAttendedValue = collegeAttendedTextBox.Text.Trim();
                string jobsHeldValue = jobsHeldTextBox.Text.Trim();
                string cityValue = cityTextBox.Text.Trim();
                string stateValue = stateTextBox.Text.Trim();

                if (!string.IsNullOrEmpty(fromValue) ||
                    !string.IsNullOrEmpty(toValue) ||
                    !string.IsNullOrEmpty(collegeAttendedValue) ||
                    !string.IsNullOrEmpty(jobsHeldValue) ||
                    !string.IsNullOrEmpty(cityValue) ||
                    !string.IsNullOrEmpty(stateValue))
                {
                    collegeList.Add(new College
                    {
                        From = DateTime.Parse(fromValue),
                        To = DateTime.Parse(toValue),
                        CollegeAttended = collegeAttendedValue,
                        Job = jobsHeldValue,
                        City = cityValue,
                        State = stateValue
                    });
                }
            }
            return collegeList;
        }





        private async Task SaveStudentEligibility(StudentEligibility eligibleStudent)
        {
            using (var context = new StudentEligibilityContext())
            {
                context.StudentEligibilities.Add(eligibleStudent);
                await context.SaveChangesAsync();
            }
        }





        private void DisplaySuccessMessage(StudentEligibility eligibleStudent)
        {
            var message = $"Thank you for your submission! Here is the data:\n\n" +
                          $"Present College: {eligibleStudent.PresentCollege}\n" +
                          $"Present Conference: {eligibleStudent.PresentConference}\n" +
                          $"Name: {eligibleStudent.Name}\n" +
                          $"Student ID: {eligibleStudent.StudentId}\n" +
                          $"Present Address: {eligibleStudent.PresentAddress}\n" +
                          $"Telephone: {eligibleStudent.Telephone}\n" +
                          $"High School Last Attended: {eligibleStudent.HighSchool}\n" +
                          $"Date of Birth: {eligibleStudent.DateOfBirth.ToShortDateString()}\n" +
                          $"Last Date Attended: {eligibleStudent.LastDateAttended.ToShortDateString()}\n" +
                          $"Sport This Season: {eligibleStudent.Sport}\n" +
                          $"Gender: {eligibleStudent.Gender}\n" +
                          $"Previous Seasons of Competition: {eligibleStudent.PreviousSeasons}\n" +
                          $"Sports Table Data:\n";

            // Append sportsTable data to the message
            foreach (var sportData in eligibleStudent.Sports)
            {
                message += $"Sport: {sportData.SportName}, College: {sportData.College}, " +
                           $"Varsity/JV/Club: {sportData.VarsityJVClub}, Semester: {sportData.Semester}, Year: {sportData.Year}\n";
            }

            // Append collegeTable data to the message
            foreach (var collegeData in eligibleStudent.CollegesAttended)
            {
                message += $"From: {collegeData.From.ToShortDateString()}, To: {collegeData.To.ToShortDateString()}, " +
                           $"College Attended: {collegeData.CollegeAttended}, Jobs Held: {collegeData.Job}, " +
                           $"City: {collegeData.City}, State: {collegeData.State}\n";
            }

            // Display the message in a JavaScript alert
            Response.Write("<script>alert('" + message.Replace("\n", "\\n") + "');</script>");
        }





        private void LogAndDisplayError(string errorMessage)
        {
            Elmah.ErrorSignal.FromCurrentContext().Raise(new Exception(errorMessage));
            Response.Write("<script>alert('" + errorMessage.Replace("'", "\\'") + "');</script>");
        }





    }
}