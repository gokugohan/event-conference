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
    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return this.FindAll().OrderBy(c => c.Name);
        }

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            return await this.RepositoryContext.Countries.ToListAsync();
        }
    }
}
