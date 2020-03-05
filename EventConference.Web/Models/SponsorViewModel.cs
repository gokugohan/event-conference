using EventConference.Web.Models.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Models
{
    public class SponsorViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; } = "#!";

        public string ImagePath { get; set; } = "~/img/avatar.png";

        public Guid? EventId { get; set; }
        public EventViewModel Event { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
