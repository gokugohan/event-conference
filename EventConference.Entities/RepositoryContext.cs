using EventConference.Entities.Configuration;
using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EventConference.Entities
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {

        }

        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Event> Events { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // Applying configurations
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new SpeakerConfiguration());
            modelBuilder.ApplyConfiguration(new EventConfiguration());

            modelBuilder.ApplyConfiguration(new SettingConfiguration());
            modelBuilder.ApplyConfiguration(new SponsorConfiguration());
            modelBuilder.ApplyConfiguration(new FaqConfiguration());
            modelBuilder.ApplyConfiguration(new GalleryConfiguration());
            modelBuilder.ApplyConfiguration(new MediaConfiguration());
            modelBuilder.ApplyConfiguration(new ParticipantConfiguration());
            modelBuilder.ApplyConfiguration(new VenueConfiguration());
            modelBuilder.ApplyConfiguration(new VolunteerConfiguration());

            modelBuilder.Entity<SessionParticipant>().HasKey(k => new { k.SessionId, k.ParticipantId });
            modelBuilder.Entity<SessionParticipant>().HasOne(s => s.Session).WithMany(sp => sp.SessionParticipants).HasForeignKey(fk => fk.SessionId);
            modelBuilder.Entity<SessionParticipant>().HasOne(p => p.Participant).WithMany(sp => sp.SessionParticipants).HasForeignKey(fk => fk.ParticipantId);
            modelBuilder.Entity<SessionParticipant>().Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);


            modelBuilder.ApplyConfiguration(new SessionConfiguration());


        }
    }

    /**
     * https://medium.com/oppr/net-core-using-entity-framework-core-in-a-separate-project-e8636f9dc9e5
     */
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../EventConference.Web/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<RepositoryContext>();
            var connectionString = configuration.GetConnectionString("sql_server");
            builder.UseSqlServer(connectionString);
            return new RepositoryContext(builder.Options);
        }
    }
}
