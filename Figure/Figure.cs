using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    abstract class Figure
    {
        private String color;

        protected Figure(string color)
        {
            this.color=color;
        }

        public string Color
        { 
            get => color; 
            protected set => color=value; 
        }

        public abstract Double Area
        {
            get;
        }
        public abstract Double Perimeter
        {
            get;
        }
    }
}
