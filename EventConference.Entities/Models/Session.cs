using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventConference.Entities.Models
{
    public class Session
    {
        [Key]
        [Column("SessionId")]
        public Guid Id { get; set; }
        public int DayNumber { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }

        public DateTime Date { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }

        public TimeSpan Duration => EndTime?.Subtract(StartTime ?? EndTime ?? DateTimeOffset.MinValue) ?? TimeSpan.Zero;

        [ForeignKey(nameof(Speaker))]
        public Guid? SpeakerId { get; set; }
        public Speaker Speaker { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey(nameof(Event))]
        public Guid? EventId { get; set; }
        public Event Event { get; set; }
        public ICollection<SessionParticipant> SessionParticipants { get; set; }

    }

    public class SessionByDayModel
    {
        public int DayNumber { get; set; }
        public IEnumerable<Session> Sessions { get; set; }

    }
}
