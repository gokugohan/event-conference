using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Entities.Models
{
    public class SessionParticipant
    {
        public Guid ParticipantId { get; set; }
        public Participant Participant { get; set; }
        public Guid SessionId { get; set; }
        public Session Session { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
