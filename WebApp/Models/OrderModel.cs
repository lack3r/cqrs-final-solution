namespace WebFrontend.Models
{
    public class OrderModel
    {
        public class OrderItem
        {
            public int MenuNumber { get; set; }
            public required string Description { get; set; }
            public int NumberToOrder { get; set; }
        }

        public required List<OrderItem> Items { get; set; }
    }
}