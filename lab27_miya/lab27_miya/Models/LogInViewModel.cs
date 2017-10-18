﻿using System;
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
