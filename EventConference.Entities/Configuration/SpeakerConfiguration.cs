using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Entities.Configuration
{
    public class SpeakerConfiguration : IEntityTypeConfiguration<Speaker>
    {

        public void Configure(EntityTypeBuilder<Speaker> builder)
        {
            builder.ToTable("Speakers");
            builder.Property(s => s.Name).IsRequired();
            builder.HasIndex(s => s.Name).IsUnique();
            builder.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.CountryId).HasDefaultValue(1);

            var speakers = new List<Speaker>
            {
                new Speaker
                {
                    Id = Guid.NewGuid(),
                    Name = "Speaker 1",
                    Description = "Description of Speaker 1",
                    FullDescription = "FullDescription of Speaker 1"
                },
                new Speaker
                {
                    Id = Guid.NewGuid(),
                    Name = "Speaker 2",
                    Description = "Description of Speaker 2",
                    FullDescription = "FullDescription of Speaker 2"
                },
                new Speaker
                {
                    Id = Guid.NewGuid(),
                    Name = "Speaker 3",
                    Description = "Description of Speaker 3",
                    FullDescription = "FullDescription of Speaker 3"
                },
                new Speaker
                {
                    Id = Guid.NewGuid(),
                    Name = "Speaker 4",
                    Description = "Description of Speaker 4",
                    FullDescription = "FullDescription of Speaker 4"
                },
                new Speaker
                {
                    Id = Guid.NewGuid(),
                    Name = "Speaker 5",
                    Description = "Description of Speaker 5",
                    FullDescription = "FullDescription of Speaker 5"
                }
            };

            builder.HasData(speakers);
        }
    }
}
