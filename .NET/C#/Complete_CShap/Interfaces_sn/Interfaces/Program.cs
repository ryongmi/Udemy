using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.Attack();
        }
    }

    public interface IAnimals
    {
        void Run();
    }

    public interface IDogCommands : IAnimals
    // 인터페이스 : 선언만 하고, 구현하지는 않음. 클래스에 상속 가능, 인스턴스 생성 불가능, 접근지정자를 public으로만 선언 가능
    {
        void Stay();
        void Sit();
        void Attack();
        string DogName
        {
            set;
            get;
        }
    }

    class Animals
    {
        string AnimalsName;

        public void SayHi()
        {
            Console.WriteLine("Hi from the animals class");
        }
    }

    class Dogs : Animals, IDogCommands
    /*
     * 클래스와 인터페이스를 같이 상속하려면 인터페이스 앞에 클래스를 먼저 상속해야함.
     * 인터페이스를 상속하면 인터페이스에 선언되어 있는 메서드들을 구현해야함.
     * 만약 상속받은 인터페이스가 인터페이스를 상속하고 있는 상태라면, 인터페이스가 상속한 인터페이스의 메서드도 구현해야함.
     */
    {
        private string DogBreed;

        public void Stay()
        {
            Console.WriteLine("Dog is staying");
        }

        public void Sit()
        {
            Console.WriteLine("Dog is sitting");
        }

        public void Attack()
        {
            Console.WriteLine("Dog is Attacking");
        }

        public void Run()
        {
            Console.WriteLine("Animals is running");
        }

        public string DogName { get; set; }
    }
}
