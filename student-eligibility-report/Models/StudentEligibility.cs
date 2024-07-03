using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace student_eligibility_report.Models
{
    public class StudentEligibility
    {
        public Guid Id { get; set; }
        public string PresentCollege { get; set; }
        public string PresentConference { get; set; }
        public string Name { get; set; }
        public string StudentId { get; set; }
        public string PresentAddress { get; set; }
        public string Telephone { get; set; }
        public string HighSchool { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime LastDateAttended { get; set; }
        public string Sport { get; set; }
        public string Gender { get; set; }
        public int PreviousSeasons { get; set; }
        public string TimeAccount { get; set; }
        public string CollegeSportsDetails { get; set; }
        public ICollection<SportsData> StudentSportsData { get; set; }

    }
}