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
            //DerivedClass d = new DerivedClass();
            //int a = 5;
            //d.DoWork(a);

            A a = new A();
            A b = new B();
            A c = new C();

            a.Print();
            b.Print();
            c.Print();

            Console.ReadKey();
        }

        class A
        {
            public virtual void Print()
            {
                Console.WriteLine("A::Print");
            }
        }

        class B : A
        {
            public override void Print()
            {
                Console.WriteLine("B::Print");
            }
        }

        class C : B
        {
            public new void Print()
            {
                base.Print();
                Console.WriteLine("C::Print");
            }
        }

    }
}
