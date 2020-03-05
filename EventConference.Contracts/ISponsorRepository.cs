using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Contracts
{
    public interface ISponsorRepository:IRepositoryBase<Sponsor>
    {
        IEnumerable<Sponsor> GetAllSponsors();
        Task<IEnumerable<Sponsor>> GetAllSponsorsAsync();

        Sponsor GetSponsorById(Guid id);
        Task<Sponsor> GetSponsorByIdAsync(Guid id);
    }
}
