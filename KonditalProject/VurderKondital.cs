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
            if (køn == Char.ToLower('m'))
            {
                switch (alder)
                {
                    case < 29:
                        switch (kondital)
                        {
                            case < 38:
                                return "lav";
                                break;
                            case < 43:
                                return "ret lav";
                                break;
                            case < 51:
                                return "middel";
                                break;
                            case < 56:
                                return "god";
                                break;
                            case > 57:
                                return "meget god";
                                break;
                        }
                        break;
                    case < 39:
                        switch (kondital)
                        {
                            case < 34:
                                return "lav";
                                break;
                            case < 39:
                                return "ret lav";
                                break;
                            case < 47:
                                return "middel";
                                break;
                            case < 51:
                                return "god";
                                break;
                            case > 52:
                                return "meget god";
                                break;
                        }
                        break;
                    case < 49:
                        switch (kondital)
                        {
                            case < 30:
                                return "lav";
                                break;
                            case < 35:
                                return "ret lav";
                                break;
                            case < 43:
                                return "middel";
                                break;
                            case < 47:
                                return "god";
                                break;
                            case > 48:
                                return "meget god";
                                break;
                        }
                        break;
                    case < 59:
                        switch (kondital)
                        {
                            case < 25:
                                return "lav";
                                break;
                            case < 31:
                                return "ret lav";
                                break;
                            case < 39:
                                return "middel";
                                break;
                            case < 43:
                                return "god";
                                break;
                            case > 44:
                                return "meget god";
                                break;
                        }
                        break;
                    case < 69:
                        switch (kondital)
                        {
                            case < 21:
                                return "lav";
                                break;
                            case < 26:
                                return "ret lav";
                                break;
                            case < 35:
                                return "middel";
                                break;
                            case < 39:
                                return "god";
                                break;
                            case > 40:
                                return "meget god";
                                break;
                        }
                        break;
                    default:
                        return "kan ikke beregnes";
                        break;
                }
            }
            else if (køn == Char.ToLower('m'))
            {
                switch (alder)
                {
                    case < 29:
                        switch (kondital)
                        {
                            case < 28:
                                return "lav";
                                break;
                            case < 34:
                                return "ret lav";
                                break;
                            case < 43:
                                return "middel";
                                break;
                            case < 48:
                                return "god";
                                break;
                            case > 49:
                                return "meget god";
                                break;
                        }
                        break;
                    case < 39:
                        switch (kondital)
                        {
                            case < 27:
                                return "lav";
                                break;
                            case < 32:
                                return "ret lav";
                                break;
                            case < 41:
                                return "middel";
                                break;
                            case < 47:
                                return "god";
                                break;
                            case > 48:
                                return "meget god";
                                break;
                        }
                        break;
                    case < 49:
                        switch (kondital)
                        {
                            case < 25:
                                return "lav";
                                break;
                            case < 31:
                                return "ret lav";
                                break;
                            case < 40:
                                return "middel";
                                break;
                            case < 45:
                                return "god";
                                break;
                            case > 46:
                                return "meget god";
                                break;
                        }
                        break;
                    case < 65:
                        switch (kondital)
                        {
                            case < 21:
                                return "lav";
                                break;
                            case < 28:
                                return "ret lav";
                                break;
                            case < 36:
                                return "middel";
                                break;
                            case < 41:
                                return "god";
                                break;
                            case > 42:
                                return "meget god";
                                break;
                        }
                        break;
                    default:
                        return "kan ikke beregnes";
                        break;
                }
            }
            return "kan ikke beregnes";
        }
    }
}
