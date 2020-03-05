using EventConference.Entities.Models;
using EventConference.Web.Models.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Models
{
    public class HomeViewModel
    {
        public EventViewModel Event { get; set; }
        public IEnumerable<SpeakerViewModel> Speakers { get; set; }
        public IEnumerable<SessionByDayModel> SessionDays { get; set; }

        public IDictionary<string,string> Settings { get; set; }

        public IEnumerable<Venue> Venues { get; set; }
        public IEnumerable<FaqViewModel> Faqs { get; internal set; }

        public IEnumerable<VolunteerModelView> Volunteers { get; set; }

    }
}
