using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventConference.Entities.Configuration
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public SessionConfiguration()
        {

        }
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.Now);
            builder.Ignore(s => s.Duration);

            var sessions = new List<Session>
                    {
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=1,
                            Title = "Session 01",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 09:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 10:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=1,
                            Title = "Session 02",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 10:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 11:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=1,
                            Title = "Session 03",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 11:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 12:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=1,
                            Title = "Session 04",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 14:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 15:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=1,
                            Title = "Session 05",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 15:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 16:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=1,
                            Title = "Session 05",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 16:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 17:00:00"),
                            Date = DateTime.Now
                        },

                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=2,
                            Title = "Session 01",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 09:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 10:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=2,
                            Title = "Session 02",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 10:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 11:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=2,
                            Title = "Session 03",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 11:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 12:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=2,
                            Title = "Session 04",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 14:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 15:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=2,
                            Title = "Session 05",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 15:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 16:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=2,
                            Title = "Session 05",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 16:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 17:00:00"),
                            Date = DateTime.Now
                        },


                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=3,
                            Title = "Session 01",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 09:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 10:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=3,
                            Title = "Session 02",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 10:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 11:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=3,
                            Title = "Session 03",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 11:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 12:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=3,
                            Title = "Session 04",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 14:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 15:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=3,
                            Title = "Session 05",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 15:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 16:00:00"),
                            Date = DateTime.Now
                        },
                        new Session{
                            Id = Guid.NewGuid(),
                            DayNumber=3,
                            Title = "Session 05",
                            Abstract = "Abstract of session 01",
                            StartTime = DateTimeOffset.Parse("2020-10-01 16:00:00"),
                            EndTime = DateTimeOffset.Parse("2020-10-01 17:00:00"),
                            Date = DateTime.Now
                        }
                    };
            builder.HasData(sessions);
        }
    }
}
