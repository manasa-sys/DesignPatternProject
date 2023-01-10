using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.DRINK
{
    public class VeggyDrink : Veggy
    {
        string canadadry;
        public VeggyDrink(string canadadry)
        {
            this.canadadry = canadadry;
        }
        public override void Buy()
        {
            Console.WriteLine("You ordered " + canadadry);
        }
        public override void Eat()
        {
            Console.WriteLine("You drink " + canadadry);

        }
    }
}
