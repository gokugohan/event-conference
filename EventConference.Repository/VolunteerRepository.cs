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
    public class VolunteerRepository : RepositoryBase<Volunteer>, IVolunteerRepository
    {
        public VolunteerRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Volunteer> GetAllVolunteers()
        {
            return this.FindAll();
        }

        public async Task<IEnumerable<Volunteer>> GetAllVolunteersAsync()
        {
            return await this.FindAll().ToListAsync();
        }

        public IEnumerable<Volunteer> GetAllVolunteersByEventId(Guid EventId)
        {
            return this.RepositoryContext.Volunteers.Where(x => x.EventId.Equals(EventId));
        }

        public Volunteer GetVolunteerById(Guid id)
        {
            return this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public async Task<Volunteer> GetVolunteerByIdAsync(Guid id)
        {
            return await this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }
    }
}
