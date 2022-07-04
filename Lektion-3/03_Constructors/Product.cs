using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors
{
    internal class Product
    {
        public Product()
        {

        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name, string? description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
