using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person perOne = new Person();
            perOne.FirstName = "Kim";
            perOne.LastName = "TAE WON";
            perOne.BirthDate = DateTime.Now;
            perOne.Contry = "THANK";

            Person perTwo = new Person();

            Console.WriteLine(perOne.FirstName + " " + perOne.LastName + " " + perOne.BirthDate.ToString() + " " + perOne.Contry);
            Console.WriteLine(perTwo.FirstName);
        }
    }

    class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate { get; set; }

        public string Contry { get; set; }

        public Person()
            // 생성자
        {
            firstName = "Unknown";
        }
    }
}
