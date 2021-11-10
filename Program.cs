using System;

namespace lab_work_11
{
    class Program
    { 
        private static Random randomizer = new Random();
        static void Main(string[] args)
        {
            var triangleArray = new Triangle[8];
            for (int i = 0; i < triangleArray.Length; i++)
            {
                while (true)
                {
                    var angleOne = randomizer.Next(30, 120);
                    var angleTwo = randomizer.Next(30, 120);
                    if (angleOne + angleTwo < 180)
                    {
                        var angleThree = 180 - (angleOne + angleTwo);
                        triangleArray[i] = new Triangle(angleOne, angleTwo, angleThree);
                        break;
                    }
                }
                
            }
            foreach (var item in triangleArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Кол-во остроуг. = {Triangle.counterSharp}");
            foreach (var item in triangleArray)
            {
                if (item.SharpTriangle())
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Кол-во прямоуг. = {Triangle.counterRect}");
            foreach (var item in triangleArray)
            {
                if (item.RectTriangle())
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Кол-во тупоуг. = {Triangle.counterUnsharp}");
            foreach (var item in triangleArray)
            {
                if (item.UnsharpTriangle())
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
