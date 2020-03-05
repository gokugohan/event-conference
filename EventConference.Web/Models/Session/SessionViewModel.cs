using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Models.Session
{
    public class SessionViewModel
    {
        [DisplayName("Session Id")]
        public Guid Id { get; set; }
        [DisplayName("Day Number")]
        public int DayNumber { get; set; }

        [DisplayName("Title")]
        public string Title { get; set; }
        [DisplayName("Abstract")]
        [DataType(DataType.MultilineText)]
        public string Abstract { get; set; }

        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; } = DateTime.UtcNow;

        [DisplayName("Start Time")]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt dd/MM/yyy}", ApplyFormatInEditMode =true)]
        public DateTimeOffset? StartTime { get; set; } = DateTimeOffset.UtcNow;
        [DisplayName("End Time")]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt dd/MM/yyy}", ApplyFormatInEditMode = true)]
        public DateTimeOffset? EndTime { get; set; } = DateTimeOffset.UtcNow;

        public TimeSpan Duration;

        public SpeakerViewModel Speaker { get; set; }

        public Guid SpeakerId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
