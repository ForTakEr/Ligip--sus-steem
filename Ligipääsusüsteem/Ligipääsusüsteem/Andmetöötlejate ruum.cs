using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem
{
    class Andmetöötlejate_ruum : Juurdepääsetavus
    {
        public Andmetöötlejate_ruum()
        {
            ToaNimi = "Andmetöötlejate ruum";
        }

        public override void IntTööJuurdepääs()
        {
            TööJuurdepääs.Add(new Andmetöötlejad());
            TööJuurdepääs.Add(new Ülemused());
            TööJuurdepääs.Add(new Vanemarendajad());
            TööJuurdepääs.Add(new Spetsiaalkoristaja());
        }
    }
}
