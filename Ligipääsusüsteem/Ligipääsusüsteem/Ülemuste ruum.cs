using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem
{
    class Ülemuste_ruum : Juurdepääsetavus
    {
        public Ülemuste_ruum()
        {
            ToaNimi = "Ülemuste ruum";
        }

        public override void IntTööJuurdepääs()
        {
            TööJuurdepääs.Add(new Ülemused());
            TööJuurdepääs.Add(new Vanemarendajad());
            TööJuurdepääs.Add(new Spetsiaalkoristaja());
        }
    }
}
