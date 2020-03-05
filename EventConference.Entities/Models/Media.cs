using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventConference.Entities.Models
{
    public class Media
    {
        [Column("MediaId")]
        public Guid Id { get; set; }
        public string ImagePath { get; set; } = "~/img/photo1.png";
        public string Name { get; set; } = "LOREM IPSUM DOLOR SIT AMET";
        [ForeignKey(nameof(Gallery))]
        public Guid? GalleryId { get; set; }
        public Gallery Gallery { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}