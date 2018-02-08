using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipääsusüsteem
{
    class Tuba
    {
        public string ToaNimi;

        public void pTuba(int count)
        {
            count++;
            Console.WriteLine(count + ". " + ToaNimi);
        }
    }
}
