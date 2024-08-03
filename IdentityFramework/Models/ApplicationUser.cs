﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityFramework.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public byte[]? ProfilePicture { get; set; }


    }
}
