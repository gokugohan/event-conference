using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Models.Event
{
    public class EditEventViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name ="Title")]
        public string Title { get; set; }
        [Display(Name ="Sub-title")]
        public string SubTitle { get; set; }
        [Display(Name ="Url for video trailer")]
        public string TrailerVideoLink { get; set; }
        
        public string Quote { get; set; }
        public string Summary { get; set; }
        [Required]
        public string About { get; set; }
        [Required]
        public string When { get; set; }
        [Required]
        public string Venue { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        [Required]
        public string OrganizedBy { get; set; }
        [Required]
        public string EndorsedBy { get; set; }

        public string Description { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime CreatedAt { get; set; }

    }
}
