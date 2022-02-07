using System;
using System.Collections.Generic;
using System.Text;


// Allen Atkins 
// CST-150

namespace Sneak_KNECT_2
{
    class InventoryManager
    {
        static void Main(String[] args)
        {
            ItemIventory feetpiece = new ItemIventory("Nike AF1", "Low", "Black", 10);
            Console.WriteLine("New feetpiece: " + "\n" + feetpiece.shoe + feetpiece.shoeDesign +
              feetpiece.color + feetpiece.quantity);
            Console.ReadKey();
        }
    }

}
