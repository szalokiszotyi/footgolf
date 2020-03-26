using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace footgolf
{
    class Program
    {
        static List<Golfozo> versenyzok;
        static void Main(string[] args)
        {
            Beolvas();
            F03();
            F04();
            F06();
            F07();
            F08();
            Console.ReadKey();
        }

        private static void F08()
        {
            
            Console.WriteLine("f08:");
        }

        private static void F07()
        {
                var sw = new StreamWriter(
                    "osszpontff.txt", false, Encoding.UTF8);
                versenyzok.ForEach(
                    a => sw.WriteLine($"f07: {a.Nev}({a.Kategoria == "Felnott ferfi"});{a.osszpontszam}"));
                sw.Close();
        }

        private static void F06()
        {

                Golfozo r = versenyzok
                    .Where(f => f.Kategoria == "Noi")
                    .OrderByDescending(f => f.osszpontszam)
                    .FirstOrDefault();

                Console.WriteLine($"f06: A bajnok női versenyző \n Név: {r.Nev}\n Egyesület: {r.Egyesület} \n Összespont: {r.osszpontszam}");
        }

        private static void F04()
        {
            decimal osszferfi = versenyzok.Count(f => f.Kategoria=="Felnott ferfi");
            decimal ossznoi = versenyzok.Count(f => f.Kategoria=="Noi");
            
            Console.WriteLine("f04: " + (ossznoi/osszferfi)*100 + "% a női tagok aránya");
        }

        private static void F03()
        {
            Console.WriteLine($"f03: {versenyzok.Count}");
        }

        private static void Beolvas()
        {
            versenyzok = new List<Golfozo>();
            var sr = new StreamReader("fob2016.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                versenyzok.Add(new Golfozo(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
