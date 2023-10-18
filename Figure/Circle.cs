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
    }
}
