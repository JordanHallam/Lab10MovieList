using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MovieListLab10
{
     class Movie
    {
        private string title;
        private string genre;
        private int releaseDate;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public int ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        public Movie() { }
        public Movie(string Title, string Genre, int Releasedate)
        {
            title = Title;
            genre = Genre;
            releaseDate = Releasedate;
            
        }
        public void ShowGenreMovies()
        {
            Console.WriteLine(title + ", " + releaseDate);
        }
    }

}
