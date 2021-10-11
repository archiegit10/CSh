using System;
using System.Collections.Generic;
using System.Collections;
namespace DaySix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Movie shawshank = new Movie("Shawshank redemption", 9.9, "Drama", 100, new DateTime(1990,10,10));
            Console.WriteLine(shawshank.GetInfo());
            shawshank.ReleaseDate = new DateTime(1990, 5, 30);
            Console.WriteLine(shawshank.GetInfo());


            //string input = Utilities.GetInput();
            //Console.WriteLine(input);

            /*
            int[] arr = { 1, 2, 3, 4 };
            CustomArrayList arrList = new CustomArrayList(arr);
            arrList.PrintValues();
            arrList.Add(5);
            arrList.PrintValues();
            */

        }
    }
}
