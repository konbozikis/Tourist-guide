﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TouristGuide_Core
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<UserHistory> History { get; set; }

    }
}
