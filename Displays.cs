using System;

class Displays
{
    public void DisplayItemsOnSale(ItemOnSale[] items)
    {
        int loopVar = 0;
        Console.WriteLine("All Items on Sale");
        while(loopVar < 5)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("[{0}] Name: {1}        Price: PhP {2} each", loopVar+1, items[loopVar].ItemName, items[loopVar].Price);
            loopVar++;
        }
        Console.WriteLine("---------------------------------------");
    }
}