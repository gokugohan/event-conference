using EventConference.Web.Models.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EventConference.Web.Models
{
    public class SessionViewModelPagingInfo
    {
        public int? PageSize { get; set; }
        public StaticPagedList<SessionViewModel> Sessions { get; set; }
    }
}
