using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.SIDEDISH
{
    public class Hawaiansidedish : Hawaian
    {
        string frites, salade;
        public Hawaiansidedish(string frites, string salade)
        {
            this.frites = frites;
            this.salade = salade;
        }
        public override void Buy()
        {
            Console.WriteLine("Buy one " + frites+","+salade);
        }
        public override void Eat()
        {
            Console.WriteLine(" Eat some " + frites+","+salade);
        }
    }
}

