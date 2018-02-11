using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem
{
    class Kasutaja
    {
        public Töötajad Amet;
        public Tuba Toas;

        public Kasutaja()
        {
            Toas = new Peauks();
        }

        public void MineTuppa(Juurdepääsetavus juurdepääsetavus)
        {
            if (juurdepääsetavus.JuurdepääsO(Amet))
            {
                Toas = juurdepääsetavus;
            }
            else
            {
                Console.WriteLine("Teil pole piisavalt kõrge amet, et siia siseneda");
                Console.WriteLine();
            }
        }
    }
}
