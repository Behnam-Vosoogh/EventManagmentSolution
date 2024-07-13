using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment.Models.Domain
{
    public class EventImage : Record
    {
        [Required]
        [StringLength(256)]
        public string ImageUrl { get; set; }

        [StringLength(256)]
        public string ThumpUrl { get; set; }

        public virtual Event Event { get; set; }

        public string EventId { get; set; }
    }
}
