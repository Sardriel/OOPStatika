using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStatika
{
    class Kalendar
    {
        public string VratNastaveni()
        {
            string s = "";
            s += string.Format("Jazyk: {0}\n", Nastaveni.Jazyk());
            s += string.Format("Barevné schéma: {0}\n", Nastaveni.BarevneSchema());
            s += string.Format("Spustit po startu: {0}\n", Nastaveni.SpustitPoStartu());
            return s;
        }
    }
}
