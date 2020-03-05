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
    public class FaqRepository : RepositoryBase<Faq>, IFaqRepository
    {
        public FaqRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Faq> GetAllFaqs()
        {
            return this.FindAll().OrderBy(f=>f.Id);
        }

        public async Task<IEnumerable<Faq>> GetAllFaqsAsync()
        {
            return await this.RepositoryContext.Faqs.ToListAsync();
        }
    }
}
