﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop.API.Models.User
{
    public class UserDTO : LoginUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public ICollection<string> Roles { get; set; }

    }
}
