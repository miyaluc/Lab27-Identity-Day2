using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab27_miya.Models
{
    //remember to add properties for firstname and lastname as they are not included in IdentityUser
    public class ApplicationUser : IdentityUser
    {
        public string Circumstances
        {
            get; set;
        }
    }
}
