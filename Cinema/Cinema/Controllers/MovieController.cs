using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    class MovieController
    {
        private readonly IList<Movie> movies;

        public MovieController() => movies = new List<Movie>();

        public void CreateMovie()
        {

            //retrieve method from service
        }

        public void ReadMovies()
        {
            foreach(var movie in movies)
            {
                Console.WriteLine(movie.GetInfo());
            }
        }
        public void DeleteMovie()
        {
            Console.WriteLine("Enter the ID of the movie to delete");
            int delMovie = Utilities.GetIntput();
            foreach(var movie in movies)
            {
                if (delMovie == movie.movieID)
                {
                    Console.WriteLine($"Deleted Movie: {movie.Name} with ID {movie.movieID}");
                }            
            }
        }


    }
}
