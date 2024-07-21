namespace BasicOrderSystem.Domain.Entities
{
    // BasicOrderSystem.Domain/Entities/Product.cs
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ColorId { get; set; }
        public Size Size { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
    }
    public enum Size
    {
        Small = 1,
        Medium = 2,
        Large = 3,
        ExtraLarge = 4
    }
}
