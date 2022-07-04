/*  
    GETTER AND SETTER   (Read-Write)
    --------------------------------------------------------------------
    SET         SKRIV/SPARA         product.Name = "Product 1";
    GET         HÄMTA/LÄS           Console.WriteLine(product.Name);
 
    public string Name { get; set; }            <=      Läs och skrivrättigheter
    public string Name { get; private set; }    <=      Läs men får bara skriv ett värde inom det egna kodblocket {}
                                                        som att använda en metod för att sätta värdet

    public string Name { get; } = "";
    public string Name => "";


    public string Name { get; set; } = null!;           <= Måste ha ett värde
    public string? Name { get; set; }                   <= Får vara tom (null)
 
*/

using _02_GettersSetters;

var product = new Product();

product.Name = "Product 1";
Console.WriteLine(product.Name);