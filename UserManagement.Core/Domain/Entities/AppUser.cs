﻿using Microsoft.AspNetCore.Identity;

namespace UserManagement.Core.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
