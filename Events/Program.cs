using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Test
    {
        static int changeCount;
        static void ListChanged(object sender, ListChangedEventArgs e)
        {
            changeCount++;
        }
        static void Main()
        {
            // Initialize instance of BindingList
            BindingList<string> names = new BindingList<string>();

            // Subcribe to Event
            names.ListChanged+=new ListChangedEventHandler(ListChanged);
            // Change the BindingList
            names.Add("Liz");
            names.Add("Martha");
            names.Add("Beth");
            names[names.IndexOf("Liz")] = "Liza";
            Console.WriteLine( $"Number of List changes: { changeCount}");		// Outputs "3"

            Console.ReadKey();
        }
    }

}
