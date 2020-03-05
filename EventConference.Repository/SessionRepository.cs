using EventConference.Contracts;
using EventConference.Entities;
using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Repository
{
    public class SessionRepository : RepositoryBase<Session>, ISessionRepository
    {
        public SessionRepository(RepositoryContext context) : base(context)
        {
        }


        public IEnumerable<SessionByDayModel> GetAllSessionAndGroupByDay()
        {
            var group = this.RepositoryContext.Sessions.Include(s => s.Speaker).Select(s => new Session
            {
                Id = s.Id,
                DayNumber = s.DayNumber,
                StartTime = s.StartTime,
                EndTime = s.EndTime,
                Date = s.Date,
                SpeakerId = s.SpeakerId,
                Speaker = s.Speaker,
                Title = s.Title,
                Abstract = s.Abstract
            }).ToList().GroupBy(t => t.DayNumber).OrderBy(o => o.Key).Select(s => new SessionByDayModel
            {
                DayNumber = s.Key,
                Sessions = s.OrderBy(d => d.StartTime).ToList()
            }).ToList();

            return group;
        }

        public IEnumerable<SessionByDayModel> GetAllSessionOfEventByIdAndGroupByDay(Guid id)
        {
            var group = this.RepositoryContext.Sessions.Include(s => s.Speaker)
                .Where(s=>s.EventId==id)
                .Select(s => new Session
            {
                Id = s.Id,
                DayNumber = s.DayNumber,
                StartTime = s.StartTime,
                EndTime = s.EndTime,
                Date = s.Date,
                SpeakerId = s.SpeakerId,
                Speaker = s.Speaker,
                Title = s.Title,
                Abstract = s.Abstract
            }).ToList().GroupBy(t => t.DayNumber).OrderBy(o => o.Key).Select(s => new SessionByDayModel
            {
                DayNumber = s.Key,
                Sessions = s.OrderBy(d => d.StartTime).ToList()
            }).ToList();

            return group;
        }

        public IEnumerable<Session> GetAllSessions()
        {
            return this.FindAll();
        }

        public async Task<IEnumerable<Session>> GetAllSessionsAsync()
        {
            return await this.FindAllAsync();
        }

        public IEnumerable<Session> GetAllSessionsBySpeakerId(Guid id)
        {
            return this.FindByCondition(s => s.SpeakerId.Equals(id));
        }

        public async Task<IEnumerable<Session>> GetAllSessionsBySpeakerIdAsync(Guid id)
        {
            return await this.FindByConditionAsync(x => x.SpeakerId.Equals(id));
        }

        public IEnumerable<Session> GetAllSessionWithConferenceAndSpeakers()
        {
            return this.RepositoryContext.Sessions
                .Include(session => session.SessionParticipants)
                .ThenInclude(sessionparticipants => sessionparticipants.Participant)
                .ThenInclude(participant=>participant.Country)
                .AsEnumerable();
        }

        public async Task<IEnumerable<Session>> GetAllSessionWithConferenceAndSpeakersAsync()
        {
            return await this.RepositoryContext.Sessions
               .Include(session => session.SessionParticipants)
               .ThenInclude(sessionparticipants => sessionparticipants.Participant)
               .ThenInclude(participant => participant.Country).ToListAsync();
        }

        public Session GetSessionById(Guid id)
        {
            return this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public async Task<Session> GetSessionByIdAsync(Guid id)
        {
            return await this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public IEnumerable<Session> Paginate(int page, int pageSize)
        {
            return this.RepositoryContext.Sessions.Skip(page).Take(pageSize).OrderBy(x => x.DayNumber).ThenBy(x => x.StartTime).ThenBy(x => x.EndTime);

        }
    }
}
