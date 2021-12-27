using System.Collections.Generic;

namespace Domain.Entities
{
    public class Role
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        
        // Relation.
        public ICollection<User> Users { get; set; }
    }
}