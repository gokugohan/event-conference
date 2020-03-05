using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Models.Event
{
    public class EventViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("Event Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [DisplayName("Header Banner Image")]
        public string HeaderBanner { get; set; }
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

        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public IEnumerable<SpeakerViewModel> Speakers { get; set; }
        public IEnumerable<SponsorViewModel> Sponsors { get; set; }

    }
}
