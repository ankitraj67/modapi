using MentorOnDemand.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentorOnDemand.Dto
{
    public class CourseDto
    {
        [Required]
        public Course Course { get; set; }
        [Required]
        public string UserId { get; set; }
    }
}
