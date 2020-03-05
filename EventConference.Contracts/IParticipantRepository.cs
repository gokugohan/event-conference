using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Contracts
{
    public interface IParticipantRepository : IRepositoryBase<Participant>
    {
        IEnumerable<Participant> GetAllParticipants();
        Task<IEnumerable<Participant>> GetAllParticipantsAsync();
        Participant GetParticipantById(Guid id);
        Task<Participant> GetParticipantByIdAsync(Guid id);

    }
}
