using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Methods
{

    internal class ProductService
    {
        private List<Product> products = new List<Product>();

        public void AddToList(Product product)
        {
            products.Add(product);
        }

        public void RemoveFromList(int id)
        {
            products = products.Where(x => x.Id != id).ToList();
        }

        public List<Product> GetList()
        {
            return products;
        }
    }
}
