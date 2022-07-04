/* 
    CONSTRUCTOR
    ----------------------------------------------------------------------------------------------
    En klass har alltid en konstruktor även om vi inte skriver ut en. Men en klass kan även ha
    specialgjorda konstruktorer för olika ändamål.

    ctor        <= förkortning för att skapa en konstruktor
 
    var product = new Product();
                      ---------                      en konstruktor

    var product = new Product("Product 1");
                      ---------------------          en konstruktor

    var product = new Product("Product 1", 100);
                      --------------------------     en konstruktor

    public class Product 
    {
        public Product() { }
        public Product(string name) { Name = name; }
        public Product(string name, decimal price) { Name = name; Price = price}
    }
*/

using _03_Constructors;

var product = new Product("Product 1", 1000);
Console.WriteLine($"{product.Name} ({product.Price}kr)");
