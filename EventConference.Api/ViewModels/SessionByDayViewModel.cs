using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Api.ViewModels
{
    public class SessionByDayViewModel
    {
        public int DayNumber { get; set; }
        public IEnumerable<SessionViewModel> Sessions { get; set; }
    }
}
