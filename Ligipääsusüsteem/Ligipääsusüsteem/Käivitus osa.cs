using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem
{
    class Käivitus_osa
    {
        List<Tuba> Toad;
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
            Toad = new List<Tuba>()
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

                if (Sisend > 0 && Sisend < Tööd.Count)
                {
                    Kasutaja.Amet = Tööd[Sisend];
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

                Console.WriteLine("Mis tuppa soovite minna?");
                Console.WriteLine();

                for (int i = 0; i < Toad.Count; i++)
                {
                    Toad[i].pTuba(i);
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

                if (Sisend > 0 && Sisend < Toad.Count)
                {
                    Kasutaja.Toas = Toad[Sisend];
                    return;
                }
                else
                {
                    Console.WriteLine("Number pole õiges vahemikus");
                }

            }
        }
        public void Käima()
        {
            HetkeTöö();
            HetkeTuba();
        }
    }
}
