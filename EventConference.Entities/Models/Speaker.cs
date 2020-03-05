using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventConference.Entities.Models
{
    public class Speaker
    {

        [Key]
        [Column("SpeakerId")]
        public Guid Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public string Description { get; set; }

        public string Biography { get; set; }
        public string Website { get; set; } = "#!";

        public string Twitter { get; set; } = "#!";
        public string Facebook { get; set; } = "#!";
        public string LinkedIn { get; set; } = "#!";
        public string FullDescription { get; set; }

        public string Avatar { get; set; } = "/img/goku.png";

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey(nameof(Event))]
        public Guid? EventId { get; set; }
        public Event Event { get; set; }

    }
}
