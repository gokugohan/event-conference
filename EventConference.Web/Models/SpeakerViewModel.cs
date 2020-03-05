using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Models
{
    public class SpeakerViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public CountryViewModel Country { get; set; }

        public string Description { get; set; }

        public string Biography { get; set; }
        public string Website { get; set; } = "#!";

        public string Twitter { get; set; } = "#!";
        public string Facebook { get; set; } = "#!";
        public string LinkedIn { get; set; } = "#!";

        [DisplayName("Full Description")]
        public string FullDescription { get; set; }

        public string Avatar { get; set; } = "/img/goku.png";

        public DateTime CreatedDate { get; set; }
    }
}
