using MVCHomework1.Models.Domain;

namespace MVCHomework1.Models.Database
{
    public static class PizzaDatabase
    {

        public static List<Pizza> LIST_PIZZA = new List<Pizza>
        {
            new Pizza(1,Enum.PizzaType.Capricciosa,12),
            new Pizza(2,Enum.PizzaType.Margherita,14),
            new Pizza (3,Enum.PizzaType.QuattroStagioni,10),
            new Pizza (4,Enum.PizzaType.Diavola,17),
            new Pizza (5,Enum.PizzaType.Marinara,14)
        };

        public static List<User> USERS = new List<User>
        {
            new User(1,"Tom","Holand","Mil 81 road","+222 344 122"),
            new User(2,"Kevin","Dor","Bevetly 21 road","+222 222 222"),
            new User(3,"Elizabeth","Brown","Ewnue 10 ul","+222 124 154"),
        };

        public static List<Order> ORDERS = new List<Order>
        {
            new Order(1,12,false,2,1),
            new Order(2,14,false,1,2),
            new Order(3,17,false,3,4),
        };
    }
}
