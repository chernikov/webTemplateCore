﻿using System.Collections.Generic;

namespace webTemplate.Web.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public List<string> Roles { get; set; }

    }
}
