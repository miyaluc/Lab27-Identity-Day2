using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab27_miya.Models
{
    public class LogInViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email
        {
            get; set;
        }

        [Required]
        [StringLength(100, ErrorMessage = "Your password is too long. Must be 100 characters or less.", MinimumLength = 8)]
        //this will make the password hidden as soon it is typed
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password
        {
            get; set;
        }

        public bool RememberMe
        {
            get; set;
        }
    }
}
