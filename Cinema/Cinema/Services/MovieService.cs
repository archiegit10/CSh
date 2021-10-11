using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Services
{
    class MovieService
    {
        private IList<Movie> movies;
        
        public MovieService()
        {
            movies = new List<Movie>();
        }
        internal Movie Create(Movie movie)
        {
            Console.WriteLine("What is the movie called?");
            string name = Utilities.GetInput();
            Console.WriteLine("What is the genre of the movie?");
            string genre = Utilities.GetInput();
            Console.WriteLine("What is the movie run time?");
            int runTime = Utilities.GetIntput();
            Console.WriteLine(runTime);
            Console.WriteLine("When was the movie released?");
            DateTime releaseDate = Utilities.GetDateput();
            Console.WriteLine("What is the movie rating?");
            double rating = Utilities.GetDoubleput();
            Console.WriteLine("What is the movie ID?");
            int movieID = Utilities.GetIntput();

            Movie newMovie = new Movie(name, rating, genre, runTime, releaseDate, movieID);
            movies.Add(newMovie);
            Console.WriteLine($"Created new movie of {newMovie}");
            return movie;
        }

        internal Movie Read(Movie movies)
        {
            return movies;
        }


    }
}
