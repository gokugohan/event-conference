using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Models
{
    public class VolunteerModelView
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string AgeRange { get; set; }
        public bool HasVolunteered { get; set; }
        public bool AgreeTermAndCondigion { get; set; }
    }
}
