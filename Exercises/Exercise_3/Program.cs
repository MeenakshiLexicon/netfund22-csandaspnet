/*  
    1. lista en meny med olika alternativ
    2. lägga till en kund i listan
    3. lista upp alla kunder från listan
    4. ta bort en kund från listan
*/

List<string> customers = new();
ShowMenu();



void ShowMenu()
{
    do
    {
        Console.Clear();
        Console.WriteLine("1. Lägg till ny Kund");
        Console.WriteLine("2. Visa Kundlistan");
        Console.WriteLine("3. Ta bort en Kund");
        Console.Write("Välj ett av alernativen ovan: ");
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                AddToList();
                break;

            case "2":
                DisplayList();
                break;

            case "3":
                RemoveFromList();
                break;
        }
    } while (true);
}




void AddToList()
{
    Console.Clear();
    Console.WriteLine("Ny Kund");
    Console.WriteLine("------------");

    Console.Write("Ange namn: ");
    var name = Console.ReadLine();

    Console.Write("Ange adress: ");
    var address = Console.ReadLine();

    Console.Write("Ange e-postadress: ");
    var email = Console.ReadLine();

    var customer = $"{name}, {address} ({email})";
    customers.Add(customer);
}

void DisplayList()
{
    Console.Clear();
    Console.WriteLine("Kundlista");
    Console.WriteLine("------------");

    foreach (var customer in customers)
    {
        Console.WriteLine(customer);
    }

    Console.ReadKey();
}

void RemoveFromList()
{
    Console.Clear();
    Console.WriteLine("Ta bort Kund");
    Console.WriteLine("------------");

    Console.Write("Ange index på kunden du vill ta bort: ");
    var index = int.Parse(Console.ReadLine());

    customers.RemoveAt(index);
}