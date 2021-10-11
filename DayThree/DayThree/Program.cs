using System;

static void Main(string[] args)
{
    User anonymousUser = new();
    User anotherUser = new("Steve", "Bob", "steveybob", 23, "steveybob@mail.com");
    Console.WriteLine(anonymousUser.GetInfo());
    anotherUser.SetForename("David");
    anotherUser.MobileTelephone = "34298742937";
    Console.WriteLine(anotherUser.GetInfo());
    // object initialisers          
    //User user = new User { forename="Dave", surname="Jones" };  
    //Console.WriteLine(user.GetInfo());         
    // object initialiser with constructor call   
    //User user2 = new User("Bob", "Jones") { age = 35, email = "bob.jones@mail.com" };       
    //Console.WriteLine(user2.GetInfo());        }
}
/*using System;

namespace DayThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime dt = DateTime.Now;

            Console.WriteLine($"Todays date is {dt.DayOfWeek} {dt.Day}");

            //string input = Console.ReadLine();
            //DateTime dt2 = DateTime.Parse(input);
            //Console.WriteLine(dt2);
            //Console.WriteLine(dt2.ToString("dd/MM/yyyy"));

            //User archie = new User("archie","ward","ward");
            Car ferrari = new Car("ferrari", "ferrari");
            User uknown = new User("uknown", "uknown", "uknown");
            

            //archie.forename = "archie";
            //archie.surname = "ward";
            //archie.nickname = "ragweed";
            //archie.age = 22;
            //archie.email = "wardar@outlook.com";

            ferrari.manufacturer = "Ferrari";
            ferrari.model = "italia";
            ferrari.dateManufactured = "2004";
            
            var carinfo = ferrari.GetInfo();
            Console.WriteLine(carinfo);
            //archie.printInfo();
            Console.WriteLine(uknown.age);
        }
    }
}
*/