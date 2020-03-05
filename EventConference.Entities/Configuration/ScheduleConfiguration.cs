using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Entities.Configuration
{
    //public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    //{
    //    public void Configure(EntityTypeBuilder<Schedule> builder)
    //    {
    //        var schedules = new List<Schedule> {
    //            new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 1,
    //                Title = "Registration",
    //                SubTitle = "Fugit voluptas iusto maiores temporibus autem numquam magnam.",
    //                StartTime = DateTime.Parse("2020/02/1 9:30:00")
    //            },
    //            new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 1,
    //                Title = "Keynote Brenden Legros",
    //                SubTitle = "Facere provident incidunt quos voluptas.",
    //                StartTime = DateTime.Parse("2020/02/1 10:00:00")
    //            },new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 1,
    //                Title = "Et voluptatem iusto dicta nobis. Hubert Hirthe",
    //                SubTitle = "Maiores dignissimos neque qui cum accusantium ut sit sint inventore.",
    //                StartTime = DateTime.Parse("2020/02/1 11:00:00")
    //            },new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 1,
    //                Title = "Explicabo et rerum quis et ut ea. Cole Emmerich",
    //                SubTitle = "Veniam accusantium laborum nihil eos eaque accusantium aspernatur.",
    //                StartTime = DateTime.Parse("2020/02/1 12:00:00")
    //            },new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 1,
    //                Title = "Qui non qui vel amet culpa sequi. Jack Christiansen",
    //                SubTitle = "Nam ex distinctio voluptatem doloremque suscipit iusto.",
    //                StartTime = DateTime.Parse("2020/02/1 14:30:00")
    //            },new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 1,
    //                Title = "Quos ratione neque expedita asperiores. Helder Menezes",
    //                SubTitle = "Eligendi quo eveniet est nobis et ad temporibus odio quo.",
    //                StartTime = DateTime.Parse("2020/02/1 15:00:00")
    //            },new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 1,
    //                Title = "Quo qui praesentium nesciunt Elias Cabral",
    //                SubTitle = "Voluptatem et alias dolorum est aut sit enim neque veritatis.",
    //                StartTime = DateTime.Parse("2020/02/1 16:00:00")
    //            },


    //            new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 2,
    //                Title = "Libero corrupti explicabo itaque. Brenden Legros",
    //                SubTitle = "Facere provident incidunt quos voluptas.",
    //                StartTime = DateTime.Parse("2020/02/2 10:00:00")
    //            },
    //             new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 2,
    //                Title = "Et voluptatem iusto dicta nobis. Hubert Hirthe",
    //                SubTitle = "Maiores dignissimos neque qui cum accusantium ut sit sint inventore.",
    //                StartTime = DateTime.Parse("2020/02/2 11:00:00")
    //            },
    //              new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 2,
    //                Title = "Explicabo et rerum quis et ut ea. Cole Emmerich",
    //                SubTitle = "Veniam accusantium laborum nihil eos eaque accusantium aspernatur.",
    //                StartTime = DateTime.Parse("2020/02/2 12:00:00")
    //            },
    //               new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 2,
    //                Title = "Qui non qui vel amet culpa sequi. Jack Christiansen",
    //                SubTitle = "Nam ex distinctio voluptatem doloremque suscipit iusto.",
    //                StartTime = DateTime.Parse("2020/02/2 14:00:00")
    //            },
    //                new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 2,
    //                Title = "Quos ratione neque expedita asperiores. Helder Menezes",
    //                SubTitle = "Eligendi quo eveniet est nobis et ad temporibus odio quo.",
    //                StartTime = DateTime.Parse("2020/02/2 15:00:00")
    //            },

    //                  new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 2,
    //                Title = "Quo qui praesentium nesciunt Elias Cabral",
    //                SubTitle = "Voluptatem et alias dolorum est aut sit enim neque veritatis.",
    //                StartTime = DateTime.Parse("2020/02/2 16:00:00")
    //            },




    //            new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 3,
    //                Title = "Libero corrupti explicabo itaque. Brenden Legros",
    //                SubTitle = "Facere provident incidunt quos voluptas.",
    //                StartTime = DateTime.Parse("2020/02/3 10:00:00")
    //            },
    //             new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 3,
    //                Title = "Et voluptatem iusto dicta nobis. Hubert Hirthe",
    //                SubTitle = "Maiores dignissimos neque qui cum accusantium ut sit sint inventore.",
    //                StartTime = DateTime.Parse("2020/02/3 11:00:00")
    //            },
    //              new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 3,
    //                Title = "Explicabo et rerum quis et ut ea. Cole Emmerich",
    //                SubTitle = "Veniam accusantium laborum nihil eos eaque accusantium aspernatur.",
    //                StartTime = DateTime.Parse("2020/02/3 12:00:00")
    //            },
    //               new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 3,
    //                Title = "Qui non qui vel amet culpa sequi. Jack Christiansen",
    //                SubTitle = "Nam ex distinctio voluptatem doloremque suscipit iusto.",
    //                StartTime = DateTime.Parse("2020/02/3 14:00:00")
    //            },
    //                new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 3,
    //                Title = "Quos ratione neque expedita asperiores. Helder Menezes",
    //                SubTitle = "Eligendi quo eveniet est nobis et ad temporibus odio quo.",
    //                StartTime = DateTime.Parse("2020/02/3 15:00:00")
    //            },

    //                  new Schedule{
    //                Id = Guid.NewGuid(),
    //                DayNumber = 3,
    //                Title = "Quo qui praesentium nesciunt Elias Cabral",
    //                SubTitle = "Voluptatem et alias dolorum est aut sit enim neque veritatis.",
    //                StartTime = DateTime.Parse("2020/02/3 16:00:00")
    //            },

    //        };

    //        builder.HasData(schedules);
    //    }
    //}
}
