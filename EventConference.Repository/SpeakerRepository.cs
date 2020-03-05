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
    public class SpeakerRepository : RepositoryBase<Speaker>, ISpeakerRepository
    {
        public SpeakerRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Speaker> GetAllSpeakers()
        {
            return this.FindAll();
        }

        public async Task<IEnumerable<Speaker>> GetAllSpeakersAsync()
        {
            return await this.FindAll().ToListAsync();
        }

        public Speaker GetSpeakerById(Guid id)
        {
            return this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public async Task<Speaker> GetSpeakerByIdAsync(Guid id)
        {
            return await this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public IEnumerable<Speaker> GetSpeakersByEventId(Guid id)
        {
            var result = this.RepositoryContext.Speakers.Where(s => s.EventId.Equals(id)).ToList();
            return result;
        }

        public async Task<IEnumerable<Speaker>> GetSpeakersByEventIdAsync(Guid id)
        {
            var result = await this.RepositoryContext.Speakers.Where(s => s.EventId.Equals(id)).ToListAsync();
            return result;
        }
    }
}
