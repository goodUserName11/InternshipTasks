using AreaCalculator;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(4, 4, 3);
            Console.WriteLine(t.IsRightTriangle());
        }
    }
}