using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q1_Interface
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }

        public void DispalyShapeInfo()
        {
            Console.WriteLine(Area);
        }
    }
}
