using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem
{
    class Töötajad
    {
        protected string Nimi;

        public void pNimi(int count)
        {
            count++;
            Console.WriteLine(count + ". " + Nimi);
        }
    }
}
