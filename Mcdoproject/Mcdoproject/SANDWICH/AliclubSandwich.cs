using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.SANDWICH
{
    public class AliclubSandwich : Aliclub
    {
        string tomato, onion, pickle;


        public AliclubSandwich(string tomato, string onin, string pickle)
        {
            this.tomato = tomato;
            this.onion = onion;
            this.pickle = pickle;

        }
        public override void Order()
        {
            Console.WriteLine(" You Ordererd sandwich with " + tomato+","+onion+","+pickle);
        }

        public override void Eat()
        {
            Console.WriteLine(" You are eating sandwich with " + tomato + "," + onion + "," + pickle);
        }

    }
}



