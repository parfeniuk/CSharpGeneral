using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,8,9000 };

            // FOREACH Analogue
            IEnumerator enum1 = arr.GetEnumerator();
                        
            //enum1.Reset();

            while (enum1.MoveNext())
            {
                Console.WriteLine(enum1.Current + " ");
            }
        }
    }
}
