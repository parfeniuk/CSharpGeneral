using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Inheritance_Pet
{
    abstract class Pet:IPet
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public Pet(string name, string breed) 
        {
            Name = name;
            Breed = breed;
        }
        public void Display() 
        {
            Console.WriteLine("I am {0} of {1}. I am a {2}",Name,Breed,this.GetType().Name);
        }
    }
}
