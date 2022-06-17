using MVCHomework1.Models.Enum;

namespace MVCHomework1.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }

        public PizzaType Name { get; set; }

        public decimal Price { get; set; }

        public Pizza(int id, PizzaType name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
