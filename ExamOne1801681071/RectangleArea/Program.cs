using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int sideA = rnd.Next(1, 101);
            int sideB = rnd.Next(1, 101);
            int area = sideA * sideB;
            Console.WriteLine($"The area of the rectangle is = {area:0.00}");
        }
    }
}
