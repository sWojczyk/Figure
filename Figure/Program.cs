using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle("Red", 2.4, 5.0);

            Console.WriteLine(rectangle.Area());
            Console.WriteLine(rectangle.Perimeter());

            //to jest test
        }
    }
}
