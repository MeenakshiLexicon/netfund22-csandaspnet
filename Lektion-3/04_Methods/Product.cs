namespace _04_Methods
{
    internal class Product
    {
        public Product()
        {

        }

        public Product(int id, string name, string description, decimal price, int quantityInStock)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
