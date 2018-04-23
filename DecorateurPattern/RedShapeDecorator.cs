using System;

namespace DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorateur
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

        public override void Drow()
        {
            DecoratedShape.Drow();
            setRedBorder();
        }

        private void setRedBorder()
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
