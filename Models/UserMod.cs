using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentorOnDemand.Models
{
    public class UserMod : IdentityUser
    {
        
        public string Firstname { get; set; }
       
        public string Password { get; set; }
        
        public string Skill { get; set; }
        public string Experience { get; set; }
        public string Timing { get; set; }

    }
}


   
   