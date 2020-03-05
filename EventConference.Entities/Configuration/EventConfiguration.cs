using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Entities.Configuration
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.Now);
            builder.HasIndex(p => p.Active).IsUnique();
            

            builder.HasData(new Event
            {
                Id=Guid.NewGuid(),
                Date = DateTime.UtcNow,
                Title= "“There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...” - <span>Lorem Ipsum.</span>",
                SubTitle = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                TrailerVideoLink = "https://www.youtube.com/watch?v=jDDaplaOz7Q",
                Quote= "“There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...” - <span>Lorem Ipsum.</span>",
                Summary= "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                About= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                When= "Monday to Wednesday<br>10-12 December",
                Venue= "Díli Convention Center, Mercado Lama, Caicoli, Timor-Leste",
                Latitude= "-8.560096",
                Longitude= "125.579218",
                OrganizedBy= "LOREM IPSUM",
                EndorsedBy= "LOREM IPSUM",
                Description= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book",

                Active = true,
            },
            new Event
            {
                Id = Guid.NewGuid(),
                Date = DateTime.UtcNow,
                Title = "“Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...” - <span>Lorem Ipsum.</span>",
                SubTitle = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                TrailerVideoLink = "https://www.youtube.com/watch?v=jDDaplaOz7Q",
                Quote = "“Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...” - <span>Lorem Ipsum.</span>",
                Summary = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                About = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo",
                When = "Wednesday to Friday<br>10-12 December",
                Venue = "Baguia Convention Center, Osso-Huna, Baguia, Timor-Leste",
                Latitude = "-8.656648",
                Longitude = "126.625446",
                OrganizedBy = "OSSO-HUNA ANAN",
                EndorsedBy = "GERASAUN OSSO-HUNA",
                Description = "",
                Active = false,
            });
        }
    }
}
