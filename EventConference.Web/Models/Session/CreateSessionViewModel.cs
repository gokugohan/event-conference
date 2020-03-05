using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Models.Session
{
    public class CreateSessionViewModel
    {
        [Required]
        [Display(Name ="Day number")]
        public int DayNumber { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Abstract { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; } = DateTime.UtcNow;
        [Required]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTimeOffset StartTime { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTimeOffset EndTime { get; set; }

        public Guid SpeakerId { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
