namespace BasicOrderSystem.Domain.Entities
{
    // BasicOrderSystem.Domain/Entities/Role.cs
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
    }

}
