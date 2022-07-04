/* 
    WHILE - när vi vill kolla ett tillstånd före innan vi gör något
    ----------------------------------------------------------------------- 
    while(condition) { }

    int counter = 0;
    while (counter < 10)
    {
        Console.WriteLine("Do something...");
        counter++;
    }


    DO WHILE - vi kör en sak minst en gång och sen kollar vi tillståndet
    ----------------------------------------------------------------------- 
    do { } while(condition);

    int counter = 0;
    do
    {
        Console.WriteLine("Do something...");
        counter++;
    } while (counter < 10);
*/

/*  
    FOR - loopar ett givet antal gånger
    -----------------------------------------------------------------------
    for(initialize; condition; increment) { }
 
    string[] names = new string[3];
    names[0] = "Hans";
    names[1] = "Tommy";
    names[2] = "Anki";


    for (int i = 0; i < names.Length; i++)
    {
        Console.WriteLine(names[i]);
    }
 
*/

/*  
    FOREACH - loopar igenom en hel lista/array
    -----------------------------------------------------------------------
    foreach(datatype item in list/array) { }

    string[] names = new string[3];
    names[0] = "Hans";
    names[1] = "Tommy";
    names[2] = "Anki";

    foreach(var name in names)
    {
        Console.WriteLine(name);
    }
 
*/









Console.ReadKey();