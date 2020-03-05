using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Entities.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.Now);
            var countries = new List<Country>
            {
                new Country{ Id=1, Name="Timor-Leste"},
                new Country{Id=2,Name="Indonesia"},
                new Country{Id=3,Name="Portugal"},
                new Country{Id=4,Name="Australia"},
                new Country{Id=5,Name="New Zealand"}
            };

            builder.HasData(countries);
        }
    }
}
