/*
    Datatyper

    JS                                  C#
    ---------------------------------------------------------------------------------------------
    String                              string, char    
    Number                              int,uint,long,ulong,decimal,double,float
    NULL                                null
    Undefined                           
                                        dynamic
    Object                              object
                                        Array
                                        List
                                        
*/

/*  
    STRING - string, char  

    JS
    --------------------------------------------------------------------------------------
    var name = "Hans"
    var name = 'Hans'
    var name = `Hans`

    var firstChar = "H"
    var firstChar = 'H'
    var firstChar = `H`

    placeholders:
        var greeting = "Hej " + firstName + " " + lastName + "."
        var greeting = 'Hej ' + firstName + ' ' + lastName + '.'
        var greeting = `Hej ${firstName} ${lastName}.`

    escapers:
        var json = "{ \"firstName\": \"Hans\", \"lastName\": \"Mattin-Lassei\" }"    =>     var json = '{ "firstName": "Hans", "lastName": "Mattin-Lassei" }';
        var path = "C:\\Users\\HansMattin-Lassei\\Documents\\Utbildning\\NETFUND22\\netfund22-csandaspnet"
    

    C#
    --------------------------------------------------------------------------------------
    var name = "Hans";
    var firstChar = 'H';

    placeholders:
        var greeting = "Hej " + firstName + " " + lastName + ".";
        var greeting = $"Hej {firstName} {lastName}.";
        var greeting = string.Format("Hej {0} {1}.", firstName, lastName);
    
    escapers:
        var json = "{ \"firstName\": \"Hans\", \"lastName\": \"Mattin-Lassei\" }";
        var path = "C:\\Users\\HansMattin-Lassei\\Documents\\Utbildning\\NETFUND22\\netfund22-csandaspnet";
        var path = @"C:\Users\HansMattin-Lassei\Documents\Utbildning\NETFUND22\netfund22-csandaspnet";

 */


/* 
    Numbers - int, uint, long, ulong, decimal, double, float 
 
    JS
    ---------------------------------------------------------------------------------------
    age = 38
    Number age = 38

    pi = 3.14
    Number pi = 3.14


    C#
    ---------------------------------------------------------------------------------------
    int age = 38;                   heltal (32bit)
    uint age = 38;                  heltal utan minusvärden (32bit)
    long age = 38;                  heltal (64bit)
    ulong age = 38;                 heltal utan minsuvärden (64bit)


    floating pointers:
        double money_double = 0.0;

        decimal money_decimal = 0.0m;
        decimal money_decimal = 0.0M;

        float money_float = 0.0f;
        float money_float = 0.0F;
*/


/*  
    ARRAY - lista med fast antal positioner (som inte kan bli större eller mindre)

    JS
    ---------------------------------------------------------------------------------------
    const names = []
    names[0] = "Hans"
    names[1] = "Tommy"
    names[2] = 'Joakim'

    const numbers = [1, 2, 3]

    C#
    ---------------------------------------------------------------------------------------
    string[] names = new string[3];  
    names[0] = "Hans";
    names[1] = "Tommy";
    names[2] = "Joakim";

    int[] numbers = new int[] { 1, 2, 3 };

    string[] namesArray = new string[3];
    namesArray[0] = "Hans";
    namesArray[1] = "Tommy";
    namesArray[2] = "Joakim";
    foreach (var name in namesArray)
        Console.WriteLine(name);

    Console.WriteLine("");

    namesArray[1] = "";
    foreach (var name in namesArray)
        Console.WriteLine(name);



    LIST - Dynamiska listor
    
    JS
    ---------------------------------------------------------------------------------------
    Finns inte utan använd array



    C#
    ---------------------------------------------------------------------------------------
    List<string> names = new List<string>();
    List<int> numbers = new List<int>();


*/




Console.WriteLine("");




List<string> names = new List<string>();

// ADD
Console.WriteLine("ADD");
names.Add("Hans");
names.Add("Tommy");
names.Add("Joakim");
foreach (var name in names)
    Console.WriteLine(name);
Console.WriteLine("");

// INSER AT POSITION
Console.WriteLine("INSERT");
names.Insert(1, "Stefan");
foreach (var name in names)
    Console.WriteLine(name);
Console.WriteLine("");

// REMOVE
Console.WriteLine("REMOVE");
names.Remove("Tommy");
foreach (var name in names)
    Console.WriteLine(name);
Console.WriteLine("");


// SORT
Console.WriteLine("SORT (A-Z, Z-A)");
names.Sort();
foreach (var name in names)
    Console.WriteLine(name);
Console.WriteLine("");

names.Reverse();
foreach (var name in names)
    Console.WriteLine(name);
Console.WriteLine("");



// FILTER
Console.WriteLine("FILTER");
names = names.Where(name => name == "Hans").ToList();
foreach (var name in names)
    Console.WriteLine(name);
Console.WriteLine("");