using _00_Repetition.Models;
using _00_Repetition.Repositories;

IProductRepository productRepository = new ProductRepository();
productRepository.Create(new Product { Name = "Product 1", Price = 1000 });
productRepository.Create(new Product { Name = "Product 20", Price = 1000 });
productRepository.Create(new Product { Name = "Product 3", Price = 3000 });

foreach (var product in productRepository.Read())
    Console.WriteLine($"{product.Id} \t {product.Name} \t {product.Price}");
Console.WriteLine("");

productRepository.Update(2, new Product { Id = 2, Name = "Product 2", Price = 2000 });

foreach (var product in productRepository.Read())
    Console.WriteLine($"{product.Id} \t {product.Name} \t {product.Price}");
Console.WriteLine("");