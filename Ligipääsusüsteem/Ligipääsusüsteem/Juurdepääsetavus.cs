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
        public abstract void intTööJuurdepääs();

        public Ligipääsusüsteem()
        {
            TööJuurdepääs = new List<Töötajad>();
            intTööJuurdepääs();
        }

        public virtual bool JuurdepääsO(Töötajad )
    }
}
