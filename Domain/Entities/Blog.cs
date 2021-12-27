using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        
        // Relations.
        public ICollection<Post> Posts { get; set; }
    }
}