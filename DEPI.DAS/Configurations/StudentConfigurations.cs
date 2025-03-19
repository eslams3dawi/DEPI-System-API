using DEPI.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(20);
            builder
                .Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(25);
            builder
                .Property(s => s.Age)
                .HasComputedColumnSql("DATEDIFF(YEAR, DateOfBirth, GETDATE())");
        }
    }
}
