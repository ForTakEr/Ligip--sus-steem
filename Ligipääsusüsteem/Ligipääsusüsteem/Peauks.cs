using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem
{
    class Peauks : Juurdepääsetavus
    {
        public Peauks()
        {
            ToaNimi = "Peauks";
        }

        public override void IntTööJuurdepääs()
        {
            TööJuurdepääs.Add(new Nooremarendaja());
            TööJuurdepääs.Add(new Ülemused());
            TööJuurdepääs.Add(new Vanemarendajad());
            TööJuurdepääs.Add(new Spetsiaalkoristaja());
            TööJuurdepääs.Add(new Koristaja());
            TööJuurdepääs.Add(new Andmetöötlejad());
        }
    }
}
