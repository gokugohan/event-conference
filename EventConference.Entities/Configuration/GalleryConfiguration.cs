﻿using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Entities.Configuration
{
    public class GalleryConfiguration : IEntityTypeConfiguration<Gallery>
    {
        public void Configure(EntityTypeBuilder<Gallery> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.Now);

        }
    }
}
