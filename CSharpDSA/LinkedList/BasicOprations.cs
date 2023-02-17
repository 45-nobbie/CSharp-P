using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Basicoprations
    {
        public static void LinkedListOprations()
        { 
            LinkedList<string> ll = new LinkedList<string>();
            //AddLast
            //AddFirst
            ll.AddLast("Tom");
            ll.AddLast("Sauron");
            ll.AddLast("Anakin");
            ll.AddLast("Kenobi");
            ll.AddLast("PennyWorth");

            //check whether the item is present in the list
            Console.WriteLine(ll.Contains("PennyWorth"));

            //Count the number of items
            Console.WriteLine(ll.Count);

            //Remove the items
            ll.RemoveFirst();

            foreach(string s in ll)
            {
                Console.Write(s + "->");
            }
            Console.WriteLine();
        }
    }
}
