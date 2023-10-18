using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Rectangle : Figure
    {
        private Double width;
        private Double height;

        public Rectangle(String color, Double width, Double height)
                            : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2*(width + height);
        }
    }
}
