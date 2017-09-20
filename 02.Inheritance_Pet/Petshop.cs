using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Inheritance_Pet
{
    class Petshop:IPetshop
    {
        private List<Pet> listPets;
        public Petshop() 
        {
            listPets = new List<Pet>();
        }
        public void AddPet(Pet p) 
        {
            if (p != null) listPets.Add(p);
        }
        public void IntroduceAll() 
        {
            foreach (Pet item in listPets)
            {
                item.Display();
            }
        }
    }
}
