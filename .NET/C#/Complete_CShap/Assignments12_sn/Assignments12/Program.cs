using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Enhancement of movies exercise (generic exercise)

Create enum for genres

Create  a generic list property of genres

Fill the necessary information for each series of movies

Create a generic method to accept the movie class instance and display the movie info

*/

namespace Assignments12
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<Movies<double, DateTime>>();
            var secondList = new List<Movies<float, int>>();

            var darkKnight1 = new Movies<float, int>();
            darkKnight1.MovieName = "Batman Begins";
            darkKnight1.Director = "Christopher Nolan";
            darkKnight1.Rate = 8.3f;
            darkKnight1.ReleaseDate = 2005;

            darkKnight1.Genres = new List<Genres>();
            darkKnight1.Genres.Add(Genres.Action);
            darkKnight1.Genres.Add(Genres.Drama);
            darkKnight1.Genres.Add(Genres.Thriller);

            var darkKnight2 = new Movies<float, int>();
            darkKnight2.MovieName = "The Dark Knight";
            darkKnight2.Director = "Christopher Nolan";
            darkKnight2.Rate = 9.0f;
            darkKnight2.ReleaseDate = 2008;

            darkKnight2.Genres = new List<Genres>();
            darkKnight2.Genres.Add(Genres.Action);
            darkKnight2.Genres.Add(Genres.Drama);
            darkKnight2.Genres.Add(Genres.Thriller);

            var darkKnight3 = new Movies<float, int>();
            darkKnight3.MovieName = "The Dark Knight Rises";
            darkKnight3.Director = "Christopher Nolan";
            darkKnight3.Rate = 8.4f;
            darkKnight3.ReleaseDate = 2012;

            darkKnight3.Genres = new List<Genres>();
            darkKnight3.Genres.Add(Genres.Action);
            darkKnight3.Genres.Add(Genres.Drama);
            darkKnight3.Genres.Add(Genres.Thriller);
            darkKnight3.Genres.Add(Genres.Mystery);

            var lordofTheRings1 = new Movies<double, DateTime>();
            lordofTheRings1.MovieName = "The Lord of the Rings: The Fellowship of the Ring";
            lordofTheRings1.Director = "Peter Jackson";
            lordofTheRings1.Rate = 8.8;
            lordofTheRings1.ReleaseDate = new DateTime(2001, 12, 19);

            var lordofTheRings2 = new Movies<double, DateTime>();
            lordofTheRings2.MovieName = "The Lord of the Rings: The Two Towers";
            lordofTheRings2.Director = "Peter Jackson";
            lordofTheRings2.Rate = 8.7;
            lordofTheRings2.ReleaseDate = new DateTime(2002, 12, 18);

            var lordofTheRings3 = new Movies<double, DateTime>();
            lordofTheRings3.MovieName = "The Lord of the Rings: The Return of the King";
            lordofTheRings3.Director = "Peter Jackson";
            lordofTheRings3.Rate = 8.9;
            lordofTheRings3.ReleaseDate = new DateTime(2003, 12, 17);

            firstList.Add(lordofTheRings1);
            firstList.Add(lordofTheRings2);
            firstList.Add(lordofTheRings3);

            secondList.Add(darkKnight1);
            secondList.Add(darkKnight2);
            secondList.Add(darkKnight3);

            Show(firstList);
            Show(secondList);
        }

        public static void Show<T, U>(List<Movies<T, U>> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("Movies name : " + item.MovieName);
                Console.WriteLine("Movie rate : " + item.Rate);
                Console.WriteLine("Release date : " + item.ReleaseDate);
                Console.WriteLine("Director : " + item.Director);
                if (!(item.Genres is null))
                {
                    if (item.Genres.Count > 0)
                    {
                        Console.Write("Genres : ");
                        foreach (var genre in item.Genres)
                        {
                            Console.Write(genre + " ");
                        }
                    }
                }
                Console.WriteLine("\n____________________________\n");
            }
        }
    }

        class Movies<T, U>
        {
            private string movieName;

            public string MovieName
            {
                get { return movieName; }
                set { movieName = value; }
            }

            private string director;

            public string Director
            {
                get { return director; }
                set { director = value; }
            }

            private U releaseDate;

            public U ReleaseDate
            {
                get { return releaseDate; }
                set { releaseDate = value; }
            }

            private T rate;

            public T Rate
            {
                get { return rate; }
                set { rate = value; }
            }

            private List<Genres> genres;

            public List<Genres> Genres
            {
                get { return genres; }
                set { genres = value; }
            }
        }

        enum Genres
        {
            Action,
            Adventure,
            Animation,
            Biography,
            Comedy,
            Crime, 
            Documentary, 
            Drama, 
            Family, 
            Fantasy, 
            History, 
            Horror, 
            Musical, 
            Mystery,
            Romance,
            SciFi,
            Sport,
            Thriller,
            War,
            Western
        }
}
