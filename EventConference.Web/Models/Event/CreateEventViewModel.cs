using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Models.Event
{
    public class CreateEventViewModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string TrailerVideoLink { get; set; }
        public string Quote { get; set; }
        public string Summary { get; set; }
        public string About { get; set; }

        public string When { get; set; }

        public string Venue { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string OrganizedBy { get; set; }
        public string EndorsedBy { get; set; }

        public string Description { get; set; }
    }
}
