using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Inheritance_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Petshop petShop = new Petshop();
                petShop.AddPet(new Cat("Beauty", "Syberian"));
                petShop.AddPet(new Cat("Rose", "Canadian"));
                petShop.AddPet(new Dog("Bob", "Terrier"));
                petShop.AddPet(new Dog("Bill", "Spaniel"));
                petShop.IntroduceAll();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERR>{0}", ex.Message);
            }
            finally 
            {
                Console.WriteLine("Finished!");
            }
            Console.Read();
        }
    }
}
