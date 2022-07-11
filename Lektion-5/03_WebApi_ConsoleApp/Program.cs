using _03_WebApi_ConsoleApp.Models;
using System.Net.Http.Json;


while(true)
{
    Console.Clear();
    using (var client = new HttpClient())
    {
        var items = await client.GetFromJsonAsync<List<Product>>("https://localhost:7228/api/products");
        foreach (var item in items)
            Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Price}kr");
    }

    Console.ReadKey();
}


