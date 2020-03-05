using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Contracts
{
    public interface IEventRepository : IRepositoryBase<Event>
    {
        IEnumerable<Event> GetAllEvents();
        
        Task<IEnumerable<Event>> GetAllEventssAsync();
        Event GetEventById(Guid id);
        Task<Event> GetEventByIdAsync(Guid id);

        Event GetActiveEvent();
        Event GetActiveEventsWithAssociates();
        Task<Event> GetActiveEventAsync();


    }
}
