using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic04.Interface_Example1
{
    internal class SeriesByFour
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }
    }
}
