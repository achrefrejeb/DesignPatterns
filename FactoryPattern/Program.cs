using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            shapes.Add(ShapeFactory.GetShape("Circle"));
            shapes.Add(ShapeFactory.GetShape("Square"));
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadLine();
        }
    }
}
