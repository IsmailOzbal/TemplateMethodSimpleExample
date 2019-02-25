using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern.BO
{
    public class RoleBread : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Role bread apply baking instructions");
        }

        public override void MıxIngredients()
        {
            Console.WriteLine("Role bread pour into ingredients");
        }
    }
}
