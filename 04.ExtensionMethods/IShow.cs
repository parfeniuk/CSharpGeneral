using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExtensionMethods
{
    interface IShow
    {
        void Show();
    }

    class ShowClass : IShow 
    {
        public int Id { get;set; }
        public void Show()
        {
            Console.WriteLine("IShow Interface implemented"); ;
        }
    }

    
}
