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
                .HasMaxLength(20);
            builder
                .Property(s => s.LastName)
                .HasMaxLength(25);
            builder
                .Property(s => s.Age)
                .HasComputedColumnSql("DATEDIFF(YEAR, DateOfBirth, GETDATE())");
            builder
                .Property(s => s.Phone)
                .HasMaxLength(11);
        }
    }
}
