using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.SIDEDISH
{
    public class Aliclubsidedish : Aliclub
    {
        string frites, salade, poutine;
        public Aliclubsidedish(string frites, string salade, string poutine)
        {
            this.frites = frites;
            this.salade = salade;
            this.poutine = poutine;
        }
        public override void Order()
        {
            Console.WriteLine("Buy one  " + frites, salade, poutine + "each");
        }
        public override void Eat()
        {
            Console.WriteLine(" Eat some " + frites, salade, poutine);
        }
    }
}

