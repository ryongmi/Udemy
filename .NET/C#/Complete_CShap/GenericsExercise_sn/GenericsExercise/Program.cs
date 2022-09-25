using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies<double, DateTime> lordofTheRings1 = new Movies<double, DateTime>();
            lordofTheRings1.MovieName = "The Lord of the Rings: The Fellowship of the Ring";
            lordofTheRings1.Director = "Peter Jackson";
            lordofTheRings1.Rate = 8.8;
            lordofTheRings1.ReleaseDate = new DateTime(2001, 12, 19);

            Movies<double, DateTime> lordofTheRings2 = new Movies<double, DateTime>();
            lordofTheRings2.MovieName = "The Lord of the Rings: The Two Towers";
            lordofTheRings2.Director = "Peter Jackson";
            lordofTheRings2.Rate = 8.7;
            lordofTheRings2.ReleaseDate = new DateTime(2002, 12, 18);

            Movies<double, DateTime> lordofTheRings3 = new Movies<double, DateTime>();
            lordofTheRings3.MovieName = "The Lord of the Rings: The Return of the King";
            lordofTheRings3.Director = "Peter Jackson";
            lordofTheRings3.Rate = 8.9;
            lordofTheRings3.ReleaseDate = new DateTime(2003, 12, 17);
            
            List<Movies<double, DateTime>> firstList = new List<Movies<double, DateTime>>();

            firstList.Add(lordofTheRings1);
            firstList.Add(lordofTheRings2);
            firstList.Add(lordofTheRings3);
            
            var darkKnight1 = new Movies<float, int>();
            darkKnight1.MovieName = "Batman Begins";
            darkKnight1.Director = "Christopher Nolan";
            darkKnight1.Rate = 8.3f;
            darkKnight1.ReleaseDate = 2005;

            var darkKnight2 = new Movies<float, int>();
            darkKnight2.MovieName = "The Dark Knight";
            darkKnight2.Director = "Christopher Nolan";
            darkKnight2.Rate = 9.0f;
            darkKnight2.ReleaseDate = 2008;

            var darkKnight3 = new Movies<float, int>();
            darkKnight3.MovieName = "The Dark Knight Rises";
            darkKnight3.Director = "Christopher Nolan";
            darkKnight3.Rate = 8.4f;
            darkKnight3.ReleaseDate = 2012;

            var secondList = new List<Movies<float, int>>();
            secondList.Add(darkKnight1);
            secondList.Add(darkKnight2);
            secondList.Add(darkKnight3);
        }
    }

    class Movies<T, U>
    // 제네릭을 두개 사용하여, 두개의 타입을 지정하여 사용 할 수 있음
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

        private T rate;

        public T Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private U releaseDate;

        public U ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
    }
}
