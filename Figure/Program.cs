using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Rectangle rectangle = new Rectangle("Blue", 2.4, 5.0);
            Circle circle = new Circle("Red", 1);

            Console.WriteLine("----------------------------\n"+rectangle);
            Console.WriteLine("----------------------------\n"+circle);
            */

            List<Circle> list = new List<Circle>();

            list.Add(Circle.FromString("White 3,3"));
            list.Add(Circle.FromString("Black 111,3"));
            list.Add(Circle.FromString("Red 2/10"));//null
            list.Add(Circle.FromString("Brown 12,2"));
            list.Add(Circle.FromString("Pink sześć"));//null
            list.Add(Circle.FromString("Brown 23"));

            //wywalamy null-e
            list.RemoveAll(el => el==null);

            //int x = list.Count();
            //int x = list.Count(a => a!=null && a.Color.StartsWith("B"));

            //foreach (Circle c in list.Where(a=>a!=null))
            foreach (Circle c in list.Where(a => a!=null && a.Color.StartsWith("B"))
                                     .OrderBy(a => a.Color).ThenByDescending(a => a.Area))
            {
                Console.WriteLine("----------------------------");

                if (c!=null)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine("Brak obiektu");
                }
            }
        }
    }
}
