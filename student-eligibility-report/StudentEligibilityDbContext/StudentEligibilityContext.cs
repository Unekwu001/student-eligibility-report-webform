using student_eligibility_report.Migrations;
using student_eligibility_report.Migrations.ChildConfigurations;
using student_eligibility_report.Models;
using System.Data.Entity;


namespace student_eligibility_report.StudentEligibilityDbContext
{
    public class StudentEligibilityContext : DbContext
    {

        public StudentEligibilityContext() : base("StudentEligibilityContext")
        {
            // This will enable automatic migrations when the context is used
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentEligibilityContext, ConfigurationA>());
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<StudentEligibility> StudentEligibilities { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<College> Colleges { get; set; } 


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new StudentEligibilityConfiguration());
            modelBuilder.Configurations.Add(new SportsConfiguration());
            modelBuilder.Configurations.Add(new CollegeConfiguration());
        }


    }
}