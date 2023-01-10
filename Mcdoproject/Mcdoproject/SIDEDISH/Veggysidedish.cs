using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.SIDEDISH
{
    public class Veggysidedish : Veggy
    {
        string frites;
        public Veggysidedish(string frites)
        {
            this.frites = frites;
        }
        public override void Buy()
        {
            Console.WriteLine("Buy one " + frites);
        }
        public override void Eat()
        {
            Console.WriteLine(" Eat some " + frites);
        }
    }
}
