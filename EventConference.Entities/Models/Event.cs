using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventConference.Entities.Models
{
    public class Event
    {
        [Key,Column("EventId")]
        public Guid Id { get; set; }
        public string Title { get; set; } = "The best geology conference on the planet” - <span>IPG-IP.</span>";
        public string SubTitle { get; set; } = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
        public DateTime Date { get; set; }
        public string TrailerVideoLink { get; set; } = "https://www.youtube.com/watch?v=jDDaplaOz7Q";
        public string HeaderBanner { get; set; }
        public string Quote { get; set; } = "The best geology conference on the planet” - <span>IPG-IP</span>";
        public string Summary { get; set; } = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
        public string About { get; set; } = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

        public string When { get; set; } = "Monday to Wednesday<br>10-12 December";

        public string Venue { get; set; } = "Díli Convention Center, Mercado Lama, Caicoli, Timor-Leste";
        public string Latitude { get; set; } = "-8.560096";
        public string Longitude { get; set; } = "125.579218";
        public string OrganizedBy { get; set; } = "IPG-IP";
        public string EndorsedBy { get; set; } = "IPG-IP";

        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public bool Active { get; set; }
        public virtual ICollection<Gallery> Galleries { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<Speaker> Speakers{ get; set; }
        public virtual ICollection<Sponsor> Sponsors { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }

    }
}
