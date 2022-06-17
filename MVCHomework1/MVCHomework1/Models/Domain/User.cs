namespace MVCHomework1.Models.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public User(int id, string name, string lastName, string adress, string phone)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Adress = adress;
            Phone = phone;
        }
    }
}
