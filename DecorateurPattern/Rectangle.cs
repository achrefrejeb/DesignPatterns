using System;

namespace DecoratorPattern
{
    public class Rectangle : IShape
    {
        public void Drow()
        {
            Console.WriteLine("Shape::Rectangle");
        }
    }
}
