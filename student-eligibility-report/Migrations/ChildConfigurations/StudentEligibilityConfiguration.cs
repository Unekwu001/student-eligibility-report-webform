using student_eligibility_report.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace student_eligibility_report.Migrations.ChildConfigurations
{
    public class StudentEligibilityConfiguration : EntityTypeConfiguration<StudentEligibility>
    {
        public StudentEligibilityConfiguration()
        {
            ToTable(nameof(StudentEligibility));
            HasKey(e => e.Id);
            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.PresentCollege)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.PresentConference)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.StudentId)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.PresentAddress)
                .IsRequired()
                .HasMaxLength(250);

            Property(e => e.Telephone)
                .IsRequired()
                .HasMaxLength(20);

            Property(e => e.HighSchool)
                .IsRequired()
                .HasMaxLength(250);

            Property(e => e.DateOfBirth)
                .IsRequired();

            Property(e => e.LastDateAttended)
                .IsRequired();

            Property(e => e.Sport)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(10);

            Property(e => e.PreviousSeasons)
                .IsRequired();

            Property(e => e.TimeAccount)
                .IsRequired()
                .HasMaxLength(500);

            Property(e => e.CollegeSportsDetails)
                .HasMaxLength(1000);

            HasMany(e => e.StudentSportsData)
                .WithRequired(sd => sd.StudentEligibility)
                .HasForeignKey(sd => sd.StudentEligibilityId)
                .WillCascadeOnDelete(false);
        }
    }
}