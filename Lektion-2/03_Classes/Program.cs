using _03_Classes.Models;

var customers = new List<Customer>();
    customers.Add(new Customer { FirstName = "Hans", LastName = "Mattin-Lassei", Email = "hans@domain.com" });
    customers.Add(new Customer { FirstName = "Tommy", LastName = "Mattin-Lassei", Email = "tommy@domain.com" });

foreach(var customer in customers)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName} ({customer.Email})");
}