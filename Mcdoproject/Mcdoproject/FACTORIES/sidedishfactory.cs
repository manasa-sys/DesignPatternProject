using Mcdoproject.SIDEDISH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcdoproject.FACTORIES
{
    public class Sidedishfactory : Abstractfactory
    {
        public override Veggy MakeVeggy(string x)
        {
            return new Veggysidedish(x);
        }

        public override Hawaian MakeHawaian(string a, string b)
        {
            return new Hawaiansidedish(a, b);
        }
        public override Aliclub MakeAliclub(string a, string b, string c)
        {
            return new Aliclubsidedish(a, b, c);
        }

    }
}
