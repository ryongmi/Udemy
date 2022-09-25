using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Lines line = new Lines();
            line.SayHi(); line.Draw();
        }
    }

    abstract class Shapes
    // abstract : 추상화, 추상 클래스, 객체 생성이 불가능함. 보통 자식 클래스에서 접근
    {
        abstract public void Draw();
        // 추상 메서드, 부모 클래스에서 선언하며 자식 클래스에서 메서드를 강제로 구현하게함. 구현할 때에는 override를 써야함. ( 예 : Lines클래스에서 상속받기 때문에 Draw() 메서드를 정의해야한다.)
        public void SayHi()
        {
            Console.WriteLine("Hi from the abstact class");
        }
    }

    class Lines : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Hi I amm a line");
        }
    }
}
