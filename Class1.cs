using System;

// Allen Atkins 
// CST-150

namespace Sneak_KNECT_2
{
    class ItemIventory
    {
        public string shoe { get; private set; }
        public string shoeDesign { get; private set; }
        public string color { get; private set; }
        public int quantity { get; private set; }


        public ItemIventory(string shoe, string shoeDesign, string color, int quantity)
        {
            this.shoe = shoe;
            this.shoeDesign = shoeDesign;
            this.color = color;
            this.quantity = quantity;


        }
        public bool outOfStock()
        {
            if (quantity == 0)
            {
                return true;
            }
            return false;
        }

    }
}


