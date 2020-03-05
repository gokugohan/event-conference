using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Contracts
{
    public interface IFaqRepository:IRepositoryBase<Entities.Models.Faq>
    {
        IEnumerable<Faq> GetAllFaqs();
        Task<IEnumerable<Faq>> GetAllFaqsAsync();
    }
}
