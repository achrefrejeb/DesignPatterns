using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape Circle = new Circle();

            IShape RedCircle = new RedShapeDecorator(new Circle());

            IShape RedRectangle = new RedShapeDecorator(new Rectangle());

            Circle.Drow();

            RedCircle.Drow();

            RedRectangle.Drow();

            Console.ReadLine();
        }
    }
}
