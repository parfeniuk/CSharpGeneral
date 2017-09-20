using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class BaseClass
    {
        public virtual void DoWork(int a)
        {
            Console.WriteLine(a);
        }
    }
}
