using Mcdoproject.PIZAA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.FACTORIES
{
    public class Pizzafactory : Abstractfactory
    {
        public override Veggy MakeVeggy(string x)
        {
            return new VeggyPizza(x);
        }

        public override Hawaian MakeHawaian(string a, string b)
        {
            return new HawaianPizza(a, b);
        }
        public override Aliclub MakeAliclub(string a, string b, string c)
        {
            return new AliclubPizza(a, b, c);
        }

    }
}
