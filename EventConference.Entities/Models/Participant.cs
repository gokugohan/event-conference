using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventConference.Entities.Models
{
    public class Participant
    {
        [Key,Column("ParticipantId")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<SessionParticipant> SessionParticipants { get; set; }
    }
}
