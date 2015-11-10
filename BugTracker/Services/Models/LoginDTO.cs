using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugTracker.Services.Models
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Username is required. Please enter username.")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Password is required. Please enter password.")]
        public string password { get; set; }
    }
}