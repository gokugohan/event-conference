using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Contracts
{
    public interface ICountryRepository:IRepositoryBase<Country>
    {
        IEnumerable<Country> GetAllCountries();
        Task<IEnumerable<Country>> GetAllCountriesAsync();
    }
}
