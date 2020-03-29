using System;

namespace _16ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Point one = new Point(1, 2, 3);
            Point two = new Point(1, 4, 9);
            Point three = one + two;
            Console.WriteLine(three.X + " " + three.Y + " " + three.Z);
            Console.ReadLine();
        }
    }
}
