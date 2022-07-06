/*  
    INTERFACE
    ----------------------------------------------------------------------------------------------------
    Ett interface är ett kontrakt där man specificerar upp vilka metoder som man ska få tillgång till
 
    Vissa kaller de här sakerna för:
    Handlers, Managers, Helpers, Services, Repositories (Repository Pattern). 
*/



using _01_Interfaces.Services;



IUserService userService = new UserService();
userService.Create("Hans", "Mattin-Lassei", "hans@domain.com");
userService.Create("Tommy", "Mattin-Lassei", "tommy@domain.com");

foreach(var user in userService.GetAllUsers())
    Console.WriteLine($"# {user.Id} \t {user.FirstName} {user.LastName} ({user.Email})");




IProductService productService = new ProductService();
productService.Create("Product 1", "Description for product 1", 100);
productService.Create("Product 2", "Description for product 2", 200);

foreach(var product in productService.GetAllProducts())
    Console.WriteLine($"# {product.Id} \t {product.Name} ({product.Price} SEK)");