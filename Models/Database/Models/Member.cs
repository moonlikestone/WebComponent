using System;
using System.Collections.Generic;

namespace WebComponent.Models
{
    public partial class Member
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public string LastLogIn { get; set; }
    }
}
