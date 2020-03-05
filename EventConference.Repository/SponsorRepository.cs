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
    public class SponsorRepository : RepositoryBase<Sponsor>,ISponsorRepository
    {
        public SponsorRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Sponsor> GetAllSponsors()
        {
            return this.FindAll();
        }

        public async Task<IEnumerable<Sponsor>> GetAllSponsorsAsync()
        {
            return await this.FindAll().ToListAsync();
        }

        public Sponsor GetSponsorById(Guid id)
        {
            return this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public async Task<Sponsor> GetSponsorByIdAsync(Guid id)
        {
            return await this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

    }
}
