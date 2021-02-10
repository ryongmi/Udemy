using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void myDelegate(string name);

    class Program
    {
        public event myDelegate myEvent;
        
        public Program()
        {
            // 객체가 만들어지면 3함수의 이벤트 생성
            myEvent += new myDelegate(SayHiEnglish);
            myEvent += new myDelegate(SayHiArabic);
            myEvent += new myDelegate(SayHiItalian);
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.myEvent("Jack");
            // 이벤트 호출시 객체 생성하면서 걸려있던 함수들을 호출
        }

        public void SayHiEnglish(string name)
        {
            Console.WriteLine("Hi " + name);
        }

        public void SayHiArabic(string name)
        {
            Console.WriteLine("Marhaaban " + name);
        }

        public void SayHiItalian(string name)
        {
            Console.WriteLine("Caio " + name);
        }
    }
}
