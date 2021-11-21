using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class mealMoreFunction : Visitor
{
    meal extm;
    double tips = 0;
    double finalCost = 0;
    
    public void visit(meal m)
    {
        this.extm = m;


    }

    public double idealTips()
    {
        tips = 0;
        tips = extm.result * 0.25;
        return tips;
    }

    public void restartMeal()
    {
        
        tips = 0;
        finalCost = 0;
    }

    public double totalCost()
    {
        finalCost = extm.result + tips;
        return finalCost;
    }
}
   