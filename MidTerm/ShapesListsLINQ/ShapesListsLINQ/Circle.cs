using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area() {
            return Math.PI * radius * radius;
        }
        public override double Perimeter() {
            return 2 * Math.PI * radius;
        }
    }
}
