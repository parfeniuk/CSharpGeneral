using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t;
            int?[] a = {null,1,2,null,5 };
            int? num = null;

            object o = num;
            Console.WriteLine("Object value: {0}", o);

            if (num.HasValue) t = num.GetType();
            else
            {
                num = num ?? -1;
                t = num.GetType();
            }

            Console.WriteLine("Base Type: {0}",t.Name);
            //if ((!t.IsGenericType && !(t.GetGenericTypeDefinition() == typeof(Nullable<int>))))
            //{
            //    Console.WriteLine("Type is Nullable<{0}>", t.Name);
            //}
            Console.Read();


        }
    }
}
