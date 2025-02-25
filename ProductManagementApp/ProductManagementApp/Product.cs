namespace ProductManagementApp
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(string id, string name, decimal price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price:c} (stock: {Stock})";
        }
    }
}
