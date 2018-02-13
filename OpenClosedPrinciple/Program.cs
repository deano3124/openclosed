using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AreaCalculator ac = new AreaCalculator();

            var rec = new Rectangle
            {
                Width = 8,
                Height = 4
            };

            var cir = new Circle()
                          {
                              Radius = 8
                          };

            object[] shapes = new object[2];

            shapes[0] = rec;
            shapes[1] = cir;

            ac.Area( shapes );
            Console.WriteLine( "End bad example");

            //Open/Closed Principle
            Console.WriteLine("\n" + "Begin Open Closed example");

            OAreaCalculator oCalc = new OAreaCalculator();

            var oRec = new ORectangle
                          {
                              Width = 8,
                              Height = 4
                          };

            var oCir = new OCircle()
                          {
                              Radius = 8
                          };

            OShape[] Oshapes = new OShape[2];

            Oshapes[0] = oRec;
            Oshapes[1] = oCir;

            oCalc.OArea( Oshapes );

        }

        public class Rectangle
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }

        public class Circle
        {
            public double Radius { get; set; }
        }

        public class AreaCalculator
        {
            public double Area( object[] shapes )
            {
                double area = 0;
                foreach ( var shape in shapes )
                {
                    if ( shape is Rectangle )
                    {
                        Rectangle rectangle = (Rectangle)shape;
                        area += rectangle.Width * rectangle.Height;
                        Console.WriteLine( "Rectangle = {0}",area );
                    }
                    else
                    {
                        Circle circle = (Circle)shape;
                        area += circle.Radius * circle.Radius * Math.PI;
                        Console.WriteLine( "Circle = {0}", area );
                    }
                }

                return area;
            }
        }

        public class OAreaCalculator
        {
            public double OArea(OShape[] shapes)
            {
                double area = 0;
                foreach (var shape in shapes)
                {
                    area += shape.Area();
                    Console.WriteLine( "{0} = {1}", shape, area );
                }

                return area;
            }
        }
    }
}
