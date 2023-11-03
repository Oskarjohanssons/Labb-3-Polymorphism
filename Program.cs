namespace Labb_3___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.DisplayArea();
            Square square = new Square();
            square.DisplayArea();
            Circle circle = new Circle();
            circle.DisplayArea();
        }
    }
}