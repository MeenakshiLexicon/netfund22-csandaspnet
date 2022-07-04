/* 
    DATA TYPES - Integrals
    -------------------------------------------------------------------------------------------------------------
    sbyte       8 bit           -128                                127
  * byte        8 bit           0                                   255
    short       16 bit          -32768                              32767
    ushort      16 bit          0                                   65535
  * int         32 bit          -2147483648                         2147483647
    uint        32 bit          0                                   4292967295
  * long        64 bit          -9223372036854775808                9223372036854775807
    ulong       64 bit          0                                   18446744073709551615

    Int16       16 bit          samma som short
    Int32       32 bit          samma som int
    Int64       64 bit          samma som long

    byte = 1;
    int age = 38;
    long total = 2147483648;

    
    DATA TYPES - Floating points
    -------------------------------------------------------------------------------------------------------------
  * float       4 bytes         6-9 digits              f eller F       lämplig för machine learning
    double      8 bytes         15-16 digits            d eller D       lämplig för optimering av prestanda
  * decimal     16 bytes        28-29 digits            m eller M       lämplig för finansiella tal såsom pengar

    float pi = 3.14f;
    double pi = 3.14;
    decimal pi = 3.14m;


    DATA TYPES - Boolean
    -------------------------------------------------------------------------------------------------------------
  * bool        1 bit           false/true
  
    bool isEnabled = false;

    
    DATA TYPES - Global Unique Identifier (GUID/UUID)
    -------------------------------------------------------------------------------------------------------------
  * Guid        16 bytes        Guid.NewGuid();         47403c55-2d2e-4702-b9d9-0e5fa9cc9384    

    Guid userId = Guid.NewGuid();


    DATA TYPES - Boolean
    -------------------------------------------------------------------------------------------------------------
    char        16 bit           ASCII/UTF-8 (unicode)
  * string      64 bit           ASCII/UTF-8 (unicode)   


    string citat = "Hans är \"bäst\" i världen.";
    string citat = "Hans är 'bäst' i världen.";
    string json = "{ \"firstName\": \"Hans\", \"lastName\": \"Mattin-Lassei\" }";

    string firstName = "Hans";
    string lastName = "Mattin-Lassei";

    string placeholder = "Hej jag heter Hans Mattin-Lassei.";
    string placeholder = "Hej jag heter " + firstName + " " + lastName + ".";
    string placeholder = string.Format("Hej jag heter {0} {1}", firstName, lastName);
    string placeholder = $"Hej jag heter {firstName} {lastName}.";

    string path = "C:\\Users\\HansMattin-Lassei\\Documents\\Utbildning\\NETFUND22\\netfund22-csandaspnet";
    string path = @"C:\Users\HansMattin-Lassei\Documents\Utbildning\NETFUND22\netfund22-csandaspnet";



    LIST - dynamisk lista (länkad lista)
    -------------------------------------------------------------------------------------------------------------  
    List<int> numbers = new List<int>();
    List<string> names = new List<string>();
    
    List<string> users = new();
    var users = new List<string>();
    

        // initialize list (new instance)
        List<string> names = new List<string>();

        // Add to list
        names.Add("Hans");                  // position 0
        names.Add("Tommy");                 // position 1
        names.Add("Joakim");                // position 2

        // Insert into list
        names.Insert(1, "Haithem");

        // Sort list
        names.Sort();                       // A-Ö
        names.Reverse();                    // Ö-A

        // Filter
        names = names.Where(name => name == "Hans").ToList();

        // Remove from list
        names.Remove("Hans");
        names.RemoveAt(1);
        names.Clear();


        foreach (var name in names)
            Console.WriteLine(name);



    ARRAY - en fast lista
    -------------------------------------------------------------------------------------------------------------  
    string[] names = new string[];


        string[] names = new string[5];

        names[0] = "Hans";
        names[1] = "Tommy";
        names[2] = "Joakim";
        names[3] = "Haithem";
        names[4] = "Stefan";

        names = names.Where(name => name == "Hans").ToArray();

        foreach (var name in names)
            Console.WriteLine(name);
*/

