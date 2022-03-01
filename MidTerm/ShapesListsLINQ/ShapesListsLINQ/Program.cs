using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShapesListsLINQ
{
    class Program
    {
        public static void AreaPerimeter<T>(T obj) where T : Shape
        {
            char response;
            Console.Write("Please select output:\n");
            Console.Write("[A]rea, [P]erimeter, [B]oth:");
            response = Char.Parse(Console.ReadLine());

            if(Char.ToLower(response) == 'a')
            {
                double Area = obj.Area();
                Console.WriteLine("Area is: " + Area);
            }
            else if (Char.ToLower(response) == 'p')
            {
                double Perimeter = obj.Perimeter();
                Console.WriteLine("Perimeter  is: " + Perimeter);
            }
            else if (Char.ToLower(response) == 'b')
            {
                double Area = obj.Area();
                Console.WriteLine("Area of is: " + Area);
                double Perimeter = obj.Perimeter();
                Console.WriteLine("Perimeter is: " + Perimeter);
            }

        }
        
        static void Main(string[] args)
        {
            char ShapeType;
            Shape s1 = null;

            while (true)
            {
                // Ask use which shape he/she would like to print
                Console.Write("Please select shape to process or [Q]uit: ");
                Console.Write("\n[C]ircle\n[R]ectangle\n[S]quare\n[T]riangle\n");
                ShapeType = Char.Parse(Console.ReadLine());
                if (Char.ToLower(ShapeType) == 'c')
                {
                    // Circle
                    // Get radius of Circle
                    Console.Write("Please enter circle radius: ");
                    double radius = Double.Parse(Console.ReadLine());
                    // Circle c1 = new Circle(radius);
                    s1 = new Circle(radius);
                }
                else if (Char.ToLower(ShapeType) == 'r')
                {
                    // Rectangle
                    // Get Length of Rectangle
                    Console.Write("Enter Length of Rectangle: ");
                    double Length = Double.Parse(Console.ReadLine());
                    Console.Write("Enter Width of Rectangle: ");
                    double Width = Double.Parse(Console.ReadLine());
                    s1 = new Rectangle(Length, Width);

                }
                else if (Char.ToLower(ShapeType) == 's')
                {
                    // Square
                    // get side of Square
                    Console.Write("Enter side of Square: ");
                    double Side = Double.Parse(Console.ReadLine());
                    s1 = new Square(Side);
                }
                else if (Char.ToLower(ShapeType) == 't')
                {
                    // Triangle

                    // Get values of sides a,b,c
                    Console.Write("Enter triangle side a: ");
                    double SideA = Double.Parse(Console.ReadLine());
                    Console.Write("Enter triangle side b ");
                    double SideB = Double.Parse(Console.ReadLine());
                    Console.Write("Enter triangle side c: ");
                    double SideC = Double.Parse(Console.ReadLine());
                    s1 = new Triangle(SideA, SideB, SideC);

                }
                else if (Char.ToLower(ShapeType) == 'q')
                    break;

                else
                {
                    Console.Write("Invalid response. Try again..\n");
                    continue;
                }
                // print area / Perimeter or both
                AreaPerimeter<Shape>(s1);
            }

        }
    }
}
