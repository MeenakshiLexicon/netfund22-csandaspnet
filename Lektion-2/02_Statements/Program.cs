/* 
    IF-STATEMENT - kollar eller eller flera olika tilstånd och om det är sant så....
    -------------------------------------------------------------------------------------
    if (condition) {}
    if (condition) {} else {}
    if (condition) {} else if (condition) else {}

    if ((condition 1) || (condition 2)) {}
    if ((condition 1) && (condition 2)) {}

    (condition) ? whentrue : else



    string name = "Anki";

    if (name == "Hans")
    {
        Console.WriteLine("Hej " + name);
    }
    else if (name == "Tommy")
    {
        Console.WriteLine("Hej och välkommen tillbaka " + name);
    }
    else
    {
        Console.WriteLine($"Hej {name}. Dig har jag inte träffat förut.");
    }
 
*/


/* 
    SWITCH - kollar ett tillstånd om det är sant och om det är sant så....
    -------------------------------------------------------------------------------------
 
    switch(value) 
    {
        case value :
            do something
            break;
    }


    string name = "Anki";

    switch (name)
    {
        case "Hans":
            Console.WriteLine("Hejsan Hans");
            break;

        case "Tommy":
            Console.WriteLine("Hej där Tommy");
            break;

        default:
            Console.WriteLine("Hejsan");
            break;

    }

*/



Console.ReadKey();