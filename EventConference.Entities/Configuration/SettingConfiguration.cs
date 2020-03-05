using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Entities.Configuration
{
    public class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.Now);

            var settings = new List<Setting>
            {
                // Site Settings
                new Setting{
                    Id=Guid.NewGuid(),
                    Key="site_name",
                    Name="Site Name",
                    Value="LOREM-IPSUM",
                    Type="text",
                    Group="Site"
                },

                new Setting{
                    Id=Guid.NewGuid(),
                    Key="site_header_image",
                    Name="Site Background Header",
                    Type="file",
                    Group="Site"
                },

                // Event settings
                //new Setting {
                //    Id=Guid.NewGuid(),
                //    Key = "event_title",
                //    Value="“There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...” - <span>Lorem Ipsum.</span>",
                //    Name="Event Title",
                //    Type="text",
                //    Group="Event"
                //},
                //new Setting{Id=Guid.NewGuid(),
                //    Key="event_subtitle",
                //    Value="Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                //    Name="Event Subtitle",
                //    Type="text",
                //    Group="Event"
                //},
                //new Setting{
                //    Id=Guid.NewGuid(),
                //    Key="event_from_to_date",
                //    Value="10-12 December",
                //    Name="Date of event (from-to)",
                //    Type="text",
                //    Group="Site"
                //},
                //new Setting{
                //    Id=Guid.NewGuid(),
                //    Key="event_trailer",
                //    Value="https://www.youtube.com/watch?v=jDDaplaOz7Q",
                //    Name="Event video trailer",
                //    Type="text",
                //    Group="Event"
                //},

                //new Setting{
                //    Id=Guid.NewGuid(),
                //    Key="event_quote",
                //    Value="“There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...” - <span>Lorem Ipsum.</span>",
                //    Type="text",
                //    Group="Event"
                //},
                //new Setting{
                //    Id=Guid.NewGuid(),
                //    Key="event_quote_summary",
                //    Value="Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                //    Type="textarea",
                //    Group="Event"
                //},
                //new Setting
                //{
                //    Id=Guid.NewGuid(),
                //    Key="event_about",
                //    Name="Description about event",
                //    Value="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                //    Type="textarea",
                //    Group="Event"
                //},
                //new Setting
                //{
                //    Id=Guid.NewGuid(),
                //    Key="event_venue",
                //    Name="Where (event location)",
                //    Value="Díli Convention Center, Mercado Lama, Caicoli, Timor-Leste",
                //    Type="text",
                //    Group="Event"
                //},
                //new Setting
                //{
                //    Id=Guid.NewGuid(),
                //    Key="event_date",
                //    Value="Monday to Wednesday<br>10-12 December",
                //    Name="When(event days - ex: <small>Monday to Wednesday<br>10-12 December <small> )",
                //    Type="text",
                //    Group="Event"
                //},

                // new Setting
                //{
                //    Id=Guid.NewGuid(),
                //    Key="event_latitude",
                //    Value="-8.560096",
                //    Name="Event Venue latitude",
                //    Type="text",
                //    Group="Event"
                //},
                // new Setting
                //{
                //    Id=Guid.NewGuid(),
                //    Key="event_longitude",
                //    Value="125.579218",
                //    Name="Event Venue longitude",
                //    Type="text",
                //    Group="Event"
                //},


                // Contact settings
                new Setting
                {
                    Id=Guid.NewGuid(),
                    Key="contact_address",
                    Value="Rua Delta 1, Aimutin Comoro, Dili. Timor-Leste",
                    Name="Contact address",
                    Type="text",
                    Group="Contact"
                },
                new Setting
                {
                    Id=Guid.NewGuid(),
                    Key="contact_phone",
                    Value="+(670) 331 017 9",
                    Name="Contact phone",
                    Type="text",
                    Group="Contact"
                },
                new Setting
                {
                    Id=Guid.NewGuid(),
                    Key="contact_email",
                    Value="helder@chebre.net",
                    Name="Contact email",
                    Type="email",
                    Group="Contact"
                },

                // Footer Settings
                new Setting
                {
                    Id=Guid.NewGuid(),
                    Key="footer_description",
                    Value="In alias aperiam. Placeat tempore facere. Officiis voluptate ipsam vel eveniet est dolor et totam porro. Perspiciatis ad omnis fugit molestiae recusandae possimus. Aut consectetur id quis. In inventore consequatur ad voluptate cupiditate debitis accusamus repellat cumque.	",
                    Name="Footer Description",
                    Type="textarea",
                    Group="Footer"
                },

                new Setting
                {
                    Id=Guid.NewGuid(),
                    Key="twitter",
                    Value="#!",
                    Name="Twitter",
                    Type="text",
                    Group="Footer"
                },
                new Setting
                {
                    Id=Guid.NewGuid(),
                    Key="facebook",
                    Value="#!",
                    Name="Facebook",
                    Type="text",
                    Group="Footer"
                },
                new Setting
                {
                    Id=Guid.NewGuid(),
                    Key="instagram",
                    Value="#!",
                    Name="Instagram",
                    Type="text",
                    Group="Footer"
                },
                new Setting
                {
                    Id=Guid.NewGuid(),
                    Key="linkedin",
                    Value="#!",
                    Name="LinkedIn",
                    Type="text",
                    Group="Footer"
                }
            };

            builder.HasData(settings);
        }
    }
}
