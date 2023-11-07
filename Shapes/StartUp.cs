namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(5,6);

            Console.WriteLine(circle.Draw());
            Console.WriteLine(rectangle.Draw());
        }
    }
}