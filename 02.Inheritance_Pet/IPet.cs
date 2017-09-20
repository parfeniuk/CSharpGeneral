using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Inheritance_Pet
{
    interface IPet
    {
        string Name { get; set; }
        string Breed { get; set; }
        void Display();
    }
}
