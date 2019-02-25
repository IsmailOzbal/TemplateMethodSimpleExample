using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern.BO
{
    public class LongBread : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Long bread apply baking instructions");
        }

        public override void MıxIngredients()
        {
            Console.WriteLine("Long bread pour into ingredients");
        }
    }
}
