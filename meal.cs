using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
interface Visitor
{
    void visit(meal m);
}


interface Visitable
{
    void accept(Visitor visitor);
}
//-------------------------------------------

class meal : Visitable
{
    public void accept(Visitor visitor)
    {
        visitor.visit(this);
    }

    public string nameOfMeal { get; set; }
    public double priceOfMeal { get; set; }
    public double caloriesOfMeal { get; set; }
    public double result = 0;
    public double result2 = 0;
    public double result3 = 0;

    public int noOfMeals { get; set; }

    public meal()
    {
        nameOfMeal = "burger meal";
        priceOfMeal = 12.99;
        caloriesOfMeal = 875.0;
        noOfMeals = 0;
    }


    public double addAnotherMeal(int choice)
    {
        noOfMeals = 0;
        result = 0;

        if (choice > 0 && choice <= 6)
        {
            noOfMeals += choice;
            result = priceOfMeal * choice;
            return result;
        }
        if (choice > 6)
        {
            Console.WriteLine("Quantity is too big please try again");
        }
        return noOfMeals;
    }


    public double calories()
    {
        result2 = 0;

        if (noOfMeals > 0 && noOfMeals <= 6)
        {

            result2 += noOfMeals * caloriesOfMeal;

        }

        if (noOfMeals > 6)
        {
            Console.WriteLine("Quantity is too big please try again");
        }
        return result2;
    }
}



