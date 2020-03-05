using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Contracts
{

    public interface ISessionRepository : IRepositoryBase<Session>
    {
        
        IEnumerable<Session> GetAllSessions();
        Task<IEnumerable<Session>> GetAllSessionsAsync();

        Session GetSessionById(Guid id);
        Task<Session> GetSessionByIdAsync(Guid id);

        IEnumerable<SessionByDayModel> GetAllSessionOfEventByIdAndGroupByDay(Guid id);
        IEnumerable<SessionByDayModel> GetAllSessionAndGroupByDay();

        Task<IEnumerable<Session>> GetAllSessionsBySpeakerIdAsync(Guid id);
        IEnumerable<Session> GetAllSessionsBySpeakerId(Guid id);

        IEnumerable<Session> GetAllSessionWithConferenceAndSpeakers();
        Task<IEnumerable<Session>> GetAllSessionWithConferenceAndSpeakersAsync();


        IEnumerable<Session> Paginate(int pageNumber, int pageSize);
    }
}
