using student_eligibility_report.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace student_eligibility_report.Migrations.ChildConfigurations
{
    public class SportsConfiguration : EntityTypeConfiguration<Sport>
    {
        public SportsConfiguration()
        {
            // Configure Primary Key
            HasKey(sd => sd.Id);

            Property(sd => sd.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); //generated on add

            // Configure Properties
            Property(sd => sd.SportName)
                .IsRequired()
                .HasMaxLength(100);

            Property(sd => sd.College)
                .IsRequired()
                .HasMaxLength(100);

            Property(sd => sd.VarsityJVClub)
                .IsRequired()
                .HasMaxLength(100);

            Property(sd => sd.Semester)
                .IsRequired()
                .HasMaxLength(50);

            Property(sd => sd.Year)
                .IsRequired()
                .HasMaxLength(100);

            // Configure Relationships
            HasRequired(sd => sd.StudentEligibility)
                .WithMany(se => se.Sports)
                .HasForeignKey(sd => sd.StudentEligibilityId)
                .WillCascadeOnDelete(false);
        }
    }
}