using EventConference.Contracts;
using EventConference.Entities;
using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventConference.Repository
{
    //public class ScheduleRepository : RepositoryBase<Schedule>, IScheduleRepository
    //{
    //    public ScheduleRepository(RepositoryContext context) : base(context)
    //    {
    //    }

    //    public IEnumerable<ScheduleByDayModel> GetAllScheduleAndGroupByDay()
    //    {
            
    //        var group = this.RepositoryContext.Schedules.Include(s=>s.Speaker).Select(s => new Schedule
    //        {
    //            Id = s.Id,
    //            DayNumber = s.DayNumber,
    //            StartTime = s.StartTime,
    //            SpeakerId = s.SpeakerId,
    //            Speaker = s.Speaker,
    //            Title = s.Title,
    //            SubTitle = s.SubTitle
    //        }).ToList().GroupBy(t => t.DayNumber).OrderBy(o=>o.Key).Select(s => new ScheduleByDayModel
    //        {
    //            DayNumber = s.Key,
    //            Schedules = s.OrderBy(d=>d.StartTime).ToList()
    //        }).ToList();

    //        return group;
    //    }


    //    public IEnumerable<Schedule> GetAllSchedules()
    //    {
    //        return this.FindAll();
    //    }

    //    public IEnumerable<Schedule> GetAllSchedulesBySpeakerId(Guid id)
    //    {
    //        return this.FindByCondition(s => s.SpeakerId.Equals(id));
    //    }

    //    public Schedule GetScheduleById(Guid id)
    //    {
    //        return this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefault();
    //    }
    //}
}
