using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Camplify.Data.Users
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ServiceType { get; set; }
        
    }
}
