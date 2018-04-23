using System;

namespace DecoratorPattern
{
    public class Circle : IShape
    {
        public void Drow()
        {
            Console.WriteLine("Shape::Circle");
        }
    }
}
