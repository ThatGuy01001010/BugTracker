using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Domain.Models
{
    public class Bug
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public string AssignedUser { get; set; }
        public string Status { get; set; }
        public List<Bug> Related { get; set; }
        public List<string> Attachments { get; set; }

    }
}