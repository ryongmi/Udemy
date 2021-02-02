using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shapes = new Shapes[4];
            shapes[0] = new Shapes();
            shapes[1] = new Circles();
            shapes[2] = new Lines();
            shapes[3] = new Triangle();

            foreach (var shape in shapes)
                shape.Draw();
        }
    }

    class Shapes
    {
        public virtual void Draw()
        // virtual : 하위 클래스에서 매서드 재정의를 허용하는 키워드
        {
            Console.WriteLine("I am a simple shape");
        }
    }

    class Circles : Shapes
    {
        public new void Draw()
        // new : 상위 클래스와 같은 이름의 메서드를 사용할 수 있지만 재정의하는 것은 아님.
        {
            Console.WriteLine("I am circles");
        }
    }

    class Lines : Shapes
    {
        public override void Draw()
        // // override : 매서드를 재정의하는 키워드.
        {
            Console.WriteLine("I am lines");
        }
    }


    class Triangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am triangle");
        }
    }
}
