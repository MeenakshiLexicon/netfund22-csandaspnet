using Exersice_4.Services;

var menuService = new MenuService();

while (true)
{
    Console.Clear();
    Console.WriteLine("Menyalternativ");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("1. Visa produktkatalogen");
    Console.WriteLine("2. Visa produktinformation");
    Console.WriteLine("3. Lägg till en produkt");
    Console.WriteLine("4. Ta bort en produkt");
    Console.WriteLine("5. Spara produktkatalogen");
    Console.Write("Välj ett av följande alternativ: (1-5): ");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            menuService.ListMenu();
            break;
        case "2":
            menuService.DetailsMenu();
            break;
        case "3":
            menuService.CreateMenu();
            break;
        case "4":
            menuService.DeleteMenu();
            break;
        case "5":
            menuService.SaveMenu();
            break;
    }
}

