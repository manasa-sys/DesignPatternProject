using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.PIZAA
{
    public class HawaianPizza : Hawaian
    {
        public string tomato;
        public string onion;
        public HawaianPizza(string m, string n)
        {

            tomato = m;
            onion = n;
        }
        public override void Eat()
        {
            Console.WriteLine("You are eating pizza with" + tomato +" and "+ onion+" topings");
        }
        public override void Buy()
        {
            Console.WriteLine(" You ordered  two toping pizza with " + tomato+" and "+onion);
        }
    }
}
