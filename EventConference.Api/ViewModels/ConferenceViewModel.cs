using System;

namespace EventConference.Api.ViewModels
{
    public class ConferenceViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string About { get; set; }

        public string When { get; set; }

        public string OrganizedBy { get; set; }
        public string EndorsedBy { get; set; }

        public VenueViewModel Venue { get; set; }
    }
}