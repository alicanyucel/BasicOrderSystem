namespace BasicOrderSystem.Domain.Entities
{
    // BasicOrderSystem.Domain/Entities/Warehouse.cs
    public class Warehouse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public bool IsReadyForSale { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
    }

}
