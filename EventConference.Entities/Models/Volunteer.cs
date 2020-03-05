using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventConference.Entities.Models
{
    public class Volunteer
    {
        [Key,Column("VolunteerId")]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public string Gender { get; set; }
        public string AgeRange { get; set; }
        public bool HasVolunteered { get; set; }
        public bool AgreeTermAndCondigion { get; set; }

        [ForeignKey(nameof(Event))]
        public Guid? EventId { get; set; }
        public Event Event { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
