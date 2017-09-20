using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExtensionMethods
{
    static class StringExt 
    {
        public static void Method1(this String s, string str) 
        {
            Console.WriteLine("{0} {1}",s,str);
        }

        public static void Method2(this String s, int a)
        {
            Console.WriteLine("{0} {1}", s, a);
        }

        public static void Print(this IShow d)
        {
            Console.WriteLine("Printed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "qwerty";
            s.Method1("123");
            s.Method2(8);
            IShow display = new ShowClass();
            display.Show();
            display.Print();
        }
    }
}
