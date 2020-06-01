namespace BronsonHolland_CE09
{
    public class Customer
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Customer(string name)
        {
            this.Name = name;
        }
        public Customer(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
