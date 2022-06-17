namespace MVCHomework1.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public bool IsDelivered { get; set; }

        public int UserId { get; set; }

        public int PizzaId { get; set; }

        public Order(int id, decimal price, bool isDelivered, int userId,int pizzaid)
        {
            Id = id;
            Price = price;
            IsDelivered = isDelivered;
            UserId = userId;
            PizzaId = pizzaid;
        }
    }
}
