using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footgolf
{
    class Golfozo
    {
        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public string Egyesület { get; set; }
        public byte[] Pontok { get; set; }


        public Golfozo(string sor)
        {
            string[] m = sor.Split(';');

            Nev = m[0];
            Kategoria = m[1];
            Egyesület = m[2];
            Pontok = new byte[8];
            for (int i = 0; i < Pontok.Length; i++)
            {
                Pontok[i] = byte.Parse(m[i + 3]);
            }

        }

        public int osszpontszam
        {
            get
            {
                int osszpont = 0;
                Array.Sort(Pontok);
                for (int i = 2; i < Pontok.Length; i++)
                {
                    osszpont += Pontok[i];
                }
                if (Pontok[0] != 0) osszpont += 10;
                if (Pontok[1] != 0) osszpont += 10;
                return osszpont;
            }
        }

    }
}
