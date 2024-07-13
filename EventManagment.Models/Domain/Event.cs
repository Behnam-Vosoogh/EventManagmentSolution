using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment.Models.Domain
{
    public class Event : Record
    {
        public Event()
        {
            CreatedOn = DateTime.UtcNow;
        }

        [Required]
        [StringLength(80)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [StringLength(256)]
        public string CoverImageUrl { get; set; }

        [Required]
        [StringLength(256)]
        public string Location { get; set; }

        public int TicketsCount { get; set; }

        public int Views { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual UserProfile UserProfile { get; set; }

        public string UserProfileId { get; set; }

        public virtual List<EventTag> EventTags { get; set; }
        public virtual List<EventImage> EventImages { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<WishlistEvent> WishlistEvents { get; set; }
        public virtual List<Like> Likes { get; set; }


    }
}
