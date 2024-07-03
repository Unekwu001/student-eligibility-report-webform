using student_eligibility_report.StudentEligibilityDbContext;
using System.Data.Entity.Migrations;

namespace student_eligibility_report.Migrations
{
    public class ConfigurationA : DbMigrationsConfiguration<StudentEligibilityContext>
    {
        public ConfigurationA()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}