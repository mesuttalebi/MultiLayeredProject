namespace Domain.Entities
{
    public class UserRole
    {
        public int RoleId { get; set; }
        public string UserId { get; set; }
        
        // Relations.
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}