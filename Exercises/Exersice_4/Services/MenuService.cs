using Exersice_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice_4.Services
{
    internal class MenuService
    {
        private readonly ProductService productService = new ProductService(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\productCatalog.json");

        #region Helpers
        private void Header(string headline)
        {
            Console.Clear();
            Console.WriteLine(headline);
            Console.WriteLine("---------------------------------------");
        }

        private void Message(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        #endregion

        #region Menus

        public void CreateMenu()
        {
            Header("Lägg till en ny Produkt");

            var product = new Product();

            Console.Write("Namn: ");
            product.Name = Console.ReadLine() ?? "";

            Console.Write("Beskrivning: ");
            product.Description = Console.ReadLine() ?? "";

            Console.Write("Pris (SEK): ");
            product.Price = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Antal i lager: ");
            product.QuantityInStock = int.Parse(Console.ReadLine() ?? "0");

            productService.Create(product);
            Message("Produkten har lagts till i produktkatalogen.");
        } 

        public void DeleteMenu()
        {
            Header("Ta bort en Produkt");
            Console.WriteLine("Ange det Id på den produkt du vill ta bort");
            Console.Write("Id: ");
            var id = Console.ReadLine() ?? "";

            try
            {
                productService.Delete(Guid.Parse(id));
                Message("Produkten har tagits bort från produktkatalogen.");
            }
            catch
            {
                Message("Något fick fel när produkten skulle tas bort.");
            }
            

        }

        public void DetailsMenu()
        {
            Header("Produktinformation");
            Console.WriteLine("Ange det Id på den produkt se");
            Console.Write("Id: ");
            var id = Console.ReadLine() ?? "";

            try
            {
                var product = productService.Details(Guid.Parse(id));
                if(product != null)
                {
                    Header("Produktinformation");
                    Console.WriteLine($"Id: {product.Id}");
                    Console.WriteLine($"Namn: {product.Name}");
                    Console.WriteLine($"Pris (SEK): {product.Price}");
                    Console.WriteLine($"Antal i lager: {product.QuantityInStock}");
                    Console.WriteLine($"Beskrivning: {product.Description}");

                    Message("");
                }
                else
                {
                    Message("Produkten du söker hittades inte.");
                }
            }
            catch
            {
                Message("Du måste ange ett giltigt id.");
            }
        }

        public void ListMenu()
        {
            Header("Produktkatalog");
            foreach(var product in productService.ProductCatalog())
            {
                Console.WriteLine($"({product.Id}) \t {product.Name} \t {product.ShortDescription}");
            }
            Message("");
        }

        public void SaveMenu()
        {
            Header("Spara produktkatalogen");

            productService.Save();
            Message("Produktkatalogen har blivit sparad");
        }

        #endregion
    }
}
