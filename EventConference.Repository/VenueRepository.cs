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
    public class VenueRepository : RepositoryBase<Venue>, IVenueRepository
    {
        public VenueRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Venue> GetAllVenues()
        {
            return this.FindAll();
        }

        public async Task<IEnumerable<Venue>> GetAllVenuesAsync()
        {
            return await this.FindAll().ToListAsync();
        }

        public Venue GetVenueById(Guid id)
        {
            return this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public async Task<Venue> GetVenueByIdAsync(Guid id)
        {
            return await this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }
    }
}
