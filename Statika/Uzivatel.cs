using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStatika
{
    class Uzivatel
    {
        private string jmeno;
        private string heslo;
        private bool prihlaseny;
        private int id;
        private static int minimalniDelkaHesla = 6;
        private static int dalsiId = 1;
        public Uzivatel(string jmeno, string heslo)
        {
            this.jmeno = jmeno;
            this.heslo = heslo;
            prihlaseny = false;
            id = dalsiId;
            dalsiId++;
        }

        public bool Prihlaste(string zadaneHeslo)
        {
            if (zadaneHeslo == heslo)
            {
                prihlaseny = true;
                return true;
            }
            else
                return false;
        }
        public static bool ZvalidujHeslo(string heslo)
        {
            if (heslo.Length >=minimalniDelkaHesla)
            {
                return true;
            }
            return false;
        }
        public static int VratMinimalniDelkuHesla()
        {
            return minimalniDelkaHesla;
        }
        public int VratId()
        {
            return id;
        }

    }
}
