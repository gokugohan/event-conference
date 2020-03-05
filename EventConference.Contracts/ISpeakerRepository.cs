using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Contracts
{
    public interface ISpeakerRepository:IRepositoryBase<Speaker>
    {
        IEnumerable<Speaker> GetAllSpeakers();
        Task<IEnumerable<Speaker>> GetAllSpeakersAsync();
        Speaker GetSpeakerById(Guid id);
        Task<Speaker> GetSpeakerByIdAsync(Guid id);

        IEnumerable<Speaker> GetSpeakersByEventId(Guid id);
        Task<IEnumerable<Speaker>> GetSpeakersByEventIdAsync(Guid id);

    }
}
