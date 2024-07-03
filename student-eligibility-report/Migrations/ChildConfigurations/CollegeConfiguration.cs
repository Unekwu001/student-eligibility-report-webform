using student_eligibility_report.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace student_eligibility_report.Migrations.ChildConfigurations
{
    public class CollegeConfiguration : EntityTypeConfiguration<College>
    {
        public CollegeConfiguration()
        { 
            // Configure Primary Key
            HasKey(sd => sd.Id);

            Property(sd => sd.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); //generated on add

            // Configure Properties
            Property(sd => sd.From)
                .IsRequired();

            Property(sd => sd.To)
                .IsRequired();            

            Property(sd => sd.CollegeAttended)
                .IsRequired()
                .HasMaxLength(500);

            Property(sd => sd.City)
                .IsRequired()
                .HasMaxLength(150);

            Property(sd => sd.State)
              .IsRequired()
              .HasMaxLength(150);

            // Configure Relationships
            HasRequired(sd => sd.StudentEligibility)
                .WithMany(se => se.CollegesAttended)
                .HasForeignKey(sd => sd.StudentEligibilityId)
                .WillCascadeOnDelete(false);
        }
    }
}