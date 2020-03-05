using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Contracts
{
    public interface IVolunteerRepository : IRepositoryBase<Volunteer>
    {
        IEnumerable<Volunteer> GetAllVolunteers();
        Task<IEnumerable<Volunteer>> GetAllVolunteersAsync();

        IEnumerable<Volunteer> GetAllVolunteersByEventId(Guid EventId);

        Volunteer GetVolunteerById(Guid id);
        Task<Volunteer> GetVolunteerByIdAsync(Guid id);
    }
}
