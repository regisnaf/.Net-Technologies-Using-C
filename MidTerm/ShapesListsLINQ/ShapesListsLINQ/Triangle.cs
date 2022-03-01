using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    public class Triangle : Shape
    {
        private double SideA, SideB, SideC;
public Triangle(double SideA, double SideB, double SideC)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }
        public override double Area() {
            double P = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(P * (P - SideA) * (P - SideB) * (P - SideC));
        }
        public override double Perimeter() {
            return SideA + SideB + SideC;
        }
    }
}
