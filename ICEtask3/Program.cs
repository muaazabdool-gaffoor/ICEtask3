using System;
using System.Drawing;

namespace ICEtask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle("Rectangle", 5, 10);
            Shape circle = new Circle("Circle", 7);

            rectangle.Display();
            Console.WriteLine();
            circle.Display();
        }
    }
}