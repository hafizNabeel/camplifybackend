using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Camplify.Data.Users
{
    public class RegisterModel
    {
        //public string Username { get; set; }
        public string FullName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ServiceType { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}
