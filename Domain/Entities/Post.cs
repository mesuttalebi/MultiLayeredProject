using System;

namespace Domain.Entities
{
    // POCO - Plain Old Csharp Object
    // Repository Pattern
    // DTO => { User.Name, Post.Title, Blog.Name, Post.CreateDate }
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public int ViewCount { get; set; }
        public bool Published { get; set; }
        
        // Relations.
        public virtual Blog Blog { get; set; }
    }
}