using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventConference.Entities.Models
{
    public class Sponsor
    {
        [Key]
        [Column("SponsorId")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; } = "#!";

        public string ImagePath { get; set; } = "~/img/avatar.png";

        [ForeignKey(nameof(Event))]
        public Guid? EventId { get; set; }
        public Event Event { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
