using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonditalProject
{
    class VurderKondital
    {
        public static string Vurder(int kondital, int alder, char køn)
        {
            string _kondiTilstand;
            if (køn == Char.ToLower('m'))
            {
                if (alder >= 20 && alder <= 29)
                {
                    if (kondital <= 28)
                    {

                    }
                    else if (kondital >= 29 && kondital <= 34)
                    {

                    }
                    else if (kondital >= 35 && kondital <= 43)
                    {

                    }
                    else if (kondital >= 44 && kondital <= 48)
                    {

                    }
                    else if (kondital >= 49)
                    {

                    }
                } 
                else if (alder >= 30 && alder <= 39)
                {

                }
                else if (alder >= 40 && alder <= 49)
                {

                }
                else if (alder >= 50 && alder <= 65)
                {

                }
            }
            else
            {
                if (alder >= 20 && alder <= 29)
                {

                }
                else if (alder >= 30 && alder <= 39)
                {

                }
                else if (alder >= 40 && alder <= 49)
                {

                }
                else if (alder >= 50 && alder <= 59)
                {

                }
                else if (alder >= 60 && alder <= 69)
                {

                }
            }
            return;
        }
    }
}
