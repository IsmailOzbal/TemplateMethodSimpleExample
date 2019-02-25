using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern.BO
{

    //Abstract class TemplateMethod 

    /*The Template Method design pattern defines the outline or skeleton of an operation, 
    but leaves the specific steps involved to be defined by subclasses.*/

    public abstract class Bread
    {
        public abstract void MıxIngredients();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine("Slicing the " + GetType().Name + " bread!");
        }

        public void Make()
        {
            MıxIngredients();
            Bake();
            Slice();
        }

    }
}
