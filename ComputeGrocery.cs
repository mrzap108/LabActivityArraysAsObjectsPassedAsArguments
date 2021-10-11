using System;

class ComputeGrocery
{
    int choice;
    double price = 0;

    public ComputeGrocery() 
    {

    }

    public double TotalPrice(ItemOnSale[] items, string choice, int numOfItems)
    {
        
        int loopVar = 0;
        this.choice = Convert.ToInt32(choice);
        this.choice-=1;
        while(loopVar < 5)
        {
            if(this.choice == loopVar)
            {
                price = (double) items[loopVar].Price * numOfItems;
                break;
            }
            loopVar++;
        }
        return (price);
    }

    public double ComputeChange(double moneyPaid)
    {
        double change = 0;
        change = moneyPaid - price;
        return(change);
    }
}