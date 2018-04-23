namespace FactoryPattern
{
    public class ShapeFactory
    {
        public static IShape GetShape(string type)
        {
            switch (type)
            {
                case ("Circle"):
                    return new Circle();
                case ("Square"):
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
