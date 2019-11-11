using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorOnDemand.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fee { get; set; }
        public string Details { get; set; }
        public string Timing { get; set; }
        public IdentityUser User { get; set; }
    }
}


