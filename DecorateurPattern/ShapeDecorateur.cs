namespace DecoratorPattern
{
    public abstract class ShapeDecorateur : IShape
    {
        protected IShape DecoratedShape;

        protected ShapeDecorateur(IShape decoratedShape)
        {
            this.DecoratedShape = decoratedShape;
        }

        public virtual void Drow() { }
    }
}
