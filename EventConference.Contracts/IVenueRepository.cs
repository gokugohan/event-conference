using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Contracts
{
    public interface IVenueRepository:IRepositoryBase<Venue>
    {
        IEnumerable<Venue> GetAllVenues();
        Task<IEnumerable<Venue>> GetAllVenuesAsync();

        Venue GetVenueById(Guid id);
        Task<Venue> GetVenueByIdAsync(Guid id);
    }
}
