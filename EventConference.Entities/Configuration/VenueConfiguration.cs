using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Entities.Configuration
{
    public class VenueConfiguration : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.Now);

            var venue = new Venue
            {
                Id = 1,
                Name = "Díli Convention Center",
                Address = "Mercado Lama, Caicoli, Timor-Leste",
                Latitude = "-8.560096",
                Longitude = "125.579218",
                Description = "Iste nobis eum sapiente sunt enim dolores labore accusantium autem. Cumque beatae ipsam. Est quae sit qui voluptatem corporis velit. Qui maxime accusamus possimus. Consequatur sequi et ea suscipit enim nesciunt quia velit."
            };

            builder.HasData(venue);


        }
    }
}
