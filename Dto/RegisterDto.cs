using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentorOnDemand.Dto
{
    public class RegisterDto
    {      
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Select { get; set; }
        public string PhoneNumber { get; set; }
        public string Experience { get; set; }
        public string Time { get; set; }
        public int Role { get; set; }
    }
}

   
    
    
   
   