using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.DRINK
{
    public class AliclubDrink : Aliclub
    {
        string canadadry, pepsi, water;

        public AliclubDrink(string canadadry, string pepsi, string water)
        {
            this.canadadry = canadadry;
            this.pepsi = pepsi;
            this.water = water;
        }
        public override void Order()
        {
            Console.WriteLine(" Order one " + canadadry+","+pepsi+","+water+" each");
        }
        public override void Eat()
        {
            Console.WriteLine(" Drink Some " + canadadry+"," + pepsi + "," + water + " each");

        }
    }
}

