using Cinema.Controllers;
using System;

namespace Cinema
{
    class Program
    {

        static void Main(string[] args)
        {
            SubMenu();


        }
        public static void SubMenu()
        {
            Console.WriteLine("1. Movies\n2. Quit");

            string input = Utilities.GetInput();
            switch (input)
            {
                case "1":
                    MovieSubMenu();
                    break;
                case "2":
                    break;    
            }
        }
        public static void MovieSubMenu()
        {
            MovieController movieControl = new MovieController();
            bool a = true;
            while (a)
            {
                Console.WriteLine("Movies\n1. Read all movies\n2. Create movie\n3. Delete movie\n4. Go back");
                string input = Utilities.GetInput();
                switch (input.ToUpper())
                {
                    case "1" or "READ":
                        //Controller to read movies
                        movieControl.ReadMovies();
                        break;
                    case "2" or "CREATE":
                        //controller to create movie
                        movieControl.CreateMovie();
                        break;
                    case "3" or "DELETE":
                        //controller to delete movie
                        movieControl.DeleteMovie();
                        break;
                    case "4" or "BACK":
                        SubMenu();
                        a = false;
                        break;
                }
            }
        }
    }
}
