using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment.Models.Domain
{
    public class EventTag : Record
    {
        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        //public virtual Event Event { get; set; }

        //public string EventId { get; set; }
    }
}
