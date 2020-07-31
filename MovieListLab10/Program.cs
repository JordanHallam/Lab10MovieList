using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MovieListLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>
            {
                new Movie("Star Wars", "fantasy", 1977),
                new Movie("Lord of the Rings", "fantasy", 2001),
                new Movie("Harry Potter", "fantasy", 2001),
                new Movie("Blade Runner", "scifi",1982),
                new Movie("The Matrix", "scifi",1999),
                new Movie("Akira", "scifi", 1988),
                new Movie("Mission Impossible", "action", 1996),
                new Movie("John Wick", "action",2014),
                new Movie("Kill Bill", "action",2003),
                new Movie("Golden Eye", "action",1995)
            };

            string cont ="y";

            while (cont == "y")
            {
                int moviecount = 1;
                while (moviecount < 2)
                {
                    Console.WriteLine("What genre movie would you like to see, Fantasy, Scifi, or Action?");
                    string selectedGenre = Console.ReadLine().ToLower();

                    foreach (Movie genre in movieList)
                    {
                        if (selectedGenre == genre.Genre)
                        {
                            genre.ShowGenreMovies();
                            moviecount++;
                        }
                    }
                    if (moviecount < 2)
                    {
                        Console.WriteLine("You did not enter a valid genre. Please enter Fantasy, Scifi, or Action.");
                    }
                    cont= ContinueProgram(cont);
                }

            } 
        }
        public static string ContinueProgram(string cont)
        {
            do
            {
                Console.WriteLine("Would you like to see another genre? Y/N");
                cont = Console.ReadLine().ToLower();

                if (cont == "y")
                {

                }
                if (cont == "n")
                {
                    Console.WriteLine("SEE YA SPACE COWBOY...");
                    return cont;
                    
                }
                else if(cont !="y")
                {
                    Console.WriteLine("OOPS! Please enter Y/N");
                    continue;


                }
            } while (cont != "y" && cont != "n");
            return cont;
        }
        

            
            
            
        
    }
}
