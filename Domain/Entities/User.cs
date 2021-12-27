using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Disabled { get; set; }
        
        // Relations.
        public ICollection<UserRole> Roles { get; set; }
    }
}