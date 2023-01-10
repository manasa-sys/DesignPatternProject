using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.SANDWICH
{
    public class VeggySandwich : Veggy
    {
        string tomato;


        public VeggySandwich(string t)
        {
            tomato = t;

        }
        public override void Buy()
        {
            Console.WriteLine(" Buy " + tomato + " sandwich");
        }

        public override void Eat()
        {
            Console.WriteLine(" Eat " + tomato + "sandwich");
        }

    }
}
