using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentorOnDemand.Dto
{
    public class LoginDto
    {

        [Required]
        [EmailAddress]
        public string Email { get; internal set; }

        [Required]
        [MinLength(6)]
        public string Password { get; internal set; }
    }
}
