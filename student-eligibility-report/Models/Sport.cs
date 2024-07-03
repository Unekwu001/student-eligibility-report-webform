using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace student_eligibility_report.Models
{
    public class Sport
    {
        public Guid Id { get; set; }
        public string SportName { get; set; }
        public string College { get; set; }
        public string VarsityJVClub { get; set; }
        public string Semester { get; set; }
        public string Year { get; set; }
        public Guid StudentEligibilityId { get; set; }
        public StudentEligibility StudentEligibility { get; set; }
    }
}