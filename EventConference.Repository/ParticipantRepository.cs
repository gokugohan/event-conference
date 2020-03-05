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
    public class ParticipantRepository : RepositoryBase<Participant>, IParticipantRepository
    {
        public ParticipantRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Participant> GetAllParticipants()
        {
            return this.FindAll();
        }

        public async Task<IEnumerable<Participant>> GetAllParticipantsAsync()
        {
            return await this.RepositoryContext.Participants.ToListAsync();
        }

        public Participant GetParticipantById(Guid id)
        {
            return this.FindByCondition(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public async Task<Participant> GetParticipantByIdAsync(Guid id)
        {
            return await this.RepositoryContext.Participants.FindAsync(id);
        }
    }
}
