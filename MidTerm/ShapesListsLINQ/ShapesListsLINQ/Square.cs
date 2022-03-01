using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    public class Square : Shape
    {
        private double Side;
        public Square(double Side)
        {
            this.Side = Side;
        }
        public override double Area() {
            return Side* Side;
        }
        public override double Perimeter() {
            return 4 * Side;
        } 
        
    }
}
