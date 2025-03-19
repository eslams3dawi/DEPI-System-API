using DEPI.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Configurations
{
    public class TrackConfigurations : IEntityTypeConfiguration<Track>
    {
      public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.
                Property(t => t.TrackName)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
