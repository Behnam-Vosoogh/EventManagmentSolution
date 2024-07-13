using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment.Models.Domain
{
    public class JobApplication : Record
    {
        public JobApplication()
        {
            ApplicationDate = DateTime.UtcNow;
        }

        public string Position { get; set; }

        public string Description { get; set; }

        public string CvUrl { get; set; }

        public JobApplicationStatus Status { get; set; }

        public virtual UserProfile AppliedUser { get; set; }

        [ForeignKey(nameof(AppliedUser))]
        public string AppliedUserId { get; set; }

        public virtual UserProfile Organizer { get; set; }

        [ForeignKey(nameof(Organizer))]
        public string OrganizerId { get; set; }

        public DateTime ApplicationDate { get; set; }
    }
    public enum JobApplicationStatus
    {
        Pending = 0,
        Reviewing = 1,
        Rejected = 2,
        Accepted = 3
    }
}
