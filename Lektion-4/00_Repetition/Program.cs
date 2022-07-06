/*  
    ACCESS MODIFIERS (Encapsulation - Objektorienterad Programmering OOP)
    -----------------------------------------------------------------------------------------------------------------------------
    public                      något är accessbart överallt - oavsett om det är i relationer eller projekt (assemblies)
    internal                    accessbart överallt inom det egna projektet (assembly)
    protected                   accessbart endast genom ett arv (ChildClass : ParentClass)
    private                     accessbart endast inom kodblocket ({})
    protected internal          (specialfall - behöver du inte lägga ner någon energi på)
    private protected           (specialfall - behöver du inte lägga ner någon energi på)
 
    * En klass kan bara vara public eller internal, den kan alltså aldrig vara protected eller private
    * Ett field/property/method kan vara public, internal, protected eller private
     
    * void innebär att en metod inte ska retunera något värde när den är klar, om den ska retunera något så måste man sätta
      dit vilken datatyp som ska retuneras.
    * en metod kan ta emot en eller flera olika inputs genom att man skickar in det i parantesen SetName(string name)
    
    camelCase       =       fields, variabler, inputs eller outputs i methoder      ex. firstName (_firstName om den är private)
    Pascal          =       Properties, Methods                                     ex. FirstName
    snake_case      =       SETTINGS_KEY_VALUE_PAIR i konfigurationsfiler           ex. SQL_CONNECTIONSTRING

    
    GETTERS AND SETTERS (LÄS/SKRIV)
    -----------------------------------------------------------------------------------------------------------------------------
    GET         LÄSA/HÄMTA/SE/ANVÄNDA           var firstName = user.FirstName;         Console.WriteLine(user.FirstName);
    SET         SKRIV/SÄTTA/SPARA               user.FirstName = firstName;             user.FirstName = "Hans";

                                                       GET                                     SET
                                                       ------------------------------------------------------------------------
    public string FirstName { get; set; }              Console.WriteLine(user.FirstName);      user.FirstName = "Hans";
    public string FirstName { get; private set; }      Console.WriteLine(user.FirstName);      FirstName = "Hans";
    
    public string DisplayName => $"{FirstName}";       Console.WriteLine(user.DisplayName);
    public string DisplayName { get; } = FirstName;    Console.WriteLine(user.DisplayName);         

 
    CONSTRUCTORS (förkortning ctor)
    ---------------------------------------------------------------------------------------------------------------------------
    En klass har alltid en konstruktor även om vi inte skriver ut en, men då har den inga argument med sig in. i C#
    så kan en klass ha flera konstruktorer som har olika argument så vi får mer valmöjligheter när vi skapar en klass.
 
    var user = new User();                              <- En konstruktor som inte har några argument ()
                   ------   
    var user = new User("Hans");                        <- En konstruktor som har ett argument (string firstName)
                   ------------   
    var user = new User("Hans", "Mattin-Lassei");       <- En konstruktor som har två argument (string firstName, string lastName)
                   -----------------------------  

 
    Googla genom att skriva:
        C# access modifiers
        C# get set
        C# constructor
 
    GoTo sidor:
        docs.microsoft.com
        stackoverflow.com
        youtube.com
*/

namespace _00_Repetition
{
    public class User
    {
        //constructor(s)

        public User()
        {
            // var user = new User();
            // var user = new User() { FirstName = "Hans" };
        }

        public User(string firstName)
        {
            //var user = new User("Hans");
            FirstName = firstName;
        }

        public User(string firstName, string lastName)
        {
            //var user = new User("Hans", "Mattin-Lassei");
            FirstName = firstName;
            LastName = lastName;
        }


        //fields
        private string _firstName;

        //Property
        public string FirstName { get; set; }
        public string LastName { get; private set; }

        // Methods
        public void SetDisplayName(string firstName, string lastName)
        {
            if (firstName == _firstName) { }

            FirstName = firstName;
            LastName = lastName;
        }
        public string GetDisplayName()
        {
            return $"{FirstName} {LastName}";
        }
    }






    public class Program
    {
        public static void Main()
        {
            var user1 = new User()
            {
                FirstName = "Hans",
                //LastName = "Mattin-Lassei"  <- går inte att göra pga private set;
            };
            Console.WriteLine(user1.GetDisplayName());

            var user2 = new User();
            user2.FirstName = "Hans";
            //user2.LastName = "Mattin-Lassei";    <- går inte att göra pga private set;
            Console.WriteLine(user2.GetDisplayName());

            var user3 = new User("Hans");
            Console.WriteLine(user3.GetDisplayName());

            var user4 = new User("Hans", "Mattin-Lassei");
            Console.WriteLine(user4.GetDisplayName());
        }
    }
}
