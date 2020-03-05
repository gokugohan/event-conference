using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventConference.Entities.Models
{
    public class Gallery
    {
        [Key]
        [Column("GalleryId")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey(nameof(Event))]
        public Guid? EventId { get; set; }
        public virtual Event Event{ get; set; }
        public virtual ICollection<Media> Medias { get; set; }
        
    }
}