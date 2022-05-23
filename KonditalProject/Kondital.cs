using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonditalProject
{
    class Kondital
    {
        public static string BeregnKondital(int hvilepuls, int maxpuls)
        {
            return Math.Round((double)maxpuls / (double)hvilepuls * 15.3).ToString();
        }
    }
}
