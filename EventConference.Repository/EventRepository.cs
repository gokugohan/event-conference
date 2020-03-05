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
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(RepositoryContext context) : base(context)
        {
        }

        public Event GetActiveEvent()
        {
            return this.RepositoryContext.Events.FirstOrDefault(x => x.Active);
        }

        public Event GetActiveEventsWithAssociates()
        {
            return this.RepositoryContext.Events.Include(x => x.Speakers)
                                                .Include(x => x.Sponsors)
                                                .Include(x => x.Galleries)
                                                .Include(x=>x.Sessions)
                                                .Include(x=>x.Volunteers)
                                                .FirstOrDefault(x => x.Active);
        }

        public async Task<Event> GetActiveEventAsync()
        {
            return await this.RepositoryContext.Events.FirstOrDefaultAsync(x => x.Active);
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return this.FindAll();
        }

        public async Task<IEnumerable<Event>> GetAllEventssAsync()
        {
            return await this.FindAllAsync();
        }

        public Event GetEventById(Guid id)
        {
            return this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public async Task<Event> GetEventByIdAsync(Guid id)
        {
            return await this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }
    }
}
