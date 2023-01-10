using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.DRINK
{
    public class HawaianDrink : Hawaian
    {
        string canadadry, pepsi;

        public HawaianDrink(string canadadry, string pepsi)
        {
            this.canadadry = canadadry;
            this.pepsi = pepsi;
        }
        public override void Buy()
        {
            Console.WriteLine("Buy Some" + canadadry + " and " + pepsi);
        }
        public override void Eat()
        {
            Console.WriteLine("Drink Some" + pepsi + " and " + canadadry);

        }
    }
}
