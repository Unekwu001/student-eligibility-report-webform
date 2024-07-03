using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace student_eligibility_report.Models
{
    public class College
    {
        public Guid Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string CollegeAttended { get; set; }
        public string Job { get; set; } = string.Empty; 
        public string City { get; set; }
        public string State { get; set; } 
        public Guid StudentEligibilityId { get; set; }
        public StudentEligibility StudentEligibility { get; set; }
    }
}