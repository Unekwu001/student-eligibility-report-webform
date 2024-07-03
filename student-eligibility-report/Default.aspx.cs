using student_eligibility_report.Models;
using student_eligibility_report.StudentEligibilityDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
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

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            // Check if the form is valid
            if (Page.IsValid)
            {
                try
                {
                    // Retrieving the form values
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
                    

                    // Collect data from sportsTable
                    var sportsList = new List<Sport>();
                    foreach (TableRow row in sportsTable.Rows)
                    {
                        // Skip the header row
                        if (row.Cells.Count == 0 || row.Cells[0].Controls.Count == 0)
                        {
                            continue;
                        }
                        else
                        {
                            var sportTextBox = (TextBox)row.Cells[0].Controls[0];
                            var collegeTextBox = (TextBox)row.Cells[1].Controls[0];
                            var varsityJVClubTextBox = (TextBox)row.Cells[2].Controls[0];
                            var semesterTextBox = (TextBox)row.Cells[3].Controls[0];
                            var yearTextBox = (TextBox)row.Cells[4].Controls[0];

                            // Collecting data from the TextBoxes in the Table
                            string sportValue = sportTextBox.Text.Trim();
                            string collegeValue = collegeTextBox.Text.Trim();
                            string varsityJVClubValue = varsityJVClubTextBox.Text.Trim();
                            string semesterValue = semesterTextBox.Text.Trim();
                            string yearValue = yearTextBox.Text.Trim();

                            // Skipping empty rows
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
                    }

                    // Create the StudentEligibility entity
                    var eligibleStudent = new StudentEligibility
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
                        Sports = sportsList
                    };

                    using (var context = new StudentEligibilityContext())
                    {
                        context.StudentEligibilities.Add(eligibleStudent);
                        context.SaveChanges();
                    }


                    // Create the message string
                    var message = $"Thank you for your submission! Here is the data:\n\n" +
                                  $"Present College: {thePresentCollege}\n" +
                                  $"Present Conference: {thePresentConference}\n" +
                                  $"Name: {theName}\n" +
                                  $"Student ID: {theStudentId}\n" +
                                  $"Present Address: {thePresentAddress}\n" +
                                  $"Telephone: {theTelephone}\n" +
                                  $"High School Last Attended: {theHighSchool}\n" +
                                  $"Date of Birth: {theDob.ToShortDateString()}\n" +
                                  $"Last Date Attended: {theLastDateAttended.ToShortDateString()}\n" +
                                  $"Sport This Season: {theSport}\n" +
                                  $"Gender: {theGender}\n" +
                                  $"Previous Seasons of Competition: {theSeason}\n" +
                                  $"Sports Table Data:\n";

                    // Append sportsTable data to the message
                    foreach (var sportData in sportsList)
                    {
                        message += $"Sport: {sportData.SportName}, College: {sportData.College}, " +
                                   $"Varsity/JV/Club: {sportData.VarsityJVClub}, Semester: {sportData.Semester}, Year: {sportData.Year}\n";
                    }

                    // Display the message in a JavaScript alert
                    Response.Write("<script>alert('" + message.Replace("\n", "\\n") + "');</script>");
                }
                catch (FormatException ex)
                {
                    // Handle date parsing errors
                    Response.Write("<script>alert('Error parsing dates. Please ensure they are in the correct format.');</script>");
                }
                catch (Exception ex)
                {
                    // Handle general errors
                    Response.Write("<script>alert('An unexpected error occurred: " + ex.Message.Replace("'", "\\'") + "');</script>");
                }
            }
        }




    }
}