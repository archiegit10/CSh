using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Movie
    {

        private string name;
        public string Name { get => name; set => name = value; }
        private double rating;
        public double Rating { get => rating; set => rating = value; }
        private string genre;
        public string Genre { get => genre; set => genre = value; }
        private DateTime? releaseDate;
        public DateTime? ReleaseDate { get => releaseDate; set => releaseDate = value; }
        private int runTime;
        public int RunTime { get => runTime; set => runTime = value; }
        public int movieID;

        public string GetInfo()
        {
            return $"---------------------------\nMovie Name: {name}\nGenre: {Genre}\nRelease Date: {releaseDate}\nRating: {rating}\nRun time: {runTime}\nID: {movieID}";
        }

        public Movie(string name = "unknown", double rating = 0.0, String genre = "uknown", int runTime = 0, DateTime? releaseDate = null, int movieID = 0)
        {
            this.name = name;
            this.rating = rating;
            this.genre = genre;
            this.releaseDate = releaseDate;
            this.runTime = runTime;
            this.movieID = movieID;
        }
    }
}