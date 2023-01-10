using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.PIZAA
{
    public class AliclubPizza : Aliclub
    {
        public string tomato;
        public string onion;
        public string chicken;

        public AliclubPizza(string a, string b, string c)
        {
            tomato = a;
            onion = b;
            chicken = c;
        }

        public override void Eat()
        {
            Console.WriteLine(" You are eating  aliclub Pizza with " + tomato+" ," +onion+" ,"+ chicken +" topings");
        }


        public override void Order()
        {
            Console.WriteLine("You orderd " + tomato + " ," + onion + " ," + chicken + " topings Aliclub Pizza");
        }
    }
}

