using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodDesignPattern.BO;

namespace TemplateMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apply Template method 

            RoleBread _roleBread = new RoleBread();

            _roleBread.Make();


            LongBread _longBread = new LongBread();

            _longBread.Make();

            Console.ReadLine();



        }
    }
}
