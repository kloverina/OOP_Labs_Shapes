using System;
using OOP_labs.Shapes;

namespace OOP_Labs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rect = new Rectangle(4, 6);
            Console.WriteLine($"Rectangle's area = {rect.CalcArea()}");
            Console.WriteLine($"Rectangle's perimeter = {rect.CalcPerimeter()}");
            
            var circle = new Circle(2);
            Console.WriteLine(circle.CalcArea());
            
            
            
        }
    }
}