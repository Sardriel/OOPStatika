using System;

namespace Statika
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzivatel u = new Uzivatel("Tomáš marný", "heslojeveslo");
            Console.WriteLine("ID prvního uživatele: {0}", u.VratId());
            Uzivatel v = new Uzivatel("Petr Pan", "csfd1fg");
            Console.WriteLine("ID druhého uživatele: {0}", v.VratId());
            Console.WriteLine("Minimální dělka hesla uživatele je: {0}", Uzivatel.VratMinimalniDelkuHesla());
            Console.WriteLine("Validnost hesla \"heslo\" je: {0}", Uzivatel.ZvalidujHeslo("heslo"));
            Console.ReadKey();

            Kalendar kalendar = new Kalendar();
            Console.WriteLine(kalendar.VratNastaveni());
            Console.ReadKey();
        }
    }
}
