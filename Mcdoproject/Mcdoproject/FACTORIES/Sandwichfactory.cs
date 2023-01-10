using Mcdoproject.SANDWICH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.FACTORIES
{
    public class Sandwichfactory : Abstractfactory
    {
        public override Veggy MakeVeggy(string x)
        {
            return new VeggySandwich(x);
        }

        public override Hawaian MakeHawaian(string a, string b)
        {
            return new HawaianSandwich(a, b);
        }
        public override Aliclub MakeAliclub(string a, string b, string c)
        {
            return new AliclubSandwich(a, b, c);
        }


    }
}


