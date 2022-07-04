using _04_Methods;

var productService = new ProductService();

productService.AddToList(new Product(1, "Product 1", "Description for product 1", 100, 10));
productService.AddToList(new Product(2, "Product 2", "Description for product 2", 200, 20));

foreach(var product in productService.GetList())
{
    Console.WriteLine($"{product.Name}");
}

productService.RemoveFromList(1);

foreach (var product in productService.GetList())
{
    Console.WriteLine($"{product.Name}");
}