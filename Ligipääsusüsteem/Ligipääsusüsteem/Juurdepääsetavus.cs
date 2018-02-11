using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem
{
    abstract class Juurdepääsetavus : Tuba
    {
        public List<Töötajad> TööJuurdepääs;

        public abstract void IntTööJuurdepääs();

        public Juurdepääsetavus()
        {
            TööJuurdepääs = new List<Töötajad>();
            IntTööJuurdepääs();
        }

        public virtual bool JuurdepääsO(Töötajad ametK)
        {
            foreach (Töötajad töötaja in TööJuurdepääs)
            {
                if (ametK.Nimi == töötaja.Nimi)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
