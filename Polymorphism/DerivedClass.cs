using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class DerivedClass:BaseClass
    {
        public override void DoWork(int a)
        {
            Console.WriteLine(a+a);
        }
        public void  DoWork(double a)
        {
            Console.WriteLine(a+a+a);
        }
    }
}
