using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem
{
    class Käivitus_osa
    {
        List<Juurdepääsetavus> Toad;
        List<Töötajad> Tööd;
        Kasutaja Kasutaja;

        public Käivitus_osa()
        {
            OlemasToad();
            OlemasTöötajad();
            Kasutaja = new Kasutaja();
        }

        void OlemasToad()
        {
            Toad = new List<Juurdepääsetavus>()
            {
                new Peauks(),
                new Arendajate_ruum(),
                new Köök(),
                new Ülemuste_ruum(),
                new Andmetöötlejate_ruum()
            };
        }

        void OlemasTöötajad()
        {
            Tööd = new List<Töötajad>()
            {
                new Andmetöötlejad(),
                new Ülemused(),
                new Koristaja(),
                new Spetsiaalkoristaja(),
                new Nooremarendaja(),
                new Vanemarendajad()
            };
        }

        void HetkeTöö()
        {
            while (true)
            {
                int Sisend;

                Console.WriteLine("Mis amet teil on?");
                Console.WriteLine();

                for (int i = 0; i < Tööd.Count; i++)
                {
                    Tööd[i].pNimi(i);
                }

                try
                {
                    Sisend = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Palun sisestage number");
                    continue;
                }

                Console.Clear();

                if (Sisend > 0 && Sisend <= Tööd.Count)
                {
                    Kasutaja.Amet = Tööd[Sisend - 1];
                    return;
                }
                else
                {
                    Console.WriteLine("Number pole õiges vahemikus");
                }

            }
        }

        void HetkeTuba()
        {
            while (true)
            {
                int Sisend;
                Console.Clear();
                Console.WriteLine("Teie pragune amet on: " + Kasutaja.Amet.Nimi);
                Console.WriteLine("Te asute hetkel: " + Kasutaja.Toas.ToaNimi);
                Console.WriteLine();

                Console.WriteLine("Mis tuppa soovite minna?");
                Console.WriteLine();

                for (int i = 0; i < Toad.Count; i++)
                {
                    Toad[i].PTuba(i);
                }

                Console.WriteLine((Toad.Count + 1) + ". Programmist väljumine");

                try
                {
                    Sisend = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Palun sisestage number");
                    continue;
                }

                Console.Clear();

                if (Sisend > 0 && Sisend <= Toad.Count)
                {
                    Kasutaja.MineTuppa(Toad[Sisend - 1]);
                }
                if (Sisend == 6)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Number pole õiges vahemikus");
                }
            }
        }
        public void Käivitu()
        {
            HetkeTöö();
            HetkeTuba();
        }
    }
}
