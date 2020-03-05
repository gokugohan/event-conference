using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Api.ViewModels
{
    public class SessionViewModel
    {
        public Guid Id { get; set; }
        public int DayNumber { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTimeOffset StartTime { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTimeOffset EndTime { get; set; }

        public string Duration { get; set; }

        public SpeakerViewModel Speaker { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
