using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Circle : Figure
    {
        private Double radius;

        public Circle(String color, Double radius)
                            : base(color)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get => Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter
        {
            get => 2 * Math.PI * radius;
        }

        public static Circle FromString(string str)
        {
            string[] args = str.Split(' ');

            if (Double.TryParse(args[1], out Double radius))
            {
                return new Circle(args[0], radius);
            }
            else
            {
                //return new Circle(args[0], 0);
                return null;
            }
        }

        public override string ToString()
        {
            return $"Koło o promieniu {radius}\n" + base.ToString();
        }
    }
}
