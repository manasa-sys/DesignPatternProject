using Mcdoproject.DRINK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.FACTORIES
{
    public class Drinkfactory : Abstractfactory
    {
        public override Veggy MakeVeggy(string x)
        {
            return new VeggyDrink(x);
        }

        public override Hawaian MakeHawaian(string a, string b)
        {
            return new HawaianDrink(a, b);
        }
        public override Aliclub MakeAliclub(string a, string b, string c)
        {
            return new AliclubDrink(a, b, c);
        }

    }
}

