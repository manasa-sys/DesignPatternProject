using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.FACTORIES
{
    public abstract class Abstractfactory
    {


        private static Pizzafactory veggyfactory = new Pizzafactory();
        private static Drinkfactory hawaianfactory = new Drinkfactory();
        private static Sandwichfactory aliclubfactory = new Sandwichfactory();
        private static Sidedishfactory sidedishfactory = new Sidedishfactory();

        public static Abstractfactory factorymethod(TypeMenu type)
        {
            Abstractfactory? mcdo = null;
            switch (type)
            {
                case TypeMenu.PIZZAFACTORY:
                    mcdo = veggyfactory;
                    break;
                case TypeMenu.SANDWICHFACTORY:
                    mcdo = hawaianfactory;
                    break;
                case TypeMenu.DRINKFACTORY:
                    mcdo = aliclubfactory;
                    break;
              /*  case TypeMenu.SIDEDISHFACTORY:
                    mcdo = aliclubfactory;
                    break;*/

            }
            return mcdo;
        }
        public abstract Veggy MakeVeggy(string a);
        public abstract Hawaian MakeHawaian(string a, string b);
        public abstract Aliclub MakeAliclub(string a, string b, string c);


    }
}






