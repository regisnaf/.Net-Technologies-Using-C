using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    public class Rectangle : Shape
    {
        private double Length;
        private double Width;

        public Rectangle(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;

        }
        public override double Area() {
            return Length * Width;
        }
        public override double Perimeter() {
            return 2 * (Length + Width);
        }


    }
}
