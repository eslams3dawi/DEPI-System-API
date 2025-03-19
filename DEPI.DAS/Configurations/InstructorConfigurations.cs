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
    public class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder
                .Property(i => i.Salary)
                .HasPrecision(7, 2);
            builder
                .Property(i => i.FirstName)
                .HasMaxLength(30);
            builder
                .Property(i => i.LastName)
                .HasMaxLength(35);
            builder
                .Property(i => i.Phone)
                .HasMaxLength(11);
        }
    }
}
