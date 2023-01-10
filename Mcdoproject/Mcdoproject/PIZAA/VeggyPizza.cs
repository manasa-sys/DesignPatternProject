using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.PIZAA
{
    public class VeggyPizza : Veggy
    {
        public string tomato;
        public VeggyPizza(string a)
        {
            tomato = a;
        }
        public override void Eat()
        {
            Console.WriteLine("You eating " + tomato +  " pizza");
        }
        public override void Buy()
        {
            Console.WriteLine("you ordered " + tomato + " pizza");
        }
    }
}
