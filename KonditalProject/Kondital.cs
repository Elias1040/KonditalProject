using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonditalProject
{
    class Kondital
    {
        public static int BeregnKondital(int hvilepuls, int maxpuls)
        {
            return (int)Math.Round(maxpuls / hvilepuls * 15.3);
        }
    }
}
