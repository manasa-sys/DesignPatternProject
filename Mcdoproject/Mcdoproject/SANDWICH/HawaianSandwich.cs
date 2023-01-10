using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.SANDWICH
{
    public class HawaianSandwich : Hawaian
    {
        string tomato, onion;

        public HawaianSandwich(string tomato, string onin)
        {
            this.tomato = tomato;
            onion = onion;

        }
        public override void Buy()
        {
            Console.WriteLine(" Buy  Sandwiches of " + tomato+","+onion);
        }

        public override void Eat()
        {
            Console.WriteLine("  You are eating  Sandwiches of " + tomato + "," + onion);
        }

    }
}
